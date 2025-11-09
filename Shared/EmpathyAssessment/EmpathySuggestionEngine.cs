using System;
using System.Collections.Generic;
using System.Linq;

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

    /// <summary>
    /// Motor de sugerencias empáticas: mapea texto de preguntas marcadas como "Sí" a heridas emocionales relevantes y construye paquetes de guía práctica.
    /// Uso: pasar la lista de preguntas afirmadas y obtener un conjunto agregado de acciones y frases para acompañar mejor a otros.
    /// </summary>
    public static class EmpathySuggestionEngine
    {
        /// <summary>
        /// Diccionario de términos clave (normalizados a minúsculas) que al aparecer en la pregunta indican asociación con una o más heridas.
        /// </summary>
        private static readonly Dictionary<string, List<string>> keywordToWounds = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
        {
            { "ignoras", new List<string>{ "rechazo", "abandono" } },
            { "interrumpes", new List<string>{ "rechazo" } },
            { "desapareciendo", new List<string>{ "abandono" } },
            { "ghosting", new List<string>{ "abandono" } },
            { "burlas", new List<string>{ "humillacion" } },
            { "sarcasmo", new List<string>{ "humillacion", "rechazo" } },
            { "comparas", new List<string>{ "humillacion", "injusticia" } },
            { "controlas", new List<string>{ "traicion" } },
            { "revisas su teléfono", new List<string>{ "traicion" } },
            { "infidelidad", new List<string>{ "traicion" } },
            { "gritas", new List<string>{ "rechazo", "humillacion" } },
            { "generalizaciones", new List<string>{ "injusticia" } },
            { "favoritismos", new List<string>{ "injusticia" } },
            { "excluyes", new List<string>{ "rechazo" } },
            { "ignoras a los nuevos", new List<string>{ "rechazo" } },
            { "rumores", new List<string>{ "humillacion", "rechazo" } },
            { "chismes", new List<string>{ "humillacion" } },
            { "ridiculizas", new List<string>{ "humillacion" } },
            { "promesas incumplidas", new List<string>{ "traicion" } },
            { "confidencias", new List<string>{ "traicion" } },
            { "castigos inconsistentes", new List<string>{ "injusticia" } },
            { "perfeccionismo", new List<string>{ "injusticia" } },
        };

        /// <summary>
        /// Genera un paquete agregado de sugerencias empáticas a partir de las preguntas afirmadas.
        /// </summary>
        /// <param name="affirmedQuestions">Enumeración de textos de preguntas marcadas como "Sí".</param>
        /// <returns>Instancia de <see cref="SuggestionBundle"/> con colecciones combinadas y sin duplicados.</returns>
        /// <exception cref="ArgumentNullException">Se lanza cuando affirmedQuestions es null.</exception>
        public static SuggestionBundle BuildSuggestions(IEnumerable<string> affirmedQuestions)
        {
            if (affirmedQuestions is null) throw new ArgumentNullException(nameof(affirmedQuestions));

            var woundIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var q in affirmedQuestions)
            {
                var lower = q.ToLowerInvariant();
                foreach (var kv in keywordToWounds)
                {
                    if (lower.Contains(kv.Key.ToLowerInvariant()))
                    {
                        foreach (var wid in kv.Value) woundIds.Add(wid);
                    }
                }
            }

            // Fallback: si ninguna coincidencia, incluir todas para ofrecer guía general (opcional)
            if (woundIds.Count == 0)
            {
                // Podríamos optar por vacío, pero se da un paquete general para no dejar sin guía.
                foreach (var w in EmotionalWoundData.Wounds) woundIds.Add(w.Id);
            }

            var bundle = new SuggestionBundle();
            bundle.WoundIds.AddRange(woundIds);

            foreach (var wid in woundIds)
            {
                var wound = EmotionalWoundData.GetById(wid);
                if (wound is null) continue;
                Merge(bundle.Phrases, wound.SupportPhrases);
                Merge(bundle.MicroPractices, wound.MicroPractices);
                Merge(bundle.SupportActions, wound.EmpathicSupportActions);
                Merge(bundle.MistakesToAvoid, wound.MistakesToAvoid);
                Merge(bundle.RepairPractices, wound.RepairPractices);
            }

            return bundle;
        }

        /// <summary>
        /// Agrega elementos de origen a destino evitando duplicados (comparación ordinal ignore case).
        /// </summary>
        /// <param name="destination">Lista destino que será extendida.</param>
        /// <param name="source">Colección de origen.</param>
        private static void Merge(List<string> destination, IEnumerable<string> source)
        {
            foreach (var item in source)
            {
                if (!destination.Any(x => string.Equals(x, item, StringComparison.OrdinalIgnoreCase)))
                {
                    destination.Add(item);
                }
            }
        }
    }
}
