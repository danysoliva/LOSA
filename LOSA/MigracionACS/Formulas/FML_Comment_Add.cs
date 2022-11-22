using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_Comment_Add : DevExpress.XtraEditors.XtraForm
    {
        string CommentKind;

        public string Comment { get; set; }

        public FML_Comment_Add(string CommentKind)
        {
            InitializeComponent();
            this.CommentKind = CommentKind;
        }

        private void btn_CancelOpt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CommentKind != "reject") 
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        private void btn_Accept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_comment.Text.ToString().Trim() != "") 
            {
                Comment = txt_comment.Text.ToString();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}