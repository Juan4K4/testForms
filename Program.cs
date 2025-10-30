﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.pkgInterfaz;

namespace testForms
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Suscribirse al evento Application.ThreadExit para limpieza (opcional)
            Application.ThreadExit += (s, e) => { };

            // Crear un manejador global para cuando se crea cualquier formulario
            Application.ApplicationExit += (s, e) => { };

            // Hook global: cada vez que se muestra un form, aplicamos la configuración
            Application.OpenForms.Cast<Form>().ToList().ForEach(AutoConfigurarControles);
            Application.Idle += (s, e) =>
            {
                foreach (Form frm in Application.OpenForms)
                {
                    AutoConfigurarControles(frm);
                }
            };
            Application.Run(new formLogin());
        }

        /// <summary>
        /// Recorre todos los controles de un Form y activa AutoSize si la propiedad existe.
        /// </summary>
        static void AutoConfigurarControles(Control root)
        {
            try
            {
                foreach (Control ctrl in root.Controls)
                {
                    if (ctrl is PictureBox pic) { continue; }
                    if (ctrl is placeHolderBox) { continue; }
                    // Intentar establecer AutoSize = true si existe la propiedad
                    var prop = ctrl.GetType().GetProperty("AutoSize");
                    if (prop != null && prop.CanWrite)
                    {
                        prop.SetValue(ctrl, true, null);
                    }

                    // Aplicar recursivamente a subcontroles
                    if (ctrl.HasChildren)
                        AutoConfigurarControles(ctrl);
                }
            }
            catch
            {
                // Ignorar controles que no soportan AutoSize o lanzan error
            }
        }
    }

    public static class FormHelper
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        
        public static void HabilitarMovimiento(Form form, params Control[] controlesPermitidos)
        {
            // Permite mover haciendo click sobre el form (fondo)
            form.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
            };

            // Permite mover desde los controles específicos (paneles, etiquetas, etc)
            foreach (Control ctrl in controlesPermitidos)
            {
                ctrl.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        ReleaseCapture();
                        SendMessage(form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                    }
                };
            }
        }
    }
}
