using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_CargoPlan : Form
    { 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        DataOperations dp = new DataOperations();
          public int IdSelected;
        int Tipotrans;
         public string codigoGen;
        public  string  shipname;
        public int Estado;
        public TT_CargoPlan()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            string Query = @"Select
	                        T1.id as ID, 
	                        T1.code as [Codigo de Plan],
	                        T1.enable [Habilitado],
	                        T1.date_begin as [Fecha de inicio],
	                        T1.date_create as [Fecha final],
	                        T2.descripcion as [Nombre de barco asignado],
	                        T2.codigo as [Codigo del Barco],
	                        T1.peso as [Peso planificado],
	                        (Case when T1.status = 10 then 'Planificado'
		                         when T1.status = 20 then 'Asignado a un plan'
		                         when T1.status = 30 then 'Finalizado'
		                         when T1.status = 99 then 'Cancelado' 
		                         end ) as Estado,
	                        T1.status as [Codigo de Estado]
                        from dbo.TS_ship_h T1 join 
                       dbo.M_ship T2 on T1.shipid = T2.id
                        where t1.enable = 1 and t1.[close] = 0 order by 1 desc";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.shiphload.Clear();
                da.Fill(dSTtracer.shiphload);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar el formulario. Llamada de pila: "+ ex.Message);
                this.Close();   
            }
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelControl1_KeyDown(object sender, KeyEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_shiph.FocusedView;
                var row = (dSTtracer.shiphloadRow)gridview.GetFocusedDataRow();
                IdSelected = row.ID;
                shipname = row.Nombre_de_barco_asignado;
                codigoGen = row.Codigo_de_Plan;
                Estado = row.Codigo_de_Estado;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception)
            {

               
            }
        }

        private void grdv_shiph_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_shiph.FocusedView;
                var row = (dSTtracer.shiphloadRow)gridview.GetFocusedDataRow();
                IdSelected = row.ID;
                shipname = row.Nombre_de_barco_asignado;
                codigoGen = row.Codigo_de_Plan;
                Estado = row.Codigo_de_Estado;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {

           
            }
        }
    }
}
