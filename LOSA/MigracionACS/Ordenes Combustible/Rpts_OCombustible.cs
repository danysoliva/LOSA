using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace LOSA.MigracionACS.Ordenes_Combustible
{
    public partial class Rpts_OCombustible : DevExpress.XtraReports.UI.XtraReport
    {
        public Rpts_OCombustible(int id_fuel, decimal liters, DateTime fecha)
        {
            InitializeComponent();

            int TipoFuel = id_fuel;
            decimal litros = liters;

            lblFecha.Text = fecha.ToString("D");

            switch (TipoFuel)
            {
                case 1:
                    TipoFuel = 1;
                    lblSuper.Text = Convert.ToString(litros);
                    lblRegular.Text = "";
                    lblDiesel.Text = "";
                    if (litros == 0)
                    {
                        lblSuper.Text = "Tanque Lleno";
                    }
                    break;

                case 2:
                    TipoFuel = 2;
                    lblSuper.Text = "";
                    lblRegular.Text = Convert.ToString(litros);
                    lblDiesel.Text = "";
                    if (litros == 0)
                    {
                        lblRegular.Text = "Tanque Lleno";
                    }
                    break;
                case 3:
                    TipoFuel = 3;
                    lblSuper.Text = " ";
                    lblRegular.Text = " ";
                    lblDiesel.Text = Convert.ToString(litros);
                    if (litros == 0)
                    {
                        lblDiesel.Text = "Tanque Lleno";
                    }
                    break;
            }
        }

    }
}
