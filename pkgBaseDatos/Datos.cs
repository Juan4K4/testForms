using Oracle;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testForms.pkgBaseDatos
{
    internal class Datos
    {
        private const string connectionString = "User Id=C##TEST;Password=oracle;Data Source=localhost:1521/xe";
        public int fnc_dml(string prmConsulta)
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
                //Error de la BD
                MessageBox.Show(ex.Message);
            }

            return filasAlteradas;
        }

        public object fnc_escalar(string prmConsulta)
        {
            using (OracleConnection oracleConexion = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand(prmConsulta, oracleConexion))
            {
                try
                {
                    oracleConexion.Open();
                    object resultado = cmd.ExecuteScalar();
                    return resultado == DBNull.Value ? null : resultado;
                }
                catch (Oracle.ManagedDataAccess.Client.OracleException ex)
                {
                    MessageBox.Show($"Error de Oracle: {ex.Message}", "Error de base de datos",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inesperado: {ex.Message}", "Error general",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public int fnc_registrarUsuario(
            string prm_nombre,
            string prm_mail,
            long prm_id,
            string prm_usuario,
            string prm_clave,
            string prm_fechaNac
        )
            {
                using (OracleConnection oracleConexion = new OracleConnection(connectionString))
                using (OracleCommand cmd = new OracleCommand("fnc_registrar", oracleConexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("RETURN_VALUE", OracleDbType.Int64).Direction = ParameterDirection.ReturnValue;

                    cmd.Parameters.Add("prm_nombre", OracleDbType.Varchar2).Value = prm_nombre;
                    cmd.Parameters.Add("prm_correo", OracleDbType.Varchar2).Value = prm_mail;
                    cmd.Parameters.Add("prm_id", OracleDbType.Int64).Value = prm_id;
                    cmd.Parameters.Add("prm_usuario", OracleDbType.Varchar2).Value = prm_usuario;
                    cmd.Parameters.Add("prm_clave", OracleDbType.Varchar2).Value = prm_clave;
                    cmd.Parameters.Add("prm_fechaNac", OracleDbType.Date).Value = DateTime.Parse(prm_fechaNac);

                    try
                    {
                        oracleConexion.Open();
                        cmd.ExecuteNonQuery();

                        var oracleDecimal = (Oracle.ManagedDataAccess.Types.OracleDecimal)cmd.Parameters["RETURN_VALUE"].Value;
                        int resultado = oracleDecimal.ToInt32();
                        return resultado;
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show($"Error de Oracle: {ex.Message}");
                        return 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error general: {ex.Message}");
                        return 0;
                    }
                }
            }


        public (string outPrm_nombre, int outPrm_numeroCuenta, decimal outPrm_saldoCuenta)? fnc_obtenerInfoCuenta(long prm_idUsuario)
            {
                using (OracleConnection oracleConexion = new OracleConnection(connectionString))
                using (OracleCommand cmd = new OracleCommand("prc_infoCuenta", oracleConexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("prm_id", OracleDbType.Int64).Value = prm_idUsuario;
                    cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_cuentaNum", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_cuentaSaldo", OracleDbType.Decimal).Direction = ParameterDirection.Output;

                    try
                    {
                        oracleConexion.Open();
                        cmd.ExecuteNonQuery();

                        string nombre = cmd.Parameters["p_nombre"].Value.ToString();
                        int numeroCuenta = Convert.ToInt32(cmd.Parameters["p_cuentaNum"].Value.ToString());
                        decimal saldoCuenta = Convert.ToDecimal(cmd.Parameters["p_cuentaSaldo"].Value.ToString());

                        return (nombre, numeroCuenta, saldoCuenta);
                    }
                    catch (Oracle.ManagedDataAccess.Client.OracleException ex)
                    {
                        MessageBox.Show(ex.Message, "Error al obtener datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                }
            }

        public (string outPrm_correo, string outPrm_usuario, string outPrm_clave)? fnc_obtenerInfoCliente(long prm_idUsuario)
        {
            using (OracleConnection oracleConexion = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand("prc_infoCliente", oracleConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("prm_id", OracleDbType.Int64).Value = prm_idUsuario;
                cmd.Parameters.Add("p_mail", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_usuario", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_clave", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;

                try
                {
                    oracleConexion.Open();
                    cmd.ExecuteNonQuery();

                    string correo = cmd.Parameters["p_mail"].Value.ToString();
                    string usuario = cmd.Parameters["p_usuario"].Value.ToString();
                    string clave = cmd.Parameters["p_clave"].Value.ToString();

                    return (correo, usuario, clave);
                }
                catch (Oracle.ManagedDataAccess.Client.OracleException ex)
                {
                    MessageBox.Show(ex.Message, "Error al obtener datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
        }
        public int fnc_actualizarInfoCliente(long prm_idUsuario, string prm_correo, string prm_usuario, string prm_clave)
        {
            using (OracleConnection oracleConexion = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand("prc_actualizar_cliente", oracleConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("prm_id", OracleDbType.Int64).Value = prm_idUsuario;
                cmd.Parameters.Add("p_mail", OracleDbType.Varchar2, 50).Value = prm_correo;
                cmd.Parameters.Add("p_usuario", OracleDbType.Varchar2, 50).Value = prm_usuario;
                cmd.Parameters.Add("p_clave", OracleDbType.Varchar2, 50).Value = prm_clave;
                cmd.Parameters.Add("p_resultado", OracleDbType.Int64).Direction = ParameterDirection.Output;

                int resultado = Convert.ToInt32(cmd.Parameters["p_resultado"].Value);

                try
                {
                    oracleConexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToInt32(cmd.Parameters["p_resultado"].Value.ToString());

                }
                catch (Oracle.ManagedDataAccess.Client.OracleException ex)
                {
                    MessageBox.Show(ex.Message, "Error al actualizar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return resultado;
            }
        }

        public DataTable fnc_select(string prm_tabla)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = $"SELECT * FROM {prm_tabla}";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    using (OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        sqlDataAdapter.Fill(tabla);
                        return tabla;
                    }
                }
            }
        }
        public DataTable fnc_consultarMovimientos(long prm_idUsuario)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                using (OracleCommand cmd = new OracleCommand("prc_consultarMovimientos", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("prm_idUsuario", OracleDbType.Int64).Value = prm_idUsuario;
                    cmd.Parameters.Add("p_resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(cmd);
                    DataTable tabla = new DataTable();

                    try
                    {
                        oracleDataAdapter.Fill(tabla);
                        return tabla;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error BD: " + ex);
                        return null;
                    }
                }
            }
        }

        public (DateTime prmOut_fecha, int prmOut_referencia)? fnc_transferencia(long prm_idUsuario, int prm_destinatario, int prm_monto)
        {
            using (OracleConnection oracleConexion = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand("prc_transferencia", oracleConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("prm_idUsuario", OracleDbType.Int64).Value = prm_idUsuario;
                cmd.Parameters.Add("prm_cuenta_destinatario", OracleDbType.Int64).Value = prm_destinatario;
                cmd.Parameters.Add("prm_monto", OracleDbType.Int64).Value = prm_monto;
                cmd.Parameters.Add("prm_fecha", OracleDbType.TimeStamp).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("prm_referencia", OracleDbType.Int64).Direction = ParameterDirection.Output;

                try
                {
                    oracleConexion.Open();
                    cmd.ExecuteNonQuery();

                    DateTime fecha_movimiento = Convert.ToDateTime(cmd.Parameters["prm_fecha"].Value.ToString());
                    int referencia = int.Parse(cmd.Parameters["prm_referencia"].Value.ToString());

                    return (fecha_movimiento, referencia);
                }
                catch (Oracle.ManagedDataAccess.Client.OracleException ex)
                {
                    MessageBox.Show(ex.Message, "Error al obtener datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
        }

        public (
            decimal  outP_saldoInicio, 
            decimal  outP_ingresos, 
            decimal  outP_egresos,
            decimal  outP_saldoFin, 
            DateTime outP_fechaInicio, 
            DateTime outP_fechaFin
            )? 
            fnc_generarExtracto (long prm_idUsuario, DateTime prm_periodo)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                using (OracleCommand cmd = new OracleCommand("prc_extracto", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("prm_id", OracleDbType.Int64).Value = prm_idUsuario;
                    cmd.Parameters.Add("prm_periodo", OracleDbType.Date).Value = prm_periodo;

                    cmd.Parameters.Add("outP_saldoInicio", OracleDbType.Decimal).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("outP_ingresos", OracleDbType.Decimal).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("outP_egresos", OracleDbType.Decimal).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("outP_saldoFin", OracleDbType.Decimal).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("outP_fechaInicio", OracleDbType.Date).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("outP_fechaFin", OracleDbType.Date).Direction = ParameterDirection.Output;

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        decimal saldoInicio = decimal.Parse(cmd.Parameters["outP_saldoInicio"].Value.ToString());
                        decimal ingresos = decimal.Parse(cmd.Parameters["outP_ingresos"].Value.ToString());
                        decimal egresos = decimal.Parse(cmd.Parameters["outP_egresos"].Value.ToString());
                        decimal saldoFin = decimal.Parse(cmd.Parameters["outP_saldoFin"].Value.ToString());
                        DateTime fechaInicio = DateTime.Parse(cmd.Parameters["outP_fechaInicio"].Value.ToString());
                        DateTime fechaFin = DateTime.Parse(cmd.Parameters["outP_fechaFin"].Value.ToString());

                        return (saldoInicio, ingresos, egresos, saldoFin, fechaInicio, fechaFin);
                    }
                    catch (Oracle.ManagedDataAccess.Client.OracleException ex)
                    {
                        MessageBox.Show(ex.Message, "Error al obtener datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                }
            }
        }
    }
}
