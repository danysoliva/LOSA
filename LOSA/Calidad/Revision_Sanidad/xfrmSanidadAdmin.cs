using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LOSA.Calidad.Revision_Sanidad.RPT;
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
    public partial class xfrmSanidadAdmin : DevExpress.XtraEditors.XtraForm
    {
        public xfrmSanidadAdmin()
        {
            InitializeComponent();
            LoadRevisionSanidad();
        }

        public void LoadRevisionSanidad()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_vehiculos_revision_sanidad", cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //da.SelectCommand.Parameters.Add("@id_h", System.Data.SqlDbType.Int).Value = id_h;

                dsSanidad.info_vehiculo.Clear();
                da.Fill(dsSanidad.info_vehiculo);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xfrmStepRevisionSanidad frm = new xfrmStepRevisionSanidad();

            if (frm.ShowDialog()== DialogResult.OK)
            {
                LoadRevisionSanidad();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                var row = (dsSanidad.info_vehiculoRow)gvVehiculo.GetFocusedDataRow();


                xrSanidad report = new xrSanidad(row.id);

                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    // Send the report to the default printer.
                    printTool.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadRevisionSanidad();
        }

        private void btnRevision_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsSanidad.info_vehiculoRow)gvVehiculo.GetFocusedDataRow();


                if (row.id_estado!=1)//Distinto a Aprobado
                {

                xfrmStepRevisionSanidad frm = new xfrmStepRevisionSanidad(row.id);
                    if (frm.ShowDialog()== DialogResult.OK)
                    {
                        LoadRevisionSanidad();
                    }
                }
                else
                {
                    CajaDialogo.Error("Este documento ha ya sido aprobado");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }
    }
}