using ACS.Classes;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Calidad.Revision_Sanidad
{
    public partial class DialogBoxRevision : DevExpress.XtraEditors.XtraForm
    {

        public int id_estado = 0;

        public DialogBoxRevision()
        {
            InitializeComponent();
            LoadStates();
        }

        private void LoadStates()
        {
            try
            {
                DataOperations dp = new DataOperations();

                string sql = @"SELECT id,
                                   descripcion
                            FROM dbo.LOSA_revision_sanidad_estado
                            WHERE enable=1";

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                dsSanidad.estado_revision_sanidad.Clear();
                SqlDataAdapter da = new SqlDataAdapter(sql,cnx);
                da.Fill(dsSanidad.estado_revision_sanidad);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.id_estado = Convert.ToInt32(lookUpEdit1.EditValue);
            this.DialogResult = DialogResult.OK;
        }
    }
}