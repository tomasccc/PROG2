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
        SqlConnection conn;
        //string cadenaconexion = @"Data Source=172.16.10.196;Initial Catalog=Carpinteria_2023;User ID=alumno1w1;Password=alumno1w1";
        string cadenaconexion=@"Data Source=DESKTOP-KFQ7MV9\SQLEXPRESS;Initial Catalog=CARPINTERIA_2023;Integrated Security=True";
        //Data Source=172.16.10.196;Initial Catalog=Carpinteria_2023;User ID=alumno1w1;Password=alumno1w1

        public DBHelper()
        {
            conn = new SqlConnection(cadenaconexion);
        }
        public int ProximoPresupuesto()
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
        }

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
        public int Insertar(string nombreSP,Presupuesto p)
        {
            SqlConnection con = new SqlConnection(cadenaconexion);
            SqlCommand cmd = new SqlCommand(nombreSP, con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            SqlParameter presu_nro = new SqlParameter();

            presu_nro.ParameterName = "@presupuesto_nro";
            presu_nro.DbType = DbType.Int32;
            presu_nro.Direction = ParameterDirection.Output;

            cmd.Parameters.AddWithValue("@cliente", p.Cliente);
            cmd.Parameters.AddWithValue("@dto", p.Descuento);
            cmd.Parameters.AddWithValue("@total", p.CalcularTotal());
            cmd.Parameters.Add(presu_nro);
            

            con.Open();
            cmd.ExecuteNonQuery();
            int presupuestonro = (int)presu_nro.Value;
            con.Close();
            int detallenro = 1;
            foreach (DetallePresupuesto dp in p.Detalles)
            {
                AgregarDetalle(dp, presupuestonro,p,detallenro);
                detallenro++;
            }
            return presupuestonro;
        }

        public void AgregarDetalle(DetallePresupuesto d, int presu,Presupuesto p,int detallenro)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_DETALLE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter idproducto = new SqlParameter("@id_producto", d.Producto.ProductoNro);
            SqlParameter detalle = new SqlParameter("@detalle", detallenro);
            SqlParameter presu_nro = new SqlParameter("@presupuesto_nro", presu);
            SqlParameter cantidad = new SqlParameter("@cantidad", d.Cantidad);
            conn.Open();

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
            conn.Close();
        }

        public DataTable ConsultarConParametros(string nombreSP,List<Parametro> parametros)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cadenaconexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();
            con.Open();
            foreach (Parametro p in parametros)
            {
                cmd.Parameters.AddWithValue(p.nombre, p.valor);
            }
            dt.Load(cmd.ExecuteReader());
            con.Close();

            return dt;
        }

    }

}
