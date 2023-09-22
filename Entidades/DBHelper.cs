using Carpinteria1w2.Datos.Implementacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria1w2.Entidades
{
    internal class DBHelper
    {
        //string cadenaconexion = @"Data Source=172.16.10.196;Initial Catalog=Carpinteria_2023;User ID=alumno1w1;Password=alumno1w1";
        string cadenaconexion=@"Data Source=DESKTOP-KFQ7MV9\SQLEXPRESS;Initial Catalog=CARPINTERIA_2023;Integrated Security=True";
        SqlConnection conn=new SqlConnection();

        public DBHelper()
        {
            conn = new SqlConnection(cadenaconexion);
        }
        /*public int ProximoPresupuesto()
        {
            SqlCommand cmd = new SqlCommand("SP_PROXIMO_ID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@next";
            param.DbType = DbType.Int32;
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return (int)param.Value;
        }*/

        public DataTable Consultar(string nombreSP)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cadenaconexion);
            SqlCommand cmd = new SqlCommand(nombreSP, con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            
            return dt;
        }
        //INSERTAR PRESUPUESTO
        public bool Insertar(string nombreSP,Presupuesto p)
        {
            conn.ConnectionString = cadenaconexion;
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                conn.Open();
                t = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(nombreSP, conn,t);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter presu_nro = new SqlParameter();

                presu_nro.ParameterName = "@presupuesto_nro";
                presu_nro.DbType = DbType.Int32;
                presu_nro.Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@cliente", p.Cliente);
                cmd.Parameters.AddWithValue("@dto", p.Descuento);
                cmd.Parameters.AddWithValue("@total", p.CalcularTotal());
                cmd.Parameters.Add(presu_nro);

                cmd.ExecuteNonQuery();
                int presupuestonro = (int)presu_nro.Value;
                int detallenro = 1;
                SqlCommand cmdDetalle;
                foreach (DetallePresupuesto dp in p.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@presupuesto_nro", presupuestonro);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detallenro);
                    cmdDetalle.Parameters.AddWithValue("@id_producto", dp.Producto.ProductoNro);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", dp.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    detallenro++;
                }
                t.Commit();
            }catch (Exception)
            {
                if(t!=null)
                {
                    t.Rollback();
                }

                resultado = false;
            }
            finally
            {
                if (conn!=null && conn.State==ConnectionState.Open)
                    conn.Close();
            }
                return resultado;
        }

        public void AgregarDetalle(DetallePresupuesto d, int presu,Presupuesto p,int detallenro)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_DETALLE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter idproducto = new SqlParameter("@id_producto", d.Producto.ProductoNro);
            SqlParameter detalle = new SqlParameter("@detalle", detallenro);
            SqlParameter presu_nro = new SqlParameter("@presupuesto_nro", presu);
            SqlParameter cantidad = new SqlParameter("@cantidad", d.Cantidad);

            presu_nro.DbType = DbType.Int32;
            presu_nro.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(presu_nro);

            detalle.DbType = DbType.Int32;
            detalle.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(detalle);

            idproducto.DbType = DbType.Int32;
            idproducto.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(idproducto);

            cantidad.DbType = DbType.Int32;
            cantidad.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(cantidad);

            cmd.ExecuteNonQuery();
        }

        //CONSULTAR PRESU
        public DataTable ConsultarConParametros(string nombreSP,List<Parametro> parametros)
        {
            /*DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cadenaconexion);
            SqlTransaction transaction = null;
            try
            {
                transaction = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;
                conn.Open();
                foreach (Parametro p in parametros)
                {
                    cmd.Parameters.AddWithValue(p.pNombre, p.pValor);
                }
                dt.Load(cmd.ExecuteReader());
                transaction.Commit();
            }catch (Exception ex) {
                //transaction.Rollback();
            }
            finally
            {
                if(conn!=null && conn.State==ConnectionState.Open)
                    conn.Close();
            }
            return dt;*/
            DataTable tabla = new DataTable();

            conn.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parametros != null)
            {
                foreach (Parametro oParametro in parametros)
                {
                    cmd.Parameters.AddWithValue(oParametro.pNombre, oParametro.pValor);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            conn.Close();

            return tabla;
        }

        public bool Ejecutar(string nombreSP) {
            bool res = false;
            SqlTransaction trans = null;
            try
            {
                SqlCommand cmd = new SqlCommand(nombreSP, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                trans=conn.BeginTransaction();
                conn.Open();
                int afectadas=cmd.ExecuteNonQuery();
                if (afectadas>0)
                {
                    res = true;
                    trans.Commit();
                }else
                    trans.Rollback();
            } catch (Exception ex)
            {
                trans.Rollback();
            }
            finally
            {
                conn.Close();
            }
            return res;
        }


        public bool EjecutarConParametros(string nombreSP,List<Parametro> parametros)
        {
            bool res = false;
            SqlTransaction trans = null;
            try
            {
                SqlCommand cmd = new SqlCommand(nombreSP, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                trans = conn.BeginTransaction();
                conn.Open();
                foreach (Parametro param in parametros) { 
                    cmd.Parameters.AddWithValue(param.pNombre,param.pValor);
                }
                int afectadas = cmd.ExecuteNonQuery();
                if (afectadas > 0)
                {
                    trans.Commit();
                    res = true;
                }
                else
                    trans.Rollback();
            }
            catch (Exception)
            {
                trans.Rollback();
                res = false;
            }
            finally
            {
                conn.Close();
            }
            return res;
        }

    }

}
