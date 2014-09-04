﻿using System;
using System.Collections.Generic;
using System.IO;
using Eto.Forms;

namespace Plugin_FileManager.Actions
{
	public class ItemUpload : Command
	{
		private Model.Status _status;
		public ItemUpload(Model.Status status)
		{
			ID = "upload";
			MenuText = "Upload";
			Executed += ItemUpload_Executed;

			_status = status;
		}
		void ItemUpload_Executed(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Title = "Select File To Upload",
				Filters = GetFilters(),
			};
			if (openFileDialog.ShowDialog(_status.FileGridView) == DialogResult.Ok)
			{
				string srcfile = openFileDialog.FileName;
				string currentDirPath = _status.CurrentDirPath;
				string fileName = Path.GetFileName(srcfile);
				string targetFilePath = Path.Combine(currentDirPath, fileName);
				UploadFile(srcfile, targetFilePath);
			}
		}

		private static IEnumerable<IFileDialogFilter> GetFilters()
		{
			yield return new FileDialogFilter("Script Files", ".asp", ".aspx", ".php", ".jsp");
			yield return new FileDialogFilter("Program", ".exe",".bat");
			yield return new FileDialogFilter("All Files", ".*");
		}

		private void UploadFile(string sourceFilePath, string targetFilePath)
		{
			try
			{
				//判断窗体是否已经被关闭
				//if (trafficManager == null || trafficManager.IsDisposed)
				//{
				//    trafficManager = new FormTrafficManager();
				//}
				//ControlProgressBar progressBar = ShowProgressBar(true, sourceFilePath, targetFilePath);
				//FileUploadOrDownload upload = new FileUploadOrDownload(_shellData, sourceFilePath, targetFilePath);
				//upload.UploadFileProgressChangedToDo += upload_UploadFileProgressChangedToDo;
				//upload.UploadFileCompletedToDo += upload_UploadFileCompletedToDo;
				//upload.StartToUploadFile();
				/*
				FileUploadOrDownload upload = new FileUploadOrDownload(_host, _shellData, sourceFilePath, targetFilePath);
				upload.UploadFileProgressChangedToDo += upload_UploadFileProgressChangedToDo;
				upload.UploadFileCompletedToDo += upload_UploadFileCompletedToDo;
				upload.StartToUploadFile();
				 */
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}
	}
}