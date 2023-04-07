using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class MateriaPrima
    {
        public MateriaPrima()
        {
            TableMasterData = new dsColleccionesClases.materia_prima_acsDataTable();
            LoadMasterDataList();
        }

        

        dsColleccionesClases.materia_prima_acsDataTable TableMasterData;
        int _IdMP_ACS;
        string _CodeMP_SAP;
        string _CodigoODOO;
        string _Name;
        bool _enable;
        string _NameComercial;
        bool _Recuperado;
        int _idRM;
        bool _permitir;

        public int IdMP_ACS { get => _IdMP_ACS; set => _IdMP_ACS = value; }
        public string CodeMP_SAP { get => _CodeMP_SAP; set => _CodeMP_SAP = value; }
        public string Codigo { get => _CodigoODOO; set => _CodigoODOO = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string NameComercial { get => _NameComercial; set => _NameComercial = value; }
        public bool Recuperado { get => _Recuperado; set => _Recuperado = value; }
        public bool Enable { get => _enable; set => _enable = value; }
        public int IdRM { get => _idRM; set => _idRM = value; }
        public bool Permitir { get => _permitir; set => _permitir = value; }

        private void LoadMasterDataList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_recuperar_registro_materias_primas_all", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@codigo_bodega", pCodigoBodega);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(TableMasterData);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public bool RecuperarRegistroPreLoaded(string pCodigoSAP)
        {
            Recuperado = false;
            foreach (dsColleccionesClases.materia_prima_acsRow row in TableMasterData.Rows)
            {
                if (row.code_sap == pCodigoSAP)
                {
                    this.IdMP_ACS = row.id;
                    this._CodigoODOO = row.codigo;
                    this.Name = row.material;
                    this.NameComercial = row.nombre_comercial;
                    Enable = row.enable; 
                    Recuperado = true;
                    break;
                }
            }
            return Recuperado;
        }

        public bool RecuperarRegistroFromID_RM(int pIdRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_clase_mp_from_id_rm", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idrm", pIdRM);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdMP_ACS = dr.GetInt32(0);
                    Codigo = dr.GetString(1);
                    Name = dr.GetString(2);
                    NameComercial = dr.GetString(3);
                    CodeMP_SAP = dr.GetString(4);
                }
                dr.Close();
                Recuperado = true;
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public bool RecuperarRegistro_MPACS_For_IDRM_APMS(int pIdRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_get_clase_raw_material_for_id_RM", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRM",pIdRM);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdRM = dr.GetInt32(0);
                    IdMP_ACS = dr.GetInt32(1);
                    Name = dr.GetString(2);
                    NameComercial = dr.GetString(3);
                    CodeMP_SAP = dr.GetString(4);
                }
                dr.Close();
                Recuperado = true;
                conn.Close();

            }
            catch (Exception ex)
            {
                Recuperado = false;
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado;
        }


        //
        public bool Get_if_mp_is_granel(int pIdRM)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_si_mp_is_granel", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp_is_mp_granel", pIdRM);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int i = dr.GetInt32(0);
                    if (i > 0)
                        r = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                r = false;
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }

        public bool RecuperarRegistroFromID_pt(int pIdPT)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_clase_mp_from_id_PT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idrm", pIdPT);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdMP_ACS = dr.GetInt32(0);
                    Codigo = dr.GetString(1);
                    Name = dr.GetString(2);
                    //name sap = dr.GetString(3);
                    CodeMP_SAP = dr.GetString(4);
                }
                dr.Close();
                Recuperado = true;
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }
        public bool RecuperarRegistroFromID_RM_PT_ONLY(int pIdRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_clase_pt_from_id_rm", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idrm", pIdRM);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdMP_ACS = dr.GetInt32(0);
                    Codigo = dr.GetString(1);
                    Name = dr.GetString(2);
                    CodeMP_SAP = dr.GetString(3);
                }
                dr.Close();
                Recuperado = true;
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }
        public bool RecuperarRegistroFromID_RM_Despachos(int pIdRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_clase_mp_from_id_rm", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idrm", pIdRM);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdMP_ACS = dr.GetInt32(0);
                    Codigo = dr.GetString(1);
                    Name = dr.GetString(2);
                    CodeMP_SAP = dr.GetString(3);
                }
                dr.Close();
                Recuperado = true;
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }


        public bool RecuperarRegistroFromCode(string pCodeSAP)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_clase_mp_from_sap_code", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", pCodeSAP);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdMP_ACS = dr.GetInt32(0);
                    Codigo = dr.GetString(1);
                    Name = dr.GetString(2);
                    CodeMP_SAP = pCodeSAP;
                }
                dr.Close();
                Recuperado = true;
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public bool PermitirEntregaParcialKG(int pid_mp)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_permite_entrega_parcial_de_kg_requisa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmp", pid_mp);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Permitir = dr.GetBoolean(0);
                }
                dr.Close();
                Recuperado = true;
                conn.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        
        }


    }
}
