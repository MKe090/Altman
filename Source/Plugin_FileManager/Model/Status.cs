﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eto.Forms;
using PluginFramework;

namespace Plugin_FileManager.Model
{
	public class Status
	{
		public string PathSeparator;
		public string CurrentDirPath;
		public string DirWillBeProcessed;
		public string FileWillBeProcessed;
		public GridView FileGridView;
		public IHost Host;
		public FileManagerService FileManager;
	}
}
