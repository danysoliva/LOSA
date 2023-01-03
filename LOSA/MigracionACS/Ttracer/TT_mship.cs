using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using System.Runtime.InteropServices;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_mship : Form
    { int IdAmod;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        DataOperations dp = new DataOperations();
        string nextcode;
        public TT_mship()
        {
            InitializeComponent();
            load_ship();
            nextcode = dp.Nexcode(4);
            txtcodigo.Text = nextcode;
        }
        public void load_ship()
        {
            string query = @"SELECT [id]
                                  ,[codigo]
                                  ,[enable]
                                  ,[descripcion]
                              FROM [dbo].[M_ship] order by 1 desc";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dSTtracer.Mship.Clear();
            da.Fill(dSTtracer.Mship);



        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Debe conocer el nombre del barco para registrarlo.");
                return;
            }
            string Query = @"INSERT INTO [dbo].[M_ship]
                                   ([codigo]
                                   ,[enable]
                                   ,[descripcion])
                             VALUES
                                   ('"+nextcode+@"'
                                   ,1
                                   ,'"+txtname.Text+@"')";
            dp.ACS_DoSmallDBOperationBas(Query);
            load_ship();
            dp.updatesecuence(4);
            MessageBox.Show("Guardado con exito!");
            txtname.Text = "";
            nextcode = dp.Nexcode(4);
            txtcodigo.Text = nextcode;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var gridview = (GridView)grdship.FocusedView;
                var row = (dSTtracer.MshipRow)gridview.GetFocusedDataRow();
                txtcodeedit.Text = row.codigo;
                txtnameedit.Text = row.descripcion;
                tggenable.IsOn = row.enable;
                IdAmod = row.id;
            }
            catch (Exception)
            {

             
            }
        }

        private void btnsaveconf_Click(object sender, EventArgs e)
        { int bit = 1;
            if (tggenable.IsOn)
            {
                bit = 1;
            }
            else
            {
                bit = 0;
            }
            if (txtnameedit.Text == "")
            {
                MessageBox.Show("La edición del nombre del barco no puede quedar vacía.");
                return;
            }
            string QueryUp = @"UPDATE [dbo].[M_ship]
                               SET [enable] = "+bit+@"
                                  ,[descripcion] = '"+txtnameedit.Text+@"'
                             WHERE id ="+ IdAmod;
            dp.ACS_DoSmallDBOperationBas(QueryUp);
            load_ship();
            txtcodeedit.Text = "";
            txtnameedit.Text = "";
        }

        private void tbship_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
