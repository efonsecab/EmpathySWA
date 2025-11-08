using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Shared.EmpathyAssessment
{
    /// <summary>
    /// Repositorio en memoria con los datos estáticos de la evaluación de empatía.
    /// Expone las categorías, preguntas y prácticas diarias disponibles en la aplicación.
    /// </summary>
    public static class AssessmentData
    {
        /// <summary>
        /// Conjunto inmutable de categorías de evaluación de empatía disponibles para navegación y consulta.
        /// </summary>
        public static readonly IReadOnlyList<EmpathyCategory> Categories = new List<EmpathyCategory>
        {
            new EmpathyCategory
            {
                Id = "comunicacion-verbal",
                Title = "Comunicación Verbal",
                Description = "Autoevaluación de hábitos verbales que pueden disminuir la empatía.",
                Questions = new List<EmpathyQuestion>
                {
                    new EmpathyQuestion { Text = "¿Usas un tono de voz frío, distante o monótono?", Explanation = "Comunica desapego e indiferencia; implica que la otra persona y su mensaje valen menos en ese momento.", Example = "Ej: Responder con tono plano 'sí, ajá' mientras alguien comparte algo importante.", SelfImpact = "Te perciben inaccesible; limita la cercanía y pierdes apoyo y colaboración futura.", BibleReference = "Efesios 4:2" },
                    new EmpathyQuestion { Text = "¿Hablas con un tono condescendiente o de sabelotodo?", Explanation = "Coloca a la otra persona en una posición inferior y reproduce jerarquías de poder, desalentando su participación.", Example = "Ej: Decir 'Déjame explicártelo bien porque tú no entiendes estas cosas'.", SelfImpact = "Deteriora tu reputación y te aísla; otros evitan consultarte o trabajar contigo.", BibleReference = "Filipenses 2:3-4" },
                    new EmpathyQuestion { Text = "¿Utilizas sarcasmo o ironía para menospreciar la opinión del otro?", Explanation = "Es un ataque encubierto que ridiculiza y deslegitima su voz, desequilibrando la relación.", Example = "Ej: Responder 'Claro, brillante idea...' con tono sarcástico.", SelfImpact = "Erosiona la confianza hacia ti; quedas como hostil y pierdes conversaciones honestas.", BibleReference = "Proverbios 15:1" },
                    new EmpathyQuestion { Text = "¿Gritas o elevas la voz para imponerte en una conversación?", Explanation = "Constituye violencia verbal que inhibe el diálogo seguro y activa respuestas defensivas.", Example = "Ej: Levantar la voz para silenciar a la otra persona: '¡Déjame terminar!'.", SelfImpact = "Te encierra en relaciones tensas; disminuye tu influencia real y credibilidad.", BibleReference = "Santiago 1:19-20" },
                    new EmpathyQuestion { Text = "¿Interrumpes constantemente antes de que la otra persona termine su idea?", Explanation = "Borra su voz y comunica que su tiempo y experiencia importan menos que los tuyos.", Example = "Ej: Cortar: 'Sí, sí, ya sé lo que vas a decir...'", SelfImpact = "Pierdes información valiosa y oportunidades de aprender o cooperar mejor.", BibleReference = "Proverbios 18:13" },
                    new EmpathyQuestion { Text = "¿Completas las frases del otro, asumiendo que sabes lo que va a decir?", Explanation = "Le quita agencia narrativa y presume superioridad interpretativa, invalidando su expresión.", Example = "Ej: Terminar la frase de alguien sin dejar que concluya su pensamiento.", SelfImpact = "Refuerza sesgos y errores de juicio; te vuelve menos preciso y menos confiable.", BibleReference = "Proverbios 18:2" },
                    new EmpathyQuestion { Text = "¿Minimizas los problemas del otro (\"No es para tanto\", \"Estás exagerando\")?", Explanation = "Invalida su experiencia y establece una jerarquía de sufrimiento donde el suyo queda por debajo.", Example = "Ej: Decir 'Eso no es nada, a otros les va peor'.", SelfImpact = "Te desconecta de la realidad emocional ajena y debilita tus redes de apoyo.", BibleReference = "Romanos 12:15" },
                    new EmpathyQuestion { Text = "¿Das consejos no solicitados inmediatamente, en lugar de solo escuchar?", Explanation = "Desplaza la necesidad de ser escuchado hacia tu control de la situación, quitándole espacio a sus emociones.", Example = "Ej: Al contarle un problema, responder enseguida 'Lo que tienes que hacer es...'", SelfImpact = "Te perciben controlador; reduces la confianza para contarte asuntos relevantes.", BibleReference = "Job 13:5" },
                    new EmpathyQuestion { Text = "¿Cambias de tema bruscamente cuando el otro comparte algo personal o doloroso?", Explanation = "Implica abandono conversacional y comunica que su dolor no merece tu atención.", Example = "Ej: Tras oír 'Perdí mi empleo', contestar '¿Viste el partido ayer?'", SelfImpact = "Se te deja fuera de conversaciones importantes; tu intimidad con otros se empobrece.", BibleReference = "Romanos 12:15" },
                    new EmpathyQuestion { Text = "¿Te jactas de tus propios logros justo después de que alguien comparte un fracaso?", Explanation = "Centra tu superioridad sobre su vulnerabilidad e implica comparación humillante.", Example = "Ej: '¿Perdiste el cliente? Yo cerré tres hoy.'", SelfImpact = "Genera rechazo hacia ti; pierdes aliados y apoyo cuando tú fallas.", BibleReference = "Jeremías 9:23-24" },
                    new EmpathyQuestion { Text = "¿Te quejas constantemente sin preguntar al otro cómo le va?", Explanation = "Usa a la persona como contenedor emocional y vuelve la relación unidireccional.", Example = "Ej: Monólogo de quejas sin preguntar '¿Y tú cómo estás?'", SelfImpact = "Te aíslas; las personas se alejan y disminuye tu soporte emocional real.", BibleReference = "Filipenses 2:4" },
                    new EmpathyQuestion { Text = "¿Usas generalizaciones acusatorias como \"Tú siempre...\" o \"Tú nunca...\"?", Explanation = "Elimina matices, etiqueta globalmente y produce una injusticia percibida que bloquea el diálogo.", Example = "Ej: 'Tú nunca escuchas', 'Siempre llegas tarde'.", SelfImpact = "Atoras conflictos y quemas puentes; te cuesta lograr acuerdos genuinos.", BibleReference = "Mateo 7:1-2" },
                    new EmpathyQuestion { Text = "¿Omites decir \"por favor\", \"gracias\" o \"con permiso\" en las interacciones diarias?", Explanation = "Despersonaliza el trato y normaliza el privilegio de ser atendido sin reciprocidad básica.", Example = "Ej: Pedir algo diciendo sólo 'Pásame eso'.", SelfImpact = "Erosiona tu imagen de respeto; disminuye la buena voluntad hacia ti.", BibleReference = "Colosenses 3:15" },
                    new EmpathyQuestion { Text = "¿Usas lenguaje pasivo-agresivo?", Explanation = "Crea doble vínculo: exige adivinación de intenciones y genera inseguridad relacional.", Example = "Ej: 'Pues hazlo como tú quieras' con tono resentido.", SelfImpact = "Te hace menos claro y efectivo; aumenta malentendidos y estrés propio.", BibleReference = "Efesios 4:29" },
                    new EmpathyQuestion { Text = "¿Haces preguntas invasivas o fuera de lugar solo por curiosidad, sin sensibilidad?", Explanation = "Rompe límites y objetiviza a la persona, reduciéndola a tu curiosidad.", Example = "Ej: Preguntar detalles íntimos sobre una ruptura sin permiso.", SelfImpact = "Te cierras puertas; pierdes acceso a confianza y a relaciones profundas.", BibleReference = "Proverbios 25:17" },
                    new EmpathyQuestion { Text = "¿Rechazas peticiones o ideas con un \"No\" tajante, sin explicar ni ayudar a buscar alternativa?", Explanation = "Cierra la colaboración y establece una jerarquía de poder que excluye al otro.", Example = "Ej: Responder únicamente 'No' y retirarte.", SelfImpact = "Da imagen de inflexibilidad; te deja fuera de decisiones y sin apoyo futuro.", BibleReference = "Colosenses 4:6" },
                    new EmpathyQuestion { Text = "¿Das respuestas ambiguas cuando sabes que tu respuesta es \"no\"?", Explanation = "Induce incertidumbre y ejerce control por dilación, desgastando emocionalmente.", Example = "Ej: Decir 'Luego vemos' sabiendo que no aceptarás.", SelfImpact = "Consumes tu energía en evasivas; generas desconfianza hacia tu palabra.", BibleReference = "Mateo 5:37" },
                },
                DailyPractices = new List<string>
                {
                    "Agradecer en voz alta: usar 'por favor', 'gracias' y 'con permiso'.",
                    "Validar primero, aconsejar después.",
                    "Preguntar por el otro antes de hablar de ti.",
                    "Hablar desde el 'Yo'.",
                    "Practicar el 'No' amable."
                }
            },
            new EmpathyCategory
            {
                Id = "comunicacion-no-verbal",
                Title = "Comunicación No Verbal",
                Description = "Lenguaje corporal y señales no verbales que afectan la empatía.",
                Questions = new List<EmpathyQuestion>
                {
                    new EmpathyQuestion { Text = "¿Pones los ojos en blanco a los demás?", Explanation = "Desprecia y ridiculiza, comunicando superioridad y descalificación.", Example = "Ej: Girar los ojos cuando alguien explica su punto.", SelfImpact = "Te perciben soberbio; disminuye la apertura hacia tus ideas." },
                    new EmpathyQuestion { Text = "¿Evitas todo contacto visual mientras la otra persona habla?", Explanation = "Borra su presencia e implica desinterés genuino por su experiencia.", Example = "Ej: Mirar solo a la pantalla mientras te hablan.", SelfImpact = "Te vuelves menos confiable; pierdes conexión y cooperación." },
                    new EmpathyQuestion { Text = "¿Miras fijamente tu teléfono, el reloj o la computadora mientras te hablan?", Explanation = "Prioriza dispositivos sobre la persona y desvaloriza su relato.", Example = "Ej: Revisar notificaciones mientras escuchas un problema.", SelfImpact = "Afecta tu atención y memoria; empeora tus relaciones y resultados." },
                    new EmpathyQuestion { Text = "¿Cruzas los brazos de forma defensiva o cerrada?", Explanation = "Levanta una barrera emocional que comunica rechazo o amenaza.", Example = "Ej: Postura cerrada, sin relajación, frente a quien comparte.", SelfImpact = "Refuerza tu rigidez; te cuesta recibir feedback y crecer." },
                    new EmpathyQuestion { Text = "¿Suspiras ruidosamente para mostrar impaciencia o fastidio?", Explanation = "Avergüenza y apura artificialmente, inhibiendo la expresión plena.", Example = "Ej: Suspirar exageradamente en medio de su relato.", SelfImpact = "Aumenta tu estrés; te aíslas de conversaciones significativas." },
                    new EmpathyQuestion { Text = "¿Frunces el ceño o haces muecas de desaprobación?", Explanation = "Señaliza desaprobación constante y promueve autocensura.", Example = "Ej: Fruncir el ceño cada vez que discrepas.", SelfImpact = "Fijas una imagen de negatividad; otros evitarán incluirte temprano." },
                    new EmpathyQuestion { Text = "¿Evitas sonreír, incluso como gesto de cortesía básica?", Explanation = "Se interpreta como frialdad o distancia que dificulta la conexión.", Example = "Ej: No devolver una sonrisa de saludo.", SelfImpact = "Empobrece tu red; reduces acercamientos y oportunidades." },
                    new EmpathyQuestion { Text = "¿Le das la espalda a la persona que habla?", Explanation = "Deshumaniza la interacción y degrada la dignidad del interlocutor.", Example = "Ej: Girarte a tu monitor mientras siguen hablando detrás de ti.", SelfImpact = "Pierdes credibilidad y liderazgo; te ven irrespetuoso." },
                    new EmpathyQuestion { Text = "¿Señalas con el dedo de forma acusatoria?", Explanation = "Culpabiliza e intimida, activando defensa en lugar de apertura.", Example = "Ej: Apuntar con el dedo mientras dices 'Tú tienes la culpa'.", SelfImpact = "Escalas conflictos y te cierras puertas a soluciones colaborativas." },
                    new EmpathyQuestion { Text = "¿Bostezas sin taparte la boca?", Explanation = "Humilla y comunica que su voz no merece tu cuidado mínimo.", Example = "Ej: Bostezar frente a alguien que expone algo serio.", SelfImpact = "Daña tu imagen profesional y reduce la confianza en ti." },
                    new EmpathyQuestion { Text = "¿Mantienes una distancia física excesiva o invades el espacio personal?", Explanation = "O excluye y enfría o invade y amenaza; en ambos casos genera inseguridad.", Example = "Ej: Colocarte demasiado cerca sin leer incomodidad.", SelfImpact = "Te vuelves torpe socialmente; otros limitarán tu cercanía física y emocional." },
                    new EmpathyQuestion { Text = "¿No asientes con la cabeza ni das señales de escucha?", Explanation = "Obliga al otro a dudar de ser comprendido y silencia su expresión.", Example = "Ej: Mirar fijo pero sin gestos de seguimiento.", SelfImpact = "Pierdes claridad y alineación; cometes más errores por falta de señales." },
                    new EmpathyQuestion { Text = "¿Tamborileas con los dedos sobre la mesa?", Explanation = "Comunica prisa e impaciencia, devaluando su discurso.", Example = "Ej: Golpear la mesa con los dedos mientras esperan terminar.", SelfImpact = "Aumenta tu ansiedad; empeora tu tolerancia y relaciones." },
                    new EmpathyQuestion { Text = "¿Te mueves nerviosamente, como si tuvieras prisa por irte?", Explanation = "Señaliza que la conversación es una carga y que la persona estorba.", Example = "Ej: Mirar repetidamente la puerta o tu reloj.", SelfImpact = "Te impide estar presente; reduces tu capacidad de influencia positiva." },
                },
                DailyPractices = new List<string>
                {
                    "Guardar el teléfono.",
                    "Asentir para escuchar.",
                    "Mantener postura abierta.",
                    "Ofrecer una sonrisa de cortesía.",
                    "Hacer contacto visual."
                }
            },
            new EmpathyCategory
            {
                Id = "escucha",
                Title = "Escucha",
                Description = "Hábitos de escucha que ayudan o dificultan la empatía.",
                Questions = new List<EmpathyQuestion>
                {
                    new EmpathyQuestion { Text = "¿Escuchas solo para encontrar errores en el argumento del otro?", Explanation = "Convierte el diálogo en competencia; invalida su necesidad de ser comprendido.", Example = "Ej: Interrumpir para corregir pequeños detalles irrelevantes.", SelfImpact = "Te desconectas de soluciones; te perciben combativo y pierdes colaboración." },
                    new EmpathyQuestion { Text = "¿'Escuchas en espera' (solo esperas tu turno para hablar)?", Explanation = "Implica que su historia es irrelevante para ti y refuerza el egocentrismo conversacional.", Example = "Ej: Preparar tu anécdota mientras el otro aún habla.", SelfImpact = "Te pierdes datos clave; tu aporte pierde pertinencia y calidad." },
                    new EmpathyQuestion { Text = "¿Invalidas los sentimientos del otro?", Explanation = "Niega la legitimidad de su emoción y promueve silencio forzado.", Example = "Ej: 'No deberías sentirte así'.", SelfImpact = "Te aíslas de la confianza emocional; disminuye la apertura contigo." },
                    new EmpathyQuestion { Text = "¿Desvías la conversación hacia ti mismo?", Explanation = "Centra tu experiencia y minimiza la del otro, borrando su protagonismo.", Example = "Ej: Responder 'Eso no es nada, a mí me pasó...'", SelfImpact = "Te vuelves poco relevante para otros; te comparten menos y te apoyan menos." },
                    new EmpathyQuestion { Text = "¿Haces multitarea mientras se supone que escuchas?", Explanation = "Señaliza prioridad baja y degrada su necesidad de conexión.", Example = "Ej: Revisar correos mientras te hablan.", SelfImpact = "Baja tu comprensión y memoria; empeora tu desempeño y relaciones." },
                    new EmpathyQuestion { Text = "¿Olvidas detalles importantes que la otra persona acaba de compartir?", Explanation = "Hace sentir invisibilidad e inutilidad al haberte confiado su historia.", Example = "Ej: Preguntar algo que mencionó minutos antes.", SelfImpact = "Te ven inatento; reduces tu confiabilidad y calidad de apoyo." },
                    new EmpathyQuestion { Text = "¿Ofreces soluciones prácticas a un problema emocional que solo necesita ser escuchado?", Explanation = "Acelera indebidamente el proceso emocional y lo minimiza.", Example = "Ej: Sugerir 'haz ejercicio y se te pasa' cuando alguien está triste.", SelfImpact = "Te desconecta de matices; empeora tu sensibilidad y tu liderazgo emocional." },
                    new EmpathyQuestion { Text = "¿Muestras aburrimiento o distracción?", Explanation = "Disuade de compartir y genera inseguridad sobre el vínculo.", Example = "Ej: Mirar el reloj repetidamente.", SelfImpact = "Te excluyen de conversaciones clave; se reduce tu influencia." },
                    new EmpathyQuestion { Text = "¿Juzgas la emoción del otro?", Explanation = "Etiquetar su sentir como 'mal' agrega vergüenza y distancia.", Example = "Ej: 'Estás siendo demasiado sensible'.", SelfImpact = "Pierdes intimidad y calor relacional; aumenta tu soledad emocional." },
                    new EmpathyQuestion { Text = "¿Finges que escuchas, pero luego preguntas algo que ya se dio?", Explanation = "Expone desconexión y convierte la conversación en trámite.", Example = "Ej: '¿Qué te dijo tu jefe?' cuando ya lo explicó.", SelfImpact = "Daña tu credibilidad; otros evitarán confiarte temas importantes." },
                },
                DailyPractices = new List<string>
                {
                    "Escuchar para entender.",
                    "Resistir el secuestro de la conversación.",
                    "Hacer preguntas de seguimiento.",
                    "Practicar la pausa.",
                    "Repetir lo que entendiste."
                }
            },
            new EmpathyCategory
            {
                Id = "comunicacion-digital",
                Title = "Comunicación Digital",
                Description = "Hábitos en textos, correos y redes que impactan la empatía.",
                Questions = new List<EmpathyQuestion>
                {
                    new EmpathyQuestion { Text = "¿Envías mensajes de texto cortantes, secos o con monosílabos?", Explanation = "Genera frialdad y una relación transaccional; hace dudar del vínculo.", Example = "Ej: Responder solo 'Ok' a un mensaje largo y personal.", SelfImpact = "Empobrece tu red; otros dejarán de contarte asuntos importantes." },
                    new EmpathyQuestion { Text = "¿Dejas 'en visto' sistemáticamente sin responder?", Explanation = "Se vive como abandono e indiferencia; niega cierre y apoyo.", Example = "Ej: Leer y no contestar por días a un pedido de ayuda.", SelfImpact = "Te perciben poco confiable; reduces la disposición de otros a ayudarte." },
                    new EmpathyQuestion { Text = "¿Rechazas invitaciones de forma seca y repetida, solo diciendo 'no puedo' sin disculpas ni proponer alternativa?", Explanation = "Desvaloriza el esfuerzo de incluirte y, al repetirse, comunica desinterés por el vínculo y puede generar sensación de rechazo acumulado. Además, al cerrarte reiteradamente también te rechazas a ti mismo: pierdes oportunidades de conexión, apoyo y crecimiento mutuo.", Example = "Ej: Responder 'no puedo' a varias invitaciones (café, cumpleaños, reunión) sin agradecer ni sugerir otra fecha.", SelfImpact = "Reducen su interés por incluirte; te quedas con menos experiencias y menos pertenencia." },
                    new EmpathyQuestion { Text = "¿Evitas conversaciones difíciles desapareciendo (ghosting)?", Explanation = "Niega un cierre mínimo y prolonga el dolor y la incertidumbre. Al desaparecer también te autoexcluyes: te privas de cierre, apoyo y aprendizaje relacional que podrían beneficiarte.", Example = "Ej: Dejar de responder tras un mensaje sobre la relación.", SelfImpact = "Arrastras asuntos pendientes; aumentas tu ansiedad y empobrecen tus vínculos." },
                    new EmpathyQuestion { Text = "¿Usas MAYÚSCULAS para 'gritar' por escrito?", Explanation = "Aumenta la amenaza percibida y bloquea el diálogo calmado.", Example = "Ej: 'TE DIJE QUE NO HAGAS ESO'.", SelfImpact = "Te etiquetan como agresivo; pierdes poder de persuasión." },
                    new EmpathyQuestion { Text = "¿Envías mensajes a horas inapropiadas?", Explanation = "Viola límites y descanso, impactando negativamente la salud del vínculo.", Example = "Ej: Mensajes laborales a las 2 AM.", SelfImpact = "Daña tu imagen profesional; genera límites más duros hacia ti." },
                    new EmpathyQuestion { Text = "¿Publicas indirectas sobre alguien en redes sociales?", Explanation = "Humilla públicamente y erosiona la confianza social.", Example = "Ej: Subir una historia criticando sin nombrar pero evidente.", SelfImpact = "Compromete tu reputación; disminuye tu red de confianza." },
                    new EmpathyQuestion { Text = "¿Te unes a linchamientos digitales o cyberbullying?", Explanation = "Participa en violencia colectiva que puede dejar secuelas psicológicas graves.", Example = "Ej: Comentar insultos en cadena de ataques.", SelfImpact = "Te asocian con violencia; cierras puertas personales y profesionales." },
                    new EmpathyQuestion { Text = "¿Compartes chismes o información privada en chats?", Explanation = "Viola privacidad, destruye confianza y genera miedo a abrirse contigo.", Example = "Ej: Reenviar capturas de conversaciones privadas.", SelfImpact = "Te consideran poco confiable; dejas de enterarte de lo relevante." },
                    new EmpathyQuestion { Text = "¿Usas emojis de forma pasivo-agresiva?", Explanation = "Introduce ambigüedad hostil y ansiedad interpretativa en el intercambio.", Example = "Ej: Responder con ?? para cerrar una discusión.", SelfImpact = "Aumenta malentendidos; eleva tu tensión y empeora tus relaciones." },
                    new EmpathyQuestion { Text = "¿Exiges una respuesta inmediata?", Explanation = "Impone control sobre el tiempo ajeno y aumenta presión innecesaria.", Example = "Ej: '¿Por qué no contestas?' tras minutos.", SelfImpact = "Generas resistencia hacia ti; limita tu acceso a colaboraciones y favores." },
                    new EmpathyQuestion { Text = "¿Ignoras correos que requieren respuesta?", Explanation = "Bloquea colaboración y deja a otros sin soporte ni claridad.", Example = "Ej: No responder a coordinación importante de fecha.", SelfImpact = "Te excluyen de decisiones; disminuye tu confiabilidad profesional." },
                    new EmpathyQuestion { Text = "¿No saludas ni te despides en los correos?", Explanation = "Deshumaniza el trato y comunica que solo te importa la tarea.", Example = "Ej: Enviar solo la solicitud sin 'Hola' ni 'Gracias'.", SelfImpact = "Empobrece tu networking; reduces buena voluntad hacia tus pedidos." },
                    new EmpathyQuestion { Text = "¿Nunca inicias conversaciones ni saludas primero en los chats con amistades/familia/equipo?", Explanation = "Delega el cuidado del vínculo en los demás y comunica baja inversión en la relación.", Example = "Ej: Solo respondes cuando te buscan; nunca escribes 'hola' o '¿cómo vas?' por iniciativa propia.", SelfImpact = "Tu presencia se vuelve prescindible; disminuye el contacto espontáneo contigo." },
                    new EmpathyQuestion { Text = "¿Omites partes de un mensaje incómodas de responder?", Explanation = "Evasión que crea opacidad y desconfianza; elude responsabilidad.", Example = "Ej: Responder solo a lo trivial y evitar la petición central.", SelfImpact = "Aumenta tu carga mental por asuntos pendientes; dañan tu credibilidad." },
                },
                DailyPractices = new List<string>
                {
                    "Evitar el 'visto' sin respuesta.",
                    "Usar frases completas.",
                    "Evitar MAYÚSCULAS sostenidas.",
                    "Ser amable al cancelar proponiendo alternativa.",
                    "Respetar horarios de descanso."
                }
            },
            new EmpathyCategory
            {
                Id = "noviazgo",
                Title = "Noviazgo",
                Description = "Patrones que disminuyen la empatía en una relación de pareja (noviazgo).",
                Questions = new List<EmpathyQuestion>
                {
                    new EmpathyQuestion { Text = "¿Desestimas sus emociones llamándolas exageradas?", Explanation = "Invalida su sentir y sugiere que su percepción 'vale menos', alejando la intimidad.", Example = "Ej: 'Estás exagerando, no fue para tanto'.", SelfImpact = "Te priva de intimidad emocional y comprensión mutua cuando la necesitas." },
                    new EmpathyQuestion { Text = "¿Usas el silencio prolongado para castigar?", Explanation = "Es retirada punitiva que instala miedo a expresar necesidades. También te aísla: te priva de reparación, cercanía y la intimidad que podrías construir.", Example = "Ej: Ignorar horas sus mensajes por enojo menor.", SelfImpact = "Alarga tu malestar y reduce la calidad de la relación que también te sostiene." },
                    new EmpathyQuestion { Text = "¿Comparas a tu pareja con exparejas para presionar cambios?", Explanation = "Implica que 'no alcanza' y socava autoestima y singularidad.", Example = "Ej: 'Mi expareja sí hacía esto bien'.", SelfImpact = "Erosiona la confianza hacia ti; pierdes motivación y cooperación de tu pareja." },
                    new EmpathyQuestion { Text = "¿Ignoras mensajes importantes por enojo?", Explanation = "Niega respuesta y cuidado, escalando el conflicto e inseguridad. También te cierras al apoyo que podría mejorar tu propio bienestar relacional.", Example = "Ej: Dejar sin contestar preguntas urgentes.", SelfImpact = "Mantiene tu tensión interna; te aleja del alivio y la claridad que buscas." },
                    new EmpathyQuestion { Text = "¿Invalidas sus límites físicos o emocionales?", Explanation = "Vulnera su seguridad y autonomía corporal/emocional.", Example = "Ej: Insistir en abrazar cuando pidió espacio.", SelfImpact = "Daña tu reputación como pareja segura; arriesga rupturas y soledad." },
                    new EmpathyQuestion { Text = "¿Trivializas temas que para tu pareja son centrales?", Explanation = "Niega importancia a lo que le duele/importa, dejándola sola con ello.", Example = "Ej: 'Eso no es importante, ya supéralo'.", SelfImpact = "Pierdes acceso a su mundo interno; disminuye la complicidad y el apoyo mutuo." },
                    new EmpathyQuestion { Text = "¿Evitas ofrecer disculpas claras cuando te equivocas?", Explanation = "Impide reparación y mantiene resentimientos activos.", Example = "Ej: 'Perdón si te ofendiste' evitando responsabilidad.", SelfImpact = "Te quedas atrapado en conflictos repetidos; baja tu paz y bienestar." },
                    new EmpathyQuestion { Text = "¿Discutes en lugares públicos exponiendo a tu pareja?", Explanation = "Aumenta vergüenza y vulnerabilidad; erosiona confianza y seguridad.", Example = "Ej: Elevar la voz en un restaurante frente a otras personas.", SelfImpact = "Daña tu imagen y la cooperación; puedes perder la relación por desgaste." },
                    new EmpathyQuestion { Text = "¿Realizas bromas pesadas a su costa?", Explanation = "Humilla y siembra inseguridad; normaliza microagresión.", Example = "Ej: Burlarte de su apariencia o habilidades frente a amistades.", SelfImpact = "Te perciben poco seguro para la intimidad; pierdes cercanía real." },
                    new EmpathyQuestion { Text = "¿Controlas con quién sale o revisas su teléfono?", Explanation = "Control invade autonomía y comunica desconfianza crónica.", Example = "Ej: Exigir contraseñas o prohibir amistades.", SelfImpact = "Aumenta ansiedad y celos; te encierra en relaciones tóxicas y frágiles." },
                    new EmpathyQuestion { Text = "¿Dejas de hacer tiempo de calidad para la relación?", Explanation = "Prioriza todo sobre el vínculo; comunica desinterés y baja inversión.", Example = "Ej: Semanas sin planear un espacio a solas.", SelfImpact = "Empobrece tu conexión; aumenta riesgo de ruptura y soledad." },
                },
                DailyPractices = new List<string>
                {
                    "Reflejar con tus palabras lo que entendiste de su emoción.",
                    "Agradecer una vulnerabilidad compartida.",
                    "Confirmar un límite y respetarlo conscientemente.",
                    "Enviar un mensaje de aprecio específico cada día.",
                    "Practicar una disculpa sin excusas cuando corresponda.",
                    "Evitar discutir en público: pausar y acordar un lugar/tiempo seguro.",
                    "Renunciar a bromas a costa de la pareja.",
                    "Planear un espacio semanal de pareja sin pantallas.",
                }
            },
            new EmpathyCategory
            {
                Id = "comportamiento-en-conflicto",
                Title = "Comportamiento en Conflicto",
                Description = "Conductas durante conflictos que afectan la empatía.",
                Questions = new List<EmpathyQuestion>
                {
                    new EmpathyQuestion { Text = "¿Recurres a ataques personales en lugar de discutir el problema?", Explanation = "Es violencia simbólica que hiere la autoestima y aleja soluciones.", Example = "Ej: 'Eres inútil' en vez de hablar del hecho puntual.", SelfImpact = "Dificulta resolver; prolonga tu estrés y daña tu imagen." },
                    new EmpathyQuestion { Text = "¿Sacas errores del pasado no relacionados?", Explanation = "Reabre heridas y anula el avance; se vive como persecución.", Example = "Ej: Traer una falla de hace años en cada discusión.", SelfImpact = "Te estanca en el resentimiento; agota tu energía y esperanza." },
                    new EmpathyQuestion { Text = "¿Usas la 'ley del hielo' como castigo?", Explanation = "Retirada punitiva que genera ansiedad y sensación de abandono deliberado. Además, te autoaisla: renuncias al apoyo, a la reparación y al aprendizaje que también necesitas.", Example = "Ej: Ignorar mensajes por días tras molestia menor.", SelfImpact = "Te priva de alivio y soluciones; agranda la distancia que también te hiere." },
                    new EmpathyQuestion { Text = "¿Amenazas con terminar la relación para conseguir lo que quieres?", Explanation = "Chantaje emocional que instala miedo como herramienta de control.", Example = "Ej: 'Si no haces esto terminamos'.", SelfImpact = "Debilita tu seguridad afectiva; te deja aislado en relaciones frágiles." },
                    new EmpathyQuestion { Text = "¿Manipulas la culpa?", Explanation = "Erosiona confianza y autonomía, desplazando responsabilidad injustamente.", Example = "Ej: 'Después de todo lo que hago por ti...'", SelfImpact = "Aumenta tu dependencia del control; te perciben tóxico y te evitan." },
                    new EmpathyQuestion { Text = "¿Practicas el 'Gaslighting'?", Explanation = "Abuso psicológico que niega la realidad del otro y desestabiliza su seguridad interna.", Example = "Ej: 'Eso nunca pasó, lo inventas'.", SelfImpact = "Rompe tu credibilidad; te aísla en dinámicas de poder insostenibles." },
                    new EmpathyQuestion { Text = "¿Te niegas a pedir perdón o te disculpas de forma falsa?", Explanation = "Bloquea reparación y valida la herida, perpetuando el daño.", Example = "Ej: 'Perdón pero tú me obligaste'.", SelfImpact = "Prolonga conflictos; te impide aprender y recuperar bienestar." },
                    new EmpathyQuestion { Text = "¿Buscas siempre tener la última palabra?", Explanation = "Prioriza ganar sobre comprender, agotando el vínculo.", Example = "Ej: Seguir contestando con 'Sí pero...' para cerrar.", SelfImpact = "Te encierra en tensiones crónicas; pierdes cooperación y respeto." },
                    new EmpathyQuestion { Text = "¿No cedes en ningún punto?", Explanation = "Impide acuerdos, cronifica frustración y eleva la tensión.", Example = "Ej: Rechazar cualquier compromiso en horario o tarea.", SelfImpact = "Te deja sin acuerdos y sin paz; reduce tu bienestar sostenido." },
                    new EmpathyQuestion { Text = "¿Te burlas de los puntos débiles del otro durante una pelea?", Explanation = "Multiplica el daño emocional y daña gravemente la confianza futura.", Example = "Ej: Ridiculizar su inseguridad física o emocional.", SelfImpact = "Te marca como poco seguro para la intimidad; pierdes cercanía real." },
                },
                DailyPractices = new List<string>
                {
                    "Atacar al problema, no a la persona.",
                    "Evitar la ley del hielo comunicando necesidad de espacio.",
                    "Pedir disculpas genuinas.",
                    "No sacar el pasado.",
                    "Saber ceder."
                }
            },
            new EmpathyCategory
            {
                Id = "egocentrismo-y-falta-de-consideracion",
                Title = "Egocentrismo y Falta de Consideración",
                Description = "Acciones cotidianas centradas en uno mismo que afectan a los demás.",
                Questions = new List<EmpathyQuestion>
                {
                    new EmpathyQuestion { Text = "¿Llegas sistemáticamente tarde sin avisar?", Explanation = "Jerarquiza tu tiempo sobre el de otros y mina la confianza.", Example = "Ej: Llegar 20 min tarde sin mensaje previo.", SelfImpact = "Daña tu credibilidad; pierdes oportunidades y calidad de relaciones." },
                    new EmpathyQuestion { Text = "¿No respetas el espacio personal de los demás?", Explanation = "Provoca inseguridad y sensación de invasión; desconoce límites.", Example = "Ej: Colocarte muy cerca al hablar pese a señales de retroceso.", SelfImpact = "Te ven imprudente; reducen contacto contigo y te aíslas." },
                    new EmpathyQuestion { Text = "¿Haces ruido excesivo en espacios compartidos?", Explanation = "Impone tus preferencias sobre el bienestar común, generando estrés.", Example = "Ej: Reproducir música alta en madrugada.", SelfImpact = "Afecta tu convivencia; te expone a conflictos y sanciones sociales." },
                    new EmpathyQuestion { Text = "¿Dejas desorden en áreas comunes para que otro limpie?", Explanation = "Traslada tu carga a otros y comunica falta de reciprocidad.", Example = "Ej: Dejar platos sucios días esperando que alguien los lave.", SelfImpact = "Reduce la cooperación hacia ti; acumulas tensiones en casa o trabajo." },
                    new EmpathyQuestion { Text = "¿Tomas lo último de algo y no lo repones?", Explanation = "Aprovecha el recurso común y devalúa la consideración mutua.", Example = "Ej: Terminar el café y no avisar ni preparar más.", SelfImpact = "Erosiona tu imagen de fiabilidad; limita apoyos en momentos clave." },
                    new EmpathyQuestion { Text = "¿No cedes el asiento a personas que lo necesitan?", Explanation = "Ignora vulnerabilidades ajenas y normaliza el privilegio propio.", Example = "Ej: Mantenerte sentado frente a persona mayor en transporte.", SelfImpact = "Te perciben indiferente; disminuye la cooperación hacia ti en público." },
                    new EmpathyQuestion { Text = "¿Te cuelas en una fila o en el tráfico?", Explanation = "Rompe la equidad básica y provoca enojo legítimo.", Example = "Ej: Meter el coche sin respetar turno.", SelfImpact = "Eleva tu estrés y riesgo; atrae sanciones y conflictos innecesarios." },
                    new EmpathyQuestion { Text = "¿No sostienes la puerta para la persona que viene detrás?", Explanation = "Invisibiliza al otro y omite cortesía mínima que facilita la convivencia.", Example = "Ej: Dejar que se cierre justo delante de alguien cargando bolsas.", SelfImpact = "Reduce la amabilidad hacia ti; empeora tu clima social diario." },
                    new EmpathyQuestion { Text = "¿Hablas de ti mismo sin parar?", Explanation = "Desplaza sistemáticamente a los demás y erosiona el sentido de conexión.", Example = "Ej: Ignorar señales de querer hablar y seguir contando tu historia.", SelfImpact = "Te vuelves poco querido como compañía; te quedas con soporte superficial." },
                    new EmpathyQuestion { Text = "¿No respetas los límites establecidos por otros?", Explanation = "Desconoce su autonomía y seguridad emocional.", Example = "Ej: Abrazar después de que pidieron no hacerlo.", SelfImpact = "Te consideran invasivo; restringen tu acceso y cercanía." },
                    new EmpathyQuestion { Text = "¿Pides favores constantemente sin ofrecer ayuda a cambio?", Explanation = "Crea desequilibrio y fatiga emocional por carga unilateral.", Example = "Ej: Solicitar recados sin nunca ofrecer apoyo propio.", SelfImpact = "Agota tu entorno; cuando necesites, recibirás menos ayuda genuina." },
                    new EmpathyQuestion { Text = "¿Tomas decisiones que afectan a otros sin explicar el por qué?", Explanation = "Impone opacidad y control, generando incertidumbre y resentimiento.", Example = "Ej: Cambiar horario de reunión sin aviso previo.", SelfImpact = "Baja tu liderazgo; te excluyen de procesos y te cuestionan más." },
                    new EmpathyQuestion { Text = "¿Dejas que sea la otra persona quien siempre tenga que proponer un nuevo plan?", Explanation = "Traslada la iniciativa y responsabilidad, causando desgaste.", Example = "Ej: Responder siempre 'Lo que tú digas' sin sugerir nada.", SelfImpact = "Te vuelves irrelevante en la agenda compartida; disminuye tu vida social." },
                },
                DailyPractices = new List<string>
                {
                    "Dejar el espacio mejor de lo que lo encontraste.",
                    "Ser consciente del ruido.",
                    "Reponer lo que se acaba.",
                    "Ceder el paso o el asiento.",
                    "Avisar si llegas tarde."
                }
            },
            new EmpathyCategory
            {
                Id = "comportamiento-social-y-grupal",
                Title = "Comportamiento Social y Grupal",
                Description = "Dinámicas con grupos y equipos que pueden carecer de empatía.",
                Questions = new List<EmpathyQuestion>
                {
                    new EmpathyQuestion { Text = "¿Excluyes intencionalmente a alguien de una conversación o actividad?", Explanation = "Provoca dolor social y legitima jerarquías informales de exclusión.", Example = "Ej: Organizar salida del equipo ignorando a una persona.", SelfImpact = "Debilita tu red; pierdes diversidad de ideas y apoyo futuro." },
                    new EmpathyQuestion { Text = "¿Hablas por encima de los demás en una reunión?", Explanation = "Invalida aportes, devalúa su voz y reduce participación segura.", Example = "Ej: Interrumpir reiteradamente para imponer tu idea.", SelfImpact = "Te perciben impositivo; disminuye tu capacidad de sumar alianzas." },
                    new EmpathyQuestion { Text = "¿Te robas el crédito por el trabajo o ideas de un compañero?", Explanation = "Apropiación que erosiona confianza y justicia dentro del grupo.", Example = "Ej: Presentar la idea sin mencionar a la persona autora.", SelfImpact = "Daña tu reputación; te excluyen de proyectos y confianza clave." },
                    new EmpathyQuestion { Text = "¿Difundes chismes o rumores para dañar la reputación de alguien?", Explanation = "Violencia reputacional que genera ansiedad y clima hostil.", Example = "Ej: Compartir rumor sobre su vida privada.", SelfImpact = "Te etiquetan como poco ético; pierdes oportunidades y respaldo." },
                    new EmpathyQuestion { Text = "¿Ignoras a los nuevos miembros de un grupo?", Explanation = "Los invisibiliza y obstaculiza su integración y bienestar.", Example = "Ej: No saludar ni incluir en conversación inicial.", SelfImpact = "Empobreces tu red; pierdes talento y amistades potenciales." },
                    new EmpathyQuestion { Text = "¿Haces 'bromas' a costa de alguien, sabiendo que le duelen?", Explanation = "Normaliza microagresiones y refuerza inseguridad en la víctima.", Example = "Ej: Repetir apodo que incomoda a la persona.", SelfImpact = "Te consideran inseguro para la convivencia; te evitan en espacios sociales." },
                    new EmpathyQuestion { Text = "¿No te presentas a un compromiso grupal sin avisar?", Explanation = "Rompe la planificación y recarga injustamente al equipo.", Example = "Ej: Faltar a reunión clave sin informar.", SelfImpact = "Baja tu confiabilidad; quedas fuera de invitaciones futuras." },
                    new EmpathyQuestion { Text = "¿Presionas a otros para que hagan algo con lo que no se sienten cómodos?", Explanation = "Vulnera su autonomía y puede forzar situaciones de riesgo o malestar.", Example = "Ej: Insistir 'vamos, no seas aburrido' ante negativa.", SelfImpact = "Te perciben invasivo; pierdes cercanía y cooperación voluntaria." },
                    new EmpathyQuestion { Text = "¿Declinas reiteradamente invitaciones grupales con respuestas mínimas ('no puedo') sin agradecer ni ofrecer alternativa?", Explanation = "El patrón crea sensación de desinterés y puede llevar al grupo a dejar de incluirte, debilitando pertenencia. Este ciclo también se convierte en autoexclusión: reduces tu red de apoyo y tu sentido de identidad colectiva.", Example = "Ej: Responder 'no puedo' a invitaciones a almuerzo, reunión informal y actividad semanal durante un mes.", SelfImpact = "Se reduce tu pertenencia; te pierdes experiencias y visibilidad positiva." },
                    new EmpathyQuestion { Text = "¿Nunca te ofreces a organizar o coordinar una actividad del grupo?", Explanation = "Deja la carga logística siempre en los mismos y comunica baja corresponsabilidad.", Example = "Ej: Nunca propones ser anfitrión/a o reservar lugar; esperas que otros lo hagan.", SelfImpact = "Baja tu influencia en el grupo; te vuelves prescindible en decisiones." },
                    new EmpathyQuestion { Text = "¿Formas 'clubes' o 'bandos' cerrados en la oficina?", Explanation = "Fragmenta el tejido del equipo y naturaliza la exclusión sistemática.", Example = "Ej: Grupo que planea todo sin invitar a otras personas.", SelfImpact = "Te encierras en cámaras de eco; pierdes oportunidades transversales." },
                },
                DailyPractices = new List<string>
                {
                    "Integrar al excluido.",
                    "Detener el chisme.",
                    "Dar crédito públicamente.",
                    "No hacer bromas a costa de otros.",
                    "Pasar la palabra.",
                    "Agradecer invitaciones y sugerir otra fecha si no puedes.",
                    "Rotar la organización de actividades dentro del grupo."
                }
            },
            new EmpathyCategory
            {
                Id = "relacion-con-entorno-y-servicios",
                Title = "Relación con el Entorno y Servicios",
                Description = "Comportamientos hacia el entorno, animales y personal de servicio.",
                Questions = new List<EmpathyQuestion>
                {
                    new EmpathyQuestion { Text = "¿Eres grosero o impaciente con el personal de servicio?", Explanation = "Deshumaniza su labor y reproduce relaciones de clase desiguales.", Example = "Ej: Tratar con brusquedad al mesero por demora.", SelfImpact = "Te cierra puertas y buena voluntad; recibes menos ayuda de calidad." },
                    new EmpathyQuestion { Text = "¿Culpas al mensajero por las malas noticias?", Explanation = "Desplaza injustamente la responsabilidad y aumenta su estrés laboral.", Example = "Ej: Regañar al repartidor por retrasos de empresa.", SelfImpact = "Aumenta tus conflictos cotidianos; empeora tus experiencias de servicio." },
                    new EmpathyQuestion { Text = "¿Maltratas a los animales o muestras indiferencia ante su sufrimiento?", Explanation = "Normaliza crueldad y mina la compasión hacia seres vulnerables.", Example = "Ej: Ignorar a un animal herido sin buscar ayuda.", SelfImpact = "Reduce tu sensibilidad; afecta tu bienestar y la percepción que otros tienen de ti." },
                    new EmpathyQuestion { Text = "¿Tiras basura en la calle o en la naturaleza?", Explanation = "Daña el entorno común y desprecia el bien colectivo.", Example = "Ej: Dejar botella en parque en vez de usar basurero.", SelfImpact = "Deteriora tu entorno; recibes rechazo social y posibles sanciones." },
                    new EmpathyQuestion { Text = "¿Conduces de forma agresiva, sin respetar a peatones u otros conductores?", Explanation = "Impone riesgo y miedo a terceros, priorizando tu urgencia sobre su seguridad.", Example = "Ej: Acelerar para impedir que otra persona se incorpore.", SelfImpact = "Aumenta tu riesgo de accidentes y estrés; pierdes tiempo y dinero." },
                    new EmpathyQuestion { Text = "¿Actúas con un sentido de 'privilegio', creyendo merecer trato especial?", Explanation = "Jerarquiza tu valor sobre el de otros y alimenta injusticias sociales.", Example = "Ej: Exigir prioridad en fila por 'tener prisa'.", SelfImpact = "Genera resistencia hacia ti; limita tu acceso a colaboraciones y favores." },
                    new EmpathyQuestion { Text = "¿No miras a los ojos ni agradeces al personal de limpieza?", Explanation = "Invisibiliza su dignidad y borra el reconocimiento a su trabajo.", Example = "Ej: Pasar frente a quien limpia sin saludar.", SelfImpact = "Empobrece tu humanidad percibida; reduces la amabilidad hacia ti." },
                    new EmpathyQuestion { Text = "¿Ignoras a las personas en situación de calle?", Explanation = "Profundiza su exclusión y deshumaniza su realidad.", Example = "Ej: Evitar cualquier contacto visual sistemáticamente.", SelfImpact = "Atrofia tu compasión; limita tu crecimiento moral y social." },
                    new EmpathyQuestion { Text = "¿Dejas un carrito de supermercado en medio del estacionamiento?", Explanation = "Traslada esfuerzo a otros y crea obstáculos innecesarios.", Example = "Ej: Abandonar el carrito junto a otro auto.", SelfImpact = "Genera fricciones; recibes menos cooperación en espacios compartidos." },
                    new EmpathyQuestion { Text = "¿Regateas o menosprecias el trabajo de artesanos o pequeños comerciantes?", Explanation = "Desvaloriza su esfuerzo y vulnera su sustento y dignidad.", Example = "Ej: Decir 'Eso no vale tanto, bájalo más' con tono despectivo.", SelfImpact = "Daña tu relación con la comunidad; reduces calidad y acceso a buen servicio." },
                },
                DailyPractices = new List<string>
                {
                    "Agradecer al personal de servicio.",
                    "Ser paciente con teleoperadores.",
                    "Devolver el carrito.",
                    "Practicar conducción cortés.",
                    "Recoger una basura."
                }
            },
            new EmpathyCategory
            {
                Id = "amistad",
                Title = "Amistad",
                Description = "Comportamientos que afectan la empatía en amistades.",
                Questions = new List<EmpathyQuestion>
                {
                    new EmpathyQuestion { Text = "¿Solo buscas a tus amistades cuando necesitas algo?", Explanation = "Convierte la amistad en utilidad; implica que la persona vale por lo que te da.", Example = "Ej: Escribir solo para pedir favores o contactos.", SelfImpact = "Te quedas con vínculos transaccionales; recibes menos apoyo genuino." },
                    new EmpathyQuestion { Text = "¿Restas importancia a los logros de tus amistades?", Explanation = "Minimiza su esfuerzo y sabotea la alegría compartida, dañando la confianza.", Example = "Ej: 'Cualquiera logra eso'.", SelfImpact = "Te priva de celebrar y ser celebrado; reduce tu felicidad compartida." },
                    new EmpathyQuestion { Text = "¿Cancelas planes a último momento sin disculparte?", Explanation = "Comunica baja prioridad y falta de consideración por su tiempo.", Example = "Ej: Avisar minutos antes 'No voy' sin motivo.", SelfImpact = "Baja tu confiabilidad; disminuyen invitaciones y cercanía." },
                    new EmpathyQuestion { Text = "¿Rechazas repetidamente invitaciones de amistades con un 'no puedo' sin agradecer ni proponer otra fecha?", Explanation = "El patrón constante muestra desinterés y erosiona el sentido de reciprocidad y pertenencia. Al negar espacios compartidos de forma sistemática también te niegas experiencias nutritivas y validación emocional.", Example = "Ej: Responder 'no puedo' a invitaciones de salida, cine y café durante semanas sin sugerir alternativa.", SelfImpact = "Te autoexcluyes de recuerdos y redes de apoyo; se enfría tu círculo." },
                    new EmpathyQuestion { Text = "¿Nunca eres quien invita o propone un plan?", Explanation = "Deja la iniciativa y el cuidado del vínculo del lado del otro, comunicando baja inversión.", Example = "Ej: Siempre esperas a que te inviten; nunca propones café, llamada o paseo.", SelfImpact = "Te vuelves prescindible en la agenda ajena; tu vida social se empobrece." },
                    new EmpathyQuestion { Text = "¿Prometes proponer fecha y nunca das seguimiento?", Explanation = "Genera expectativas incumplidas y sensación de desinterés sostenido.", Example = "Ej: Decir 'yo organizo y te aviso' y no escribir en semanas.", SelfImpact = "Daña tu palabra; pierdes confianza y espontaneidad en el vínculo." },
                    new EmpathyQuestion { Text = "¿Hablas más de ti que de ellos de forma constante?", Explanation = "Desbalancea el vínculo y agota emocionalmente a la otra persona.", Example = "Ej: Monólogo continuo sin preguntar cómo están.", SelfImpact = "Te perciben centrado en ti; se reduce el deseo de compartir contigo." },
                    new EmpathyQuestion { Text = "¿Revelas confidencias que te compartieron?", Explanation = "Traiciona la confianza nuclear y puede exponerlos a daño social.", Example = "Ej: Contar a otros una situación íntima que te confió.", SelfImpact = "Te vuelves no confiable; pierdes amistades y apoyo real." },
                    new EmpathyQuestion { Text = "¿Te muestras ausente emocionalmente cuando comparten un problema?", Explanation = "Niega apoyo seguro y deja a la persona sola con su carga.", Example = "Ej: Responder con monosílabos y mirar el móvil.", SelfImpact = "Pierdes intimidad; disminuye la reciprocidad cuando tú necesites." },
                    new EmpathyQuestion { Text = "¿Evitas celebrar activamente sus victorias?", Explanation = "Se percibe como envidia o desinterés y erosiona cercanía.", Example = "Ej: No felicitar un logro profesional relevante.", SelfImpact = "Te roba oportunidades de alegría compartida; te aíslas emocionalmente." },
                },
                DailyPractices = new List<string>
                {
                    "Enviar un mensaje de apoyo sin motivo aparente.",
                    "Celebrar explícitamente un logro de tu amigo/a.",
                    "Proponer un plan tú en una fecha concreta.",
                    "Escuchar 2 minutos antes de responder sobre ti.",
                    "Agradecer la confianza cuando te cuentan algo personal."
                }
            },
            new EmpathyCategory
            {
                Id = "matrimonio",
                Title = "Matrimonio",
                Description = "Conductas que reducen la empatía en el matrimonio.",
                Questions = new List<EmpathyQuestion>
                {
                    new EmpathyQuestion { Text = "¿Das por sentado el trabajo doméstico del otro sin reconocerlo?", Explanation = "Invisibiliza esfuerzo y contribución, minando el sentido de equipo y justicia.", Example = "Ej: Usar ropa limpia sin agradecer la colada hecha.", SelfImpact = "Daña la cooperación a tu favor; aumenta tensiones y desgaste en casa." },
                    new EmpathyQuestion { Text = "¿Respondes con sarcasmo ante intentos de acercamiento?", Explanation = "Desalienta intimidad y reemplaza cuidado por defensa constante.", Example = "Ej: 'Ahora sí quieres hablar, ¿eh?'", SelfImpact = "Te priva de cercanía afectiva; refuerza la distancia que te duele." },
                    new EmpathyQuestion { Text = "¿Hablas de temas sensibles en momentos de cansancio extremo?", Explanation = "Aumenta malentendidos y dispara reactividad emocional.", Example = "Ej: Sacar tema financiero tarde en la noche.", SelfImpact = "Multiplica tus conflictos; afecta tu descanso y bienestar general." },
                    new EmpathyQuestion { Text = "¿Retienes información financiera relevante?", Explanation = "Erosiona la confianza y amenaza la corresponsabilidad.", Example = "Ej: Ocultar compras grandes hasta descubrirse.", SelfImpact = "Te deja sin transparencia; aumenta tu ansiedad y riesgo de ruptura." },
                    new EmpathyQuestion { Text = "¿Menosprecias su forma de criar o decidir frente a otros?", Explanation = "Hiere respeto mutuo y autoridad compartida, dejando expuesto al otro.", Example = "Ej: Corregir frente a familiares con tono burlón.", SelfImpact = "Daña tu alianza como pareja; pierdes respaldo en decisiones." },
                    new EmpathyQuestion { Text = "¿Descalificas sus pasatiempos o intereses?", Explanation = "Reduce identidad y autonomía personal dentro de la relación.", Example = "Ej: 'Tu hobby es una pérdida de tiempo'.", SelfImpact = "Limita tu mundo compartido; empobrece la alegría y complicidad." },
                    new EmpathyQuestion { Text = "¿Interrumpes o dominas las conversaciones familiares?", Explanation = "Limita su voz y participación equitativa, restándole agencia.", Example = "Ej: Responder por tu pareja sin consultarle.", SelfImpact = "Te vuelve controlador; reduce la confianza hacia tu liderazgo en casa." },
                    new EmpathyQuestion { Text = "¿Expones la relación en redes sociales buscando validación?", Explanation = "Vuelve íntimos asuntos públicos y abre espacio a chismes y malentendidos.", Example = "Ej: Publicar conflictos o detalles sensibles.", SelfImpact = "Aumenta tensiones; reduces privacidad y paz en el vínculo." },
                    new EmpathyQuestion { Text = "¿Niega afecto o cercanía como forma de castigo?", Explanation = "Retira cuidado esencial y crea inseguridad crónica.", Example = "Ej: Evitar contacto por días tras enojo menor.", SelfImpact = "Te priva de intimidad; eleva resentimiento y distancia emocional." },
                    new EmpathyQuestion { Text = "¿Nunca oran/reflexionan juntos por la relación?", Explanation = "Pierde un espacio de co-regulación y propósito compartido.", Example = "Ej: Evitar momentos de conexión espiritual.", SelfImpact = "Menos resiliencia ante crisis; disminuye sentido de equipo y propósito." },
                },
                DailyPractices = new List<string>
                {
                    "Agradecer en voz alta una tarea doméstica específica.",
                    "Agendar un espacio semanal de conversación sin pantallas.",
                    "Validar primero su emoción antes de debatir soluciones.",
                    "Compartir de forma transparente un dato relevante (tiempo, finanzas).",
                    "Reconocer un punto fuerte de tu cónyuge cada día.",
                    "Orar/meditar juntos 5 minutos por la relación.",
                    "Evitar publicaciones sensibles sobre la relación en redes.",
                }
            },
            new EmpathyCategory
            {
                Id = "amar-responsablemente",
                Title = "Amar responsablemente",
                Description = "Patrones y prácticas para amar de forma sana y responsable (respeto, honestidad, límites, apoyo y crecimiento conjunto).",
                Questions = new List<EmpathyQuestion>
                {
                    new EmpathyQuestion { Text = "¿Buscas 'conquistar' sin intención de compromiso?", Explanation = "Instrumentaliza a la persona y trivializa su dignidad y proyecto de vida.", Example = "Ej: Sostener vínculos paralelos por entretenimiento.", SelfImpact = "Relaciones superficiales y frágiles; aumentan culpas y conflictos." },
                    new EmpathyQuestion { Text = "¿Te cuesta ser honesto y vulnerable sobre tus miedos y límites?", Explanation = "Opaca la confianza y deja a tu pareja sin mapa para cuidarte/cuidarse.", Example = "Ej: Ocultar ansiedad, deudas o heridas relevantes.", SelfImpact = "Te aísla; dificulta recibir apoyo y crecer juntos." },
                    new EmpathyQuestion { Text = "¿Te pones a la defensiva ante feedback constructivo?", Explanation = "Bloquea aprendizaje y reparación; sostiene ciclos de conflicto.", Example = "Ej: Responder atacando en lugar de escuchar.", SelfImpact = "Repites errores; pierdes paz y calidad del vínculo." },
                    new EmpathyQuestion { Text = "¿Practicas desprecio, sarcasmo o soberbia en desacuerdos?", Explanation = "Deshumaniza; uno de los predictores más fuertes de ruptura.", Example = "Ej: Ojos en blanco y burlas en discusión.", SelfImpact = "Erosiona tu autoridad moral; te quedas solo en tu orgullo." },
                    new EmpathyQuestion { Text = "¿Evades conflictos en lugar de resolverlos?", Explanation = "Acumula resentimientos y agranda problemas pendientes.", Example = "Ej: Cambiar de tema, posponer indefinidamente.", SelfImpact = "Carga mental alta; clima relacional tenso y frío." },
                    new EmpathyQuestion { Text = "¿Intentas controlar (horarios, amistades, vestimenta)?", Explanation = "Invade autonomía y crea miedo; no construye confianza real.", Example = "Ej: Revisar teléfono, prohibir amistades.", SelfImpact = "Aumenta celos y ansiedad; pierdes cooperación voluntaria." },
                    new EmpathyQuestion { Text = "¿Minimizas su fe o su crecimiento espiritual?", Explanation = "Niega una dimensión central de sentido y co-regulación.", Example = "Ej: Burlarse de su oración o impedir asistir a comunidad.", SelfImpact = "Menos propósito compartido y resiliencia ante crisis." },
                    new EmpathyQuestion { Text = "¿Descuidas tu autocuidado (sueño, salud, emociones)?", Explanation = "Sin autoempatía es difícil sostener empatía hacia otros.", Example = "Ej: No dormir y responder con irritabilidad crónica.", SelfImpact = "Elevas reactividad; reduces calidad de presencia y amor." },
                },
                DailyPractices = new List<string>
                {
                    "Preguntar: '¿Cómo estuvo tu día?' y escuchar 2 minutos sin interrumpir.",
                    "Decir 1 razón específica por la que amas/valoras hoy.",
                    "Orar/meditar juntos por 3–5 minutos.",
                    "Acordar límites y respetarlos activamente.",
                    "Practicar una disculpa completa cuando corresponda.",
                    "Planear una micro-cita (20–30 min) semanal.",
                }
            },
        };

        /// <summary>
        /// Obtiene una categoría por su identificador legible para URL.
        /// La comparación es ordinal sin distinción de mayúsculas/minúsculas.
        /// </summary>
        /// <param name="id">Identificador (slug) de la categoría a buscar. Puede ser nulo.</param>
        /// <returns>
        /// La instancia de <see cref="EmpathyCategory"/> correspondiente al identificador
        /// proporcionado, o <c>null</c> si no se encuentra.
        /// </returns>
        public static EmpathyCategory GetById(string id)
        {
            return Categories.FirstOrDefault(c => string.Equals(c.Id, id, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
