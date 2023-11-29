using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.TransaccionesMP.EntregaMP;
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

namespace LOSA.Produccion
{
    public partial class frmAlimentacionMacros : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        int Id_registro_bascula1;
        int Id_registro_bascula2;
        decimal pesoBascula1;
        decimal pesoBascula2;

        enum Bascula 
        { 
            Bascula1 = 1,
            Bascula2 = 2
        }

        Bascula BasculaIni;

        public frmAlimentacionMacros(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            timerBascula.Start();

            ValidarCargaEnProceso();
        }

        private void ValidarCargaEnProceso()
        {
            try
            {
                AlimentacionBasculas aliMacro = new AlimentacionBasculas();
                 
                aliMacro.RecuperarPesajeEnProcesoBascula(Convert.ToInt32(Bascula.Bascula1));
                        
                if(aliMacro.Recuperado)
                    CargarDetalleBascula1(aliMacro.Id);

                                         
                aliMacro.RecuperarPesajeEnProcesoBascula(Convert.ToInt32(Bascula.Bascula2));

                if (aliMacro.Recuperado)
                    CargarDetalleBascula2(aliMacro.Id);

                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdSelectTarima_Click(object sender, EventArgs e)
        {
            if (pesoBascula1 == 0 && pesoBascula2 == 0)
            {
                CajaDialogo.Error("No se Detecta Peso en las Basculas!");
            }
            else
            {
                frmShowTarimasEnBascula frm = new frmShowTarimasEnBascula(frmShowTarimasEnBascula.TipoVentana.Seleccion);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    switch (frm.BascuilaID)
                    {
                        case 1:
                            Id_registro_bascula1 = frm.Id_RegistroBascula;
                            CargarDetalleBascula1(Id_registro_bascula1);
                            btnBascula1ON.Enabled = true;

                            break;

                        case 2:
                            Id_registro_bascula2 = frm.Id_RegistroBascula;
                            CargarDetalleBascula2(Id_registro_bascula2);
                            btnBascula2ON.Enabled = true;

                            break;
                        default:
                            break;
                    }
                }

            }
        }


        private void CargarDetalleBascula1(int pid_registro_bascula)
        {
            DataOperations dp = new DataOperations();
            try
            {
                string query = @"[sp_get_tarimas_en_proceso_bascula_for_id]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_registro", pid_registro_bascula);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProduccion1.Bascula1.Clear();
                adat.Fill(dsProduccion1.Bascula1);
                conn.Close();

                btnBascula1Off.Enabled = true;
                btnCancelBasc1.Enabled = true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarDetalleBascula2(int pid_registro_bascula)
        {
            DataOperations dp = new DataOperations();
            try
            {
                string query = @"[sp_get_tarimas_en_proceso_bascula_for_id]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_registro", pid_registro_bascula);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProduccion1.Bascula2.Clear();
                adat.Fill(dsProduccion1.Bascula2);
                conn.Close();

                btnBascula2Off.Enabled = true;
                btnCancelBasc2.Enabled = true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void timerBascula_Tick(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

            pesoBascula1 = 0;
            pesoBascula2 = 0;

            //using (SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS))
            using (SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_basculas_value_alimentacion]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pesoBascula1 = dr.GetDecimal(0);
                    pesoBascula2 = dr.GetDecimal(1);
                }
                dr.Close();
                conn.Close();
            }

            lblValorBascula1.Text = "Valor en Báscula: " + pesoBascula1.ToString("N2") + " Kg";
            lblValorBascula2.Text = "Valor en Báscula: " + pesoBascula2.ToString("N2") + " Kg";
        }

        private void btnBascula1ON_Click(object sender, EventArgs e)
        {
            if (pesoBascula1 <= 0)
            {
                CajaDialogo.Error("No hay Peso en la Bascula 1");
                return;
            }

            GuardarPesoBruto(Bascula.Bascula1);

            
        }

        private void GuardarPesoBruto(Bascula BasculaSelected)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_alimentacion_macros_inicio_pesaje", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                switch (BasculaSelected)
                {
                    case Bascula.Bascula1:
                        cmd.Parameters.AddWithValue("@pid_registro", Id_registro_bascula1);
                        cmd.Parameters.AddWithValue("@peso_bruto", pesoBascula1);
                        break;
                    case Bascula.Bascula2:
                        cmd.Parameters.AddWithValue("@pid_registro", Id_registro_bascula2);
                        cmd.Parameters.AddWithValue("@peso_bruto", pesoBascula2);
                        break;
                    default:
                        break;
                }
                cmd.ExecuteNonQuery();
                conn.Close();

                switch (BasculaSelected)
                {
                    case Bascula.Bascula1:
                        CargarDetalleBascula1(Id_registro_bascula1);
                        btnBascula1ON.Enabled = false;

                        break;
                    case Bascula.Bascula2:
                        CargarDetalleBascula2(Id_registro_bascula2);
                        btnBascula2ON.Enabled = false;

                        break;
                    default:
                        break;
                }
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }
        }

        private void btnBascula2ON_Click(object sender, EventArgs e)
        {
            if (pesoBascula2 <= 0)
            {
                CajaDialogo.Error("No hay Peso en la Bascula 2");
                return;
            }

            GuardarPesoBruto(Bascula.Bascula2);
        }

        private void btnBascula1Off_Click(object sender, EventArgs e)
        {
            if (dsProduccion1.Bascula1.Count == 0)
            {
                CajaDialogo.Error("No se a Cargado el Pesaje!");
                return;
            }

            foreach (dsProduccion.Bascula1Row item in dsProduccion1.Bascula1.Rows)
            {
                if (item.id_registro > 0)
                {
                    Id_registro_bascula1 = item.id_registro;
                }
                
            }

            AlimentacionBasculas AliBasculas = new AlimentacionBasculas();
            AliBasculas.RecuperarRegistros(Id_registro_bascula1);

            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_requisa_entrega_a_prd_pesajeBascula", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", AliBasculas.Id_Tarima);
                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                cmd.Parameters.AddWithValue("@id_req", AliBasculas.Num_Requisa);
                cmd.Parameters.AddWithValue("@cantidad", AliBasculas.Unidades);
                cmd.Parameters.AddWithValue("@peso", AliBasculas.Peso);
                cmd.Parameters.AddWithValue("@peso_bascula", pesoBascula1);
                cmd.Parameters.AddWithValue("@id_registro", Id_registro_bascula1);
                //cmd.Parameters.AddWithValue("", AliBasculas.);
                cmd.ExecuteNonQuery();
                conn.Close();

                LimpiarDatosBascula1();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void LimpiarDatosBascula1()
        {
            dsProduccion1.Bascula1.Clear();
            Id_registro_bascula1 = 0;
            btnBascula1Off.Enabled = false;
        }
        private void LimpiarDatosBascula2()
        {
            dsProduccion1.Bascula2.Clear();
            Id_registro_bascula2 = 0;
            btnBascula2Off.Enabled = false;
        }

        private void btnBascula2Off_Click(object sender, EventArgs e)
        {
            if (dsProduccion1.Bascula2.Count == 0)
            {
                CajaDialogo.Error("No se a Cargado el Pesaje!");
                return;
            }

            foreach (dsProduccion.Bascula2Row item in dsProduccion1.Bascula2.Rows)
            {
                if (item.id_registro > 0)
                {
                    Id_registro_bascula2 = item.id_registro;
                }

            }

            AlimentacionBasculas AliBasculas = new AlimentacionBasculas();
            AliBasculas.RecuperarRegistros(Id_registro_bascula2);

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_requisa_entrega_a_prd_pesajeBascula", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", AliBasculas.Id_Tarima);
                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                cmd.Parameters.AddWithValue("@id_req", AliBasculas.Num_Requisa);
                cmd.Parameters.AddWithValue("@cantidad", AliBasculas.Unidades);
                cmd.Parameters.AddWithValue("@peso", AliBasculas.Peso);
                cmd.Parameters.AddWithValue("@peso_bascula", pesoBascula2);
                cmd.Parameters.AddWithValue("@id_registro", Id_registro_bascula2);
                //cmd.Parameters.AddWithValue("", AliBasculas.);
                cmd.ExecuteNonQuery();
                conn.Close();

                LimpiarDatosBascula1();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCancelBasc1_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea Cancelar el Pesaje?\nEl Montacarguista debera colocar de nuevo el Peso en la Bascula y Escanear nuevamente");
            if (r == DialogResult.Yes)
            {
                
            }

        }

        private void btnCancelBasc2_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlimentacionMacros));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdSelectTarima = new DevExpress.XtraEditors.SimpleButton();
            this.lblValorBascula1 = new DevExpress.XtraEditors.LabelControl();
            this.lblBascula1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblValorBascula2 = new DevExpress.XtraEditors.LabelControl();
            this.btnBascula1ON = new DevExpress.XtraEditors.SimpleButton();
            this.btnBascula2ON = new DevExpress.XtraEditors.SimpleButton();
            this.btnBascula1Off = new DevExpress.XtraEditors.SimpleButton();
            this.btnBascula2Off = new DevExpress.XtraEditors.SimpleButton();
            this.timerBascula = new System.Windows.Forms.Timer(this.components);
            this.vGridControl2 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.dsProduccion1 = new LOSA.Produccion.dsProduccion();
            this.row_requisa1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowLoteP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmp1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowlote1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowcodigo_barra1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowunidades1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPres = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_bruto1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_tara1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_prd1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowbascula1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.row1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.row_requisa = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowLotePT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmp = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowlote = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowcodigo_barra = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowunidades = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPresentacion = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_bruto = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_tara = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_prd = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowbascula = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.btnCancelBasc1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelBasc2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(534, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(230, 25);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Seleccion de Tarima:";
            // 
            // cmdSelectTarima
            // 
            this.cmdSelectTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectTarima.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectTarima.Appearance.Options.UseFont = true;
            this.cmdSelectTarima.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSelectTarima.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.cmdSelectTarima.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSelectTarima.Location = new System.Drawing.Point(730, 19);
            this.cmdSelectTarima.Name = "cmdSelectTarima";
            this.cmdSelectTarima.Size = new System.Drawing.Size(62, 44);
            this.cmdSelectTarima.TabIndex = 109;
            this.cmdSelectTarima.Click += new System.EventHandler(this.cmdSelectTarima_Click);
            // 
            // lblValorBascula1
            // 
            this.lblValorBascula1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBascula1.Appearance.Options.UseFont = true;
            this.lblValorBascula1.Appearance.Options.UseTextOptions = true;
            this.lblValorBascula1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValorBascula1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValorBascula1.Location = new System.Drawing.Point(135, 153);
            this.lblValorBascula1.Name = "lblValorBascula1";
            this.lblValorBascula1.Size = new System.Drawing.Size(389, 30);
            this.lblValorBascula1.TabIndex = 110;
            this.lblValorBascula1.Text = "Valor en Báscula: 0.00 Kg";
            // 
            // lblBascula1
            // 
            this.lblBascula1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBascula1.Appearance.Options.UseFont = true;
            this.lblBascula1.Appearance.Options.UseTextOptions = true;
            this.lblBascula1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBascula1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBascula1.Location = new System.Drawing.Point(135, 118);
            this.lblBascula1.Name = "lblBascula1";
            this.lblBascula1.Size = new System.Drawing.Size(389, 29);
            this.lblBascula1.TabIndex = 111;
            this.lblBascula1.Text = "Báscula 1";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(814, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(389, 29);
            this.labelControl2.TabIndex = 112;
            this.labelControl2.Text = "Báscula 2";
            // 
            // lblValorBascula2
            // 
            this.lblValorBascula2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorBascula2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBascula2.Appearance.Options.UseFont = true;
            this.lblValorBascula2.Appearance.Options.UseTextOptions = true;
            this.lblValorBascula2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValorBascula2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValorBascula2.Location = new System.Drawing.Point(814, 153);
            this.lblValorBascula2.Name = "lblValorBascula2";
            this.lblValorBascula2.Size = new System.Drawing.Size(389, 30);
            this.lblValorBascula2.TabIndex = 113;
            this.lblValorBascula2.Text = "Valor en Báscula: 0.00 Kg";
            // 
            // btnBascula1ON
            // 
            this.btnBascula1ON.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula1ON.Appearance.Options.UseFont = true;
            this.btnBascula1ON.Enabled = false;
            this.btnBascula1ON.ImageOptions.Image = global::LOSA.Properties.Resources.bascula_x32;
            this.btnBascula1ON.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula1ON.Location = new System.Drawing.Point(160, 206);
            this.btnBascula1ON.Name = "btnBascula1ON";
            this.btnBascula1ON.Size = new System.Drawing.Size(104, 74);
            this.btnBascula1ON.TabIndex = 114;
            this.btnBascula1ON.Text = "Acumular";
            this.btnBascula1ON.Click += new System.EventHandler(this.btnBascula1ON_Click);
            // 
            // btnBascula2ON
            // 
            this.btnBascula2ON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBascula2ON.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula2ON.Appearance.Options.UseFont = true;
            this.btnBascula2ON.Enabled = false;
            this.btnBascula2ON.ImageOptions.Image = global::LOSA.Properties.Resources.bascula_x32;
            this.btnBascula2ON.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula2ON.Location = new System.Drawing.Point(839, 206);
            this.btnBascula2ON.Name = "btnBascula2ON";
            this.btnBascula2ON.Size = new System.Drawing.Size(104, 74);
            this.btnBascula2ON.TabIndex = 115;
            this.btnBascula2ON.Text = "Acumular";
            this.btnBascula2ON.Click += new System.EventHandler(this.btnBascula2ON_Click);
            // 
            // btnBascula1Off
            // 
            this.btnBascula1Off.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula1Off.Appearance.Options.UseFont = true;
            this.btnBascula1Off.Enabled = false;
            this.btnBascula1Off.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula1Off.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBascula1Off.ImageOptions.SvgImage")));
            this.btnBascula1Off.Location = new System.Drawing.Point(272, 527);
            this.btnBascula1Off.Name = "btnBascula1Off";
            this.btnBascula1Off.Size = new System.Drawing.Size(104, 74);
            this.btnBascula1Off.TabIndex = 116;
            this.btnBascula1Off.Text = "Guardar";
            this.btnBascula1Off.Click += new System.EventHandler(this.btnBascula1Off_Click);
            // 
            // btnBascula2Off
            // 
            this.btnBascula2Off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBascula2Off.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula2Off.Appearance.Options.UseFont = true;
            this.btnBascula2Off.Enabled = false;
            this.btnBascula2Off.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula2Off.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBascula2Off.ImageOptions.SvgImage")));
            this.btnBascula2Off.Location = new System.Drawing.Point(955, 527);
            this.btnBascula2Off.Name = "btnBascula2Off";
            this.btnBascula2Off.Size = new System.Drawing.Size(104, 74);
            this.btnBascula2Off.TabIndex = 117;
            this.btnBascula2Off.Text = "Guardar";
            this.btnBascula2Off.Click += new System.EventHandler(this.btnBascula2Off_Click);
            // 
            // timerBascula
            // 
            this.timerBascula.Interval = 650;
            this.timerBascula.Tick += new System.EventHandler(this.timerBascula_Tick);
            // 
            // vGridControl2
            // 
            this.vGridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl2.DataMember = "Bascula2";
            this.vGridControl2.DataSource = this.dsProduccion1;
            this.vGridControl2.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl2.Location = new System.Drawing.Point(814, 295);
            this.vGridControl2.Name = "vGridControl2";
            this.vGridControl2.RecordWidth = 115;
            this.vGridControl2.RowHeaderWidth = 85;
            this.vGridControl2.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.row_requisa1,
            this.rowLoteP,
            this.rowmp1,
            this.rowlote1,
            this.rowcodigo_barra1,
            this.rowunidades1,
            this.rowPres,
            this.rowpeso1,
            this.rowpeso_bruto1,
            this.rowpeso_tara1,
            this.rowpeso_prd1,
            this.rowbascula1,
            this.row1});
            this.vGridControl2.Size = new System.Drawing.Size(389, 226);
            this.vGridControl2.TabIndex = 119;
            // 
            // dsProduccion1
            // 
            this.dsProduccion1.DataSetName = "dsProduccion";
            this.dsProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // row_requisa1
            // 
            this.row_requisa1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.row_requisa1.AppearanceCell.Options.UseFont = true;
            this.row_requisa1.Name = "row_requisa1";
            this.row_requisa1.Properties.AllowEdit = false;
            this.row_requisa1.Properties.Caption = "# Requisa";
            this.row_requisa1.Properties.FieldName = "#requisa";
            // 
            // rowLoteP
            // 
            this.rowLoteP.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowLoteP.AppearanceCell.Options.UseFont = true;
            this.rowLoteP.Name = "rowLoteP";
            this.rowLoteP.Properties.AllowEdit = false;
            this.rowLoteP.Properties.Caption = "Lote PT";
            this.rowLoteP.Properties.FieldName = "lote_pt";
            // 
            // rowmp1
            // 
            this.rowmp1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowmp1.AppearanceCell.Options.UseFont = true;
            this.rowmp1.Name = "rowmp1";
            this.rowmp1.Properties.AllowEdit = false;
            this.rowmp1.Properties.Caption = "Materia Prima";
            this.rowmp1.Properties.FieldName = "mp";
            // 
            // rowlote1
            // 
            this.rowlote1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowlote1.AppearanceCell.Options.UseFont = true;
            this.rowlote1.Name = "rowlote1";
            this.rowlote1.Properties.AllowEdit = false;
            this.rowlote1.Properties.Caption = "Lote MP";
            this.rowlote1.Properties.FieldName = "lote";
            // 
            // rowcodigo_barra1
            // 
            this.rowcodigo_barra1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowcodigo_barra1.AppearanceCell.Options.UseFont = true;
            this.rowcodigo_barra1.Name = "rowcodigo_barra1";
            this.rowcodigo_barra1.Properties.AllowEdit = false;
            this.rowcodigo_barra1.Properties.Caption = "Codigo de Barra";
            this.rowcodigo_barra1.Properties.FieldName = "codigo_barra";
            // 
            // rowunidades1
            // 
            this.rowunidades1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowunidades1.AppearanceCell.Options.UseFont = true;
            this.rowunidades1.Name = "rowunidades1";
            this.rowunidades1.Properties.AllowEdit = false;
            this.rowunidades1.Properties.Caption = "Unidades";
            this.rowunidades1.Properties.FieldName = "unidades";
            // 
            // rowPres
            // 
            this.rowPres.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowPres.AppearanceCell.Options.UseFont = true;
            this.rowPres.Name = "rowPres";
            this.rowPres.Properties.AllowEdit = false;
            this.rowPres.Properties.Caption = "Presentacion";
            this.rowPres.Properties.FieldName = "presentacion";
            // 
            // rowpeso1
            // 
            this.rowpeso1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowpeso1.AppearanceCell.Options.UseFont = true;
            this.rowpeso1.Name = "rowpeso1";
            this.rowpeso1.Properties.AllowEdit = false;
            this.rowpeso1.Properties.Caption = "Peso en Sacos";
            this.rowpeso1.Properties.FieldName = "peso";
            // 
            // rowpeso_bruto1
            // 
            this.rowpeso_bruto1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowpeso_bruto1.AppearanceCell.Options.UseFont = true;
            this.rowpeso_bruto1.Name = "rowpeso_bruto1";
            this.rowpeso_bruto1.Properties.AllowEdit = false;
            this.rowpeso_bruto1.Properties.Caption = "Peso Inicial";
            this.rowpeso_bruto1.Properties.FieldName = "peso_bruto";
            // 
            // rowpeso_tara1
            // 
            this.rowpeso_tara1.Name = "rowpeso_tara1";
            this.rowpeso_tara1.Properties.AllowEdit = false;
            this.rowpeso_tara1.Properties.Caption = "peso_tara";
            this.rowpeso_tara1.Properties.FieldName = "peso_tara";
            this.rowpeso_tara1.Visible = false;
            // 
            // rowpeso_prd1
            // 
            this.rowpeso_prd1.Name = "rowpeso_prd1";
            this.rowpeso_prd1.Properties.AllowEdit = false;
            this.rowpeso_prd1.Properties.Caption = "peso_prd";
            this.rowpeso_prd1.Properties.FieldName = "peso_prd";
            this.rowpeso_prd1.Visible = false;
            // 
            // rowbascula1
            // 
            this.rowbascula1.Name = "rowbascula1";
            this.rowbascula1.Properties.AllowEdit = false;
            this.rowbascula1.Properties.Caption = "bascula";
            this.rowbascula1.Properties.FieldName = "bascula";
            this.rowbascula1.Visible = false;
            // 
            // row1
            // 
            this.row1.Name = "row1";
            this.row1.Properties.Caption = "row1";
            this.row1.Properties.FieldName = "id_registro";
            this.row1.Visible = false;
            // 
            // vGridControl1
            // 
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl1.DataMember = "Bascula1";
            this.vGridControl1.DataSource = this.dsProduccion1;
            this.vGridControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(135, 295);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 115;
            this.vGridControl1.RowHeaderWidth = 85;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.row_requisa,
            this.rowLotePT,
            this.rowmp,
            this.rowlote,
            this.rowcodigo_barra,
            this.rowunidades,
            this.rowPresentacion,
            this.rowpeso,
            this.rowpeso_bruto,
            this.rowpeso_tara,
            this.rowpeso_prd,
            this.rowbascula,
            this.rowID});
            this.vGridControl1.Size = new System.Drawing.Size(389, 226);
            this.vGridControl1.TabIndex = 118;
            // 
            // row_requisa
            // 
            this.row_requisa.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.row_requisa.AppearanceCell.Options.UseFont = true;
            this.row_requisa.Name = "row_requisa";
            this.row_requisa.Properties.AllowEdit = false;
            this.row_requisa.Properties.Caption = "# Requisa";
            this.row_requisa.Properties.FieldName = "#requisa";
            // 
            // rowLotePT
            // 
            this.rowLotePT.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowLotePT.AppearanceCell.Options.UseFont = true;
            this.rowLotePT.Name = "rowLotePT";
            this.rowLotePT.Properties.AllowEdit = false;
            this.rowLotePT.Properties.Caption = "Lote PT";
            // 
            // rowmp
            // 
            this.rowmp.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowmp.AppearanceCell.Options.UseFont = true;
            this.rowmp.Name = "rowmp";
            this.rowmp.Properties.AllowEdit = false;
            this.rowmp.Properties.Caption = "Materia Prima";
            this.rowmp.Properties.FieldName = "mp";
            // 
            // rowlote
            // 
            this.rowlote.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowlote.AppearanceCell.Options.UseFont = true;
            this.rowlote.Name = "rowlote";
            this.rowlote.Properties.AllowEdit = false;
            this.rowlote.Properties.Caption = "Lote MP";
            this.rowlote.Properties.FieldName = "lote";
            // 
            // rowcodigo_barra
            // 
            this.rowcodigo_barra.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowcodigo_barra.AppearanceCell.Options.UseFont = true;
            this.rowcodigo_barra.Name = "rowcodigo_barra";
            this.rowcodigo_barra.Properties.AllowEdit = false;
            this.rowcodigo_barra.Properties.Caption = "Codigo de Barra";
            this.rowcodigo_barra.Properties.FieldName = "codigo_barra";
            // 
            // rowunidades
            // 
            this.rowunidades.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowunidades.AppearanceCell.Options.UseFont = true;
            this.rowunidades.Name = "rowunidades";
            this.rowunidades.Properties.AllowEdit = false;
            this.rowunidades.Properties.Caption = "Unidades";
            this.rowunidades.Properties.FieldName = "unidades";
            // 
            // rowPresentacion
            // 
            this.rowPresentacion.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowPresentacion.AppearanceCell.Options.UseFont = true;
            this.rowPresentacion.Name = "rowPresentacion";
            this.rowPresentacion.Properties.AllowEdit = false;
            this.rowPresentacion.Properties.Caption = "Presentacion Saco";
            this.rowPresentacion.Properties.FieldName = "presentacion";
            // 
            // rowpeso
            // 
            this.rowpeso.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowpeso.AppearanceCell.Options.UseFont = true;
            this.rowpeso.Name = "rowpeso";
            this.rowpeso.Properties.AllowEdit = false;
            this.rowpeso.Properties.Caption = "Peso en Sacos";
            this.rowpeso.Properties.FieldName = "peso";
            // 
            // rowpeso_bruto
            // 
            this.rowpeso_bruto.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowpeso_bruto.AppearanceCell.Options.UseFont = true;
            this.rowpeso_bruto.Name = "rowpeso_bruto";
            this.rowpeso_bruto.Properties.AllowEdit = false;
            this.rowpeso_bruto.Properties.Caption = "Peso Inicial";
            this.rowpeso_bruto.Properties.FieldName = "peso_bruto";
            // 
            // rowpeso_tara
            // 
            this.rowpeso_tara.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rowpeso_tara.AppearanceCell.Options.UseFont = true;
            this.rowpeso_tara.Name = "rowpeso_tara";
            this.rowpeso_tara.Properties.AllowEdit = false;
            this.rowpeso_tara.Properties.Caption = "peso_tara";
            this.rowpeso_tara.Properties.FieldName = "peso_tara";
            this.rowpeso_tara.Visible = false;
            // 
            // rowpeso_prd
            // 
            this.rowpeso_prd.Name = "rowpeso_prd";
            this.rowpeso_prd.Properties.AllowEdit = false;
            this.rowpeso_prd.Properties.Caption = "peso_prd";
            this.rowpeso_prd.Properties.FieldName = "peso_prd";
            this.rowpeso_prd.Visible = false;
            // 
            // rowbascula
            // 
            this.rowbascula.Name = "rowbascula";
            this.rowbascula.Properties.AllowEdit = false;
            this.rowbascula.Properties.Caption = "Bascula #";
            this.rowbascula.Properties.FieldName = "bascula";
            this.rowbascula.Visible = false;
            // 
            // rowID
            // 
            this.rowID.Name = "rowID";
            this.rowID.Properties.Caption = "rowId";
            this.rowID.Properties.FieldName = "id_registro";
            this.rowID.Visible = false;
            // 
            // btnCancelBasc1
            // 
            this.btnCancelBasc1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBasc1.Appearance.Options.UseFont = true;
            this.btnCancelBasc1.Enabled = false;
            this.btnCancelBasc1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCancelBasc1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnCancelBasc1.Location = new System.Drawing.Point(363, 222);
            this.btnCancelBasc1.Name = "btnCancelBasc1";
            this.btnCancelBasc1.Size = new System.Drawing.Size(84, 58);
            this.btnCancelBasc1.TabIndex = 120;
            this.btnCancelBasc1.Text = "Cancelar";
            this.btnCancelBasc1.Click += new System.EventHandler(this.btnCancelBasc1_Click);
            // 
            // btnCancelBasc2
            // 
            this.btnCancelBasc2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelBasc2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBasc2.Appearance.Options.UseFont = true;
            this.btnCancelBasc2.Enabled = false;
            this.btnCancelBasc2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCancelBasc2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.btnCancelBasc2.Location = new System.Drawing.Point(1050, 222);
            this.btnCancelBasc2.Name = "btnCancelBasc2";
            this.btnCancelBasc2.Size = new System.Drawing.Size(84, 58);
            this.btnCancelBasc2.TabIndex = 121;
            this.btnCancelBasc2.Text = "Cancelar";
            this.btnCancelBasc2.Click += new System.EventHandler(this.btnCancelBasc2_Click);
            // 
            // frmAlimentacionMacros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 765);
            this.Controls.Add(this.btnCancelBasc2);
            this.Controls.Add(this.btnCancelBasc1);
            this.Controls.Add(this.vGridControl2);
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.btnBascula2Off);
            this.Controls.Add(this.btnBascula1Off);
            this.Controls.Add(this.btnBascula2ON);
            this.Controls.Add(this.btnBascula1ON);
            this.Controls.Add(this.lblValorBascula2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblBascula1);
            this.Controls.Add(this.lblValorBascula1);
            this.Controls.Add(this.cmdSelectTarima);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmAlimentacionMacros";
            this.Text = "Alimentacion de MacroIngredientes";
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}