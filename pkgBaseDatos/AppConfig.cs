using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace testForms
{
    public class AppConfig
    {
        private static readonly string Key = "12345678901234567890123456789012"; // 32 caracteres
        private static readonly string IV = "1234567890123456"; // 16 caracteres

        public string Server { get; set; }
        public int Port { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public static AppConfig Load()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json.enc");

            if (!File.Exists(path))
                throw new FileNotFoundException($"No se encontró el archivo de configuración: {path}");

            try
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(Key);
                byte[] ivBytes = Encoding.UTF8.GetBytes(IV);
                byte[] cipherBytes = File.ReadAllBytes(path);

                using (Aes aes = Aes.Create())
                using (var decryptor = aes.CreateDecryptor(keyBytes, ivBytes))
                using (var ms = new MemoryStream(cipherBytes))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    string json = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<AppConfig>(json);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer la configuración: " + ex.Message);
            }
        }

    }

}
