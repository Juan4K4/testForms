using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle;

namespace testForms.pkgBaseDatos
{
    internal class Datos
    {
        private string connectionString = "User Id=C##TEST;Password=oracle;Data Source=locahost:1521/xe";
        public int fncEjecutarDML(string prmConsulta)
        {
            OracleConnection oracleConexion = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(prmConsulta, oracleConexion);
            int filasAlteradas = default;

            try
            {
                oracleConexion.Open();
                cmd.Connection = oracleConexion;
                filasAlteradas = cmd.ExecuteNonQuery();
                oracleConexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return filasAlteradas;
        }
    }
}
