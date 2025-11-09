using System.Collections.Generic;
using System.Linq;

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

    /// <summary>
    /// Proveedor estático de datos sobre las cinco heridas emocionales y sus guías empáticas.
    /// </summary>
    public static class EmotionalWoundData
    {
        /// <summary>
        /// Lista inmutable con las cinco heridas emocionales y sus atributos empáticos.
        /// </summary>
        public static readonly IReadOnlyList<EmotionalWound> Wounds = new List<EmotionalWound>
        {
            new EmotionalWound
            {
                Id = "rechazo",
                Name = "Rechazo",
                CoreDescription = "Sensación de no ser digno de pertenecer o ser elegido; miedo a ser ignorado o excluido.",
                CommonOrigins = new List<string>{ "Comentarios despectivos constantes en infancia", "Preferencias marcadas por parte de cuidadores hacia otros hermanos", "Experiencias tempranas de bullying" },
                DefensivePatterns = new List<string>{ "Autoaislamiento preventive", "Descalificar antes de que descalifiquen", "Frialdad emocional para evitar exposición" },
                RelationalDistortions = new List<string>{ "Si no responden rápido es porque no me quieren", "Si discrepan conmigo me están invalidando", "Si no me buscan primero soy irrelevante" },
                ActivationSignals = new List<string>{ "Tensión en pecho", "Pensamiento repetitivo 'no importo'", "Necesidad urgente de retirarse" },
                ReflectionQuestions = new List<string>{ "¿Hay evidencia objetiva de rechazo o lo estoy interpretando así?", "¿Qué otra explicación benigna existe?", "¿Cómo puedo mostrar inclusión activa ahora?" },
                EmpathicSupportActions = new List<string>{ "Nombrar explícitamente la inclusión: ‘Me importa tu opinión, ¿qué piensas?’", "Invitar sin presión y aceptar un ‘no’ sin retirar el vínculo", "Evitar bromas o comparaciones que refuercen exclusión", "Dar feedback con permiso y ejemplos concretos y amables", "Contactar de forma proactiva y breve para mostrar presencia", "Celebrar contribuciones pequeñas públicamente", "Practicar mencionar su nombre en grupo para integrar" },
                SupportPhrases = new List<string>{ "Gracias por estar aquí, tu presencia importa.", "¿Te gustaría sumarte a esto? Si no, igual seguimos contando contigo.", "Veo tu aporte y quiero reconocerlo.", "Si algo te hizo sentir fuera, avísame para corregirlo.", "Tu perspectiva suma, compártela cuando quieras." },
                MistakesToAvoid = new List<string>{ "Burlarse de la sensibilidad", "Ignorar sistemáticamente sus mensajes", "Comparar negativamente con otra persona", "Presionar para que hable sin crear seguridad", "Hacer bromas internas excluyentes frente a la persona" },
                RepairPractices = new List<string>{ "Proponer espacios seguros de participación (turnos de palabra)", "Validar emociones antes de debatir ideas", "Celebrar contribuciones específicas en público o en privado", "Fomentar micro-acciones de pertenencia (saludo por nombre)", "Acordar rituales simples de bienvenida e integración" },
                MicroPractices = new List<string>{ "Saludar por su nombre mirando a los ojos", "Hacer una pregunta abierta breve sobre su opinión", "Reflejar una idea que expresó para mostrar escucha", "Enviar mensaje corto de ‘aquí estoy’", "Invitar a una micro-tarea compartida (ej: revisar algo juntos 1 minuto)" }
            },
            new EmotionalWound
            {
                Id = "abandono",
                Name = "Abandono",
                CoreDescription = "Sensación de quedar solo sin apoyo estable; miedo a que los vínculos se desvanezcan.",
                CommonOrigins = new List<string>{ "Separaciones abruptas sin explicación", "Inconsistencia emocional de figuras de apego", "Pérdidas tempranas significativas" },
                DefensivePatterns = new List<string>{ "Hipervigilancia de disponibilidad ajena", "Exigir respuesta inmediata", "Sobre-adaptación para evitar perder el vínculo" },
                RelationalDistortions = new List<string>{ "Si tarda en contestar me va a dejar", "Si pide espacio es que ya no me quiere", "Debo agradar siempre para que se quede" },
                ActivationSignals = new List<string>{ "Nudo en estómago", "Chequeo compulsivo del teléfono", "Miedo intenso a ser olvidado" },
                ReflectionQuestions = new List<string>{ "¿Estoy confundiendo demora con abandono?", "¿Qué seguridad concreta puedo ofrecer sin prometer de más?", "¿Cómo cuido su necesidad y mis límites?" },
                EmpathicSupportActions = new List<string>{ "Acordar tiempos de respuesta realistas y cumplirlos", "Enviar confirmación breve de recepción cuando no puedas responder aún", "Nombrar límites con calidez: ‘Necesito X tiempo y sigo aquí’", "Cumplir microcompromisos para fortalecer previsibilidad", "Recordar explícitamente la continuidad del vínculo (‘seguimos en esto’)", "Avisar anticipadamente cuando te ausentarás", "Evitar desapariciones bruscas ante conflicto" },
                SupportPhrases = new List<string>{ "Estoy aquí, aunque ahora no pueda responder largo.", "Necesito un rato para X y después te escribo.", "Gracias por expresar lo que necesitas, lo valoro.", "No te estoy dejando; requiero espacio breve y luego retomamos.", "Podemos buscar juntos otras fuentes de apoyo también." },
                MistakesToAvoid = new List<string>{ "Prometer disponibilidad que no podrás sostener", "Dejar ‘en visto’ prolongado sin contexto", "Retirar afecto como castigo", "Invalidar su ansiedad con ‘exageras’", "Desaparecer en medio de una conversación delicada" },
                RepairPractices = new List<string>{ "Promover redes de apoyo diversas (no depender de una sola persona)", "Animar a pedir claramente lo que necesita", "Practicar cierres y reencuentros planificados", "Crear acuerdos de pausas y retornos", "Resaltar momentos en que la conexión se mantuvo" },
                MicroPractices = new List<string>{ "Enviar confirmación breve de mensaje (‘recibido, luego te respondo’)", "Nombrar un momento específico en que retomarás (hora aproximada)", "Recordar una cosa que compartió para validar memoria del vínculo", "Reafirmar pertenencia (‘seguimos en esto juntos’)", "Agradecer la apertura sin juicio" }
            },
            new EmotionalWound
            {
                Id = "humillacion",
                Name = "Humillación",
                CoreDescription = "Sensación de exposición vergonzosa o burla de la dignidad personal.",
                CommonOrigins = new List<string>{ "Ridiculización pública en etapas formativas", "Castigos que implicaban vergüenza", "Comparaciones despectivas repetidas" },
                DefensivePatterns = new List<string>{ "Auto-ironía excesiva para desactivar burla", "Evitar pedir ayuda por miedo a quedar mal", "Ataque preventivo con sarcasmo" },
                RelationalDistortions = new List<string>{ "Si pido ayuda pareceré incompetente", "Si se ríen cerca me están criticando", "Mostrar emoción es quedar expuesto" },
                ActivationSignals = new List<string>{ "Rubor o calor en el rostro", "Deseo de esconder información personal", "Pensamientos de inferioridad súbita" },
                ReflectionQuestions = new List<string>{ "¿Estoy por hacer un comentario que podría avergonzar?", "¿Cómo puedo resguardar su dignidad ahora?", "¿Estoy pidiendo consentimiento antes de exponerle?" },
                EmpathicSupportActions = new List<string>{ "Evitar bromas a su costa y comentarios públicos que expongan", "Ofrecer ayuda en privado y con respeto", "Pedir consentimiento antes de compartir su información o logros", "Elogiar de forma específica y auténtica (preferir privado si hay duda)", "Modelar vulnerabilidad segura para normalizar pedir ayuda", "Ofrecer una salida digna cuando se equivoca (‘todo bien, lo revisamos juntos’)", "Redirigir burlas del grupo deteniéndolas con firmeza respetuosa" },
                SupportPhrases = new List<string>{ "Lo que compartes es valioso, gracias.", "Si prefieres, lo revisamos en privado.", "Todos aprendemos cometiendo errores, está bien.", "¿Te gustaría ayuda puntual en esto?", "Tu dignidad no depende de este resultado." },
                MistakesToAvoid = new List<string>{ "Exponer errores en público como ‘lección’", "Responder con sarcasmo a su vulnerabilidad", "Forzar a que cuente algo íntimo", "Comparar su fallo con éxitos de otros", "Reírse de su emoción evidente" },
                RepairPractices = new List<string>{ "Crear espacios de aprendizaje sin burla", "Reforzar avances concretos y esfuerzo", "Invitar a pedir ayuda en tareas pequeñas", "Modelar aceptación de propios errores", "Establecer normas anti-ridiculización" },
                MicroPractices = new List<string>{ "Decir ‘gracias por intentarlo’ tras un error", "Cubrir discretamente un error sin resaltarlo", "Pedir permiso rápido antes de compartir un dato suyo", "Mostrar breve vulnerabilidad propia (‘yo también me equivoco en esto’)", "Preguntar si desea apoyo en un punto específico" }
            },
            new EmotionalWound
            {
                Id = "traicion",
                Name = "Traición",
                CoreDescription = "Sensación de ruptura abrupta de confianza o lealtad; miedo a ser utilizado.",
                CommonOrigins = new List<string>{ "Promesas incumplidas repetidas", "Infidelidad o engaños significativos", "Confidencias reveladas sin permiso" },
                DefensivePatterns = new List<string>{ "Control excesivo de detalles", "Duda crónica de motivos ajenos", "Retención de vulnerabilidad" },
                RelationalDistortions = new List<string>{ "Si no lo controlo me dañará", "Si comete un error ya no es confiable", "Todos terminarán traicionando" },
                ActivationSignals = new List<string>{ "Tensión mandibular", "Pensamientos de vigilancia constante", "Impulso de revisar o comprobar" },
                ReflectionQuestions = new List<string>{ "¿Puedo ser más transparente para favorecer confianza?", "¿Estoy minimizando su cautela?", "¿Estoy cumpliendo lo que dije, incluso en detalles?" },
                EmpathicSupportActions = new List<string>{ "Decir lo que harás y hacerlo (coherencia observable)", "Anticipar cambios con tiempo y explicar razones", "Respetar límites y acuerdos establecidos sin buscar atajos", "Ofrecer opciones de verificación sin invadir (transparencia)", "Validar su cautela sin etiquetarla como ‘exageración’", "Reconocer explícitamente cuando cumples un acuerdo", "Registrar acuerdos compartidos y compartir acceso" },
                SupportPhrases = new List<string>{ "Esto es lo que haré y cuándo, te avisaré si cambia.", "Tu necesidad de claridad es válida.", "Puedes verificar X sin problema.", "Aprecio que cuides límites, quiero respetarlos.", "Gracias por señalarlo; ajusto para ser consistente." },
                MistakesToAvoid = new List<string>{ "Cambiar planes sin avisar", "Ocultar información relevante", "Prometer para calmar y luego incumplir", "Desestimar su cautela como paranoia", "Revelar confidencias sin permiso" },
                RepairPractices = new List<string>{ "Construir confianza con pequeños cumplimientos repetidos", "Hacer retroalimentación en primera persona y sin acusación", "Registrar acuerdos por escrito para claridad", "Revisar periódicamente compromisos", "Practicar transparencia de proceso (mostrar pasos, no solo resultado)" },
                MicroPractices = new List<string>{ "Avisar de un pequeño retraso antes de que ocurra", "Confirmar por escrito un acuerdo recién hablado", "Reconocer el cumplimiento de un límite suyo", "Mostrar un avance parcial para transparencia", "Evitar prometer más de lo que puedes cumplir; ajustar verbalmente a tiempo" }
            },
            new EmotionalWound
            {
                Id = "injusticia",
                Name = "Injusticia",
                CoreDescription = "Sensación de trato desigual, severo o arbitrario; necesidad intensa de equidad.",
                CommonOrigins = new List<string>{ "Comparaciones constantes otorgando privilegios a otros", "Castigos o reglas inconsistentes", "Experiencias de discriminación" },
                DefensivePatterns = new List<string>{ "Perfeccionismo rígido", "Intolerancia a pequeños errores ajenos", "Crítica moralizante" },
                RelationalDistortions = new List<string>{ "Si no es perfecto es injusto", "Si me corrigen me están menospreciando", "Debo evidenciar cada inequidad inmediatamente" },
                ActivationSignals = new List<string>{ "Rigidez corporal", "Pensamiento absoluto (siempre/nunca)", "Impulso de corregir al instante" },
                ReflectionQuestions = new List<string>{ "¿Estoy usando lenguaje absoluto?", "¿Qué hechos y criterios puedo transparentar?", "¿Cómo reconoceré el esfuerzo además del resultado?" },
                EmpathicSupportActions = new List<string>{ "Transparentar criterios y decisiones de forma simple y verificable", "Reconocer el esfuerzo, no solo el resultado", "Evitar absolutismos; usar lenguaje matizado y basado en hechos", "Ser consistente con reglas/aplicaciones y explicar excepciones", "Pedir y acoger feedback sobre equidad percibida", "Diferenciar error humano de patrón injusto", "Dar ejemplo de autocrítica responsable" },
                SupportPhrases = new List<string>{ "Estos son los criterios que usamos: X, Y, Z.", "Valoro el esfuerzo que estás poniendo en esto.", "Si ves algo inequitativo, podemos revisarlo juntos.", "Esto fue un error puntual, no invalida tu aporte.", "Estoy dispuesto a ajustar si la aplicación no fue consistente." },
                MistakesToAvoid = new List<string>{ "Aplicar reglas de forma arbitraria", "Usar favoritismos ocultos", "Descalificar su sensibilidad como exageración moral", "Ignorar reclamos sin revisión", "Responder con ironía a pedidos de equidad" },
                RepairPractices = new List<string>{ "Co-construir reglas claras y estables", "Acordar mecanismos de revisión cuando haya errores", "Dar seguimiento visible a compromisos de mejora", "Practicar reconocimiento público equilibrado", "Separar retroalimentación de juicio personal" },
                MicroPractices = new List<string>{ "Explicar brevemente la razón de una decisión", "Reconocer un esfuerzo antes de señalar mejora", "Usar lenguaje matizado (‘puede ser’, ‘parece’)", "Pedir un ejemplo concreto antes de responder a acusación", "Admitir un pequeño error propio para modelar equidad" }
            },
        };

        /// <summary>
        /// Obtiene una herida emocional por su identificador (slug) ignorando mayúsculas/minúsculas.
        /// </summary>
        /// <param name="id">Identificador de la herida.</param>
        /// <returns>Instancia de la herida o null si no existe.</returns>
        public static EmotionalWound? GetById(string id)
        {
            return Wounds.FirstOrDefault(w => string.Equals(w.Id, id, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
