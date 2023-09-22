using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria1w2.Datos
{
    public class HelperDAO
    {
        private static HelperDAO instancia;
        SqlConnection conn = new SqlConnection();
        string cadenaconexion = @"Data Source=172.16.10.196;Initial Catalog=Carpinteria_2023;User ID=alumno1w1;Password=alumno1w1";
        //string cadenaconexion=@"Data Source=DESKTOP-KFQ7MV9\SQLEXPRESS;Initial Catalog=CARPINTERIA_2023;Integrated Security=True";
        private HelperDAO() {
            /*nose si va con comillas o no
             --dentro de properties _ recursos*/
            conn = new SqlConnection(Properties.Resources.CadenaConexionCASA);
            //conn = new SqlConnection(cadenaconexion);
        }

        public static HelperDAO getInstance()
        {
            if (instancia==null)
                instancia = new HelperDAO();
            return instancia;
        }

        public int ConsultarEscalar(string nombreSP,string nombreParametroOut)
        {
            SqlCommand cmd = new SqlCommand(nombreSP, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param.ParameterName = nombreParametroOut;
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

    }
}
