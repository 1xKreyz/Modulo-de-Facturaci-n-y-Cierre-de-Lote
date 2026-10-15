using System;

namespace ejeeer123
{
    /// <summary>
    /// Motor de reglas de negocio para el Gestor de Tarifas. 
    /// Provee métodos de cálculo y control de excepciones para los módulos asociados.
    /// </summary>
    public static class GestorDeTarifas
    {
        /// <summary>
        /// Calcula el costo de envío de manera dinámica basándose en las métricas de peso, volumen y variables de negocio.
        /// </summary>
        /// <param name="peso">Peso del paquete en kilogramos (debe ser mayor a 0).</param>
        /// <param name="volumen">Volumen del paquete en metros cúbicos (debe ser mayor a 0).</param>
        /// <param name="tarifaBase">Tarifa base establecida por las políticas del sistema.</param>
        /// <returns>El costo de envío calculado (double).</returns>
        /// <exception cref="PaqueteInvalidoException">Se lanza si el peso o el volumen no cumplen con las reglas válidas.</exception>
        /// <exception cref="ExcepcionDeHilo">Se lanza si ocurre una incidencia imprevista en el procesamiento del hilo.</exception>
        public static double CalcularCostoEnvio(double peso, double volumen, double tarifaBase)
        {
            // 1. Validación de métricas de negocio (Peso / Volumen)
            if (peso <= 0 || volumen <= 0)
            {
                throw new PaqueteInvalidoException("Error: El peso y el volumen del paquete deben ser mayores estricto a cero.");
            }

            try
            {
                // 2. Variables de Negocio y Fórmula Dinámica
                double factorPeso = 4.5;
                double factorVolumen = 10.2;

                // Cálculo dinámico del costo de envío
                double costoEnvioCalculado = tarifaBase + (peso * factorPeso) + (volumen * factorVolumen);

                return costoEnvioCalculado;
            }
            catch (PaqueteInvalidoException)
            {
                // Propagamos explícitamente la excepción de negocio sin alterarla
                throw;
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otra falla y la convertimos en la ExcepcionDeHilo solicitada en el reto
                throw new ExcepcionDeHilo("Falla crítica en el hilo de cálculo de tarifas del sistema.", ex);
            }
        }
    }
}