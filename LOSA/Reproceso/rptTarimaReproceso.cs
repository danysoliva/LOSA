﻿using DevExpress.XtraReports.UI;
using LOSA.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace LOSA.Reproceso
{
    public partial class rptTarimaReproceso : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTarimaReproceso(int idTarima)
        {
            InitializeComponent();

            int id_tarima_PT;
            Tarima tar1 = new Tarima();
            if (tar1.RecuperarRegistro(idTarima, ""))
            {
                //IdUnidadMedida = dr.GetInt32(1);
                lblCantidad.Text = string.Format("{0:0.00}", tar1.Cantidad);
                //NombreTarima = dr.GetString(2);
                //TipoTarimaDescripcion = dr.GetString(3);
                lblTipoReproceso.Text = tar1.MateriaPrima;
                lblLote.Text = Convert.ToString(tar1.LoteMP);
                lblCantidad.Text = tar1.Cantidad.ToString();
                //lblNombreProducto.Text = tar1.ProductoTerminadoName;
                lblFechaIngreso.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaIngreso);
                lblNumeroIngreso.Text = tar1.NumeroTransaccion.ToString();
                lblFechaProduccion.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaProduccion);
                lblFechadeVencimiento.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaVencimiento);
                txtcodigo.Text = tar1.ItemCode;
                BarCode1.Text = BarCode2.Text = tar1.CodigoBarra;
                id_tarima_PT = tar1.Id_tarima_reproceso;

                Tarima tar2 = new Tarima();
                tar2.RecuperarRegistro(id_tarima_PT);
                if (tar2.ProductoTerminadoName == null)
                {
                    lblNombreProducto.Text = tar1.MateriaPrima;
                }
                else
                {
                    lblNombreProducto.Text = tar2.ProductoTerminadoName;
                }
                
            }


        }

    }
}
