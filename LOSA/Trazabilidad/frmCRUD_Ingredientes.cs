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
    public partial class frmCRUD_Ingredientes : DevExpress.XtraEditors.XtraForm
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
        int idmp;
        int idpres;

        public frmCRUD_Ingredientes(string pcardCode, int pidMP, int pidpresentacion, TipoAccion ptipoAccion, int pIduser)
        {
            InitializeComponent();
            TipoAccionActual = ptipoAccion;
            idmp = pidMP;
            idpres = pidpresentacion;
            CardCode = pcardCode;
            IdUser = pIduser;
            string SAPCODE;
            vProveedor = new Proveedor();
            //vPlanta = new PlantaPrvTrz();
            LoadPresentaciones();
            LoadMateriales();

            switch (TipoAccionActual)
            {
                case TipoAccion.Insert:
                    if (vProveedor.RecuperarRegistroWithRTN(pcardCode))
                    {
                        txtProveedor.Text = vProveedor.Nombre;
                    }
                    break;
                case TipoAccion.Update:
                    if (vProveedor.RecuperarRegistroWithRTN(pcardCode))
                    {
                        txtProveedor.Text = vProveedor.Nombre;
                        //if (vPlanta.RecuperarRegistro(IdPlanta))
                        //{
                        //    txtNombre.Text = vPlanta.Nombre;
                        //    txtDireccion.Text = vPlanta.Direccion;
                        //    //txtComentario.Text = vPlanta.Comentario;
                        //}
                        MateriaPrima mp = new MateriaPrima();
                        if (mp.RecuperarRegistroFromID_RM(pidMP))
                        {
                            SAPCODE = mp.CodeMP_SAP;
                            //txtNombre.Text = mp.Name;
                            gridLookUpEditPresentacion.EditValue = idpres;
                            gridLookUpEdit_MP.EditValue = pidMP;
                        }
                    }
                    break;
            }
        }

        public void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_presentaciones_activas_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsMantoTrazabilidad1.presentaciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.presentaciones);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void LoadMateriales()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lista_materia_prima_dato_maestro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsMantoTrazabilidad1.material.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.material);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gridLookUpEdit_MP.Text))
            {
                CajaDialogo.Error("No se permite dejar el nombre vacio!");
                return;
            }

            if (string.IsNullOrEmpty(gridLookUpEditPresentacion.Text))
            {
                CajaDialogo.Error("No se permite dejar la Presentación vacía!");
                return;
            }

            switch (TipoAccionActual)
            {
                case TipoAccion.Insert:
                    if (vProveedor.RecuperarRegistroWithRTN(CardCode))
                    {
                        CrudMP_Prov(1, idmp, idpres, true, vProveedor.Codigo);
                    }
                    break;
                case TipoAccion.Update:
                    if (vProveedor.RecuperarRegistroWithRTN(CardCode))
                    {
                        CrudMP_Prov(2, idmp, idpres, true, vProveedor.Codigo);
                    }
                    break;
            }
        }

        public bool CrudMP_Prov(int pOption, int pIDMP, int pIdPresentacion, bool pEnable, string pCardCode)
        {
            bool a = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_mantenaince_mp_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@option", pOption);
                cmd.Parameters.AddWithValue("@idmp", pIDMP);
                cmd.Parameters.AddWithValue("@idpresentacion", pIdPresentacion);
                cmd.Parameters.AddWithValue("@enable", pEnable);
                cmd.Parameters.AddWithValue("@cardcode", pCardCode);
                cmd.ExecuteNonQuery();
                a = true;

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return a;
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