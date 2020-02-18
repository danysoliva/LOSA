using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.RecepcionMP
{
    public partial class frmUbicacionTarima2 : Form
    {
        DataOperations dp = new DataOperations();
        int IdBodega;
        public string BodegaNombre;
        string Pasillo_;
        string Rack_;
        int IdUbicacion;

        private int _idbicacion;
        private string _rack, _altura, _profundidad,_pasillo;
        public int idUbicacion { get { return _idbicacion; } set { _idbicacion = value; } }

        public string altura { get { return _altura; } set { _altura = value; } }

        public string profundidad { get { return _profundidad; } set { _profundidad = value; } }

        public string rack { get { return _rack; } set { _rack = value; } }

        public string pasillo { get { return _pasillo; } set { _pasillo = value; } }
        public frmUbicacionTarima2()
        {
            InitializeComponent();
            //cargarDatos();
            LoadBodegas();
        }


        void LoadBodegas()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                string SQL = @"exec sp_get_bodegas_enable";

                dsRecepcionMPx.bodegas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                //adat.SelectCommand.Parameters.AddWithValue("@codigo_barra", "");

          
                adat.Fill(dsRecepcionMPx.bodegas);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.bodegasRow)gridView.GetFocusedDataRow();

            IdBodega = row.id;
            BodegaNombre = row.descripcion;

            if (IdBodega > 0)
            {
                this.navigationFrame1.SelectNextPage();
                LoadPasillos(IdBodega);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.bodegasRow)gridView.GetFocusedDataRow();

            IdBodega = row.id;

            if (IdBodega > 0)
            {
                this.navigationFrame1.SelectNextPage();
                LoadPasillos(IdBodega);
            }
        }

        private void LoadPasillos(int idBodega)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_pasillos_enable_from_bodega", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsRecepcionMPx.pasillos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx.pasillos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnSeleccionar2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //seleccion de pasillo
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsRecepcionMPx.pasillosRow)gridView.GetFocusedDataRow();

            Pasillo_ = row.id;

            if (!string.IsNullOrEmpty(Pasillo_))
            {
                this.navigationFrame1.SelectNextPage();
                LoadRacks();
            }
        }

        private void LoadRacks()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_racks_enable_from_pasillo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpasillo", Pasillo_);
                cmd.Parameters.AddWithValue("@idbodega", IdBodega);
                dsRecepcionMPx.racks.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx.racks);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnSeleccionar3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //seleccion de rack
            var gridView = (GridView)gridControl3.FocusedView;
            var row = (dsRecepcionMPx.racksRow)gridView.GetFocusedDataRow();

            Rack_ = row.id;

            if (!string.IsNullOrEmpty(Rack_))
            {
                //this.navigationFrame1.SelectNextPage();
                idUbicacion = GetUbicacion();

                if (idUbicacion > 0)
                {
                    //Seleccion del lote
                    
                    this.idUbicacion = idUbicacion;
                    this.rack = Rack_;
                    this.pasillo = Pasillo_;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private int GetUbicacion()
        {
            int i = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ubicacion_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idbodega", IdBodega);
                cmd.Parameters.AddWithValue("@idpasillo", Pasillo_);
                cmd.Parameters.AddWithValue("@idrack", Rack_);
                i = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return i;
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            //Doble click
            //seleccion de rack
            var gridView = (GridView)gridControl3.FocusedView;
            var row = (dsRecepcionMPx.racksRow)gridView.GetFocusedDataRow();

            Rack_ = row.id;

            if (!string.IsNullOrEmpty(Rack_))
            {
                //this.navigationFrame1.SelectNextPage();
                idUbicacion = GetUbicacion();

                if (idUbicacion > 0)
                {
                    //Seleccion del lote

                    this.idUbicacion = idUbicacion;
                    this.rack = Rack_;
                    this.pasillo = Pasillo_;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
          
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void GvUbicacion_DoubleClick(object sender, EventArgs e)
        {
            //Seleccion del lote
            //bib
            //var gridView = (GridView)gcUbicacion.FocusedView;
            //var row = (dsRecepcionMPx.UbicacionesRow)gridView.GetFocusedDataRow();

            //this.idUbicacion = row.id;
            //this.altura = row.altura;
            //this.profundidad = row.profundidad;
            //this.rack = row.rack;
            //this.pasillo = row.pasillo;
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            //Seleccion del lote
            //bib
            //var gridView = (GridView)gcUbicacion.FocusedView;
            //var row = (dsRecepcionMPx.UbicacionesRow)gridView.GetFocusedDataRow();

            //this.idUbicacion = row.id;
            //this.altura = row.altura;
            //this.profundidad = row.profundidad;
            //this.rack = row.rack;
            //this.pasillo = row.pasillo;
            //this.DialogResult = DialogResult.OK;
            //this.Close();

        }
    }
}
