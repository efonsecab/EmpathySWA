using System.Collections.Generic;

namespace BlazorApp.Shared.EmpathyAssessment
{
    /// <summary>
    /// Conjunto agregado de sugerencias empáticas derivadas de una o varias heridas emocionales relacionadas a patrones marcados en la evaluación.
    /// Combina frases, micro-prácticas, acciones de apoyo, errores a evitar y prácticas de reparación para ofrecer respuesta concreta.
    /// </summary>
    public class SuggestionBundle
    {
        /// <summary>
        /// Lista de identificadores de heridas que originan estas sugerencias (puede haber más de una por patrón observado).
        /// </summary>
        public List<string> WoundIds { get; set; } = new List<string>();
        /// <summary>
        /// Frases empáticas sugeridas para validar y acompañar.
        /// </summary>
        public List<string> Phrases { get; set; } = new List<string>();
        /// <summary>
        /// Micro-prácticas inmediatas (baja inversión de tiempo) recomendadas.
        /// </summary>
        public List<string> MicroPractices { get; set; } = new List<string>();
        /// <summary>
        /// Acciones empáticas de apoyo (más extensas o relacionales).
        /// </summary>
        public List<string> SupportActions { get; set; } = new List<string>();
        /// <summary>
        /// Errores frecuentes a evitar.
        /// </summary>
        public List<string> MistakesToAvoid { get; set; } = new List<string>();
        /// <summary>
        /// Prácticas de reparación que se pueden facilitar o promover.
        /// </summary>
        public List<string> RepairPractices { get; set; } = new List<string>();
    }
}
