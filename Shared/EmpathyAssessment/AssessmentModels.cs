using System.Collections.Generic;

namespace BlazorApp.Shared.EmpathyAssessment
{
    public class EmpathyCategory
    {
        public string Id { get; set; } // slug for routing
        public string Title { get; set; }
        public string Description { get; set; }
        public List<EmpathyQuestion> Questions { get; set; }
        public List<string> DailyPractices { get; set; }

        public EmpathyCategory()
        {
            Id = string.Empty;
            Title = string.Empty;
            Description = string.Empty;
            Questions = new List<EmpathyQuestion>();
            DailyPractices = new List<string>();
        }
    }

    public class EmpathyQuestion
    {
        public string Text { get; set; }
        public string Explanation { get; set; } // Impacto emocional en otros cuando este comportamiento ocurre
        public string Example { get; set; } // Ejemplo concreto que ilustra la conducta
        public string SelfImpact { get; set; } // Impacto personal específico cuando se mantiene este patrón
        public EmpathyQuestion()
        {
            Text = string.Empty;
            Explanation = string.Empty;
            Example = string.Empty;
            SelfImpact = string.Empty;
        }
    }
}
