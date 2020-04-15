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
using LOSA.Clases;
using System.Data.SqlClient;

namespace LOSA.Despachos
{
    public partial class fromdespacho : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        int idDetalle;
        string ItemCode;
        string ItemName;
        string CardCode;
        string CardName;
        int Cant_asignada;
        int cant_aenviar;
        int idSerial; // Numero de Serie de boleta
        int idboleta;
        decimal factor;
        public fromdespacho(UserLogin UsuarioLogeado, int detalle)
        {
            InitializeComponent();
            this.UsuarioLogeado = UsuarioLogeado;
            idDetalle = detalle;
            load_data();
            load_encabezado();
            load_boleta_in_place();
        }
        public void load_data()
        {
            string query = @"EXEC [dbo].[sp_load_req_entrada]
		                    @iddetalle = @iddetalle";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.Parameters.Add("@iddetalle", SqlDbType.Int).Value = idDetalle;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.lote_entregado.Clear();
                da.Fill(ds_despachos.lote_entregado);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_boleta_in_place()
        {
            string query = @"EXEC [dbo].[sp_get_boletas_en_predio]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.boleta.Clear();
                da.Fill(ds_despachos.boleta);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_encabezado()
        {
            string query = @"EXEC [dbo].[sp_load_info_encabezado]
		                    @iddetalle = @iddetalle";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@iddetalle", SqlDbType.Int).Value = idDetalle;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ItemCode = dr.GetString(0);
                    ItemName = dr.GetString(1);
                    Cant_asignada = dr.GetInt32(2);
                    cant_aenviar = dr.GetInt32(3);
                    factor = dr.GetDecimal(4);
                }
                dr.Close();
                cn.Close();
                txtItemCode.Text = ItemCode;
                txtItemName.Text = ItemName;
                txtcantidad.Text = String.Format("{0:###,##0.00}", Cant_asignada);
                txtcantidadEnviar.Text = String.Format("{0:###,##0.00}", cant_aenviar);
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

        private void fromdespacho_Load(object sender, EventArgs e)
        {

        }

        private void grd_boleta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                idSerial = Convert.ToInt32(grd_boleta.EditValue);
                foreach (ds_despachos.boletaRow row in ds_despachos.boleta.Rows)
                {

                    if (row.id == idSerial)
                    {
                        CardCode = row.carcode;
                        CardName = row.cardname;
                        idboleta = row.NumID;
                        break;
                    }

                }
                txtCardCode.Text = CardCode;
                txtCardName.Text = CardName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btnguardado_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"EXEC [dbo].sp_insert_into_despacho
                                @iddetalle = @Viddetalle
                                ,@iduser = @VUsuario
	                            ,@CardCode = @Vitemcode
	                            ,@CardName = @Vcardname
	                            ,@idserie = @VidserieBol
	                            ,@idboleta = @VidBoleta
	                            ,@cantidad = @VCantidad
	                            ,@factor = @VFactor";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@Viddetalle", SqlDbType.Int).Value = idDetalle;
                cmd.Parameters.Add("@VUsuario", SqlDbType.Int).Value = UsuarioLogeado.Id;
                cmd.Parameters.Add("@Vitemcode", SqlDbType.VarChar).Value = ItemCode;
                cmd.Parameters.Add("@Vcardname", SqlDbType.VarChar).Value = ItemName;
                cmd.Parameters.Add("@VidserieBol", SqlDbType.Int).Value = idSerial;
                cmd.Parameters.Add("@VidBoleta", SqlDbType.Int).Value = idboleta;
                cmd.Parameters.Add("@VCantidad", SqlDbType.Int).Value = cant_aenviar;
                cmd.Parameters.Add("@VFactor", SqlDbType.Decimal).Value = factor;
               int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result == 1)
                {//Sacar impresion
                    CajaDialogo.Information("Hola");
                }
                else
                {
                    CajaDialogo.Error("Error en el proceso, contactar al departamente de IT");
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}