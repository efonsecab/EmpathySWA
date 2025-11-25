namespace BlazorApp.Shared.EmpathyAssessment
{
    /// <summary>
    /// Pregunta específica utilizada para autoevaluar un comportamiento que puede afectar
    /// la empatía, incluyendo explicación del impacto y ejemplo concreto.
    /// </summary>
    public class EmpathyQuestion
    {
        /// <summary>
        /// Texto principal de la pregunta que se muestra al usuario.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Explicación del impacto emocional o relacional cuando el comportamiento ocurre.
        /// </summary>
        public string Explanation { get; set; } // Impacto emocional en otros cuando este comportamiento ocurre

        /// <summary>
        /// Ejemplo concreto que ilustra la conducta descrita en la pregunta.
        /// </summary>
        public string Example { get; set; } // Ejemplo concreto que ilustra la conducta

        /// <summary>
        /// Impacto personal (cómo afecta a quien lo practica) si el patrón se mantiene.
        /// </summary>
        public string SelfImpact { get; set; } // Impacto personal específico cuando se mantiene este patrón

        /// <summary>
        /// Referencia bíblica asociada que invita a la reflexión empática (solo referencia, sin texto con copyright).
        /// Ej.: "Filipenses 2:3-4" o "Juan 13:34-35".
        /// </summary>
        public string? BibleReference { get; set; }

        /// <summary>
        /// Inicializa una nueva pregunta con valores de texto vacíos para evitar nulos.
        /// </summary>
        public EmpathyQuestion()
        {
            Text = string.Empty;
            Explanation = string.Empty;
            Example = string.Empty;
            SelfImpact = string.Empty;
            BibleReference = null;
        }
    }
}
