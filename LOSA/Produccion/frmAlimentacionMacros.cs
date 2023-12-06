using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.TransaccionesMP.EntregaMP;
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

namespace LOSA.Produccion
{
    public partial class frmAlimentacionMacros : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        int Id_registro_bascula1;
        int Id_registro_bascula2;
        decimal pesoBascula1;
        decimal pesoBascula2;

        enum Bascula 
        { 
            Bascula1 = 1,
            Bascula2 = 2
        }

        Bascula BasculaIni;

        public frmAlimentacionMacros(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            cmdSelectTarima.Anchor = AnchorStyles.Top;
            
            timerBascula.Start();

            ValidarCargaEnProceso();
        }

        private void ValidarCargaEnProceso()
        {
            try
            {
                AlimentacionBasculas aliMacro = new AlimentacionBasculas();
                 
                aliMacro.RecuperarPesajeEnProcesoBascula(Convert.ToInt32(Bascula.Bascula1));
                        
                if(aliMacro.Recuperado)
                    CargarDetalleBascula1(aliMacro.Id);

                                         
                aliMacro.RecuperarPesajeEnProcesoBascula(Convert.ToInt32(Bascula.Bascula2));

                if (aliMacro.Recuperado)
                    CargarDetalleBascula2(aliMacro.Id);

                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdSelectTarima_Click(object sender, EventArgs e)
        {
            if (pesoBascula1 == 0 && pesoBascula2 == 0)
            {
                CajaDialogo.Error("No se Detecta Peso en las Basculas!");
            }
            else
            {
                frmShowTarimasEnBascula frm = new frmShowTarimasEnBascula(frmShowTarimasEnBascula.TipoVentana.Seleccion);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    switch (frm.BascuilaID)
                    {
                        case 1:
                            Id_registro_bascula1 = frm.Id_RegistroBascula;
                            CargarDetalleBascula1(Id_registro_bascula1);
                            btnBascula1ON.Enabled = true;
                            btnCancelBasc1.Enabled = true;

                            break;

                        case 2:
                            Id_registro_bascula2 = frm.Id_RegistroBascula;
                            CargarDetalleBascula2(Id_registro_bascula2);
                            btnBascula2ON.Enabled = true;
                            btnCancelBasc2.Enabled = true;

                            break;
                        default:
                            break;
                    }
                }

            }
        }


        private void CargarDetalleBascula1(int pid_registro_bascula)
        {
            DataOperations dp = new DataOperations();
            try
            {
                string query = @"[sp_get_tarimas_en_proceso_bascula_for_id]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_registro", pid_registro_bascula);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProduccion1.Bascula1.Clear();
                adat.Fill(dsProduccion1.Bascula1);
                conn.Close();

                btnBascula1Off.Enabled = true;
                btnCancelBasc1.Enabled = true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarDetalleBascula2(int pid_registro_bascula)
        {
            DataOperations dp = new DataOperations();
            try
            {
                string query = @"[sp_get_tarimas_en_proceso_bascula_for_id]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_registro", pid_registro_bascula);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProduccion1.Bascula2.Clear();
                adat.Fill(dsProduccion1.Bascula2);
                conn.Close();

                btnBascula2Off.Enabled = true;
                btnCancelBasc2.Enabled = true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void timerBascula_Tick(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

            pesoBascula1 = 0;
            pesoBascula2 = 0;

            using (SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS))
            //using (SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_basculas_value_alimentacion]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pesoBascula1 = dr.GetDecimal(0);
                    pesoBascula2 = dr.GetDecimal(1);
                }
                dr.Close();
                conn.Close();
            }

            lblValorBascula1.Text = "Valor en Báscula: " + pesoBascula1.ToString("N2") + " Kg";
            lblValorBascula2.Text = "Valor en Báscula: " + pesoBascula2.ToString("N2") + " Kg";
        }

        private void btnBascula1ON_Click(object sender, EventArgs e)
        {
            if (pesoBascula1 <= 0)
            {
                CajaDialogo.Error("No hay Peso en la Bascula 1");
                return; 
            }
            btnCancelBasc1.Enabled = false;


            GuardarPesoBruto(Bascula.Bascula1);

            
        }

        private void GuardarPesoBruto(Bascula BasculaSelected)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_alimentacion_macros_inicio_pesaje", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                switch (BasculaSelected)
                {
                    case Bascula.Bascula1:
                        cmd.Parameters.AddWithValue("@pid_registro", Id_registro_bascula1);
                        cmd.Parameters.AddWithValue("@peso_bruto", pesoBascula1);
                        break;
                    case Bascula.Bascula2:
                        cmd.Parameters.AddWithValue("@pid_registro", Id_registro_bascula2);
                        cmd.Parameters.AddWithValue("@peso_bruto", pesoBascula2);
                        break;
                    default:
                        break;
                }
                cmd.ExecuteNonQuery();
                conn.Close();

                switch (BasculaSelected)
                {
                    case Bascula.Bascula1:
                        CargarDetalleBascula1(Id_registro_bascula1);


                        break;
                    case Bascula.Bascula2:
                        CargarDetalleBascula2(Id_registro_bascula2);


                        break;
                    default:
                        break;
                }
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }
        }

        private void btnBascula2ON_Click(object sender, EventArgs e)
        {
            if (pesoBascula2 <= 0)
            {
                CajaDialogo.Error("No hay Peso en la Bascula 2");
                return;
            }
            btnCancelBasc2.Enabled = false;
            GuardarPesoBruto(Bascula.Bascula2);
        }

        private void btnBascula1Off_Click(object sender, EventArgs e)
        {
            if (dsProduccion1.Bascula1.Count == 0)
            {
                CajaDialogo.Error("No se a Cargado el Pesaje!");
                return;
            }

            foreach (dsProduccion.Bascula1Row item in dsProduccion1.Bascula1.Rows)
            {
                if (item.id_registro > 0)
                {
                    Id_registro_bascula1 = item.id_registro;
                }
                
            }

            AlimentacionBasculas AliBasculas = new AlimentacionBasculas();
            AliBasculas.RecuperarRegistros(Id_registro_bascula1);

            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_requisa_entrega_a_prd_pesajeBascula", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", AliBasculas.Id_Tarima);
                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                cmd.Parameters.AddWithValue("@id_req", AliBasculas.Num_Requisa);
                cmd.Parameters.AddWithValue("@cantidad", AliBasculas.Unidades);
                cmd.Parameters.AddWithValue("@peso", AliBasculas.Peso);
                cmd.Parameters.AddWithValue("@peso_bascula", pesoBascula1);
                cmd.Parameters.AddWithValue("@id_registro", Id_registro_bascula1);
                //cmd.Parameters.AddWithValue("", AliBasculas.);
                cmd.ExecuteNonQuery();
                conn.Close();

                CajaDialogo.Information("Pesaje Completado!");

                LimpiarDatosBascula1();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void LimpiarDatosBascula1()
        {
            dsProduccion1.Bascula1.Clear();
            Id_registro_bascula1 = 0;
            btnBascula1Off.Enabled = false;
            btnCancelBasc1.Enabled = false;
        }
        private void LimpiarDatosBascula2()
        {
            dsProduccion1.Bascula2.Clear();
            Id_registro_bascula2 = 0;
            btnBascula2Off.Enabled = false;
            btnCancelBasc2.Enabled = false;
        }

        private void btnBascula2Off_Click(object sender, EventArgs e)
        {
            if (dsProduccion1.Bascula2.Count == 0)
            {
                CajaDialogo.Error("No se a Cargado el Pesaje!");
                return;
            }

            foreach (dsProduccion.Bascula2Row item in dsProduccion1.Bascula2.Rows)
            {
                if (item.id_registro > 0)
                {
                    Id_registro_bascula2 = item.id_registro;
                }

            }

            AlimentacionBasculas AliBasculas = new AlimentacionBasculas();
            AliBasculas.RecuperarRegistros(Id_registro_bascula2);

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_requisa_entrega_a_prd_pesajeBascula", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", AliBasculas.Id_Tarima);
                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                cmd.Parameters.AddWithValue("@id_req", AliBasculas.Num_Requisa);
                cmd.Parameters.AddWithValue("@cantidad", AliBasculas.Unidades);
                cmd.Parameters.AddWithValue("@peso", AliBasculas.Peso);
                cmd.Parameters.AddWithValue("@peso_bascula", pesoBascula2);
                cmd.Parameters.AddWithValue("@id_registro", Id_registro_bascula2);
                //cmd.Parameters.AddWithValue("", AliBasculas.);
                cmd.ExecuteNonQuery();
                conn.Close();

                CajaDialogo.Information("Pesaje Completado!");

                LimpiarDatosBascula2();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCancelBasc1_Click(object sender, EventArgs e)
        {
            foreach (dsProduccion.Bascula1Row item in dsProduccion1.Bascula1.Rows)
            {
                if (item.id_registro > 0)
                    Id_registro_bascula1 = item.id_registro;

            }

            if (Id_registro_bascula1 == 0)
            {
                CajaDialogo.Error("No existe un Pesaje Cargado a esta Bascula!");
                return;
            }


            DialogResult r = CajaDialogo.Pregunta("Desea Cancelar el Pesaje?\nEl Montacarguista debera colocar de nuevo el Peso en la Bascula y Escanear nuevamente");
            if (r == DialogResult.Yes)
            {
                
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_alimentacion_macro_cancelar_pesaje", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_registro_pesjaje", Id_registro_bascula1);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    CajaDialogo.Information("Pesaje Cancelado!");

                    LimpiarDatosBascula1();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }

        }


        private void btnCancelBasc2_Click(object sender, EventArgs e)
        {
            foreach (dsProduccion.Bascula2Row item in dsProduccion1.Bascula2.Rows)
            {
                if (item.id_registro > 0)
                    Id_registro_bascula2 = item.id_registro;
                
            }

            if (Id_registro_bascula2 == 0)
            {
                CajaDialogo.Error("No existe un Pesaje Cargado a esta Bascula!");
                return;
            }


            DialogResult r = CajaDialogo.Pregunta("Desea Cancelar el Pesaje?\nEl Montacarguista debera colocar de nuevo el Peso en la Bascula y Escanear nuevamente");
            if (r == DialogResult.Yes)
            {

                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_alimentacion_macro_cancelar_pesaje", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_registro_pesjaje", Id_registro_bascula2);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    CajaDialogo.Information("Pesaje Cancelado!");

                    LimpiarDatosBascula2();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ValidarCargaEnProceso();
        }

        private void btnBinActivo_Click(object sender, EventArgs e)
        {
            xfrmCheckActiveBin frm = new xfrmCheckActiveBin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}