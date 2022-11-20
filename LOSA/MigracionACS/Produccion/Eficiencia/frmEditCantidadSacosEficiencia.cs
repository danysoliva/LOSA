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

namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    public partial class frmEditCantidadSacosEficiencia : DevExpress.XtraEditors.XtraForm
    {
        int Id;
        public frmEditCantidadSacosEficiencia(int pcantidad, int pId)
        {
            InitializeComponent();
            Id = pId;
            textEdit1.EditValue = pcantidad;
            spinEdit1.EditValue = pcantidad;
        }

        private void btnsave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }

        private void cmdGuardar__Click(object sender, EventArgs e)
        {
            //Guardar
            DialogResult r = CajaDialogo.Pregunta("¿Confirma que desea guardar estos cambios?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                //dsEficiencia.PRB_Detalle_lotes
                //var gridView = (GridView)gridControl1.FocusedView;
                //var row = (dsEficiencia)gridView.GetFocusedDataRow();
                DataOperations dp = new DataOperations();
                string Query;
                Query = @"sp_set_update_cantidad_prb_lotes_cantidad";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@cantidad", spinEdit1.EditValue);
                cmd.ExecuteNonQuery();
                cn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cmd_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}