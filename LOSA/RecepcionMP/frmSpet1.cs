using DevExpress.XtraEditors;
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
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.AlmacenesExterno;

namespace LOSA.RecepcionMP
{
    public partial class frmSpet1 : DevExpress.XtraEditors.XtraForm
    {
        public int Tipo_Ingreso_Selected = 0;
        public string Descripcion_Tipo_Selected = "";
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public object MDI_Parent;
        public frmSpet1(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_data();
        }

        public void load_data()
        {
            string query = @"sp_load_tipos_ingreso_wizard";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query,cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dsWizard.tipo_Ingreso.Clear();
            da.Fill(dsWizard.tipo_Ingreso);
            cn.Close();

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void grdv_data_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsWizard.tipo_IngresoRow)gridView.GetFocusedDataRow();
                Tipo_Ingreso_Selected = row.id;
                Descripcion_Tipo_Selected = row.descripcion;
                foreach (dsWizard.tipo_IngresoRow fila in dsWizard.tipo_Ingreso.Rows)
                {

                    fila.selected = false;
                   
                }
                dsWizard.tipo_Ingreso.AcceptChanges();
                foreach (dsWizard.tipo_IngresoRow fila in dsWizard.tipo_Ingreso.Rows)
                {
                    if (fila.id == row.id)
                    {
                        row.selected = true;
                    }
                }
                row.AcceptChanges();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_data_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
        
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsWizard.tipo_IngresoRow)gridView.GetDataRow(e.RowHandle);
                if (e.RowHandle >= 0)
                {

                    if (row.selected)
                    {
                        e.Appearance.BackColor = Color.FromArgb(0, 178, 149);
                        
                    }
                }
            }

            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (Tipo_Ingreso_Selected == 0)
            {
                CajaDialogo.Error("Debe seleccionar un tipo de ingreso.");
                return;
            }

            if (Tipo_Ingreso_Selected == 3)
            {// si es almacen externo abrimos la ventana de almacen externo.
                xfrmAlmacenesExternos_Main frmExterno = new xfrmAlmacenesExternos_Main(UsuarioLogeado);
                if (this.MdiParent != null)
                {
                    //frmExterno.MdiParent = this.MdiParent;
                    frmExterno.MdiParent = (Form)MDI_Parent;
                }
                if (frmExterno.ShowDialog()== DialogResult.OK)
                {

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                frmSpet2 frm = new frmSpet2(UsuarioLogeado, Descripcion_Tipo_Selected, Tipo_Ingreso_Selected);
                switch (frm.ShowDialog())
                {
                    case DialogResult.OK:
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                    default:
                        break;
                }
            }

            
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsWizard.tipo_IngresoRow)gridView.GetFocusedDataRow();
                Tipo_Ingreso_Selected = row.id;
                Descripcion_Tipo_Selected = row.descripcion;
                foreach (dsWizard.tipo_IngresoRow fila in dsWizard.tipo_Ingreso.Rows)
                {
                    fila.selected = false;
                }
                dsWizard.tipo_Ingreso.AcceptChanges();
                foreach (dsWizard.tipo_IngresoRow fila in dsWizard.tipo_Ingreso.Rows)
                {
                    if (fila.id == row.id)
                    {
                        row.selected = true;
                    }
                }
                row.AcceptChanges();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            if (Tipo_Ingreso_Selected == 0)
            {
                CajaDialogo.Error("Debe seleccionar un tipo de ingreso.");
                return;
            }
            if (Tipo_Ingreso_Selected == 3)
            {// si es almacen externo abrimos la ventana de almacen externo.
                xfrmAlmacenesExternos_Main frmExterno = new xfrmAlmacenesExternos_Main(UsuarioLogeado);
                if (this.MdiParent != null)
                {
                    //frmExterno.MdiParent = this.MdiParent;
                    //frm.FormBorderStyle = FormBorderStyle.Sizable;
                    frmExterno.MdiParent = (Form)MDI_Parent;
                }
                if (frmExterno.ShowDialog() == DialogResult.OK)
                {

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                frmSpet2 frm = new frmSpet2(UsuarioLogeado, Descripcion_Tipo_Selected, Tipo_Ingreso_Selected);
                switch (frm.ShowDialog())
                {

                    case DialogResult.OK:
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
           
        }
    }
}