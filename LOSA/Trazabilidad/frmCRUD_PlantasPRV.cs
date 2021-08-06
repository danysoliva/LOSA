using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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

namespace LOSA.Trazabilidad
{
    public partial class frmCRUD_PlantasPRV : DevExpress.XtraEditors.XtraForm
    {
        string ProveedorN;
        string CardCode;
        int IdUser;
        int IdPlanta;

        public enum TipoAccion
        {
            Insert = 1,
            Update = 2
        }

        TipoAccion TipoAccionActual;
        Proveedor vProveedor;
        PlantaPrvTrz vPlanta;

        public frmCRUD_PlantasPRV(string pcardCode, int pIdPlanta, TipoAccion ptipoAccion, int pIduser)
        {
            InitializeComponent();
            TipoAccionActual = ptipoAccion;
            IdPlanta = pIdPlanta;
            CardCode = pcardCode;
            IdUser = pIduser;
            vProveedor = new Proveedor();
            vPlanta = new PlantaPrvTrz();

            switch (TipoAccionActual)
            {
                case TipoAccion.Insert:
                    if (vProveedor.RecuperarRegistroWithRTN(pcardCode))
                    {
                        txtProveedor.Text = vProveedor.Nombre;
                        txtNombre.Focus();
                    }
                    break;
                case TipoAccion.Update:
                    if (vProveedor.RecuperarRegistroWithRTN(pcardCode))
                    {
                        txtProveedor.Text = vProveedor.Nombre;
                        if (vPlanta.RecuperarRegistro(IdPlanta))
                        {
                            txtNombre.Text = vPlanta.Nombre;
                            txtDireccion.Text = vPlanta.Direccion;
                            txtComentario.Text = vPlanta.Comentario;
                        }
                    }
                    break;
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            switch (TipoAccionActual)
            {
                case TipoAccion.Insert:
                    if (vProveedor.RecuperarRegistroWithRTN(CardCode))
                    {
                        vPlanta.Nombre = txtNombre.Text;
                        vPlanta.Direccion = txtDireccion.Text;
                        vPlanta.Comentario = txtComentario.Text;
                        vPlanta.Id_user = IdUser;
                        if (vPlanta.GuardarRegistro(CardCode))
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    break;
                case TipoAccion.Update:
                    if (vProveedor.RecuperarRegistroWithRTN(CardCode))
                    {
                        vPlanta.Nombre = txtNombre.Text;
                        vPlanta.Direccion = txtDireccion.Text;
                        vPlanta.Comentario = txtComentario.Text;
                        vPlanta.Id_user = IdUser;
                        if (vPlanta.UpdateRegistro(IdPlanta))
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    break;
            }
        }

        private void txtComentario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void frmCRUD_PlantasPRV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}