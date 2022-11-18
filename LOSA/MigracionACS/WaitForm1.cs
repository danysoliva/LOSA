using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;

namespace LOSA
{
    public partial class WaitForm1 : WaitForm
    {
        public WaitForm1()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }

[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeRush", "Member is not implemented")]
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeRush", "Member is not implemented")]
        private void WaitForm1_Load(object sender, EventArgs e)
        {

        }

[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeRush", "Member is not implemented")]
        private void timer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}