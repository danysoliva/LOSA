using ACS.Classes;
using LOSA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public frmIngresoGranelAlosy(UserLogin pUsuarioLogeado, ArrayList pArray, ItemMP_Lote pItem)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            pLista = pArray;
            dtFechaIngreso.EditValue = string.Format("{0:dd/MM/yyyy}", dp.Now());
            txtCodigoMP.Text = pItem.ItemCode;
            txtMP_Name.Text = pItem.Card_Name;
            txtLote.Text = pItem.Lote;

            foreach(dsRecepcionMPx.granelRow rowg in pArray)
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

                dsRecepcionMPx1.granel.AddgranelRow(row1);
                dsRecepcionMPx1.AcceptChanges();
            }

        }
    }
}
