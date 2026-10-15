using System;
using System.IO;
using System.Text;

namespace Módulos_de_criterio_y_de_servicio
{
    public class ServidorLogs
    {
        // Ruta donde se guardarán los registros.
        private readonly string rutaArchivo;

        // Evita que varios hilos escriban al mismo tiempo.
        private static readonly object bloqueo = new object();

        // Constructor de la clase.
        public ServidorLogs()
        {
            rutaArchivo = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "eventos.txt"
            );
        }

        // Registra un evento en el archivo.
        public void RegistrarEvento(string mensaje)
        {
            if (string.IsNullOrWhiteSpace(mensaje))
            {
                throw new ArgumentException(
                    "El mensaje no puede estar vacío.",
                    nameof(mensaje)
                );
            }

            string fechaHora = DateTime.Now.ToString(
                "yyyy-MM-dd HH:mm:ss"
            );

            string registro = $"[{fechaHora}] EVENTO: {mensaje}";

            lock (bloqueo)
            {
                File.AppendAllText(
                    rutaArchivo,
                    registro + Environment.NewLine,
                    Encoding.UTF8
                );
            }
        }

        // Registra un error en el archivo.
        public void RegistrarError(string mensaje)
        {
            if (string.IsNullOrWhiteSpace(mensaje))
            {
                throw new ArgumentException(
                    "El mensaje de error no puede estar vacío.",
                    nameof(mensaje)
                );
            }

            string fechaHora = DateTime.Now.ToString(
                "yyyy-MM-dd HH:mm:ss"
            );

            string registro = $"[{fechaHora}] ERROR: {mensaje}";

            lock (bloqueo)
            {
                File.AppendAllText(
                    rutaArchivo,
                    registro + Environment.NewLine,
                    Encoding.UTF8
                );
            }
        }
    }
}