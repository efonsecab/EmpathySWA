using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Shared.EmpathyAssessment
{
    /// <summary>
    /// Representa un versículo bíblico asociado a temas de empatía y amor al prójimo.
    /// Contiene referencia, resumen temático, texto completo (versión dominio público) y metadatos de énfasis.
    /// </summary>
    public class BibleVerse
    {
        /// <summary>
        /// Referencia del versículo (Libro capítulo:versículos), p.ej. "Filipenses 2:3-4".
        /// </summary>
        public string Reference { get; set; } = string.Empty;
        /// <summary>
        /// Resumen breve del énfasis empático del versículo.
        /// </summary>
        public string Summary { get; set; } = string.Empty;
        /// <summary>
        /// Texto completo del versículo (versión dominio público para evitar restricciones de copyright).
        /// </summary>
        public string Text { get; set; } = string.Empty;
        /// <summary>
        /// Nombre corto de la versión bíblica usada (ej. RVA, RV1909, WEB, LBLA-PD si corresponder). Debe ser una versión de dominio público.
        /// </summary>
        public string Version { get; set; } = string.Empty;
        /// <summary>
        /// Indica si enfatiza directamente amar al prójimo o considerar a otros superiores.
        /// </summary>
        public bool HighlightLoveNeighbor { get; set; }
        /// <summary>
        /// Etiquetas temáticas ("humildad", "servicio", etc.).
        /// </summary>
        public List<string> Tags { get; set; } = new List<string>();
    }

    /// <summary>
    /// Proveedor estático de versículos bíblicos de apoyo al aprendizaje empático.
    /// Usa solo textos en dominio público/paráfrasis fiel breve.
    /// </summary>
    public static class BibleVerseProvider
    {
        private static readonly System.Random rng = new System.Random();

        /// <summary>
        /// Lista inmutable de versículos (texto dominio público / paráfrasis fiel) relevantes a empatía.
        /// </summary>
        public static readonly IReadOnlyList<BibleVerse> Verses = new List<BibleVerse>
        {
            new BibleVerse { Reference = "Mateo 22:37-39", Summary = "Mandato central: amar a Dios y al prójimo.", Text = "Amarás al Señor tu Dios con todo tu corazón, con toda tu alma y con toda tu mente... Amarás a tu prójimo como a ti mismo.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "amor", "projimo" } },
            new BibleVerse { Reference = "Juan 13:34-35", Summary = "Amor visible como señal de discipulado.", Text = "Un mandamiento nuevo os doy: Que os améis unos a otros; como yo os he amado... En esto conocerán todos que sois mis discípulos, si tenéis amor unos a otros.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "amor", "testimonio" } },
            new BibleVerse { Reference = "Filipenses 2:3-4", Summary = "Humildad: considerar a otros superiores.", Text = "Nada hagáis por contienda o por vanagloria; antes bien con humildad estimando cada uno a los demás como superiores a él mismo. No mirando cada uno a lo suyo propio, sino también a lo de los otros.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "humildad", "servicio" } },
            new BibleVerse { Reference = "Romanos 12:10", Summary = "Amor fraternal y preferencia por el otro.", Text = "Amaos los unos a los otros con amor fraternal, en cuanto a honra, prefiriéndoos los unos a los otros.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "amor", "fraternidad" } },
            new BibleVerse { Reference = "Gálatas 5:13-14", Summary = "El amor al prójimo cumple la ley.", Text = "Servíos por amor los unos a los otros. Porque toda la ley en esta sola palabra se cumple: Amarás a tu prójimo como a ti mismo.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "libertad", "amor" } },
            new BibleVerse { Reference = "1 Juan 3:16-18", Summary = "Amor en hechos concretos.", Text = "En esto hemos conocido el amor, en que él puso su vida por nosotros; nosotros debemos poner nuestras vidas por los hermanos... No amemos de palabra ni de lengua, sino de hecho y en verdad.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "acciones", "sacrificio" } },
            new BibleVerse { Reference = "1 Juan 4:7-11", Summary = "Amar porque Dios nos amó primero.", Text = "Amados, amémonos unos a otros; porque el amor es de Dios... Si Dios así nos ha amado, también debemos amarnos unos a otros.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "amor", "origen" } },
            new BibleVerse { Reference = "1 Corintios 13:4-7", Summary = "Características del amor.", Text = "La caridad es sufrida, es benigna; la caridad no tiene envidia, la caridad no es jactanciosa... Todo lo sufre, todo lo cree, todo lo espera, todo lo soporta.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "caracter", "amor" } },
            new BibleVerse { Reference = "Efesios 4:2", Summary = "Humildad, mansedumbre, paciencia y amor.", Text = "Con toda humildad y mansedumbre, con longanimidad, soportándoos los unos a los otros en amor.", Version = "RV1909", HighlightLoveNeighbor = false, Tags = new List<string>{ "humildad", "paciencia" } },
            new BibleVerse { Reference = "Colosenses 3:12-14", Summary = "Vestirse de compasión y sobre todo amor.", Text = "Vestíos... de entrañas de misericordia, de benignidad, de humildad... Sobre todas estas cosas vestíos de caridad, que es el vínculo de la perfección.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "compasion", "amor" } },
            new BibleVerse { Reference = "Lucas 6:31", Summary = "Regla de oro.", Text = "Como queréis que los hombres hagan con vosotros, así también haced vosotros con ellos.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "regla-de-oro", "reciprocidad" } },
            new BibleVerse { Reference = "Gálatas 6:2", Summary = "Llevar cargas mutuas.", Text = "Sobrellevad los unos las cargas de los otros, y cumplid así la ley de Cristo.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "cargas", "apoyo" } },
            new BibleVerse { Reference = "Proverbios 19:17", Summary = "Compasión al necesitado.", Text = "A Jehová presta el que tiene misericordia del pobre, y el bien que ha hecho, se lo volverá a pagar.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "compasion", "pobreza" } },
            // añadidos previos
            new BibleVerse { Reference = "Efesios 4:29", Summary = "Hablar para edificar y dar gracia a quienes oyen.", Text = "Ninguna palabra corrompida salga de vuestra boca, sino la que sea buena para edificación, para que dé gracia a los oyentes.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "lenguaje", "edificacion" } },
            new BibleVerse { Reference = "Efesios 4:32", Summary = "Bondad, compasión y perdón mutuo.", Text = "Antes sed benignos unos con otros, misericordiosos, perdonándoos unos a otros, como Dios también os perdonó en Cristo.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "compasion", "perdon" } },
            new BibleVerse { Reference = "Colosenses 3:14", Summary = "El amor como vínculo perfecto.", Text = "Y sobre todas estas cosas vestíos de caridad, que es el vínculo de la perfección.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "amor", "vinculo" } },
            new BibleVerse { Reference = "Gálatas 5:14", Summary = "Toda la ley se resume en amar al prójimo.", Text = "Porque toda la ley en esta sola palabra se cumple: Amarás a tu prójimo como a ti mismo.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "ley", "amor" } },
            // nuevos solicitados por el usuario
            new BibleVerse { Reference = "Mateo 7:1-2", Summary = "No juzgar con vara ajena.", Text = "No juzguéis, para que no seáis juzgados. Porque con el juicio con que juzgáis, seréis juzgados; y con la medida con que medís, os será medido.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "juicio", "medida" } },
            new BibleVerse { Reference = "2 Juan 6", Summary = "Amor practicado en obediencia.", Text = "Y este es el amor: que andemos según sus mandamientos. Este es el mandamiento: que andéis en amor, como vosotros habéis oído desde el principio.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "obediencia", "amor" } },
            new BibleVerse { Reference = "Romanos 13:10", Summary = "El amor cumple la ley.", Text = "El amor no hace mal al prójimo; así que el cumplimiento de la ley es el amor.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "ley", "amor" } },
            new BibleVerse { Reference = "Gálatas 5:22-23", Summary = "Fruto del Espíritu.", Text = "Mas el fruto del Espíritu es amor, gozo, paz, paciencia, benignidad, bondad, fe, mansedumbre, templanza; contra tales cosas no hay ley.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "fruto", "caracter" } },
            new BibleVerse { Reference = "1 Juan 3:18", Summary = "Amar con hechos y verdad.", Text = "Hijitos míos, no amemos de palabra ni de lengua, sino de hecho y en verdad.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "acciones", "verdad" } },
            new BibleVerse { Reference = "1 Juan 4:20-21", Summary = "Incompatibilidad entre odiar al hermano y amar a Dios.", Text = "Si alguno dice: Yo amo a Dios, y aborrece a su hermano, es mentiroso... Y este mandamiento tenemos de él: El que ama a Dios, ame también a su hermano.", Version = "RV1909", HighlightLoveNeighbor = true, Tags = new List<string>{ "coherencia", "amor" } },
        };

        /// <summary>
        /// Obtiene versículos filtrados por etiqueta; etiqueta vacía devuelve todos.
        /// </summary>
        /// <param name="tag">Etiqueta temática (puede ser vacía).</param>
        /// <returns>Lista filtrada de versículos.</returns>
        public static IReadOnlyList<BibleVerse> GetByTag(string tag)
        {
            if (string.IsNullOrWhiteSpace(tag)) return Verses;
            return Verses.Where(v => v.Tags.Any(t => string.Equals(t, tag, System.StringComparison.OrdinalIgnoreCase))).ToList();
        }

        /// <summary>
        /// Obtiene un versículo aleatorio. Si se especifica etiqueta se filtra primero.
        /// </summary>
        /// <param name="tag">Etiqueta opcional (vacía para usar todos).</param>
        /// <returns>Versículo aleatorio seleccionado.</returns>
        public static BibleVerse GetRandom(string tag)
        {
            var source = string.IsNullOrWhiteSpace(tag) ? Verses : GetByTag(tag);
            if (source.Count == 0) return Verses[0];
            var idx = rng.Next(source.Count);
            return source[idx];
        }

        /// <summary>
        /// Obtiene un versículo por referencia exacta (ordinal ignore case).
        /// </summary>
        /// <param name="reference">Referencia bíblica (Libro cap:vers).</param>
        /// <returns>Instancia del versículo o null si no existe.</returns>
        public static BibleVerse GetByReference(string reference)
        {
            return Verses.FirstOrDefault(v => string.Equals(v.Reference, reference, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
