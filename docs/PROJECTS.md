# Inventario profesional de proyectos

Documento interno para mantener consistente el contenido del portafolio. Resume únicamente información profesional y técnica confirmada por Alexander o comprobada en sus repositorios autorizados. No incluye credenciales, secretos, datos de clientes ni código privado.

## GoGo Delivery RD

- Rol: desarrollador junior dentro del equipo, remoto y bajo contrato por proyecto.
- Producto: aplicación Flutter para comercios del ecosistema de pedidos de GOGO DELIVERY RD.
- Stack comprobado: Flutter, Dart, Riverpod, Dio, go_router, almacenamiento seguro, integración mediante contratos de API y pruebas móviles.
- Participación visible: trabajo de compatibilidad con la API central y flujos de acceso, verificación y documentación.
- Visibilidad: repositorio privado de la organización. El portafolio no debe enlazarlo ni revelar detalles internos.

## MiSalónYa

- Producto: plataforma MVC para descubrir salones, solicitar citas y apartar productos.
- Funciones principales: catálogo público, citas con y sin cuenta, referencias privadas para visitantes, agenda del salón, profesionales, tratamientos, reseñas verificadas, productos, preórdenes, notificaciones internas, conversación para cambios de horario y moderación.
- Arquitectura: proyectos separados para Domain, Application, Infrastructure y Web.
- Stack comprobado: C#, ASP.NET Core MVC, .NET 10, Entity Framework Core, SQLite, xUnit, pruebas de integración y Docker.
- Visibilidad: repositorio privado. Presentarlo como caso de producto sin enlazar el código.

## Gym Mejorada

- Producto: sistema web de gestión de gimnasio.
- Funciones principales: panel administrativo; portales de entrenador y cliente; gestión de usuarios, clientes, entrenadores, membresías, pagos, clases y rutinas.
- Seguridad: sesiones, autorización por rol, protección antifalsificación y contraseñas con BCrypt.
- Stack comprobado: C#, ASP.NET Core MVC sobre .NET 8, Entity Framework Core, SQL Server/LocalDB, Bootstrap, CSS, JavaScript y xUnit.
- Visibilidad: repositorio privado. Presentarlo como proyecto freelance sin compartir información de clientes.

## SmartFitAssistant

- Producto: asistente de entrenamiento físico con un modelo local.
- Funciones comprobadas: perfil básico por nivel y objetivo, historial de conversación en sesión y cuatro técnicas de prompting: zero-shot, few-shot, chain-of-thought y role prompting.
- Stack comprobado: C#, ASP.NET Core MVC, .NET 8, Microsoft.Extensions.AI, Microsoft.Extensions.AI.Ollama y Ollama con Llama 3.2.
- Repositorio: <https://github.com/AlexanderDiazRz/SmartFitAssistant->

## DonanT

- Producto: prototipo móvil para registrar y localizar donantes, gestionar solicitudes de sangre y consultar el historial.
- Funciones comprobadas: inicio de sesión de demostración, registro de donantes, búsqueda por nombre/tipo de sangre/ubicación, selección de foto, solicitudes de sangre y navegación con Shell.
- Contexto: proyecto desarrollado en conjunto. El repositorio pertenece al compañero de equipo; Alexander tiene acceso de colaboración desde su cuenta oficial.
- Stack comprobado: C#, .NET MAUI sobre .NET 10, XAML, Shell Navigation y CommunityToolkit.Maui.
- Persistencia actual: colecciones locales/en memoria propias de un prototipo académico; las dependencias de SQLite están declaradas, pero no se presentan como una función terminada.
- Repositorio del equipo: <https://github.com/GiancarloAlvarez/donante-app>
- Antes de destacarlo como muestra de código: consolidar la rama principal, resolver marcadores de integración pendientes y retirar credenciales de demostración del código de interfaz.
