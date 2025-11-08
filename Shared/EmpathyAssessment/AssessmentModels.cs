using System.Collections.Generic;

namespace BlazorApp.Shared.EmpathyAssessment
{
    /// <summary>
    /// Representa una categoría temática de la evaluación de empatía, que agrupa
    /// preguntas sobre un conjunto coherente de comportamientos y prácticas diarias
    /// sugeridas para mejorar.
    /// </summary>
    public class EmpathyCategory
    {
        /// <summary>
        /// Identificador corto (slug) único usado para ruteo y búsqueda.
        /// </summary>
        public string Id { get; set; } // slug for routing

        /// <summary>
        /// Título visible de la categoría mostrado en la interfaz.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Descripción breve que contextualiza el foco de la categoría.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Colección de preguntas diagnósticas asociadas a la categoría.
        /// </summary>
        public List<EmpathyQuestion> Questions { get; set; }

        /// <summary>
        /// Lista de prácticas diarias sugeridas (acciones concretas) para reforzar hábitos empáticos.
        /// </summary>
        public List<string> DailyPractices { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la categoría con colecciones y cadenas vacías
        /// para evitar referencias nulas en consumo de componentes Blazor.
        /// </summary>
        public EmpathyCategory()
        {
            Id = string.Empty;
            Title = string.Empty;
            Description = string.Empty;
            Questions = new List<EmpathyQuestion>();
            DailyPractices = new List<string>();
        }
    }

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
