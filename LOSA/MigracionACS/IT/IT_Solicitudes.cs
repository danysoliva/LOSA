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
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.IT.Model;
using LOSA.Clases;
using LOSA.MigracionACS.Classes;

namespace LOSA.MigracionACS.IT
{
    public partial class IT_Solicitudes : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        IT_Solicitud_Info iT_Solicitud_Info = new IT_Solicitud_Info();
        Email_IT_RequestParams emailParams = new Email_IT_RequestParams();
        SecOps ops = new SecOps();
        
        UserLogin UsuarioLogeado;
        int id;
        public enum tipotrans
        {
            insert = 1,
            update =2
        }
        tipotrans vtipotrans;

        public IT_Solicitudes()
        { 
            InitializeComponent();
            vtipotrans = tipotrans.insert;

            lblEstado.Visible = false;
            grdEstado.Visible = false;

            LoadAccesosActivos();
            LoadDepartamentos();
            LoadUsuarios();
            
            dtSolicitud.Format = DateTimePickerFormat.Custom;
            dtSolicitud.CustomFormat = "MM/dd/yyyy";
            
            DataOperations dp = new DataOperations();
            dtSolicitud.Value = dp.Now();
            dtEliminar.Value = dp.Now();
        }

        public IT_Solicitudes(int pid)
        {
            InitializeComponent();
            SolicitudIT IT = new SolicitudIT();
            vtipotrans = tipotrans.update;
            IT.RecuperarRegistro(pid);
            //IT.RecuperarAccesos(pid);
            //IT.ActualizarRegistros(pid);
            id = pid;
            LoadAccesosConferidos(pid);
            LoadDepartamentos();
            LoadUsuarios();
            LoadEstado();

            grdSolicitud.Text = IT.id_solicitante.ToString();
            txtUsuario.Text = IT.nombre_usuario.ToString();
            grdDepartamento.Text = IT.id_depar.ToString();
            if (IT.acceso_t)
            {
                if (IT.fecha_eliminar.Year > 1)
                {
                    dtEliminar.Text = IT.fecha_eliminar.ToString();
                }
                radioPerma.Checked = false;
            }
            else
            {
                radioPerma.Checked = true;
            }
            dtSolicitud.Text = IT.fecha_soli.ToString();
            
            radioPerma.Checked = IT.acceso_p;
            radioTempo.Checked = IT.acceso_t;
            txtOacceso.Text = IT.otros_acceso_especial;
            txtRazon.Text = IT.razon;

            if (IT.ticket>0)
                txtTicket.Text = IT.ticket.ToString();

            txtAsignado.Text = IT.asignado_a;
            boxEspecial.Checked = IT.acceso_especial;
            grdEstado.Text = IT.id_estado.ToString();
        }

        private void LoadEstado()
        {

            try
            {
                string sql = @"SELECT [id]
                                 ,[descripcion]  
                              FROM [dbo].[IT_Estado]";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsSolicitudes.estado.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsSolicitudes.estado);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadAccesosConferidos(int pid)
        {
            try
            {
                string sql = @"SELECT aa.[id]
	                      ,aa.[nombre]
                          ,(select case when count(*) > 0 then 1 else 0 end
		                    from [dbo].[IT_Solicitud_acceso] 
		                    where [id_soli] = @pid  and [id_acceso] = aa.id)as checkcolumn
                    FROM [dbo].[IT_Acceso] as aa
                    where [enable] = 1";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@pid", SqlDbType.Int).Value = pid;
                dsSolicitudes.acceso.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsSolicitudes.acceso);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadUsuarios()
        {
            try
            {
                string sql = @"SELECT [id]
                                      ,[nombre]
                                  FROM [dbo].[conf_usuarios]
                                  where activo = 1
                                    order by 2 asc";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsSolicitudes.usuarios.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsSolicitudes.usuarios);   
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDepartamentos()
        {
            try
            {
                string sql = @"SELECT [id]
                                      ,[grupo]  
                                  FROM [dbo].[conf_group]";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsSolicitudes.departamentos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsSolicitudes.departamentos);
            }
            catch (Exception ec)
            { 
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadAccesosActivos()
        {
            try
            {
                string sql = @"SELECT [id]
                                      ,[nombre]
      
                                  FROM [dbo].[IT_Acceso]
                                  where [enable] = 1";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsSolicitudes.acceso.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsSolicitudes.acceso);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            //if (UsuarioLogeado.ValidarNivelPermisos(19))
            //{
                frmConfAccesos frmConf = new frmConfAccesos();
                if (frmConf.ShowDialog() == DialogResult.OK)
                {
                    LoadAccesosActivos();
                }
            //}
            //else
            //{
            //    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #19");
            //}
        }

        private void IT_Solicitudes_Load(object sender, EventArgs e)
        {
           
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            //Inicializar un contador para contar, en este caso los checks seleccionados
            int contador = 0;
            //Condiciones para saber si los check estan activos o no
            int BOXT;
            int BOXP;
            int BOXE;

            if (radioTempo.Checked)
            {
                BOXT = 1;
            }
            else
            {
                BOXT = 0;
            }

            if (radioPerma.Checked)
            {
                BOXP = 1;
            }
            else
            {
                BOXP = 0;
            }

            if (boxEspecial.Checked)
            {
                BOXE = 1;
            }
            else
            {
                BOXE = 0;
            }
 
            if (string.IsNullOrEmpty(grdSolicitud.Text))
            {
                CajaDialogo.Error("No puede quedar este campo vacio!");
                grdSolicitud.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                CajaDialogo.Error("No puede quedar este campo vacio!");
                txtUsuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(grdDepartamento.Text))
            {
                CajaDialogo.Error("No puede quedar este campo vacio!");
                grdDepartamento.Focus();
                return;
            }

            //Recorrer el grid, especificamente la columna checkcolumn
            //Vamos a contar para ver si al menos hay uno seleccionado
            foreach (DataRow roww in dsSolicitudes.acceso.Rows)
            {
                if (roww["checkcolumn"].ToString() == "True")
                {
                    contador = contador + 1;
                    break;
                }
            }

            if (contador > 0)
            {
                switch (vtipotrans)
                {
                    case tipotrans.insert:
                        //Insertar una nueva solicitud
                        
                        try
                        {

                            string sql = @"INSERT INTO [dbo].[IT_Solicitudes]
                                                   ([id_solicitante]
                                                       ,[nombre_usuario]
                                                       ,[fecha_soli]
                                                       ,[fecha_eliminar]
                                                       ,[id_depar]
                                                       ,[otros_acceso_especial]
                                                       ,[razon]
                                                       ,[acceso_p]
                                                       ,[acceso_t]
                                                       ,[ticket]
                                                       ,[asignado_a]
                                                       ,[acceso_especial]
                                                       ,[id_estado])
         
                                             VALUES
                                                   (@id_solicitante, @nombre_usuario , @fecha_soli, @fecha_eliminar, @id_depar, @otros_acceso_especial
                                                   ,@razon, @accesop, @accesot, @ticket, @asignado_a, @acceso_especial, @id_estado ) SELECT SCOPE_IDENTITY()";
                            DataOperations dp = new DataOperations();
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.Add("@id_solicitante", SqlDbType.Int).Value = grdSolicitud.EditValue;
                            cmd.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = txtUsuario.Text;
                            cmd.Parameters.Add("@fecha_soli", SqlDbType.DateTime).Value = dtSolicitud.Value;
                            cmd.Parameters.Add("@id_depar", SqlDbType.Int).Value = grdDepartamento.EditValue;
                            cmd.Parameters.Add("@otros_acceso_especial", SqlDbType.VarChar).Value = txtOacceso.Text;

                            if (string.IsNullOrEmpty(txtRazon.Text))
                                cmd.Parameters.Add("@razon", SqlDbType.VarChar).Value = DBNull.Value;
                            else
                                cmd.Parameters.Add("@razon", SqlDbType.VarChar).Value = txtRazon.Text;

                            cmd.Parameters.Add("@accesop", SqlDbType.Bit).Value = BOXP;
                            cmd.Parameters.Add("@accesot", SqlDbType.Bit).Value = BOXT;
                            cmd.Parameters.Add("@id_estado", SqlDbType.Int).Value = 1;
                            

                            if (radioPerma.Checked)
                                cmd.Parameters.Add("@fecha_eliminar", SqlDbType.DateTime).Value = DBNull.Value;
                            else
                                cmd.Parameters.Add("@fecha_eliminar", SqlDbType.DateTime).Value = dtEliminar.Value;

                            if (string.IsNullOrEmpty(txtTicket.Text))
                                cmd.Parameters.Add("@ticket", SqlDbType.Int).Value = DBNull.Value;
                            else
                                cmd.Parameters.Add("@ticket", SqlDbType.Int).Value = txtTicket.Text;

                            cmd.Parameters.Add("@asignado_a", SqlDbType.VarChar).Value = txtAsignado.Text;
                            cmd.Parameters.Add("@acceso_especial", SqlDbType.Bit).Value = BOXE;
                            

                            //cmd.ExecuteNonQuery();
                            //conn.Close();


                            //INSERCION DE LOS ACCESOS
                            int lastID = Convert.ToInt32(cmd.ExecuteScalar());
                            conn.Close();
                            foreach (DataRow row in dsSolicitudes.acceso.Rows)
                            {
                                if (Convert.ToBoolean(row["checkcolumn"]) == true)
                                {
                                    string sql2 = @"INSERT INTO [dbo].[IT_Solicitud_acceso]
                                                           ([id_acceso]
                                                           ,[id_soli])
                                                     VALUES
                                                           (@idacceso, @idsoli)";

                                    SqlConnection conn2 = new SqlConnection(dp.ConnectionStringCostos);
                                    conn2.Open();
                                    SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                                    cmd2.Parameters.Add("@idacceso", SqlDbType.Int).Value = Convert.ToInt32(row["id"]);
                                    cmd2.Parameters.Add("@idsoli", SqlDbType.Int).Value = lastID;
                                    cmd2.ExecuteNonQuery();
                                    conn2.Close();
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }


                            if (iT_Solicitud_Info.RecuperaRegistro(lastID))
                            {

                                emailParams.TicketID = iT_Solicitud_Info.ID_Solicitud;
                                emailParams.NombreUsuarioSolicita = iT_Solicitud_Info.NombreSolicitante;
                                emailParams.MailUsuarioSolicita = iT_Solicitud_Info.MailSolicitante;
                                emailParams.NombreUsuarioAcceso = iT_Solicitud_Info.NombreUsuarioAccceso;
                                emailParams.Asignado_A = iT_Solicitud_Info.AsignadoA;

                                emailParams.Estado = iT_Solicitud_Info.Estado;
                                emailParams.Razon = iT_Solicitud_Info.Razon;
                                emailParams.Departamento = iT_Solicitud_Info.Departamento;
                                emailParams.IsHTML = true;
                                emailParams.Subject = "Se ha creado la solicitud [#" + emailParams.TicketID.ToString().PadLeft(7,'0') + "]";


                                if (iT_Solicitud_Info.Accesos != null)
                                {

                                    emailParams.Accesos = iT_Solicitud_Info.Accesos;
                                }

                               ops.SendEmailSolicitudITCreated(emailParams);

                            }



                            CajaDialogo.Information("Solcitud procesada con exito");
                            this.Close();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error("Ocurrio un eror en el proceso de ejecucion!", ec);
                        }

                        break;

                    case tipotrans.update:
                        
                        //Editar una solicitud ya existente
                        SolicitudIT IT = new SolicitudIT();
                        IT.RecuperarRegistro(id);
                        
                        IT.id_solicitante = Convert.ToInt32(grdSolicitud.EditValue);
                        IT.nombre_usuario = txtUsuario.Text;
                        IT.fecha_soli = Convert.ToDateTime(dtSolicitud.Text);
                        if (!string.IsNullOrEmpty(dtEliminar.Text))
                        {
                            IT.fecha_eliminar = Convert.ToDateTime(dtEliminar.Text);
                        }
                        
                        IT.id_depar = Convert.ToInt32(grdDepartamento.EditValue);
                        IT.otros_acceso_especial = txtOacceso.Text;
                        IT.razon = txtRazon.Text;
                        IT.acceso_p = radioPerma.Checked;
                        IT.acceso_t = radioTempo.Checked;
                        if (!string.IsNullOrEmpty(txtTicket.Text))
                        {
                            IT.ticket = Convert.ToInt32(txtTicket.Text);
                        }
                        
                        IT.asignado_a = txtAsignado.Text;
                        IT.acceso_especial = boxEspecial.Checked;
                        IT.id_estado = Convert.ToInt32(grdEstado.EditValue);
                        IT.ActualizarRegistros(id);
                        //Eliminacion y Insercion de accesos
                        string sql3 = @"DELETE FROM [dbo].[IT_Solicitud_acceso] 
                                           WHERE [id_soli] =" + id;
                        SqlConnection conn3 = new SqlConnection(dp.ConnectionStringCostos);
                        conn3.Open();
                        SqlCommand cmd3 = new SqlCommand(sql3, conn3);
                        cmd3.ExecuteNonQuery();
                        conn3.Close();

                        foreach (DataRow row in dsSolicitudes.acceso)
                        {
                            if (Convert.ToBoolean(row["checkcolumn"]) == true)
                            {
                                string sql2 = @"INSERT INTO [dbo].[IT_Solicitud_acceso]
                                                               ([id_acceso]
                                                               ,[id_soli])
                                                         VALUES
                                                               (@idacceso,@idsoli)";
                                SqlConnection conn2 = new SqlConnection(dp.ConnectionStringCostos);
                                conn2.Open();
                                SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                                cmd2.Parameters.Add("@idacceso", SqlDbType.Int).Value = Convert.ToInt32(row["id"]);
                                cmd2.Parameters.Add("@idsoli", SqlDbType.Int).Value = id;
                                cmd2.ExecuteNonQuery();
                                conn2.Close();
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                        CajaDialogo.Information("Actualizacion realizada!");
                        break;
                        
                    default:
                        CajaDialogo.Error("No se definio una operacion de transaccion (INSERT-UPDATE) para este formulario");
                        break;
                }
            }
            else
            {
                CajaDialogo.Error("Debe seleccionar almenos un acceso.");
            }
            
        }

        private void GenerarReporte()
        {
            try
            {
                #region Obteniendo_datos
                String query = @"";
                Console.Out.WriteLine();
                #endregion

                #region Imprimiendo
                

                #endregion
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);   
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        { 
                     
        }

        private void dtEliminar_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void dtEliminar_ValueChanged(object sender, EventArgs e)
        {
            
        }
        
        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsSolicitudes.accesoRow)gridview.GetFocusedDataRow();

            switch (e.Column.Name)
            {
                case "colDataColumn1":
                    if (Convert.ToBoolean(e.Value))
                    {
                        foreach (DataRow item in dsSolicitudes.acceso.Rows)
                        {
                            if (row.id.ToString() == item["id"].ToString())
                            {
                                item["checkcolumn"] = e.Value;
                            }
                        }
                    }
                    else
                    {
                        foreach (DataRow item in dsSolicitudes.acceso.Rows)
                        {
                            if (row.id.ToString() == item["id"].ToString())
                            {
                                item["checkcolumn"] = e.Value;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void checkall_CheckedChanged(object sender, EventArgs e)
        {
                foreach (DataRow item in dsSolicitudes.acceso.Rows)
                {
                    item["checkcolumn"] = checkall.Checked;
                }
        }

        private void radioPerma_Click(object sender, EventArgs e)
        {
               
        }

        private void radioTempo_Click(object sender, EventArgs e)
        {
            
        }

        private void radioPerma_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPerma.Checked)
            {
                dtEliminar.Visible = false;
                labeldt.Visible = false;
            }
        }

        private void radioTempo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTempo.Checked)
            {
                dtEliminar.Visible = true;
                labeldt.Visible = true;
            }
        }
    }
}