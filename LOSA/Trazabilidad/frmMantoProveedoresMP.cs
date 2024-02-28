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
        int IdPlantaSeleccionada;
        public frmMantoProveedoresMP(UserLogin pUser)
        {
            InitializeComponent();
            vProveedorActual = new Proveedor();
            LoadTiposArchivos();
            UsuarioLogeado = pUser;
            LoadAdjuntosRows();
            LoadRiesgos();
            LoadAprobaciones();
            IdPlantaSeleccionada = 0;
        }

        public frmMantoProveedoresMP(UserLogin pUser, string pCardCode)
        {
            InitializeComponent();
            vProveedorActual = new Proveedor();
            UsuarioLogeado = pUser;
            if (vProveedorActual.RecuperarRegistroWithRTN(pCardCode))
            {
                LoadTiposArchivos();
                LoadAdjuntosRows();
                LoadRiesgos();
                LoadAprobaciones();
                AsignarDatosFromProveedor(vProveedorActual);
                IdPlantaSeleccionada = 0;
            }
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

                //txtCodigo.Text = frm.ProveedorRow.Codigo;
                //txtNombre.Text = frm.ProveedorRow.Nombre;
                //txtNombreF.Text = frm.ProveedorRow.NombreF;
                //txtRTN.Text = frm.ProveedorRow.RTN;
                //vProveedorActual = frm.ProveedorRow;
                //txtContacto.Text= frm.ProveedorRow.Contacto;
                //txtTel1.Text = frm.ProveedorRow.Telefono1;
                //txtTel2.Text = frm.ProveedorRow.Telefono2;
                //txtTel3.Text = frm.ProveedorRow.Telefono3;
                //txtDireccion.Text = frm.ProveedorRow.Direccion;
                //txtCorreo.Text = frm.ProveedorRow.Correo;

                //this.gridLookUpEdit_Riesgos.EditValueChanged -= new System.EventHandler(this.gridLookUpEdit_Riesgos_EditValueChanged);
                //this.gridLookUpEdit_aprobacion.EditValueChanged -= new System.EventHandler(this.gridLookUpEdit_aprobacion_EditValueChanged);
                //this.toggleSwitch1.EditValueChanged -= new System.EventHandler(this.toggleSwitch1_EditValueChanged);
                //gridLookUpEdit_aprobacion.EditValue = gridLookUpEdit_Riesgos.EditValue = null;

                //gridLookUpEdit_aprobacion.EditValue = frm.ProveedorRow.IdAprobacion;
                //gridLookUpEdit_Riesgos.EditValue = frm.ProveedorRow.IdRiesgo;
                //toggleSwitch1.IsOn = frm.ProveedorRow.Auditoria;
                //LoadAdjuntosRows();
                //LoadPlantas();
                //LoadIngredientes();
                //LoadMateriasPrimas();
                //gridLookUpEdit_aprobacion.Enabled = gridLookUpEdit_Riesgos.Enabled = true;
                //toggleSwitch1.Enabled = true;

                //this.gridLookUpEdit_Riesgos.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_Riesgos_EditValueChanged);
                //this.gridLookUpEdit_aprobacion.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_aprobacion_EditValueChanged);
                //this.toggleSwitch1.EditValueChanged += new System.EventHandler(this.toggleSwitch1_EditValueChanged);
                AsignarDatosFromProveedor(frm.ProveedorRow);
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

        public void AsignarDatosFromProveedor(Proveedor ProveedorRow)
        {
            txtCodigo.Text = ProveedorRow.Codigo;
            txtNombre.Text = ProveedorRow.Nombre;
            txtNombreF.Text = ProveedorRow.NombreF;
            txtRTN.Text = ProveedorRow.RTN;
            vProveedorActual = ProveedorRow;
            txtContacto.Text = ProveedorRow.Contacto;
            txtTel1.Text = ProveedorRow.Telefono1;
            txtTel2.Text = ProveedorRow.Telefono2;
            txtTel3.Text = ProveedorRow.Telefono3;
            txtDireccion.Text = ProveedorRow.Direccion;
            txtCorreo.Text = ProveedorRow.Correo;

            this.gridLookUpEdit_Riesgos.EditValueChanged -= new System.EventHandler(this.gridLookUpEdit_Riesgos_EditValueChanged);
            this.gridLookUpEdit_aprobacion.EditValueChanged -= new System.EventHandler(this.gridLookUpEdit_aprobacion_EditValueChanged);
            this.toggleSwitch1.EditValueChanged -= new System.EventHandler(this.toggleSwitch1_EditValueChanged);
            gridLookUpEdit_aprobacion.EditValue = gridLookUpEdit_Riesgos.EditValue = null;

            gridLookUpEdit_aprobacion.EditValue = ProveedorRow.IdAprobacion;
            gridLookUpEdit_Riesgos.EditValue = ProveedorRow.IdRiesgo;
            toggleSwitch1.IsOn = ProveedorRow.Auditoria;
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

        private void LoadAdjuntosRows(int pIdPlanta)
        {
            //
            if (vProveedorActual.Codigo == null)
            {
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_detalle_adjuntos_trz_prv_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cardcode", vProveedorActual.Codigo);
                cmd.Parameters.AddWithValue("@id_planta", pIdPlanta);
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
                frmMateriaPrimaViewer frm = new frmMateriaPrimaViewer(mp.CodeMP_SAP, txtCodigo.Text,1);
                if (this.MdiParent != null)
                    frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void cmdAbrir_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (!vProveedorActual.Recuperado)
            {
                CajaDialogo.Error("Debe seleccionar un proveedor para poder relacionar un archivo Adjunto!");
                return;
            }
            frmAdjuntar frm = new frmAdjuntar(vProveedorActual.Codigo, UsuarioLogeado, IdPlantaSeleccionada);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadAdjuntosRows();
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions7 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject25 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject26 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject27 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject28 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions8 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject29 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject30 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject31 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject32 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions9 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject33 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject34 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject35 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject36 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions10 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject37 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject38 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject39 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject40 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions11 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject41 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject42 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject43 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject44 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions12 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject45 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject46 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject47 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject48 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions13 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject49 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject50 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject51 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject52 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions14 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject53 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject54 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject55 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject56 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions15 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject57 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject58 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject59 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject60 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions16 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject61 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject62 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject63 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject64 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions17 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject65 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject66 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject67 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject68 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions18 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject69 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject70 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject71 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject72 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions19 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject73 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject74 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject75 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject76 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantoProveedoresMP));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabPlantas = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
            this.dsMantoTrazabilidad1 = new LOSA.Trazabilidad.dsMantoTrazabilidad();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bindingSourceTipoArchivos = new System.Windows.Forms.BindingSource(this.components);
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit9 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit10 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit11 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid_planta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplanta_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDelete_ = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colfecha_creado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.TabAdjuntos = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridTipoArchivoEmbebed = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbrir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAbrir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEliminarRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDownload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDownload = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tabIngredientes = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdLinkIngrediente = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colidpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcardcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete___ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDelete__ = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.TabMateriales = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidrm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemdescrip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.link_materia_prima = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colpresentacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcardcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreF = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRTN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmdBuscarProveedores = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.txtContacto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTel1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTel2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTel3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.xtraFolderBrowserDialog1 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit_Riesgos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceRiesgos = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.gridLookUpEdit_aprobacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceAprobaciones = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cmdVerTodosAdjuntos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabPlantas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            this.TabAdjuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoArchivoEmbebed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAbrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminarRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDownload)).BeginInit();
            this.tabIngredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdLinkIngrediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete__)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).BeginInit();
            this.TabMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.link_materia_prima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_Riesgos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRiesgos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_aprobacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAprobaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(1, 269);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabPlantas;
            this.xtraTabControl1.Size = new System.Drawing.Size(1044, 373);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPlantas,
            this.TabAdjuntos,
            this.tabIngredientes,
            this.TabMateriales});
            // 
            // TabPlantas
            // 
            this.TabPlantas.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPlantas.Appearance.Header.Options.UseFont = true;
            this.TabPlantas.Controls.Add(this.cmdVerTodosAdjuntos);
            this.TabPlantas.Controls.Add(this.simpleButton5);
            this.TabPlantas.Controls.Add(this.gridControl5);
            this.TabPlantas.Controls.Add(this.simpleButton2);
            this.TabPlantas.Controls.Add(this.gridControl1);
            this.TabPlantas.Name = "TabPlantas";
            this.TabPlantas.Size = new System.Drawing.Size(1042, 341);
            this.TabPlantas.Text = "Fabricantes";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.Location = new System.Drawing.Point(895, 3);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(142, 34);
            this.simpleButton5.TabIndex = 13;
            this.simpleButton5.Text = "Agregar Archivo";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // gridControl5
            // 
            this.gridControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl5.DataMember = "archivos";
            this.gridControl5.DataSource = this.dsMantoTrazabilidad1;
            this.gridControl5.Location = new System.Drawing.Point(611, 40);
            this.gridControl5.MainView = this.gridView8;
            this.gridControl5.Name = "gridControl5";
            this.gridControl5.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit3,
            this.repositoryItemButtonEdit10,
            this.repositoryItemButtonEdit9,
            this.repositoryItemButtonEdit11});
            this.gridControl5.Size = new System.Drawing.Size(426, 295);
            this.gridControl5.TabIndex = 12;
            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView8});
            // 
            // dsMantoTrazabilidad1
            // 
            this.dsMantoTrazabilidad1.DataSetName = "dsMantoTrazabilidad";
            this.dsMantoTrazabilidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView8
            // 
            this.gridView8.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView8.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView8.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView8.Appearance.Row.Options.UseFont = true;
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.colid_planta,
            this.colplanta_descripcion});
            this.gridView8.GridControl = this.gridControl5;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsView.ShowAutoFilterRow = true;
            this.gridView8.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Path";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 163;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "FileName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 200;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "id";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Type";
            this.gridColumn4.ColumnEdit = this.repositoryItemGridLookUpEdit3;
            this.gridColumn4.FieldName = "id_tipo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 152;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.DataSource = this.bindingSourceTipoArchivos;
            this.repositoryItemGridLookUpEdit3.DisplayMember = "descripcion";
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.PopupView = this.gridView9;
            this.repositoryItemGridLookUpEdit3.ValueMember = "id";
            // 
            // bindingSourceTipoArchivos
            // 
            this.bindingSourceTipoArchivos.DataMember = "tipos_archivos_prv";
            this.bindingSourceTipoArchivos.DataSource = this.dsMantoTrazabilidad1;
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "id";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tipo de Archivo";
            this.gridColumn8.FieldName = "descripcion";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "enabled";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Open";
            this.gridColumn10.ColumnEdit = this.repositoryItemButtonEdit9;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 82;
            // 
            // repositoryItemButtonEdit9
            // 
            this.repositoryItemButtonEdit9.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit9.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit9.Name = "repositoryItemButtonEdit9";
            this.repositoryItemButtonEdit9.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Delete";
            this.gridColumn13.ColumnEdit = this.repositoryItemButtonEdit10;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 5;
            this.gridColumn13.Width = 71;
            // 
            // repositoryItemButtonEdit10
            // 
            this.repositoryItemButtonEdit10.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemButtonEdit10.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit10.Name = "repositoryItemButtonEdit10";
            this.repositoryItemButtonEdit10.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Description";
            this.gridColumn14.FieldName = "descripcion";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            this.gridColumn14.Width = 310;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Download";
            this.gridColumn15.ColumnEdit = this.repositoryItemButtonEdit11;
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            // 
            // repositoryItemButtonEdit11
            // 
            this.repositoryItemButtonEdit11.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.repositoryItemButtonEdit11.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit11.Name = "repositoryItemButtonEdit11";
            this.repositoryItemButtonEdit11.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colid_planta
            // 
            this.colid_planta.FieldName = "id_planta";
            this.colid_planta.Name = "colid_planta";
            // 
            // colplanta_descripcion
            // 
            this.colplanta_descripcion.FieldName = "planta_descripcion";
            this.colplanta_descripcion.Name = "colplanta_descripcion";
            this.colplanta_descripcion.OptionsColumn.ReadOnly = true;
            this.colplanta_descripcion.Visible = true;
            this.colplanta_descripcion.VisibleIndex = 6;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(463, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(142, 34);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Nueva";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.DataMember = "plantas";
            this.gridControl1.DataSource = this.dsMantoTrazabilidad1;
            this.gridControl1.Location = new System.Drawing.Point(1, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdDelete_,
            this.cmdEditar});
            this.gridControl1.Size = new System.Drawing.Size(604, 295);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.colnombre,
            this.coldireccion,
            this.colcomentario,
            this.col_delete,
            this.colfecha_creado,
            this.colid_user,
            this.col_update});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            this.colnombre.Width = 167;
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "Dirección";
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.AllowEdit = false;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 1;
            this.coldireccion.Width = 167;
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Comentario";
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 2;
            this.colcomentario.Width = 338;
            // 
            // col_delete
            // 
            this.col_delete.Caption = "Eliminar";
            this.col_delete.ColumnEdit = this.cmdDelete_;
            this.col_delete.Name = "col_delete";
            this.col_delete.Visible = true;
            this.col_delete.VisibleIndex = 4;
            this.col_delete.Width = 71;
            // 
            // cmdDelete_
            // 
            this.cmdDelete_.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.cmdDelete_.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdDelete_.Name = "cmdDelete_";
            this.cmdDelete_.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdDelete_.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdDelete__ButtonClick);
            // 
            // colfecha_creado
            // 
            this.colfecha_creado.FieldName = "fecha_creado";
            this.colfecha_creado.Name = "colfecha_creado";
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            // 
            // col_update
            // 
            this.col_update.Caption = "Editar";
            this.col_update.ColumnEdit = this.cmdEditar;
            this.col_update.Name = "col_update";
            this.col_update.Visible = true;
            this.col_update.VisibleIndex = 3;
            this.col_update.Width = 72;
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoHeight = false;
            editorButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions5.Image")));
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEditar_ButtonClick);
            // 
            // TabAdjuntos
            // 
            this.TabAdjuntos.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.TabAdjuntos.Appearance.Header.Options.UseFont = true;
            this.TabAdjuntos.Controls.Add(this.simpleButton1);
            this.TabAdjuntos.Controls.Add(this.gridControl2);
            this.TabAdjuntos.Name = "TabAdjuntos";
            this.TabAdjuntos.PageVisible = false;
            this.TabAdjuntos.Size = new System.Drawing.Size(1042, 341);
            this.TabAdjuntos.Text = "Datos Adjuntos";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(891, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(142, 34);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Agregar Archivo";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "archivos";
            this.gridControl2.DataSource = this.dsMantoTrazabilidad1;
            this.gridControl2.Location = new System.Drawing.Point(1, 40);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.GridTipoArchivoEmbebed,
            this.cmdEliminarRow,
            this.cmdAbrir,
            this.cmdDownload});
            this.gridControl2.Size = new System.Drawing.Size(1032, 295);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPath,
            this.colFileName,
            this.colid,
            this.colid_tipo,
            this.colenabled,
            this.colAbrir,
            this.colDelete,
            this.coldescripcion1,
            this.colDownload});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            // 
            // colPath
            // 
            this.colPath.FieldName = "Path";
            this.colPath.Name = "colPath";
            this.colPath.Width = 163;
            // 
            // colFileName
            // 
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.OptionsColumn.AllowEdit = false;
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 0;
            this.colFileName.Width = 200;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_tipo
            // 
            this.colid_tipo.Caption = "Type";
            this.colid_tipo.ColumnEdit = this.GridTipoArchivoEmbebed;
            this.colid_tipo.FieldName = "id_tipo";
            this.colid_tipo.Name = "colid_tipo";
            this.colid_tipo.Visible = true;
            this.colid_tipo.VisibleIndex = 2;
            this.colid_tipo.Width = 152;
            // 
            // GridTipoArchivoEmbebed
            // 
            this.GridTipoArchivoEmbebed.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.GridTipoArchivoEmbebed.AutoHeight = false;
            this.GridTipoArchivoEmbebed.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridTipoArchivoEmbebed.DataSource = this.bindingSourceTipoArchivos;
            this.GridTipoArchivoEmbebed.DisplayMember = "descripcion";
            this.GridTipoArchivoEmbebed.Name = "GridTipoArchivoEmbebed";
            this.GridTipoArchivoEmbebed.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.GridTipoArchivoEmbebed.ValueMember = "id";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Tipo de Archivo";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colenabled
            // 
            this.colenabled.FieldName = "enabled";
            this.colenabled.Name = "colenabled";
            // 
            // colAbrir
            // 
            this.colAbrir.Caption = "Open";
            this.colAbrir.ColumnEdit = this.cmdAbrir;
            this.colAbrir.Name = "colAbrir";
            this.colAbrir.Visible = true;
            this.colAbrir.VisibleIndex = 3;
            this.colAbrir.Width = 82;
            // 
            // cmdAbrir
            // 
            this.cmdAbrir.AutoHeight = false;
            editorButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions6.Image")));
            this.cmdAbrir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdAbrir.Name = "cmdAbrir";
            this.cmdAbrir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdAbrir.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdAbrir_ButtonClick);
            this.cmdAbrir.Click += new System.EventHandler(this.cmdAbrir_Click);
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Delete";
            this.colDelete.ColumnEdit = this.cmdEliminarRow;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 5;
            this.colDelete.Width = 71;
            // 
            // cmdEliminarRow
            // 
            this.cmdEliminarRow.AutoHeight = false;
            editorButtonImageOptions7.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions7.Image")));
            this.cmdEliminarRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions7, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject25, serializableAppearanceObject26, serializableAppearanceObject27, serializableAppearanceObject28, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEliminarRow.Name = "cmdEliminarRow";
            this.cmdEliminarRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEliminarRow.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEliminarRow_ButtonClick);
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Description";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 1;
            this.coldescripcion1.Width = 310;
            // 
            // colDownload
            // 
            this.colDownload.Caption = "Download";
            this.colDownload.ColumnEdit = this.cmdDownload;
            this.colDownload.Name = "colDownload";
            this.colDownload.Visible = true;
            this.colDownload.VisibleIndex = 4;
            // 
            // cmdDownload
            // 
            this.cmdDownload.AutoHeight = false;
            editorButtonImageOptions8.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions8.Image")));
            this.cmdDownload.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions8, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject29, serializableAppearanceObject30, serializableAppearanceObject31, serializableAppearanceObject32, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdDownload.Name = "cmdDownload";
            this.cmdDownload.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdDownload.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdDownload_ButtonClick);
            // 
            // tabIngredientes
            // 
            this.tabIngredientes.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tabIngredientes.Appearance.Header.Options.UseFont = true;
            this.tabIngredientes.Controls.Add(this.simpleButton3);
            this.tabIngredientes.Controls.Add(this.gridControl3);
            this.tabIngredientes.Name = "tabIngredientes";
            this.tabIngredientes.PageVisible = false;
            this.tabIngredientes.Size = new System.Drawing.Size(1042, 341);
            this.tabIngredientes.Text = "Ingrediente(s) Aprobado(s)";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(692, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(142, 34);
            this.simpleButton3.TabIndex = 12;
            this.simpleButton3.Text = "Agregar \r\nIngrediente";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.DataMember = "ingredientes_list";
            this.gridControl3.DataSource = this.dsMantoTrazabilidad1;
            this.gridControl3.Location = new System.Drawing.Point(1, 40);
            this.gridControl3.MainView = this.gridView4;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemButtonEdit2,
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit3,
            this.cmdDelete__,
            this.cmdLinkIngrediente});
            this.gridControl3.Size = new System.Drawing.Size(833, 286);
            this.gridControl3.TabIndex = 11;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView4.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView4.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView4.Appearance.Row.Options.UseFont = true;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid5,
            this.colidmp,
            this.colmaterial,
            this.colidpresentacion,
            this.colpresentacion,
            this.colfecha,
            this.colcardcode,
            this.colDelete___});
            this.gridView4.GridControl = this.gridControl3;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // colid5
            // 
            this.colid5.FieldName = "id";
            this.colid5.Name = "colid5";
            // 
            // colidmp
            // 
            this.colidmp.FieldName = "idmp";
            this.colidmp.Name = "colidmp";
            // 
            // colmaterial
            // 
            this.colmaterial.Caption = "Name";
            this.colmaterial.ColumnEdit = this.cmdLinkIngrediente;
            this.colmaterial.FieldName = "material";
            this.colmaterial.Name = "colmaterial";
            this.colmaterial.Visible = true;
            this.colmaterial.VisibleIndex = 0;
            // 
            // cmdLinkIngrediente
            // 
            this.cmdLinkIngrediente.AutoHeight = false;
            editorButtonImageOptions9.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions9.SvgImage")));
            this.cmdLinkIngrediente.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions9, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject33, serializableAppearanceObject34, serializableAppearanceObject35, serializableAppearanceObject36, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdLinkIngrediente.Name = "cmdLinkIngrediente";
            this.cmdLinkIngrediente.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdLinkIngrediente_ButtonClick);
            // 
            // colidpresentacion
            // 
            this.colidpresentacion.FieldName = "idpresentacion";
            this.colidpresentacion.Name = "colidpresentacion";
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Size";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 1;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Date";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            // 
            // colcardcode
            // 
            this.colcardcode.FieldName = "cardcode";
            this.colcardcode.Name = "colcardcode";
            // 
            // colDelete___
            // 
            this.colDelete___.Caption = "Delete";
            this.colDelete___.ColumnEdit = this.cmdDelete__;
            this.colDelete___.Name = "colDelete___";
            this.colDelete___.Visible = true;
            this.colDelete___.VisibleIndex = 3;
            // 
            // cmdDelete__
            // 
            this.cmdDelete__.AutoHeight = false;
            editorButtonImageOptions10.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions10.SvgImage")));
            this.cmdDelete__.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions10, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject37, serializableAppearanceObject38, serializableAppearanceObject39, serializableAppearanceObject40, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdDelete__.Name = "cmdDelete__";
            this.cmdDelete__.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdDelete__.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdDelete___ButtonClick);
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.bindingSourceTipoArchivos;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "descripcion";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.gridView6;
            this.repositoryItemGridLookUpEdit1.ValueMember = "id";
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "id";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tipo de Archivo";
            this.gridColumn6.FieldName = "descripcion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions11.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions11.Image")));
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions11, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject41, serializableAppearanceObject42, serializableAppearanceObject43, serializableAppearanceObject44, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions12.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions12.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions12, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject45, serializableAppearanceObject46, serializableAppearanceObject47, serializableAppearanceObject48, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEdit3
            // 
            this.repositoryItemButtonEdit3.AutoHeight = false;
            editorButtonImageOptions13.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions13.Image")));
            this.repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions13, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject49, serializableAppearanceObject50, serializableAppearanceObject51, serializableAppearanceObject52, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            this.repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // TabMateriales
            // 
            this.TabMateriales.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.TabMateriales.Appearance.Header.Options.UseFont = true;
            this.TabMateriales.Controls.Add(this.simpleButton4);
            this.TabMateriales.Controls.Add(this.gridControl4);
            this.TabMateriales.Name = "TabMateriales";
            this.TabMateriales.Size = new System.Drawing.Size(1042, 341);
            this.TabMateriales.Text = "Materia(s) Prima(s)";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(694, 3);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(142, 34);
            this.simpleButton4.TabIndex = 14;
            this.simpleButton4.Text = "Agregar \r\nIngrediente";
            this.simpleButton4.Visible = false;
            // 
            // gridControl4
            // 
            this.gridControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl4.DataMember = "lista_mp";
            this.gridControl4.DataSource = this.dsMantoTrazabilidad1;
            this.gridControl4.Location = new System.Drawing.Point(1, 40);
            this.gridControl4.MainView = this.gridView5;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemButtonEdit6,
            this.repositoryItemButtonEdit7,
            this.repositoryItemButtonEdit8,
            this.repositoryItemButtonEdit5,
            this.repositoryItemButtonEdit4,
            this.link_materia_prima});
            this.gridControl4.Size = new System.Drawing.Size(833, 286);
            this.gridControl4.TabIndex = 13;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView5.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView5.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView5.Appearance.Row.Options.UseFont = true;
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidrm,
            this.colitemdescrip,
            this.colpresentacion1,
            this.colitemcode,
            this.colcardcode1});
            this.gridView5.GridControl = this.gridControl4;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // colidrm
            // 
            this.colidrm.FieldName = "idrm";
            this.colidrm.Name = "colidrm";
            // 
            // colitemdescrip
            // 
            this.colitemdescrip.ColumnEdit = this.link_materia_prima;
            this.colitemdescrip.FieldName = "itemdescrip";
            this.colitemdescrip.Name = "colitemdescrip";
            this.colitemdescrip.Visible = true;
            this.colitemdescrip.VisibleIndex = 0;
            // 
            // link_materia_prima
            // 
            this.link_materia_prima.AutoHeight = false;
            editorButtonImageOptions14.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions14.SvgImage")));
            this.link_materia_prima.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions14, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject53, serializableAppearanceObject54, serializableAppearanceObject55, serializableAppearanceObject56, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.link_materia_prima.Name = "link_materia_prima";
            this.link_materia_prima.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.link_materia_prima_ButtonClick);
            // 
            // colpresentacion1
            // 
            this.colpresentacion1.FieldName = "presentacion";
            this.colpresentacion1.Name = "colpresentacion1";
            this.colpresentacion1.OptionsColumn.AllowEdit = false;
            this.colpresentacion1.Visible = true;
            this.colpresentacion1.VisibleIndex = 1;
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 2;
            // 
            // colcardcode1
            // 
            this.colcardcode1.FieldName = "cardcode";
            this.colcardcode1.Name = "colcardcode1";
            this.colcardcode1.OptionsColumn.AllowEdit = false;
            this.colcardcode1.Visible = true;
            this.colcardcode1.VisibleIndex = 3;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.bindingSourceTipoArchivos;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "descripcion";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.PopupView = this.gridView7;
            this.repositoryItemGridLookUpEdit2.ValueMember = "id";
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "id";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Tipo de Archivo";
            this.gridColumn12.FieldName = "descripcion";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            // 
            // repositoryItemButtonEdit6
            // 
            this.repositoryItemButtonEdit6.AutoHeight = false;
            editorButtonImageOptions15.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions15.Image")));
            this.repositoryItemButtonEdit6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions15, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject57, serializableAppearanceObject58, serializableAppearanceObject59, serializableAppearanceObject60, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit6.Name = "repositoryItemButtonEdit6";
            this.repositoryItemButtonEdit6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEdit7
            // 
            this.repositoryItemButtonEdit7.AutoHeight = false;
            editorButtonImageOptions16.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions16.Image")));
            this.repositoryItemButtonEdit7.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject61, serializableAppearanceObject62, serializableAppearanceObject63, serializableAppearanceObject64, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit7.Name = "repositoryItemButtonEdit7";
            this.repositoryItemButtonEdit7.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEdit8
            // 
            this.repositoryItemButtonEdit8.AutoHeight = false;
            editorButtonImageOptions17.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions17.Image")));
            this.repositoryItemButtonEdit8.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions17, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject65, serializableAppearanceObject66, serializableAppearanceObject67, serializableAppearanceObject68, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit8.Name = "repositoryItemButtonEdit8";
            this.repositoryItemButtonEdit8.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEdit5
            // 
            this.repositoryItemButtonEdit5.AutoHeight = false;
            editorButtonImageOptions18.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions18.SvgImage")));
            this.repositoryItemButtonEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions18, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject69, serializableAppearanceObject70, serializableAppearanceObject71, serializableAppearanceObject72, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit5.Name = "repositoryItemButtonEdit5";
            this.repositoryItemButtonEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEdit4
            // 
            this.repositoryItemButtonEdit4.AutoHeight = false;
            editorButtonImageOptions19.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions19.SvgImage")));
            this.repositoryItemButtonEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions19, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject73, serializableAppearanceObject74, serializableAppearanceObject75, serializableAppearanceObject76, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit4.Name = "repositoryItemButtonEdit4";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(127, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(344, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(127, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(344, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nombre";
            // 
            // txtNombreF
            // 
            this.txtNombreF.Enabled = false;
            this.txtNombreF.Location = new System.Drawing.Point(127, 68);
            this.txtNombreF.Name = "txtNombreF";
            this.txtNombreF.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtNombreF.Properties.Appearance.Options.UseFont = true;
            this.txtNombreF.Size = new System.Drawing.Size(344, 26);
            this.txtNombreF.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 20);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nombre Foraneo";
            // 
            // txtRTN
            // 
            this.txtRTN.Enabled = false;
            this.txtRTN.Location = new System.Drawing.Point(127, 96);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtRTN.Properties.Appearance.Options.UseFont = true;
            this.txtRTN.Size = new System.Drawing.Size(344, 26);
            this.txtRTN.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(10, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 20);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "RTN";
            // 
            // cmdBuscarProveedores
            // 
            this.cmdBuscarProveedores.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdBuscarProveedores.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscarProveedores.Appearance.Options.UseBackColor = true;
            this.cmdBuscarProveedores.Appearance.Options.UseFont = true;
            this.cmdBuscarProveedores.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdBuscarProveedores.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdBuscarProveedores.ImageOptions.SvgImage")));
            this.cmdBuscarProveedores.Location = new System.Drawing.Point(477, 12);
            this.cmdBuscarProveedores.Name = "cmdBuscarProveedores";
            this.cmdBuscarProveedores.Size = new System.Drawing.Size(142, 51);
            this.cmdBuscarProveedores.TabIndex = 9;
            this.cmdBuscarProveedores.Text = "Buscar";
            this.cmdBuscarProveedores.Click += new System.EventHandler(this.cmdBuscarProveedores_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(913, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(127, 51);
            this.cmdHome.TabIndex = 10;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // txtContacto
            // 
            this.txtContacto.Enabled = false;
            this.txtContacto.Location = new System.Drawing.Point(127, 124);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtContacto.Properties.Appearance.Options.UseFont = true;
            this.txtContacto.Size = new System.Drawing.Size(344, 26);
            this.txtContacto.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(10, 126);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 20);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Contacto";
            // 
            // txtTel1
            // 
            this.txtTel1.Enabled = false;
            this.txtTel1.Location = new System.Drawing.Point(127, 152);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtTel1.Properties.Appearance.Options.UseFont = true;
            this.txtTel1.Size = new System.Drawing.Size(164, 26);
            this.txtTel1.TabIndex = 16;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(10, 154);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(71, 20);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Telefono 1";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(127, 180);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtDireccion.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion.Size = new System.Drawing.Size(699, 26);
            this.txtDireccion.TabIndex = 20;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(10, 186);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(63, 20);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Dirección";
            // 
            // txtTel2
            // 
            this.txtTel2.Enabled = false;
            this.txtTel2.Location = new System.Drawing.Point(392, 152);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtTel2.Properties.Appearance.Options.UseFont = true;
            this.txtTel2.Size = new System.Drawing.Size(164, 26);
            this.txtTel2.TabIndex = 22;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(315, 154);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 20);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Telefono 2";
            // 
            // txtTel3
            // 
            this.txtTel3.Enabled = false;
            this.txtTel3.Location = new System.Drawing.Point(662, 152);
            this.txtTel3.Name = "txtTel3";
            this.txtTel3.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtTel3.Properties.Appearance.Options.UseFont = true;
            this.txtTel3.Size = new System.Drawing.Size(164, 26);
            this.txtTel3.TabIndex = 24;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(585, 154);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(71, 20);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Telefono 3";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(127, 208);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtCorreo.Properties.Appearance.Options.UseFont = true;
            this.txtCorreo.Size = new System.Drawing.Size(344, 26);
            this.txtCorreo.TabIndex = 26;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(10, 210);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(45, 20);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "Correo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // xtraFolderBrowserDialog1
            // 
            this.xtraFolderBrowserDialog1.SelectedPath = "xtraFolderBrowserDialog1";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(489, 212);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(45, 20);
            this.labelControl11.TabIndex = 27;
            this.labelControl11.Text = "Riesgo";
            // 
            // gridLookUpEdit_Riesgos
            // 
            this.gridLookUpEdit_Riesgos.EditValue = "ddf";
            this.gridLookUpEdit_Riesgos.Enabled = false;
            this.gridLookUpEdit_Riesgos.Location = new System.Drawing.Point(540, 208);
            this.gridLookUpEdit_Riesgos.Name = "gridLookUpEdit_Riesgos";
            this.gridLookUpEdit_Riesgos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.gridLookUpEdit_Riesgos.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_Riesgos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_Riesgos.Properties.DataSource = this.bindingSourceRiesgos;
            this.gridLookUpEdit_Riesgos.Properties.DisplayMember = "descripcion";
            this.gridLookUpEdit_Riesgos.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit_Riesgos.Properties.ValueMember = "id";
            this.gridLookUpEdit_Riesgos.Size = new System.Drawing.Size(286, 26);
            this.gridLookUpEdit_Riesgos.TabIndex = 28;
            this.gridLookUpEdit_Riesgos.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_Riesgos_EditValueChanged);
            // 
            // bindingSourceRiesgos
            // 
            this.bindingSourceRiesgos.DataMember = "riesgos";
            this.bindingSourceRiesgos.DataSource = this.dsMantoTrazabilidad1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid3,
            this.coldescripcion2});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid3
            // 
            this.colid3.FieldName = "id";
            this.colid3.Name = "colid3";
            // 
            // coldescripcion2
            // 
            this.coldescripcion2.Caption = "Elija una Opción";
            this.coldescripcion2.FieldName = "descripcion";
            this.coldescripcion2.Name = "coldescripcion2";
            this.coldescripcion2.Visible = true;
            this.coldescripcion2.VisibleIndex = 0;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(10, 236);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(62, 20);
            this.labelControl12.TabIndex = 29;
            this.labelControl12.Text = "Auditoría";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Enabled = false;
            this.toggleSwitch1.Location = new System.Drawing.Point(127, 236);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.OffText = "No";
            this.toggleSwitch1.Properties.OnText = "Si";
            this.toggleSwitch1.Size = new System.Drawing.Size(106, 21);
            this.toggleSwitch1.TabIndex = 30;
            this.toggleSwitch1.EditValueChanged += new System.EventHandler(this.toggleSwitch1_EditValueChanged);
            // 
            // gridLookUpEdit_aprobacion
            // 
            this.gridLookUpEdit_aprobacion.EditValue = "ddf";
            this.gridLookUpEdit_aprobacion.Enabled = false;
            this.gridLookUpEdit_aprobacion.Location = new System.Drawing.Point(540, 236);
            this.gridLookUpEdit_aprobacion.Name = "gridLookUpEdit_aprobacion";
            this.gridLookUpEdit_aprobacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.gridLookUpEdit_aprobacion.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit_aprobacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_aprobacion.Properties.DataSource = this.bindingSourceAprobaciones;
            this.gridLookUpEdit_aprobacion.Properties.DisplayMember = "descripcion";
            this.gridLookUpEdit_aprobacion.Properties.PopupView = this.gridView3;
            this.gridLookUpEdit_aprobacion.Properties.ValueMember = "id";
            this.gridLookUpEdit_aprobacion.Size = new System.Drawing.Size(286, 26);
            this.gridLookUpEdit_aprobacion.TabIndex = 32;
            this.gridLookUpEdit_aprobacion.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_aprobacion_EditValueChanged);
            // 
            // bindingSourceAprobaciones
            // 
            this.bindingSourceAprobaciones.DataMember = "aprobacion";
            this.bindingSourceAprobaciones.DataSource = this.dsMantoTrazabilidad1;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid4,
            this.coldescripcion3});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colid4
            // 
            this.colid4.FieldName = "id";
            this.colid4.Name = "colid4";
            // 
            // coldescripcion3
            // 
            this.coldescripcion3.Caption = "Elija una Opción";
            this.coldescripcion3.FieldName = "descripcion";
            this.coldescripcion3.Name = "coldescripcion3";
            this.coldescripcion3.Visible = true;
            this.coldescripcion3.VisibleIndex = 0;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(456, 238);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(78, 20);
            this.labelControl13.TabIndex = 31;
            this.labelControl13.Text = "Aprobación";
            // 
            // cmdVerTodosAdjuntos
            // 
            this.cmdVerTodosAdjuntos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVerTodosAdjuntos.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdVerTodosAdjuntos.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmdVerTodosAdjuntos.Appearance.Options.UseBackColor = true;
            this.cmdVerTodosAdjuntos.Appearance.Options.UseFont = true;
            this.cmdVerTodosAdjuntos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdVerTodosAdjuntos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.cmdVerTodosAdjuntos.Location = new System.Drawing.Point(747, 3);
            this.cmdVerTodosAdjuntos.Name = "cmdVerTodosAdjuntos";
            this.cmdVerTodosAdjuntos.Size = new System.Drawing.Size(142, 34);
            this.cmdVerTodosAdjuntos.TabIndex = 14;
            this.cmdVerTodosAdjuntos.Text = "Ver Todos";
            this.cmdVerTodosAdjuntos.Click += new System.EventHandler(this.cmdVerTodosAdjuntos_Click);
            // 
            // frmMantoProveedoresMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 643);
            this.Controls.Add(this.gridLookUpEdit_aprobacion);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.gridLookUpEdit_Riesgos);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtTel3);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.cmdBuscarProveedores);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtNombreF);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmMantoProveedoresMP";
            this.Text = "Master Proveedores MP";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabPlantas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoArchivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            this.TabAdjuntos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoArchivoEmbebed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAbrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminarRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDownload)).EndInit();
            this.tabIngredientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdLinkIngrediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete__)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).EndInit();
            this.TabMateriales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.link_materia_prima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_Riesgos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRiesgos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_aprobacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAprobaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMantoTrazabilidad.plantasRow)gridView.GetFocusedDataRow();

            if (!row.IsidNull())
            {
                IdPlantaSeleccionada = row.id;
                LoadAdjuntosRows(row.id);
            }
        }

        private void cmdVerTodosAdjuntos_Click(object sender, EventArgs e)
        {
            LoadAdjuntosRows();
        }
    }
}