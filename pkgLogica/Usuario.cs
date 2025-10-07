using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testForms.pkgBaseDatos;

namespace testForms.pkgLogica
{
    internal class Usuario
    {
        Datos data = new Datos();
        public int fnc_registrarUsuario (
            string prm_nombre,
            string prm_mail,
            int prm_id,
            string prm_usuario,
            string prm_clave,
            string prm_fechaNac
            )
        {
            string sqlRegistroUsuario =
                "INSERT INTO Usuarios (usu_nombre, usu_mail, usu_id, usu_user, usu_clave, usu_fechaNac)" +
                "VALUES ('" + prm_nombre + "', '" + prm_mail + "', " + prm_id + ", '" + prm_usuario + "', '" + prm_clave + "', '" + prm_fechaNac + "')";
            return data.fnc_dml(sqlRegistroUsuario);
        }

        public int fnc_loginUsuario (string prm_usuario, string prm_clave)
        {
            string sql = $"SELECT fnc_login('{prm_usuario}', '{prm_clave}') FROM dual";

            object result = data.fnc_escalar(sql);

            if (result != null)
            {
                int valor = Convert.ToInt32(result);
                return valor; // 1 = login válido, 0 = inválido
            }
            else
            {
                return 0;
            }
        }
    }
}
