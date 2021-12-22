using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Trazabilidad
{
    public partial class frmMantoProveedoresMP : DevExpress.XtraEditors.XtraForm
    {
        Proveedor vProveedorActual;
        UserLogin UsuarioLogeado;
        public frmMantoProveedoresMP(UserLogin pUser)
        {
            InitializeComponent();
            vProveedorActual = new Proveedor();
            LoadTiposArchivos();
            UsuarioLogeado = pUser;
            LoadAdjuntosRows();
            LoadRiesgos();
            LoadAprobaciones();
        }

        private void LoadAprobaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lista_aprobaciones", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@cardcode", vProveedorActual.Codigo);
                dsMantoTrazabilidad1.aprobacion.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.aprobacion);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadRiesgos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lista_riesgos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@cardcode", vProveedorActual.Codigo);
                dsMantoTrazabilidad1.riesgos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.riesgos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdBuscarProveedores_Click(object sender, EventArgs e)
        {
            frmBuscarProvMP frm = new frmBuscarProvMP();
            if(frm.ShowDialog()== DialogResult.OK)
            {
                
                txtCodigo.Text = frm.ProveedorRow.Codigo;
                txtNombre.Text = frm.ProveedorRow.Nombre;
                txtNombreF.Text = frm.ProveedorRow.NombreF;
                txtRTN.Text = frm.ProveedorRow.RTN;
                vProveedorActual = frm.ProveedorRow;
                txtContacto.Text= frm.ProveedorRow.Contacto;
                txtTel1.Text = frm.ProveedorRow.Telefono1;
                txtTel2.Text = frm.ProveedorRow.Telefono2;
                txtTel3.Text = frm.ProveedorRow.Telefono3;
                txtDireccion.Text = frm.ProveedorRow.Direccion;
                txtCorreo.Text = frm.ProveedorRow.Correo;
                
                this.gridLookUpEdit_Riesgos.EditValueChanged -= new System.EventHandler(this.gridLookUpEdit_Riesgos_EditValueChanged);
                this.gridLookUpEdit_aprobacion.EditValueChanged -= new System.EventHandler(this.gridLookUpEdit_aprobacion_EditValueChanged);
                this.toggleSwitch1.EditValueChanged -= new System.EventHandler(this.toggleSwitch1_EditValueChanged);
                gridLookUpEdit_aprobacion.EditValue = gridLookUpEdit_Riesgos.EditValue = null;

                gridLookUpEdit_aprobacion.EditValue = frm.ProveedorRow.IdAprobacion;
                gridLookUpEdit_Riesgos.EditValue = frm.ProveedorRow.IdRiesgo;
                toggleSwitch1.IsOn = frm.ProveedorRow.Auditoria;
                LoadAdjuntosRows();
                LoadPlantas();
                LoadIngredientes();
                LoadMateriasPrimas();
                gridLookUpEdit_aprobacion.Enabled = gridLookUpEdit_Riesgos.Enabled = true;
                toggleSwitch1.Enabled = true;

                this.gridLookUpEdit_Riesgos.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_Riesgos_EditValueChanged);
                this.gridLookUpEdit_aprobacion.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_aprobacion_EditValueChanged);
                this.toggleSwitch1.EditValueChanged += new System.EventHandler(this.toggleSwitch1_EditValueChanged);
            }
            else
            {
                this.gridLookUpEdit_Riesgos.EditValueChanged -= new System.EventHandler(this.gridLookUpEdit_Riesgos_EditValueChanged);
                this.gridLookUpEdit_aprobacion.EditValueChanged -= new System.EventHandler(this.gridLookUpEdit_aprobacion_EditValueChanged);
                this.toggleSwitch1.EditValueChanged -= new System.EventHandler(this.toggleSwitch1_EditValueChanged);

                gridLookUpEdit_aprobacion.Enabled = gridLookUpEdit_Riesgos.Enabled = false;
                toggleSwitch1.Enabled = false;
                gridLookUpEdit_aprobacion.EditValue = gridLookUpEdit_Riesgos.EditValue = null;

                this.gridLookUpEdit_Riesgos.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_Riesgos_EditValueChanged);
                this.gridLookUpEdit_aprobacion.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_aprobacion_EditValueChanged);
                this.toggleSwitch1.EditValueChanged += new System.EventHandler(this.toggleSwitch1_EditValueChanged);
            }
        }

        private void LoadIngredientes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lista_ingresdientes_asociados_a_proveedor_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cardcode", vProveedorActual.Codigo);
                dsMantoTrazabilidad1.ingredientes_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.ingredientes_list);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadMateriasPrimas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_materia_prima_por_proveedorv2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cardcode", vProveedorActual.Codigo);
                dsMantoTrazabilidad1.lista_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.lista_mp);

                con.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!vProveedorActual.Recuperado)
            {
                CajaDialogo.Error("Debe seleccionar un proveedor para poder relacionar un archivo Adjunto!");
                return;
            }
            frmAdjuntar frm = new frmAdjuntar(vProveedorActual.Codigo, UsuarioLogeado);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadAdjuntosRows();
            }
        }

        private void LoadAdjuntosRows()
        {
            //
            if(vProveedorActual.Codigo == null)
            {
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_adjuntos_trz_prv", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cardcode", vProveedorActual.Codigo);
                dsMantoTrazabilidad1.archivos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.archivos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void LoadTiposArchivos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tipos_archivos_trz_prv", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsMantoTrazabilidad1.tipos_archivos_prv.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.tipos_archivos_prv);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEliminarRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Realmente desea eliminar este Archivo?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                var gridView = (GridView)gridControl2.FocusedView;
                var row = (dsMantoTrazabilidad.archivosRow)gridView.GetFocusedDataRow();

                SqlCommand cmd = new SqlCommand("sp_set_disable_archivo_adjunto_trz_prv", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadAdjuntosRows();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "descripcion":
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();

                        var gridView = (GridView)gridControl2.FocusedView;
                        var row = (dsMantoTrazabilidad.archivosRow)gridView.GetFocusedDataRow();

                        SqlCommand cmd = new SqlCommand("sp_set_update_description_archivo_adjunto_trz_prv", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.Parameters.AddWithValue("@descrip", row.descripcion);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        //LoadAdjuntosRows();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case "id_tipo":
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();

                        var gridView = (GridView)gridControl2.FocusedView;
                        var row = (dsMantoTrazabilidad.archivosRow)gridView.GetFocusedDataRow();

                        SqlCommand cmd = new SqlCommand("sp_set_update_type_archivo_adjunto_trz_prv", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.Parameters.AddWithValue("@id_type", row.id_tipo);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        //LoadAdjuntosRows();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
            }
            
        }

        private void cmdAbrir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                string dir = @"C:\ALOSY_TMP";

                // If directory does not exist, create it
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }


                var gridView = (GridView)gridControl2.FocusedView;
                var row = (dsMantoTrazabilidad.archivosRow)gridView.GetFocusedDataRow();


                OpenFile(row.Path, dir + @"\" + row.FileName);
                //openFileDialog1.OpenFile(
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void OpenFile(string pathSource, string pathDestination)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                //request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
                request.Credentials = new NetworkCredential(UsuarioLogeado.ADuser1, UsuarioLogeado.Pass);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(pathDestination))
                {

                    ftpStream.CopyTo(fileStream);

                    Process.Start(pathDestination);

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdDownload_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)gridControl2.FocusedView;
                var row = (dsMantoTrazabilidad.archivosRow)gridView.GetFocusedDataRow();

                if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    DownloadFile(row.Path, xtraFolderBrowserDialog1.SelectedPath + @"\" + row.FileName);
                    //CajaDialogo.Information(xtraFolderBrowserDialog1.SelectedPath);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void DownloadFile(string pathSource, string pathDestination)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                //request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
                request.Credentials = new NetworkCredential(UsuarioLogeado.ADuser1,UsuarioLogeado.Pass);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(pathDestination))
                {
                    ftpStream.CopyTo(fileStream);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdDelete__ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Delete
            DialogResult r = CajaDialogo.Pregunta("Realmente desea eliminar esta registro?");
            if (r != DialogResult.Yes)
                return;

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMantoTrazabilidad.plantasRow)gridView.GetFocusedDataRow();
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_disable_planta_prv_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();

                con.Close();
                LoadPlantas();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmCRUD_PlantasPRV frm = new frmCRUD_PlantasPRV(vProveedorActual.Codigo, 0, frmCRUD_PlantasPRV.TipoAccion.Insert, UsuarioLogeado.Id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadPlantas();
            }
        }

        private void LoadPlantas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lista_plantas_prv_trz]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cardcode",vProveedorActual.Codigo);
                dsMantoTrazabilidad1.plantas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.plantas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMantoTrazabilidad.plantasRow)gridView.GetFocusedDataRow();

            frmCRUD_PlantasPRV frm = new frmCRUD_PlantasPRV(vProveedorActual.Codigo, row.id, frmCRUD_PlantasPRV.TipoAccion.Update, UsuarioLogeado.Id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadPlantas();
            }
        }

        private void gridLookUpEdit_Riesgos_EditValueChanged(object sender, EventArgs e)
        {
            if (vProveedorActual.Recuperado)
            {
                if(vProveedorActual.UpdateDatos(gridLookUpEdit_Riesgos.EditValue, 1, false, vProveedorActual.Codigo))
                {
                    //accion 
                    vProveedorActual.IdRiesgo = Convert.ToInt32(gridLookUpEdit_Riesgos.EditValue);
                }
            }
        }

        private void gridLookUpEdit_aprobacion_EditValueChanged(object sender, EventArgs e)
        {
            if (vProveedorActual.Recuperado)
            {
                if (vProveedorActual.UpdateDatos(gridLookUpEdit_aprobacion.EditValue, 3, false, vProveedorActual.Codigo))
                {
                    //accion 
                    vProveedorActual.IdAprobacion = Convert.ToInt32(gridLookUpEdit_aprobacion.EditValue);
                }
            }
        }

        private void toggleSwitch1_EditValueChanged(object sender, EventArgs e)
        {
            if (vProveedorActual.Recuperado)
            {
                if (vProveedorActual.UpdateDatos(0, 2, toggleSwitch1.IsOn, vProveedorActual.Codigo))
                {
                    //accion 
                    vProveedorActual.Auditoria = toggleSwitch1.IsOn;
                }
            }
        }

        private void cmdDelete___ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Delete Ingredientes
            DialogResult r = CajaDialogo.Pregunta("¿Esta seguro de eliminar este Ingrediente?");
            if (r != DialogResult.Yes)
                return;

            var gridView = (GridView)gridControl3.FocusedView;
            var row = (dsMantoTrazabilidad.ingredientes_listRow)gridView.GetFocusedDataRow();

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_disable_row_ingrediente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                //cmd.Parameters.AddWithValue("@idmp", row.idmp);
                //cmd.Parameters.AddWithValue("@idpresentacion", row.idpresentacion);
                dsMantoTrazabilidad1.plantas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.plantas);

                con.Close();
                LoadIngredientes();
                LoadMateriasPrimas();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            if (!vProveedorActual.Recuperado)
            {
                CajaDialogo.Error("Debe seleccionar un proveedor para poder relacionar un archivo Adjunto!");
                return;
            }
            frmCRUD_Ingredientes frm = new frmCRUD_Ingredientes(vProveedorActual.Codigo,1,1, frmCRUD_Ingredientes.TipoAccion.Insert, UsuarioLogeado.Id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadIngredientes();
                LoadMateriasPrimas();
            }
        }

        private void cmdLinkIngrediente_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl3.FocusedView;
            var row = (dsMantoTrazabilidad.ingredientes_listRow)gridView.GetFocusedDataRow();
            MateriaPrima mp = new MateriaPrima();
            if (mp.RecuperarRegistroFromID_RM(row.idmp))
            {
                frmMateriaPrimaViewer frm = new frmMateriaPrimaViewer(mp.CodeMP_SAP);
                frm.Show();
            }
        }

        private void link_materia_prima_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl4.FocusedView;
            var row = (dsMantoTrazabilidad.lista_mpRow)gridView.GetFocusedDataRow();
            MateriaPrima mp = new MateriaPrima();
            if (mp.RecuperarRegistroFromID_RM(row.idrm))
            {
                frmMateriaPrimaViewer frm = new frmMateriaPrimaViewer(mp.CodeMP_SAP, txtCodigo.Text);
                if (this.MdiParent != null)
                    frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void cmdAbrir_Click(object sender, EventArgs e)
        {

        }
    }
}