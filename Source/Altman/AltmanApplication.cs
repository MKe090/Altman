﻿using System;
using Eto;
using Eto.Forms;

namespace Altman.Desktop
{
    public class AltmanApplication:Application
    {
        public AltmanApplication(Platform platform): base(platform)
        {
            this.Name = "Altman App";
            this.Style = "application";
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            this.MainForm = new FormMain();
            this.MainForm.Show();
        }

        protected override void OnTerminating(System.ComponentModel.CancelEventArgs e)
		{
			base.OnTerminating(e);
			/*
			var result = MessageBox.Show(MainForm, "Are you sure you want to quit?", MessageBoxButtons.YesNo, MessageBoxType.Question);
			if (result == DialogResult.No)
				e.Cancel = true;
             */
		}
    }
}
