using System.Collections.Generic;

namespace BlazorApp.Shared.EmpathyAssessment
{
    /// <summary>
    /// Representa una herida emocional primaria (rechazo, abandono, humillación, traición, injusticia) y su impacto en la empatía.
    /// Contiene descripciones de origen, patrones defensivos, distorsiones relacionales y prácticas para acompañar con empatía.
    /// </summary>
    public class EmotionalWound
    {
        /// <summary>
        /// Identificador único (slug) para ruteo y búsqueda. Ej: "rechazo".
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Nombre visible de la herida emocional.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Descripción breve del núcleo de la herida: qué sensación esencial produce.
        /// </summary>
        public string CoreDescription { get; set; } = string.Empty;
        /// <summary>
        /// Posibles orígenes típicos (experiencias comunes) que pueden contribuir al desarrollo de la herida.
        /// </summary>
        public List<string> CommonOrigins { get; set; } = new List<string>();
        /// <summary>
        /// Patrones defensivos frecuentes que pueden aparecer cuando la herida se activa.
        /// </summary>
        public List<string> DefensivePatterns { get; set; } = new List<string>();
        /// <summary>
        /// Distorsiones relacionales o creencias que afectan la interpretación de las acciones de otros cuando la herida está activa.
        /// </summary>
        public List<string> RelationalDistortions { get; set; } = new List<string>();
        /// <summary>
        /// Señales internas o externas (emocionales, físicas, cognitivas, conductuales) que podrías observar cuando se activa la herida.
        /// </summary>
        public List<string> ActivationSignals { get; set; } = new List<string>();
        /// <summary>
        /// Preguntas de reflexión para quien acompaña: ayudan a mantener una actitud empática hacia la persona herida.
        /// </summary>
        public List<string> ReflectionQuestions { get; set; } = new List<string>();
        /// <summary>
        /// Acciones concretas para acompañar con empatía a una persona cuya herida esté activa (qué hacer / cómo interactuar).
        /// </summary>
        public List<string> EmpathicSupportActions { get; set; } = new List<string>();
        /// <summary>
        /// Frases empáticas sugeridas (micro-validaciones) que pueden ayudar a reconocer la experiencia de la persona sin juzgar.
        /// </summary>
        public List<string> SupportPhrases { get; set; } = new List<string>();
        /// <summary>
        /// Errores frecuentes a evitar al acompañar (conductas que pueden reactivar o profundizar la herida).
        /// </summary>
        public List<string> MistakesToAvoid { get; set; } = new List<string>();
        /// <summary>
        /// Prácticas de reparación que puedes promover o facilitar en la persona, sin imponer ni controlar su proceso.
        /// </summary>
        public List<string> RepairPractices { get; set; } = new List<string>();
        /// <summary>
        /// Micro-prácticas inmediatas (30-120 segundos) que cualquier persona puede aplicar en el momento para generar seguridad empática.
        /// </summary>
        public List<string> MicroPractices { get; set; } = new List<string>();
    }
}
