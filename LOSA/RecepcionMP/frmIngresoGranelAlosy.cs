using ACS.Classes;
using LOSA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RecepcionMP
{
    public partial class frmIngresoGranelAlosy : Form
    {
        UserLogin UsuarioLogeado;
        ArrayList pLista;
        DataOperations dp = new DataOperations();
        int idUbicacionSelected;
        string Rack;
        string Codigo_Barra_ubicacion;
        int IdLoteSelected;

        public frmIngresoGranelAlosy(UserLogin pUsuarioLogeado, ArrayList pArray, ItemMP_Lote pItem)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            pLista = pArray;
            dtFechaIngreso.EditValue = string.Format("{0:dd/MM/yyyy}", dp.Now());
            txtCodigoMP.Text = pItem.ItemCode;
            txtMP_Name.Text = pItem.Card_Name;
            txtLote.Text = pItem.Lote;
            IdLoteSelected = pItem.IdLote;
            LoadBarcos();
            LoadUbicaciones();

            if (pItem.RecuperarRegistro(pItem.IdLote))
            {
                dtFechaProduccion.EditValue = pItem.FechaProd;
                dtFechaVencimiento.EditValue = pItem.FechaVence;
            }

            foreach (dsRecepcionMPx.granelRow rowg in pArray)
            {
                dsRecepcionMPx.granelRow row1 = dsRecepcionMPx1.granel.NewgranelRow();
                //row1 = rowg;
                //row1.itemcode = item.ItemCode;
                //row1.card_name = item.Card_Name;
                //pendiente agregar el valor de lote
                row1.id = rowg.id;
                row1.comentarios = rowg.comentarios;
                row1.EmpresaTrans = rowg.EmpresaTrans;
                row1.fechaEntra= rowg.fechaEntra;
                row1.FechaFin= rowg.FechaFin;

                try
                {
                    row1.shipid = rowg.shipid;
                }
                catch { row1.shipid = 0; }

                try
                {
                    row1.barco = rowg.barco;
                }
                catch { row1.barco = ""; }
                
                row1.NBoleta= rowg.NBoleta;
                row1.numero_factura= rowg.numero_factura;
                row1.Operador= rowg.Operador;
                row1.PesoBruto= rowg.PesoBruto;
                row1.PesonetoIn= rowg.PesonetoIn;
                row1.PesoProd= rowg.PesoProd;
                row1.pesoSalida= rowg.pesoSalida;
                row1.peso_factura= rowg.peso_factura;
                row1.conductorin= rowg.conductorin;
                row1.vehiculo= rowg.vehiculo;
                row1.furgon = rowg.furgon;
                row1.TipoBoleta = rowg.TipoBoleta;
                row1.id_tipo_boleta = rowg.id_tipo_boleta;
                row1.SNegocio = rowg.SNegocio;
                row1.Producto = rowg.Producto;
                row1.itemcode = rowg.itemcode;
                row1.seleccionar = rowg.seleccionar;
                try
                {
                    row1.id_ubicacion = rowg.id_ubicacion;
                }
                catch {  }
               

                dsRecepcionMPx1.granel.AddgranelRow(row1);
                dsRecepcionMPx1.AcceptChanges();
            }

        }

        private void LoadUbicaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                string SQL = @"sp_get_lista_ubicaciones_granel";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@codigo_barra", "");
                dsRecepcionMPx1.ubicaciones_granel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.ubicaciones_granel);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void LoadBarcos()
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ships_active_for_losa", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsRecepcionMPx1.barcos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.barcos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            //Seleccionar Ubicacion
            frmUbicaciones_granel frm = new frmUbicaciones_granel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int idUbicacionNueva = frm.IdUbicacionSelected;
                beNuevaUbicacion.Text = frm.UbicacionCodigo + " - "+ frm.UbicacionNombre;
                idUbicacionSelected = idUbicacionNueva;
                Rack = frm.UbicacionNombre;
                Codigo_Barra_ubicacion = frm.UbicacionCodigo;
            }
        }

        private void cmdGenerarIngreso_Click(object sender, EventArgs e)
        {
            //Guardar Ingresos
            //if (idUbicacionSelected == 0)
            //{
            //    CajaDialogo.Error("Es necesario seleccionar una Ubicación Valida!");
            //    return;
            //}

            if(dtFechaVencimiento.EditValue == null)
            {
                CajaDialogo.Error("Es necesario seleccionar una fecha de Vencimiento!");
                return;
            }

            if (dtFechaProduccion.EditValue == null)
            {
                CajaDialogo.Error("Es necesario seleccionar una fecha de Producción!");
                return;
            }

            //if (txtNumIngreso.Value == 0)
            //{
            //    CajaDialogo.Error("Es necesario un Número de Ingreso Valido!");
            //    return;
            //}
            bool PuedeContinuar = false;
            foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            {
                
                try
                {
                    int a = row.id_ubicacion;
                    if (a > 0)
                        PuedeContinuar = true;
                    
                }
                catch 
                {
                    PuedeContinuar = false;
                    break;
                } 
            }

            if (!PuedeContinuar)
            {
                CajaDialogo.Error("Debe seleccionar una ubicacion valida!");
                return;
            }

            PuedeContinuar = false;
            foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            {

                try
                {
                    int a = row.shipid;
                    if (a > 0)
                        PuedeContinuar = true;

                }
                catch
                {
                    PuedeContinuar = false;
                    break;
                }
            }

            if (!PuedeContinuar)
            {
                CajaDialogo.Error("Debe seleccionar una barco valido!");
                return;
            }

            //Validar ingreso si es necesario
            bool Guardo = false;
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar estos ingresos de Materia Prima Granel?");
            if (r != DialogResult.Yes)
                return;
            foreach(dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            {
                //
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();

                    string SQL = @"sp_set_insert_tarimas_graneles";
                    SqlCommand cmd = new SqlCommand(SQL, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_boleta", row.NBoleta);
                    cmd.Parameters.AddWithValue("@entrada", row.PesoProd);
                    cmd.Parameters.AddWithValue("@item_code", txtCodigoMP.Text);
                    cmd.Parameters.AddWithValue("@lote", txtLote.Text);
                    cmd.Parameters.AddWithValue("@id_lote", IdLoteSelected);
                    cmd.Parameters.AddWithValue("@id", row.id);
                    cmd.Parameters.AddWithValue("@id_ubicacion", row.id_ubicacion);

                    cmd.ExecuteNonQuery();
                    Guardo = true;
                    cn.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }

            if (Guardo)
            {
                CajaDialogo.InformationAuto();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }
    }
}
