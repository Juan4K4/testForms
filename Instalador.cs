using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Runtime.InteropServices;

namespace testForms
{
    [RunInstaller(true)]
    public partial class Instalador : Installer
    {
        [DllImport("gdi32.dll")]
        private static extern int AddFontResource(string lpFileName);

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int wMsg, int wParam, int lParam);

        private const int HWND_BROADCAST = 0xffff;
        private const int WM_FONTCHANGE = 0x001D;

        public Instalador()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            try
            {
                // Obtiene el directorio donde se instaló la aplicación
                string targetDir = Context.Parameters["targetdir"];
                string fontsDir = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);

                if (string.IsNullOrEmpty(targetDir) || !Directory.Exists(targetDir))
                    return;

                // Busca todos los archivos .ttf dentro del directorio de instalación
                string[] fontFiles = Directory.GetFiles(targetDir, "*.ttf", SearchOption.AllDirectories);

                foreach (string fontPath in fontFiles)
                {
                    try
                    {
                        string fontName = Path.GetFileName(fontPath);
                        string destFontPath = Path.Combine(fontsDir, fontName);

                        // Copia la fuente solo si no existe ya en Windows\Fonts
                        if (!File.Exists(destFontPath))
                        {
                            File.Copy(fontPath, destFontPath, true);
                            AddFontResource(destFontPath);
                            SendMessage(HWND_BROADCAST, WM_FONTCHANGE, 0, 0);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error instalando fuente {fontPath}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error general en Instalador: {ex.Message}");
            }
        }

        protected override void OnCommitted(IDictionary savedState)
        {
            // Llama siempre al método base
            base.OnCommitted(savedState);
        }

        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);

            try
            {
                // (Opcional) Si deseas eliminar las fuentes al desinstalar,
                // puedes agregar aquí el mismo código de búsqueda y eliminar los .ttf del sistema.
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al desinstalar fuentes: {ex.Message}");
            }
        }
    }
}
