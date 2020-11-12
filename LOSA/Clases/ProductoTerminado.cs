﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Clases
{
    public class ProductoTerminado
    {
        string ConnectionString;
        public string codigo, descripcion, fecha, estado, formula_code, tamaño, diametro, registro;
        public TimeSpan horasP;
        public decimal proteinas, grasa, size;
        public int id, id_bag, id_category, id_proceso, id_portafolio, id_tamaño, especie, family, idOr;
        public bool recuperado;
        public string material, nombre_comercial, customer_visibility, oldCode, mixType, CodigoMP;
        public int tipo, tipof, grouping_id, tipor;
        public Boolean aplic_costos, apli_incl, nc_use, nmly_manual;
        public string Codigo;



        public ProductoTerminado(string pConnectionString)
        {
            ConnectionString = pConnectionString;
        }

        
        public bool Recuperar_producto(string Pcodigo)
        {
            try
            {//Recupera las caracteristicas 
                string sql = @"SELECT [id]
                                      ,[Descripcion]
                                      ,coalesce ([Proteina], 0.0) as [Proteina]
                                      ,coalesce ([Grasa], 0.0) as [Grasa]
                                      ,[Especie]
                                      ,coalesce ([family], 0) as [family]
                                      ,coalesce ([id_bag],0) as [id_bag]
                                      ,coalesce ([size], 0) as [size]
                                      ,coalesce ([formula_code], '') as [formula_code]
                                      ,coalesce ([id_category], '0') as [id_category]
                                      ,coalesce ([id_proceso], 0) as [id_proceso]
                                      ,coalesce ([id_portafolio], 0) as [id_portafolio]
                                      ,[proteina]
                                      ,[grasa]
                                      ,coalesce ([tamanio] , ' ') as [tamaño]
                                      ,coalesce ([id_origen] , 0) as [id_origen]
                                      ,coalesce ([Registro], ' ') as [Registro]
                                      ,coalesce ([diametro], ' ') as [diametro]
                                      ,Codigo
                                  FROM [ACS].[dbo].[PT_Productos]
                                  where (Codigo) = '" + Pcodigo + "'";
                //,coalesce([HorasTon], '00:00:00 a.m.') as HorasP
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dl = cmd.ExecuteReader();
                if (dl.Read())
                {

                    id = dl.GetInt32(0);
                    descripcion = dl.GetString(1);
                    proteinas = dl.GetDecimal(2);
                    grasa = dl.GetDecimal(3);
                    especie = dl.GetInt32(4);
                    family = dl.GetInt32(5);
                    id_bag = dl.GetInt32(6);
                    size = dl.GetDecimal(7);
                    formula_code = dl.GetString(8);
                    id_category = dl.GetInt32(9);
                    id_proceso = dl.GetInt32(10);
                    id_portafolio = dl.GetInt32(11);
                    proteinas = dl.GetDecimal(12);
                    grasa = dl.GetDecimal(13);
                    tamaño = dl.GetString(14);
                    idOr = dl.GetInt32(15);
                    registro = dl.GetString(16);
                    diametro = dl.GetString(17);
                    Codigo = dl.GetString(18);
                    // horasP = dl.GetTimeSpan(18);
                    recuperado = true;
                }
            }
            catch (Exception ex)
            {

                recuperado = false;
                MessageBox.Show(ex.Message);
            }
            return recuperado;
        }

        public bool Recuperar_producto(int IdProd)
        {
            try
            {//Recupera las caracteristicas 
                string sql = @"SELECT [id]
                                      ,[Descripcion]
                                      ,coalesce ([Proteina], 0.0) as [Proteina]
                                      ,coalesce ([Grasa], 0.0) as [Grasa]
                                      ,[Especie]
                                      ,coalesce ([family], 0) as [family]
                                      ,coalesce ([id_bag],0) as [id_bag]
                                      ,coalesce ([size], 0) as [size]
                                      ,coalesce ([formula_code], '') as [formula_code]
                                      ,coalesce ([id_category], '0') as [id_category]
                                      ,coalesce ([id_proceso], 0) as [id_proceso]
                                      ,coalesce ([id_portafolio], 0) as [id_portafolio]
                                      ,[proteina]
                                      ,[grasa]
                                      ,coalesce ([tamanio] , ' ') as [tamaño]
                                      ,coalesce ([id_origen] , 0) as [id_origen]
                                      ,coalesce ([Registro], ' ') as [Registro]
                                      ,coalesce ([diametro], ' ') as [diametro]
                                      ,Codigo
                                  FROM [ACS].[dbo].[PT_Productos]
                                  where id = '" + IdProd + "'";
                //,coalesce([HorasTon], '00:00:00 a.m.') as HorasP
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dl = cmd.ExecuteReader();
                if (dl.Read())
                {

                    id = dl.GetInt32(0);
                    descripcion = dl.GetString(1);
                    proteinas = dl.GetDecimal(2);
                    grasa = dl.GetDecimal(3);
                    especie = dl.GetInt32(4);
                    family = dl.GetInt32(5);
                    id_bag = dl.GetInt32(6);
                    size = dl.GetDecimal(7);
                    formula_code = dl.GetString(8);
                    id_category = dl.GetInt32(9);
                    id_proceso = dl.GetInt32(10);
                    id_portafolio = dl.GetInt32(11);
                    proteinas = dl.GetDecimal(12);
                    grasa = dl.GetDecimal(13);
                    tamaño = dl.GetString(14);
                    idOr = dl.GetInt32(15);
                    registro = dl.GetString(16);
                    diametro = dl.GetString(17);    
                    Codigo = dl.GetString(18);
                    // horasP = dl.GetTimeSpan(18);
                    recuperado = true;
                }
            }
            catch (Exception ex)
            {

                recuperado = false;
                MessageBox.Show(ex.Message);
            }
            return recuperado;
        }

        public int Recuperaridmpgroup(int PidGrup)
        {
            int varidconf = 0;
            if (PidGrup == 1)
            {
                varidconf = 7;

            }
            if (PidGrup == 2)
            {
                varidconf = 8;
            }
            if (PidGrup == 3)
            {
                varidconf = 9;
            }
            if (PidGrup == 4)
            {
                varidconf = 10;
            }
            if (PidGrup == 5)
            {
                varidconf = 11;
            }
            if (PidGrup == 6)
            {
                varidconf = 12;
            }
            return varidconf;
        }
        public bool MP_Get_Data(int ParidMp)
        {
            bool recuperado;
            string query;
            query = @"SELECT   [codigo]
                              ,[material]
                              ,[nombre_comercial]
                              ,[tipo]
                              ,[tipof]
                              ,[customer_visibility]
                              ,[grouping_id]
                              ,[tipor]
                              ,[oldCode]
                              ,[mixType]
                              ,[estado]
                              ,[aplic_costos]
                              ,[aplic_incl]
                              ,[nc_use]
                              ,[nmly_manual]
                          FROM [ACS].[dbo].[MP_MateriasPrimas]
                          where id = " + ParidMp;
            try
            {

                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    CodigoMP = dr.GetString(0);
                    material = dr.GetString(1);
                    nombre_comercial = dr.GetString(2);
                    customer_visibility = dr.GetString(5);
                    mixType = dr.GetString(9);
                    estado = dr.GetString(10);
                    tipo = dr.GetInt32(3);
                    tipof = dr.GetInt32(4);
                    grouping_id = dr.GetInt32(6);
                    tipor = dr.GetInt32(7);
                    aplic_costos = dr.GetBoolean(11);
                    apli_incl = dr.GetBoolean(12);
                    nc_use = dr.GetBoolean(13);

                    recuperado = true;
                }
                else
                {
                    recuperado = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                recuperado = false;
            }
            return recuperado;
        }
    }

}
