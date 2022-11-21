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
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PRB_Create : DevExpress.XtraEditors.XtraForm
    {
        int IDRegistro;
        int Editable = 1;
        string Usuarioc;
        string horas;
        DataOperations dp;
        int pickdays;
        public PRB_Create(string codigo)
        {
            InitializeComponent();
            horas = "12:00:00 pm";
            //dtIni.Text = DateTime.Now.ToString();
            //dtIni.EditValue = DateTime.Now;
            dp = new DataOperations();
            //dtFin.Text = DateTime.Now.AddDays(1).ToString();
            //dtFin.EditValue = DateTime.Now.AddDays(1);
            Usuarioc = codigo;
            pickdays = 0;
            LoadHorarios();
            LoadHorasDisponibles();

        }

        private void LoadHorasDisponibles()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_horas_disponibles_produccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                pRBdata.horas_disponibles.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(pRBdata.horas_disponibles);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadHorarios()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_horarios_turnos_reporte_produccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                pRBdata.horas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(pRBdata.horas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void dtFin_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime Regreso;
                Regreso = Convert.ToDateTime(dtIni.Text);
                Regreso = Regreso.AddDays(1);
                if (Convert.ToDateTime(dtIni.EditValue) > Convert.ToDateTime(dtFin.EditValue))
                {
                    MessageBox.Show("La fecha final no puede ser menor a la inicial.");
                    dtFin.Focus();
                    dtFin.EditValue = Regreso;
                    dtFin.Text = Regreso.ToString();

                }
                Editable = 2;
            }
            catch(Exception)
            {
            }
            if(dtFin.EditValue != DBNull.Value)
            {
                txtComentario.Enabled = true;
                txtComentario.Focus();
            }
        }
        public void load_edit()
        {
            string query;
            query = @"SELECT  
                              [id]
                              ,[descripcion]
                          FROM [dbo].[PRB_Turno]
                          where enable = 1";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata.Turno.Clear();
                da.Fill(pRBdata.Turno);


            }
            catch (Exception)
            {

               
            }
        }

        private void dtIni_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                    DateTime NextDay;
                    NextDay = Convert.ToDateTime(dtIni.Text);
                    NextDay = NextDay.AddDays(1);
                    //dtFin.EditValue = NextDay;
                    //dtFin.Text = Convert.ToString(NextDay);

               
            }catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }

            if(dtIni.EditValue != DBNull.Value)
            {
                dtFin.Enabled = true;
                dtFin.Focus();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {

            try
            {
                //if (rdjourna.SelectedIndex == 1)
                //{
                //    pickdays = 1;
                //    horas = "12:00:00";
                //}
                //else
                //{
                //    pickdays = 0;
                //    horas = "12:00:00";
                //}



                horas = "";
                //if (spinEditHorasDisponibles.Text.Length == 1)
                //    horas = "0" + spinEditHorasDisponibles.Text;

                //horas = spinEditHorasDisponibles.Text + ":00:00";


                if (gridLookUpEdit1.Text == "")
                {
                    MessageBox.Show("Seleccione turno correspondiente.");
                    gridLookUpEdit1.Focus();
                    return;

                }

                string Query;
                Query = @"";
                if (MessageBox.Show("Desea crear un nuevo registro.", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (txtComentario.Text == "")
                    {
                        txtComentario.Text = " ";
                    }
                    string date = string.Format("{0:yyyy/MM/dd}", dtFin.EditValue);
                    DateTime day = Convert.ToDateTime(date);

                    //Query = @"INSERT INTO [dbo].[PRB_Registro_H]
                    //                   ([fecha_ini]
                    //                   ,[horas_dis]
                    //                   ,[estatus]
                    //                   ,[fecha_fin]
                    //                   ,[enable]
                    //                   ,comentario
                    //                   ,idturno
                    //                   ,[user_code]
                    //                   ,[isdon]
                    //                   ,id_horario)
                    //             VALUES
                    //                   ('" + string.Format("{0:yyyy/MM/dd}",dtIni.EditValue) + @"'
                    //                   ,'"+gridHorasDisponible.Text.ToString() +@"'
                    //                   ,10
                    //                   ,'" + string.Format("{0:yyyy/MM/dd}", dtFin.EditValue) + @"'
                    //                   ,1
                    //                   ,'" + txtComentario.Text + @"'
                    //                   ,"+gridLookUpEdit1.EditValue.ToString()+@"
                    //                   , "+Usuarioc+ ", "+ pickdays + "," + gridLookUpHorarios.EditValue + ") SELECT SCOPE_IDENTITY()";

                    Query = "sp_insert_new_row_h_prb_registro_produccion";

                    SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    TimeSpan time = new TimeSpan(Convert.ToInt32(gridHorasDisponible.Text),0, 0);
                    cmd.Parameters.AddWithValue("@fecha_ini", dtIni.EditValue);
                    cmd.Parameters.AddWithValue("@horas_dis", time);
                    cmd.Parameters.AddWithValue("@fecha_fin", dtFin.EditValue);
                    cmd.Parameters.AddWithValue("@comentario", txtComentario.Text);
                    cmd.Parameters.AddWithValue("@idturno", gridLookUpEdit1.EditValue);
                    cmd.Parameters.AddWithValue("@user_code", Usuarioc);
                    cmd.Parameters.AddWithValue("@isdon", pickdays);
                    cmd.Parameters.AddWithValue("@id_horario", gridLookUpHorarios.EditValue);
                    cmd.CommandType = CommandType.StoredProcedure;
                    IDRegistro = Convert.ToInt32(cmd.ExecuteScalar());
                   
                    //string qry;
                    //qry = @" INSERT INTO[dbo].[PRB_Registro_D]
                    //                             ([id_h]
                    //                             ,[enable]
                    //                            ,[idMaqui]
                    //                            ,[horasMa], [horassave])

                    //                    VALUES
                    //                            (" + IDRegistro + @", 1,1,0,0);
                    //            INSERT INTO[dbo].[PRB_Registro_D]
                    //                             ([id_h]
                    //                             ,[enable]
                    //                            ,[idMaqui]  
                    //                            ,[horasMa], [horassave])

                    //                    VALUES
                    //                            (" + IDRegistro + @", 1,2,0,0);
                    //              INSERT INTO[dbo].[PRB_Registro_D]
                    //                            ([id_h]
                    //                            ,[enable]
                    //                            ,[idMaqui]
                    //                            ,[horasMa], [horassave])

                    //                   VALUES
                    //                           (" + IDRegistro + @", 1,3,0,0);";
                    //cmd = new SqlCommand(qry, cn);
                    //cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.Yes;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema en generar registro. Contacte al Administrador: "+ex.Message, "Error");
                
            }
           
           
        }
        public int IDReturn()
        {
            return IDRegistro;
        }

        private void PRB_Create_Load(object sender, EventArgs e)
        {
            load_edit();
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (gridLookUpEdit1.EditValue != DBNull.Value)
            {
                gridHorasDisponible.Enabled = true;
                gridHorasDisponible.Focus();
            }
        }

        private void rdjourna_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (rdjourna.SelectedIndex == 0)
            //{
            //    txtHorasdisp.Text = "12";
            //}
            //else
            //{
            //    txtHorasdisp.Text = "12";
            //}
        }

        private void spinEditHorasDisponibles_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridHorasDisponible_EditValueChanged(object sender, EventArgs e)
        {
            if (gridHorasDisponible.EditValue != DBNull.Value)
            {
                gridLookUpHorarios.Enabled = true;
                gridLookUpHorarios.Focus();
            }
        }

        private void gridLookUpHorarios_EditValueChanged(object sender, EventArgs e)
        {
            if(gridLookUpHorarios.EditValue != DBNull.Value)
            {
                
                int idSelectedHorario = (int)gridLookUpHorarios.EditValue;
                DateTime FechaI = dp.Now();
                switch (idSelectedHorario)
                {
                    case 4:
                        dtIni.EditValue = FechaI;
                        dtFin.EditValue = FechaI;
                        break;
                    case 5:
                        dtIni.EditValue = FechaI;
                        dtFin.EditValue = FechaI.AddDays(1);
                        break;
                    default:
                        break;
                }
                dtIni.Enabled = true;
                dtIni.Focus();
            }
        }

        private void gridLookUpHorarios_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }







    }

}