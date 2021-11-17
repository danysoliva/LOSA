using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Liquidos.Models;
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

namespace LOSA.Liquidos
{
    public partial class xfrm_select_camiones : DevExpress.XtraEditors.XtraForm
    {
        CamionIN camion = new CamionIN();
       public List<CamionIN> camiones = new List<CamionIN>();

        string itemCode;

        public xfrm_select_camiones(string pItemCode)
        {
            InitializeComponent();
            itemCode = pItemCode;
            loadCamionesDisponiblesIngreso();
        }


        private void loadCamionesDisponiblesIngreso()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_camiones_IN_liquidos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@itemCode",SqlDbType.VarChar).Value=itemCode;
                dsLiquidos_.Camiones_IN.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLiquidos_.Camiones_IN);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void grdv_data_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //var row = (dsLiquidos_.Camiones_INRow)grdv_data.GetFocusedDataRow();

                camiones = new List<CamionIN>();
                //camion.ID = row.id; 
                //camion.Comentarios  = row.comentarios;
                //camion.EmpresaTransporte  = row.empresaTrans;
                //camion.FechaEntra  = row.fechaEntra;
                //camion.FechaFin = row.FechaFin; 
                //camion.ShipID = row.shipid; 
                //camion.Barco  = row.barco;
                //camion.NumeroFactura  = row.numero_factura;
                //camion.Operador  = row.operador;
                //camion.PesoBruto = row.PesoBruto; 
                //camion.PesoNetoIN  = row.PesonetoIn;
                //camion.PesoProd  = row.PesoProd;
                //camion.PesoSalida = row.pesoSalida; 
                //camion.ConductorIN  = row.conductorin;
                //camion.Vehiculo = row.vehiculo;
                //camion.Furgon  = row.furgon;
                //camion.TipoBoleta  = row.TipoBoleta;
                //camion.TipoBoletaID  = row.id_tipo_boleta;
                //camion.SNegocio  = row.SNegocio;
                //camion.Producto  = row.Producto;
                //camion.ItemCode  = row.itemcode;


                foreach (var item in dsLiquidos_.Camiones_IN)
                {

                    camion = new CamionIN();

                    camion.ID = item.id;
                    camion.Nboleta = item.NBoleta;
                    camion.Comentarios = item.comentarios;
                    camion.EmpresaTransporte = item.empresaTrans;
                    camion.FechaEntra = item.fechaEntra;
                    camion.FechaFin = item.FechaFin;
                    camion.ShipID = item.shipid;
                    camion.Barco = item.barco;
                    camion.NumeroFactura = item.numero_factura;
                    camion.Operador = item.operador;
                    camion.PesoBruto = item.PesoBruto;
                    camion.PesoNetoIN = item.PesonetoIn;
                    camion.PesoProd = item.PesoProd;
                    camion.PesoSalida = item.pesoSalida;
                    camion.ConductorIN = item.conductorin;
                    camion.Vehiculo = item.vehiculo;
                    camion.Furgon = item.furgon;
                    camion.TipoBoleta = item.TipoBoleta;
                    camion.TipoBoletaID = item.id_tipo_boleta;
                    camion.SNegocio = item.SNegocio;
                    camion.Producto = item.Producto;
                    camion.ItemCode = item.itemcode;
                    camion.PesoFactura = item.peso_factura;
                    camion.CardCode = item.cardcode;
                    camion.CardName = item.cardname;

                    if (item.seleccionar == true)
                    {
                        camiones.Add(camion);
                    }

            }


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            //CajaDialogo.Information(camiones.Count().ToString());

            this.DialogResult = DialogResult.OK;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}