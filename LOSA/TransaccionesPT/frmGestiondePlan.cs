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
using LOSA.Clases;

namespace LOSA.TransaccionesPT
{
    public partial class frmGestiondePlan : DevExpress.XtraEditors.XtraForm
    {
        public int DocEntry;
        public string ItemCode;
        public string ItemName;
        public int Especie;
        public DateTime dtProduccion;
        public DateTime dtVencimiento;
        public decimal PesoPlan;
        public decimal PesoTarima;
        public decimal CantidadSacos;
        public decimal Factor;
        DataOperations dp = new DataOperations();
        public decimal CantidadTarimas;
        UserLogin UsuarioLogeado;

        public frmGestiondePlan(int docentry
                                ,string itemcode
                                ,string itemname
                                ,DateTime dtproduccion
                                ,decimal Peso_planificado
                                , UserLogin puser )
        {
            InitializeComponent();
            this.DocEntry = docentry;
            this.ItemCode = itemcode;
            this.ItemName = itemname;
            this.dtProduccion = dtproduccion;
            this.dtVencimiento = dtproduccion.AddDays(60);
            UsuarioLogeado = puser;
            PesoPlan = Peso_planificado;
            Inicializar_Data();
            Asignar_data();

        }

        public void Asignar_data()
        {
            grdproducto.EditValue = ItemCode;
            foreach (dsPT.productosRow row in dsPT.productos.Rows)
            {
                if (row.itemcode == ItemCode)
                {
                    Especie = row.Especie;
                }
            }
           
            if (Especie == 1)
            {
                grdcliente.EditValue = "CL00001";
                grdpresentacion.EditValue = 12;
                foreach (dsPT.presentacionRow row in dsPT.presentacion.Rows)
                {
                    if (row.id == 12)
                    {
                        Factor = row.factor;
                    }
                }
                txtSacos.Text = 50.ToString();
                CantidadSacos = PesoPlan / Factor;
                CantidadSacos = PesoPlan / Factor;
                CantidadTarimas = CantidadSacos / 50;
                txttarimas.Text = Convert.ToInt32(CantidadTarimas).ToString();
                txtpesoxtarima.Text = (50 * Factor).ToString();
            }
            else
            {
                foreach (dsPT.presentacionRow row in dsPT.presentacion.Rows)
                {
                    if (row.id == 19)
                    {
                        Factor = row.factor;
                    }
                }
                grdcliente.EditValue = "CL00009";     
                grdpresentacion.EditValue = 19;
                txtSacos.Text = 70.ToString();
                CantidadSacos = PesoPlan / Factor;
                CantidadTarimas = CantidadSacos / 70;
                txttarimas.Text = Convert.ToInt32(CantidadTarimas).ToString();
                txtpesoxtarima.Text = (70 * Factor).ToString();

            }
            dtfechaprod.EditValue = dtProduccion;
            devencimiento.EditValue = dtVencimiento;

        }
        public  void Inicializar_Data()
        {
            string Query = @"sp_load_productos_pt";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.productos.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.productos);
                cn.Close();

                cn.Open();
                Query = @"sp_get_clientes";
                cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.cliente.Clear();
                da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.cliente);
                cn.Close();

                cn.Open();
                Query = @"sp_get_presentacion_sacos";
                cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.presentacion.Clear();
                da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.presentacion);
                cn.Close();

                cn.Open();
                Query = @"sp_load_turnos";
                cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.turno.Clear();
                da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.turno);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdpresentacion_EditValueChanged(object sender, EventArgs e)
        {
            foreach (dsPT.presentacionRow row in dsPT.presentacion.Rows)
            {
                if (Convert.ToInt32(grdpresentacion.EditValue) == row.id)
                {
                    Factor = row.factor;
                } 
                
            }
            int CantidadSacosXtarima = Convert.ToInt32(txtSacos.Text);
            txtpesoxtarima.Text = (CantidadSacosXtarima * Factor).ToString();

        }

        private void txtSacos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (dsPT.presentacionRow row in dsPT.presentacion.Rows)
                {
                    if (Convert.ToInt32(grdpresentacion.EditValue) == row.id)
                    {
                        Factor = row.factor;
                    }

                }
                int CantidadSacosXtarima = Convert.ToInt32(Convert.ToDecimal(txtSacos.Text));
                txtpesoxtarima.Text = (CantidadSacosXtarima * Factor).ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Boolean exitoso = false;
            int id_Inserted = 0;
            if (grdproducto.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar un articulo.");
                return;
            }
            if (grd_turno.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar un turno.");
                return;
            }
            if (txtlot_number.Text == "")
            {
                CajaDialogo.Error("Debe seleccionar un lote para planificar las tarimas.");
                return;
            }
            if (grdpresentacion.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar una presentacion.");
                return;
            } 
            if (txtSacos.Text == "0")
            {
                CajaDialogo.Error("La cantidad de sacos no debe ser 0.");
                return;
            }
            if (txttarimas.Text == "0")
            {
                CajaDialogo.Error("La cantidad de tarimas no puede ser 0");
                return;
            }
            string query = @"sp_insert_into_plan_produccion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", grdproducto.EditValue);
                cmd.Parameters.AddWithValue("@itemname", grdproducto.Text);
                cmd.Parameters.AddWithValue("@enable", 1);
                cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtpesoxtarima.Text) * Convert.ToDecimal(txttarimas.Text));
                cmd.Parameters.AddWithValue("@usuario", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@abierto", 1);
                cmd.Parameters.AddWithValue("@DocEntry", DocEntry);
                SqlDataReader dr = cmd.ExecuteReader(); 
                if (dr.Read())
                {
                    id_Inserted = dr.GetInt32(0);
                }
                dr.Close();
                cn.Close();
                int CantidadTarimas = Convert.ToInt32(txttarimas.Text);

                for (int i = 0; i < CantidadTarimas; i++)     //Cantidad de tarimas.
                {
                    SqlConnection Con = new SqlConnection(dp.ConnectionStringLOSA);
                    Con.Open();
                    SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", Con);
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.Parameters.AddWithValue("@id", 1);
                    string barcode = cmm.ExecuteScalar().ToString();

                    query = @"sp_insert_tarima_produccion";
                  
                    cmd = new SqlCommand(query, Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaProduccion", dtfechaprod.EditValue);
                    cmd.Parameters.AddWithValue("@fechaVencimiento", devencimiento.EditValue);
                    cmd.Parameters.AddWithValue("@id_presentacion", grdpresentacion.EditValue);
                    cmd.Parameters.AddWithValue("@usuario", UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@itemcode", grdproducto.EditValue);
                    cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                    cmd.Parameters.AddWithValue("@cantidad", txtSacos.Text);
                    cmd.Parameters.AddWithValue("@peso", txtpesoxtarima.Text);
                    cmd.Parameters.AddWithValue("@Id_Alimentacion", id_Inserted);
                    cmd.Parameters.AddWithValue("@lote_pt", txtlot_number.Text);   
                    cmd.Parameters.AddWithValue("@id_turno", grd_turno.EditValue);
                    cmd.ExecuteNonQuery();
                }
                exitoso = true;
              



            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
                exitoso = false;

            }

            if (exitoso)
            {
                CajaDialogo.Information("Informacion Planificada.");
                this.Close();
            }
        }

        private void txtLote_Click(object sender, EventArgs e)
        {
            frmLotePT frm = new frmLotePT();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtlot_number.Text = frm.Lote.ToString();
            }
        }

        private void frmGestiondePlan_Load(object sender, EventArgs e)
        {

        }
    }
}