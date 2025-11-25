using System.Collections.Generic;

namespace BlazorApp.Shared.EmpathyAssessment
{
    /// <summary>
    /// Representa un versículo bíblico asociado a temas de empatía y amor al prójimo.
    /// Contiene referencia, resumen temático, texto completo (versión dominio público/paráfrasis) y metadatos de énfasis.
    /// </summary>
    public class BibleVerse
    {
        /// <summary>Referencia del versículo (Libro capítulo:versículos), p.ej. "Filipenses 2:3-4".</summary>
        public string Reference { get; set; } = string.Empty;
        /// <summary>Resumen breve del énfasis empático del versículo.</summary>
        public string Summary { get; set; } = string.Empty;
        /// <summary>Texto completo base (dominio público) usado como fallback.</summary>
        public string Text { get; set; } = string.Empty;
        /// <summary>Nombre corto de la versión bíblica base almacenada en <see cref="Text"/>.</summary>
        public string Version { get; set; } = string.Empty;
        /// <summary>Indica si enfatiza directamente amar al prójimo o considerar a otros superiores.</summary>
        public bool HighlightLoveNeighbor { get; set; }
        /// <summary>Etiquetas temáticas ("humildad", "servicio", etc.).</summary>
        public List<string> Tags { get; set; } = new List<string>();
        /// <summary>
        /// Textos alternativos por versión (paráfrasis muy breve para estudio empático). Clave: código versión (RV1960, DHH, NVI, NTV, TLA).
        /// Para evitar problemas de copyright se emplean síntesis fieles, no texto literal completo.
        /// </summary>
        public Dictionary<string, string> VersionTexts { get; set; } = new Dictionary<string, string>();
    }
}
