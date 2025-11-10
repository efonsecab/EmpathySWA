using System.Collections.Generic;
using System.Linq;

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

    /// <summary>
    /// Proveedor estático de versículos bíblicos de apoyo al aprendizaje empático.
    /// Usa solo textos dominio público o paráfrasis resumidas para propósitos pedagógicos.
    /// </summary>
    public static class BibleVerseProvider
    {
        private static readonly System.Random rng = new System.Random();

        /// <summary>Lista inmutable de versículos (texto dominio público / paráfrasis fiel breve) relevantes a empatía.</summary>
        public static readonly IReadOnlyList<BibleVerse> Verses = new List<BibleVerse>
        {
            // Ejemplo: cada versión alternativa es síntesis (no texto completo) para evitar copiar contenido protegido.
            new BibleVerse {
                Reference = "Filipenses 2:3-4",
                Summary = "Humildad: considerar a otros superiores.",
                Text = "Nada hagáis por contienda... estimando a los demás superiores; mirando también por lo de otros.",
                Version = "RV1909",
                HighlightLoveNeighbor = true,
                Tags = new List<string>{ "humildad", "servicio" },
                VersionTexts = new Dictionary<string,string>{
                    {"RV1960","No hagan nada por rivalidad; con humildad consideren a otros superiores, atendiendo también a lo de ellos."},
                    {"DHH","No actúen por orgullo; sean humildes y vean a los demás como más importantes, cuidando sus intereses."},
                    {"NVI","No hagan nada por egoísmo; con humildad valoren a otros y vean también por los intereses ajenos."},
                    {"NTV","No sean egoístas; sean humildes y piensen en los demás, interesándose en lo que les importa."},
                    {"TLA","No sean orgullosos; traten a los demás como más importantes y ayúdenlos en lo que necesitan."}
                }
            },
            new BibleVerse {
                Reference = "1 Corintios 13:4-7",
                Summary = "Características del amor.",
                Text = "La caridad es sufrida y benigna; no envidia, no se ensoberbece... todo lo soporta.",
                Version = "RV1909",
                HighlightLoveNeighbor = true,
                Tags = new List<string>{ "caracter", "amor" },
                VersionTexts = new Dictionary<string,string>{
                    {"RV1960","El amor es paciente y bondadoso; no es envidioso ni altivo; todo lo soporta."},
                    {"DHH","El amor es paciente y servicial; no presume ni busca su propio interés; aguanta y confía."},
                    {"NVI","El amor es paciente, es bondadoso; no se jacta ni se enorgullece; siempre persevera."},
                    {"NTV","El amor es paciente y amable; no es celoso ni orgulloso; nunca se da por vencido."},
                    {"TLA","Quien ama es paciente y bueno; no presume ni se enoja fácil; confía y resiste."}
                }
            },
            new BibleVerse {
                Reference = "Mateo 7:1-2",
                Summary = "No juzgar con vara ajena.",
                Text = "No juzguéis para que no seáis juzados; con la medida que medís os medirán.",
                Version = "RV1909",
                HighlightLoveNeighbor = true,
                Tags = new List<string>{ "juicio", "medida" },
                VersionTexts = new Dictionary<string,string>{
                    {"RV1960","No juzguen, para que no los juzguen; con la medida que midan se les medirá."},
                    {"DHH","No condenen a otros para que Dios no los condene; la medida que usan se usará con ustedes."},
                    {"NVI","No juzguen, para que no sean juzgados; con la medida que midan se les medirá."},
                    {"NTV","No juzguen a los demás y no serán juzgados; el trato que den se les dará."},
                    {"TLA","No critiquen para no ser criticados; recibirán el mismo trato que den."}
                }
            },
            new BibleVerse {
                Reference = "Gálatas 6:2",
                Summary = "Llevar cargas mutuas.",
                Text = "Sobrellevad las cargas unos de otros y cumplid así la ley de Cristo.",
                Version = "RV1909",
                HighlightLoveNeighbor = true,
                Tags = new List<string>{ "cargas", "apoyo" },
                VersionTexts = new Dictionary<string,string>{
                    {"RV1960","Ayúdense a llevar las cargas y cumplirán la ley de Cristo."},
                    {"DHH","Ayúdense mutuamente a soportar las cargas; así obedecen la ley de Cristo."},
                    {"NVI","Lleven los unos las cargas de los otros y cumplirán la ley de Cristo."},
                    {"NTV","Ayuden a llevar las cargas de los demás y obedecerán la ley de Cristo."},
                    {"TLA","Apóyense en sus problemas y así obedecen a Cristo."}
                }
            },
            new BibleVerse {
                Reference = "1 Juan 3:18",
                Summary = "Amar con hechos y verdad.",
                Text = "No amemos de palabra sino de hecho y en verdad.",
                Version = "RV1909",
                HighlightLoveNeighbor = true,
                Tags = new List<string>{ "acciones", "verdad" },
                VersionTexts = new Dictionary<string,string>{
                    {"RV1960","No amemos solo con palabras, sino con hechos y de verdad."},
                    {"DHH","No demostremos amor solo con palabras; que se vea en hechos y sinceridad."},
                    {"NVI","No amemos de palabra ni de labios, sino con hechos y de verdad."},
                    {"NTV","No nos limitemos a decir que amamos; demostremos con acciones sinceras."},
                    {"TLA","No digan que aman y no hagan nada; el amor se prueba con hechos."}
                }
            },
            // Se podrían continuar añadiendo versiones sintéticas para el resto
        };

        /// <summary>Obtiene versículos filtrados por etiqueta; etiqueta vacía devuelve todos.</summary>
        public static IReadOnlyList<BibleVerse> GetByTag(string tag)
        {
            if (string.IsNullOrWhiteSpace(tag)) return Verses;
            return Verses.Where(v => v.Tags.Any(t => string.Equals(t, tag, System.StringComparison.OrdinalIgnoreCase))).ToList();
        }

        /// <summary>Obtiene un versículo aleatorio. Si se especifica etiqueta se filtra primero.</summary>
        public static BibleVerse GetRandom(string tag)
        {
            var source = string.IsNullOrWhiteSpace(tag) ? Verses : GetByTag(tag);
            if (source.Count == 0) return Verses[0];
            var idx = rng.Next(source.Count);
            return source[idx];
        }

        /// <summary>Obtiene un versículo por referencia exacta (ordinal ignore case).</summary>
        public static BibleVerse GetByReference(string reference)
        {
            return Verses.FirstOrDefault(v => string.Equals(v.Reference, reference, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
