﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.RecepcionMP
{
    public partial class rptReporteTarimaPT : DevExpress.XtraReports.UI.XtraReport
    {
        public rptReporteTarimaPT(int idTarima)
        {
            InitializeComponent();
            Tarima tar1 = new Tarima();
            if (tar1.RecuperarRegistro(idTarima, ""))
            {
                DataOperations dp = new DataOperations();
                ProductoTerminado pt = new ProductoTerminado(dp.ConnectionStringCostos);
                if (pt.Recuperar_producto(tar1.IdProductoterminado))
                {
                    lblNombreProducto.Text = pt.descripcion;
                    BagsPT bag = new BagsPT();
                    if (bag.RecuperarRegistro(pt.id_bag))
                    {
                        lblPresentacion.Text = bag.Descripcion;
                    }
                }

                lblCantidad.Text = string.Format("{0:0.00}", tar1.Cantidad);
                //lblPresentacion.Text = tar1.Proveedor;
                lblLote.Text = tar1.LotePT.ToString();
                lblCantidad.Text = tar1.Cantidad.ToString();
                //lblNombreProducto.Text = tar1.MateriaPrima;
                lblFechaIngreso.Text = string.Format("{0:MM/dd/yyyy}", tar1.FechaIngreso);
                lblNumeroIngreso.Text = tar1.NumeroTransaccion.ToString();
                lblFechaProduccion.Text = string.Format("{0:MM/dd/yyyy}", tar1.FechaProduccion);
                lblFechadeVencimiento.Text = string.Format("{0:MM/dd/yyyy}", tar1.FechaVencimiento);
                BarCode1.Text = BarCode2.Text = tar1.CodigoBarra;
            }

        }

    }
}