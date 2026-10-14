using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Generador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrarLote_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Llamadas estrictas requeridas por el enunciado (Temas 9 y 10)
                var rawHistorial = ServidorLogs.ObtenerHistorial();
                var rawTotal = GestorTarifas.ObtenerTotalFacturado();

                // Normalización compatible con cualquier tipo de retorno que definan los Temas 9 y 10
                string historialTexto = NormalizarHistorial(rawHistorial);
                decimal totalFacturado = Convert.ToDecimal(rawTotal);

                // Actualizar vistas parciales en pantalla
                lblMontoTotal.Text = $"$ {totalFacturado:N2}";
                txtHistorialLogs.Text = string.IsNullOrWhiteSpace(historialTexto)
                    ? "[Sin registros de auditoría]"
                    : historialTexto;

                // 2. Punto Bloqueante: Confirmar que no hay errores grabados en la auditoría
                if (ContieneErroresDeAuditoria(historialTexto))
                {
                    lblEstadoLote.Text = "Estado: CIERRE BLOQUEADO (Errores en Auditoría)";
                    lblEstadoLote.ForeColor = Color.FromArgb(255, 85, 85);

                    MessageBox.Show(
                        "No es posible cerrar el lote: Se detectaron errores grabados en el historial de auditoría.",
                        "Punto Bloqueante — Auditoría",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // 3. Construcción del Reporte Consolidado
                StringBuilder reporte = new StringBuilder();
                reporte.AppendLine("==========================================");
                reporte.AppendLine("     REPORTE CONSOLIDADO DE FIN DE TURNO  ");
                reporte.AppendLine("==========================================");
                reporte.AppendLine($"Fecha/Hora de Cierre : {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                reporte.AppendLine($"Total Procesado      : $ {totalFacturado:N2}");
                reporte.AppendLine("------------------------------------------");
                reporte.AppendLine("AUDITORÍA DE LOGS (TEMA 9):");
                reporte.AppendLine(string.IsNullOrWhiteSpace(historialTexto) ? "Sin incidencias." : historialTexto);
                reporte.AppendLine("------------------------------------------");
                reporte.AppendLine("VERIFICACIÓN         : SIN ERRORES GRABADOS");
                reporte.AppendLine("ESTADO FINAL         : LOTE CERRADO");
                reporte.AppendLine("==========================================");

                txtReporteConsolidado.Text = reporte.ToString();

                // 4. Guardar el resumen en un archivo físico para cerrar el lote
                string rutaArchivo = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    $"ReporteConsolidado_{DateTime.Now:yyyyMMdd_HHmmss}.txt");

                File.WriteAllText(rutaArchivo, reporte.ToString(), Encoding.UTF8);

                // 5. Confirmación visual de Lote Cerrado
                lblEstadoLote.Text = "Estado: LOTE CERRADO Y ARCHIVO GUARDADO";
                lblEstadoLote.ForeColor = Color.FromArgb(80, 250, 123);
                btnCerrarLote.Enabled = false;

                MessageBox.Show(
                    $"Lote cerrado exitosamente.\n\nArchivo físico generado en:\n{rutaArchivo}",
                    "Cierre de Lote Completado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió una anomalía durante el cierre de lote:\n{ex.Message}",
                    "Error de Integración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private string NormalizarHistorial(object? historial)
        {
            if (historial == null) return string.Empty;
            if (historial is IEnumerable<string> coleccion)
            {
                return string.Join(Environment.NewLine, coleccion);
            }
            return historial.ToString() ?? string.Empty;
        }

        private bool ContieneErroresDeAuditoria(string historial)
        {
            if (string.IsNullOrWhiteSpace(historial)) return false;

            string textoUpper = historial.ToUpperInvariant();
            return textoUpper.Contains("ERROR") ||
                   textoUpper.Contains("CRITICAL") ||
                   textoUpper.Contains("EXCEPCION") ||
                   textoUpper.Contains("EXCEPTION") ||
                   textoUpper.Contains("FALLO");
        }
    }

    // =========================================================================
    // CLASES DE PRUEBA LOCAL (ELIMINAR AL UNIR LOS ARCHIVOS DE LOS TEMAS 9 Y 10)
    // =========================================================================
    public static class ServidorLogs
    {
        public static List<string> ObtenerHistorial()
        {
            return new List<string>
            {
                "[INFO] 08:00 - Inicio de turno registrado.",
                "[INFO] 10:15 - Transacción procesada correctamente.",
                "[INFO] 12:30 - Sincronización de tarifas completada.",
                "[INFO] 16:00 - Solicitud de cierre de turno."
            };
        }
    }

    public static class GestorTarifas
    {
        public static decimal ObtenerTotalFacturado()
        {
            return 14580.50m;
        }
    }
}