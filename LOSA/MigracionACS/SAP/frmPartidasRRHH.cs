using ACS.Classes;
using Devart.Data.PostgreSql;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.SAP
{
    public partial class frmPartidasRRHH : Form
    {
        DataOperations dp;
        string _UserSAP;
        string _PasswordSAP;

        public enum EstadoConexion
        {
            Conectado = 1,
            Desconectado = 2
        }

        EstadoConexion EstadoConexionActual;
        /// <summary>
        /// String. Get or Set User Name SAP
        /// </summary>
        public string UserSAP { get => _UserSAP; set => _UserSAP = value; }

        /// <summary>
        /// String. Get or Set Password SAP
        /// </summary>
        public string PasswordSAP { get => _PasswordSAP; set => _PasswordSAP = value; }

        UserLogin UsuarioLogeado;

        public frmPartidasRRHH(UserLogin pUser)
        {
            InitializeComponent();
            EstadoConexionActual = EstadoConexion.Desconectado;
            UsuarioLogeado = pUser;
            dp = new DataOperations();
            LoadData();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Carga el Set de Datos tomando en cuenta partidas que no se han posteado en SAP BO. ------ 
        /// Autor: Danys Oliva  --  
        /// Fecha: 22/nov/2018  --
        /// </summary>
        private void LoadData()
        {
            try
            {
                string query = @"select * from public.ft_recupera_detalle_partidas_for_sapv2();";
                PgSqlConnection psConnecton = new PgSqlConnection(dp.ConnectionStringODOO5);
                psConnecton.Open();
                PgSqlCommand cmd = new PgSqlCommand(query, psConnecton);
                PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                dsDataSetSAP1.PartidasRRHH.Clear();
                adat.Fill(dsDataSetSAP1.PartidasRRHH);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("Error al cargar el detalle de Partidas desde ODOO.  ", ec);
            }


            if (dsDataSetSAP1.PartidasRRHH.Count > 0)
            {
                foreach (dsDataSetSAP.PartidasRRHHRow row in dsDataSetSAP1.PartidasRRHH)
                {
                    ValidatePartidaDiff(row.id);
                }
            }
        }

        private void ValidatePartidaDiff(int id)
        {
            if (id >= 493)
            {
                try
                {
                    string query = @"select * from public.ft_update_diff_auto_detalle_planlla(:p_id_asiento);";
                    PgSqlConnection psConnecton = new PgSqlConnection(dp.ConnectionStringODOO5);
                    psConnecton.Open();
                    PgSqlCommand cmd = new PgSqlCommand(query, psConnecton);
                    cmd.Parameters.AddWithValue("p_id_asiento", id);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error("Error al cargar el detalle de Partidas desde ODOO.  ", ec);
                }
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            //Confirmacion sobre la accion



            //Procesar en SAP las partidas de planillas
            var gridView = (GridView)gridControl1.FocusedView;

            bool guardado = false;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow r = gridView1.GetDataRow(i);

                bool selec = false;
                try
                {
                    selec = Convert.ToBoolean(r["seleccionado"]);
                }
                catch { }
                double _credit = 0;
                double _debit = 0;


                if (selec)
                {
                    int idMove = Convert.ToInt32(r["id"]);
                    try
                    {
                        //Multiple de conexiones a servidores Aquafeed
                        DataOperations dp = new DataOperations();

                        //Posteo de Partidas en SAP
                        SAPbobsCOM.Company oCmp = dp.CompanyMake(UserSAP, PasswordSAP);
                        //dp.CompanyIsconected(UserSAP, PasswordSAP);
                        
                        //Encabezado del Asiento contable
                        SAPbobsCOM.JournalEntries oJE;
                        string errMsg = "";
                        int errNum = 0;

                        oJE = oCmp.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalEntries);
                        oJE.DueDate = Convert.ToDateTime(r["fecha"]);
                        oJE.ReferenceDate = oJE.DueDate;
                        oJE.TaxDate = oJE.ReferenceDate;
                        oJE.Memo = r["numero"].ToString();
                        oJE.Reference = r["referencia"].ToString();


                        //Detalle del asiento.
                        PgSqlConnection psConnection = new PgSqlConnection(dp.ConnectionStringODOO5);
                        psConnection.Open();
                        
                        //Vamos a sacar las lineas de cada asiento.
                        string sql = @"select * from public.ft_recupera_move_line_group (:p_id_move);";
                        PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                        cmd.Parameters.Add("p_id_move", PgSqlType.Int).Value = idMove;
                        PgSqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            MoveLineODOO MoveLine = new MoveLineODOO();
                            if (MoveLine.RecuperarRegistro(dr.GetInt32(0)))
                            {
                                //Agregamos el dato de linea al asiento de SAP
                                if (string.IsNullOrEmpty(MoveLine.Code))
                                {
                                    CajaDialogo.Error("La cuenta #" + MoveLine.Id_cuenta + " " 
                                                     + MoveLine.Cuenta + ". No tiene vinculado un codigo de cuenta de SAP");
                                }
                                else
                                {
                                    oJE.Lines.AccountCode = MoveLine.Code;
                                    switch (MoveLine.IdType)
                                    {
                                        case 1:
                                            oJE.Lines.CostingCode = MoveLine.CodeCECO;
                                            //oJE.Lines.CostingCode2 = "";
                                            //oJE.Lines.CostingCode3 = "";
                                            break;
                                        case 2:
                                            //oJE.Lines.CostingCode = "";
                                            oJE.Lines.CostingCode2 = MoveLine.CodeCECO;
                                            //oJE.Lines.CostingCode3 = "";
                                            break;
                                        case 3:
                                            //oJE.Lines.CostingCode = "";
                                            //oJE.Lines.CostingCode2 = "";

                                            oJE.Lines.CostingCode3 = MoveLine.CodeCECO;
                                            break;
                                        default:
                                            break;
                                    }

                                    //oJE.Lines.de
                                    //USD
                                    //HNL
                                    string _Moneda = r["moneda"].ToString();
                                    switch (_Moneda.ToUpper().Trim())
                                    {
                                        case "USD":
                                            _Moneda = "USD";
                                            break;
                                        case "HNL":
                                            _Moneda = "LPS";
                                            break;
                                    }

                                    oJE.Lines.FCCurrency = _Moneda;
                                    _credit += oJE.Lines.Credit = Math.Round(Convert.ToDouble(MoveLine.Credit), 2);
                                    _debit += oJE.Lines.Debit = Math.Round(Convert.ToDouble(MoveLine.Debit),2);
                                    oJE.Lines.Add();
                                }
                            }
                        }
                        psConnection.Close();
                        _credit = Math.Round(_credit, 2);
                        _debit = Math.Round(_debit, 2);
                        double dif = Math.Round(_credit,2) - Math.Round(_debit,2);
                        //oJE.DocumentType = "30";
                        oJE.TransactionCode = "PLAN";
                        //Fin del proceso por partida seleccionada.
                        errNum = oJE.Add();
                        if (errNum == 0)
                        {
                            guardado = true;
                            MessageBox.Show("Transaccion exitosa!");
                        }
                        else
                        {
                            guardado = false;
                            oCmp.GetLastError(out errNum, out errMsg);
                            MessageBox.Show(errNum + " - " + errMsg);
                        }
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                }
            }

            if (guardado)
            {
                CajaDialogo.Information("Transacción Exitosa!");
                LoadData();
            }
        }

        private void btnDetalles_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //ver detalles
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsDataSetSAP.PartidasRRHHRow)gridView.GetFocusedDataRow();
            int id_moneda = 0;
            decimal tasaCambio = 1;
            switch (row.moneda)
            {
                case "LPS":
                    id_moneda = 44;
                    break;
                case "USD":
                    id_moneda = 2;
                    tasaCambio = row.tasa;
                    break;
            }
            frmDetallePartida frm = new frmDetallePartida(row.id, id_moneda, tasaCambio);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdConexionSAP_Click(object sender, EventArgs e)
        {
            if (UsuarioLogeado.ValidarNivelPermisos(19))
            {
                if (EstadoConexionActual == EstadoConexion.Desconectado)
                {
                    frmLoginSAP frm = new frmLoginSAP();
                    //frm.MdiParent = this;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        //frmPartidasRRHH fmr = new frmPartidasRRHH();
                        //fmr.MdiParent = this;
                        //fmr.UserSAP = frm.txtUsuario.Text;
                        //fmr.PasswordSAP = frm.txtPassword.Text;
                        //fmr.Show();
                        EstadoConexionActual = EstadoConexion.Conectado;
                        cmdConexionSAP.Text = "Conectado";
                        this.PasswordSAP = frm.txtPassword.Text;
                        UserSAP = frm.txtUsuario.Text;
                        cmdConexionSAP.Appearance.BackColor = Color.FromArgb(192, 255, 192);
                    }
                    else
                    {
                        EstadoConexionActual = EstadoConexion.Desconectado;
                        cmdConexionSAP.Appearance.BackColor = Color.Transparent;
                        cmdConexionSAP.Text = "Desconectado";
                    }
                }
                else
                {
                    //Esta pidiendo desconectar
                    DialogResult result = CajaDialogo.Pregunta("Confirme que desea desconectar?");
                    if (result != DialogResult.Yes)
                        return;

                    EstadoConexionActual = EstadoConexion.Desconectado;
                    cmdConexionSAP.Appearance.BackColor = Color.Transparent;
                    cmdConexionSAP.Text = "Desconectado";
                }
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #19");
            }
        }

        private void cmdSubirA_SAP_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (EstadoConexionActual == EstadoConexion.Desconectado)
            {
                CajaDialogo.Error("Es necesario estar conectado a SAP para poder subir un asiento contable!");
                errorProvider1.SetError(cmdConexionSAP, "Inicie sesion para poder continuar!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            var gridView = (GridView)gridControl1.FocusedView;
            var r = (dsDataSetSAP.PartidasRRHHRow)gridView.GetFocusedDataRow();

            if (r.estado == "Asentado")
            {
                CajaDialogo.Error("Este asiento ya fue posteado en SAP!");
                return;
            }

            DialogResult result = CajaDialogo.Pregunta("Esta seguro de subir este asiento contable a SAP?");
            if (result != DialogResult.Yes)
                return;

            //Procesar en SAP las partidas de planillas
            
            bool guardado = false;
            
            double _credit = 0;
            double _debit = 0;

            int idMove = Convert.ToInt32(r["id"]);
            try
            {
                //Multiple de conexiones a servidores Aquafeed
                DataOperations dp = new DataOperations();

                //Posteo de Partidas en SAP
                SAPbobsCOM.Company oCmp = dp.CompanyMake(UserSAP, PasswordSAP);

                //Encabezado del Asiento contable
                SAPbobsCOM.JournalEntries oJE;
                string errMsg = "";
                int errNum = 0;

                oJE = oCmp.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalEntries);
                oJE.DueDate = Convert.ToDateTime(r["fecha"]);
                oJE.ReferenceDate = oJE.DueDate;
                oJE.TaxDate = oJE.ReferenceDate;
                oJE.Memo = r["referencia"].ToString(); //r["numero"].ToString();
                oJE.Reference = r["referencia"].ToString();

                //Detalle del asiento.
                PgSqlConnection psConnection = new PgSqlConnection(dp.ConnectionStringODOO5);
                psConnection.Open();

                //Vamos a sacar las lineas de cada asiento.
                string sql = @"select * from public.ft_recupera_move_line_group (:p_id_move);";
                PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                cmd.Parameters.Add("p_id_move", PgSqlType.Int).Value = idMove;
                PgSqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MoveLineODOO MoveLine = new MoveLineODOO();
                    if (MoveLine.RecuperarRegistro(dr.GetInt32(0)))
                    {
                        //Agregamos el dato de linea al asiento de SAP
                        if (string.IsNullOrEmpty(MoveLine.Code))
                        {
                            CajaDialogo.Error("La cuenta #" + MoveLine.Id_cuenta + " "
                                             + MoveLine.Cuenta + ". No tiene vinculado un codigo de cuenta de SAP");
                        }
                        else
                        {
                            oJE.Lines.AccountCode = MoveLine.Code;
                            switch (MoveLine.IdType)
                            {
                                case 1:
                                    oJE.Lines.CostingCode = MoveLine.CodeCECO;
                                    //oJE.Lines.CostingCode2 = "";
                                    //oJE.Lines.CostingCode3 = "";
                                    break;
                                case 2:
                                    //oJE.Lines.CostingCode = "";
                                    oJE.Lines.CostingCode2 = MoveLine.CodeCECO;
                                    //oJE.Lines.CostingCode3 = "";
                                    break;
                                case 3:
                                    //oJE.Lines.CostingCode = "";
                                    //oJE.Lines.CostingCode2 = "";
                                    oJE.Lines.CostingCode3 = MoveLine.CodeCECO;
                                    break;
                                default:
                                    break;
                            }

                            //Solo en caso de Dolares hacemos la definicion de la moneda, en lempiras no hacemos nada porque es la moneda del sistema.
                            if (r.moneda == "USD")
                            {
                                oJE.Lines.FCCurrency = r.moneda;

                                //oJE.Lines.FCCredit = oJE.Lines.CreditSys = Math.Round(MoveLine.Credit, 2);
                                //oJE.Lines.FCDebit = oJE.Lines.DebitSys = Math.Round(MoveLine.Debit, 2);

                                double tasacambio = Math.Round(Convert.ToDouble(r.tasa),2);
                                oJE.Lines.FCCredit = Math.Round((Convert.ToDouble( MoveLine.Credit) / tasacambio),2);
                                oJE.Lines.FCDebit = Math.Round((Convert.ToDouble(MoveLine.Debit) / tasacambio),2);
                            }

                            _credit += oJE.Lines.Credit = Math.Round(Convert.ToDouble(MoveLine.Credit),2);
                            _debit += oJE.Lines.Debit = Math.Round(Convert.ToDouble(MoveLine.Debit),2);
                            oJE.Lines.Add();
                        }
                    }
                }
                
                _credit = Math.Round(_credit, 2);
                _debit = Math.Round(_debit, 2);
                double dif = Math.Round(_credit, 2) - Math.Round(_debit, 2);
                //oJE.DocumentType = "30";
                oJE.TransactionCode = "PLAN";
                //Fin del proceso por partida seleccionada.
                errNum = oJE.Add();
                if (errNum == 0)
                {
                    guardado = true;
                    string NumeroAsientoSAP = null;
                    try
                    {
                        NumeroAsientoSAP = oCmp.GetNewObjectKey();
                    }
                    catch { }

                    PgSqlCommand cmdODOO = new PgSqlCommand();
                    cmdODOO.Connection = psConnection;
                    cmdODOO.CommandText = @"UPDATE public.account_move
	                                            SET state = 'posted'
                                                    ,name = " + NumeroAsientoSAP +
                                            " WHERE id = " + r.id.ToString();
                    cmdODOO.ExecuteNonQuery();
                    MessageBox.Show("Transaccion exitosa!");
                }
                else
                {
                    guardado = false;
                    oCmp.GetLastError(out errNum, out errMsg);
                    CajaDialogo.Error("Error# " + errNum + " MSJ: " + errMsg);
                }
                psConnection.Close();
            }
            catch (Exception ec)
            {

                CajaDialogo.Error(ec.Message);
            }

            if (guardado)
            {
                CajaDialogo.Information("Transacción Exitosa!");
                LoadData();
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName == "referencia")
            {
                try
                {
                    var gridView = (GridView)gridControl1.FocusedView;
                    var r = (dsDataSetSAP.PartidasRRHHRow)gridView.GetFocusedDataRow();
                    PgSqlConnection psConnection = new PgSqlConnection(dp.ConnectionStringODOO5);
                    psConnection.Open();
                    PgSqlCommand cmdODOO = new PgSqlCommand();
                    cmdODOO.Connection = psConnection;
                    cmdODOO.CommandText = @"UPDATE public.account_move
	                                            SET ref = :referencia 
                                             WHERE id = :id;";

                    cmdODOO.Parameters.AddWithValue("referencia", r.referencia);
                    cmdODOO.Parameters.AddWithValue("id", r.id);
                    cmdODOO.ExecuteNonQuery();
                }
                catch(Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }
    }
}
