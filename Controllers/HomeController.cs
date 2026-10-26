using Microsoft.AspNetCore.Mvc;
using PortfolioAlexander.Models;

namespace PortfolioAlexander.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(string? lang)
    {
        var language = string.Equals(lang, "en", StringComparison.OrdinalIgnoreCase) ? "en" : "es";
        var isEnglish = language == "en";
        string T(string spanish, string english) => isEnglish ? english : spanish;

        var viewModel = new PortfolioViewModel
        {
            Language = language,
            Projects =
            [
                new ProjectItem(
                    "01",
                    "GoGo Delivery RD",
                    T("Trabajo actual · Aplicación móvil para comercios", "Current role · Mobile application for merchants"),
                    T(
                        "Colaboro dentro del equipo en la aplicación Flutter para comercios del ecosistema de pedidos de GOGO DELIVERY RD, incluyendo compatibilidad con la API central y flujos de acceso, verificación y documentación.",
                        "I collaborate with the team on the Flutter application for merchants in the GOGO DELIVERY RD ordering ecosystem, including central API compatibility and access, verification, and documentation flows."),
                    T("En desarrollo", "In development"),
                    ["Flutter", "Dart", "Riverpod", "Dio", "go_router", T("Pruebas móviles", "Mobile testing")],
                    null,
                    T("Proyecto privado", "Private project"),
                    "/images/projects/gogo-delivery-safe.svg",
                    T("Pantalla inicial segura de la aplicación para comercios de GoGo Delivery RD", "Safe opening screen of the GoGo Delivery RD merchant application"),
                    "desktop",
                    T("Sin contenido operativo ni datos internos", "No operational content or internal data"),
                    T("Pantalla inicial", "Opening screen")),
                new ProjectItem(
                    "02",
                    "MiSalónYa",
                    T("Producto propio · Plataforma para salones", "Independent product · Salon platform"),
                    T(
                        "Piloto web para descubrir salones, solicitar citas y apartar productos. Incluye agenda, panel de propietaria, reseñas verificadas, conversación sobre cambios de horario, moderación y operaciones sin obligar a la clienta a crear una cuenta.",
                        "Web pilot for discovering salons, requesting appointments, and reserving products. It includes scheduling, an owner dashboard, verified reviews, conversations about schedule changes, moderation, and customer flows that do not require an account."),
                    T("Piloto privado en desarrollo", "Private pilot in development"),
                    ["C#", "ASP.NET Core MVC", ".NET 10", "Entity Framework Core", "SQLite", "xUnit", "Docker"],
                    null,
                    T("Caso privado", "Private case study"),
                    "/images/projects/misalonya-home-mobile.png",
                    T("Portada móvil de MiSalónYa con el mensaje Tu salón, tu cita, tu momento", "MiSalónYa mobile landing page with the message Tu salón, tu cita, tu momento"),
                    "mobile",
                    T("Demo temporal · versión móvil", "Temporary demo · mobile version")),
                new ProjectItem(
                    "03",
                    "Gym Mejorada",
                    T("Proyecto freelance · Gestión web", "Freelance project · Web management"),
                    T(
                        "Sistema con portales diferenciados para administración, entrenadores y clientes. Gestiona membresías, pagos, clases y rutinas, con autorización por rol, contraseñas protegidas y pruebas automatizadas.",
                        "System with separate portals for administrators, trainers, and clients. It manages memberships, payments, classes, and routines, with role-based authorization, protected passwords, and automated tests."),
                    T("Proyecto privado mejorado", "Enhanced private project"),
                    ["C#", "ASP.NET Core MVC", ".NET 8", "Entity Framework Core", "SQL Server", "BCrypt", "xUnit"],
                    null,
                    T("Caso privado", "Private case study"),
                    "/images/projects/gym-login.svg",
                    T("Pantalla de acceso seguro de Gym Mejorada con la marca Fit Portal", "Secure sign-in screen for Gym Mejorada with Fit Portal branding"),
                    "desktop",
                    T("Acceso seguro · datos de demostración", "Secure access · demonstration data")),
                new ProjectItem(
                    "04",
                    "SmartFitAssistant",
                    T("IA aplicada · Asistente de entrenamiento", "Applied AI · Training assistant"),
                    T(
                        "Asistente de entrenamiento físico con un modelo local de Ollama. Adapta las consultas al nivel y objetivo del usuario, conserva el historial de la sesión y permite comparar cuatro técnicas de prompting.",
                        "Fitness training assistant powered by a local Ollama model. It adapts queries to the user's level and goal, retains session history, and makes it possible to compare four prompting techniques."),
                    T("Repositorio público", "Public repository"),
                    ["C#", "ASP.NET Core MVC", ".NET 8", "Microsoft.Extensions.AI", "Ollama", "Prompt engineering"],
                    "https://github.com/AlexanderDiazRz/SmartFitAssistant-",
                    T("Ver código", "View code"),
                    "/images/projects/smartfit-assistant.svg",
                    T("Interfaz de SmartFitAssistant con perfil, consulta y cuatro técnicas de prompting", "SmartFitAssistant interface with profile, query, and four prompting techniques"),
                    "desktop",
                    T("Ollama local · cuatro técnicas", "Local Ollama · four techniques")),
                new ProjectItem(
                    "05",
                    "DonanT",
                    T("Proyecto · Aplicación móvil", "Project · Mobile application"),
                    T(
                        "Prototipo móvil para registrar y localizar donantes, gestionar solicitudes de sangre y consultar el historial. Desarrollado en conjunto como una solución enfocada en los principales flujos de gestión de donantes.",
                        "Mobile prototype for registering and locating donors, managing blood requests, and reviewing history. Developed collaboratively as a solution focused on the main donor-management flows."),
                    T("Repositorio público · desarrollo en conjunto", "Public repository · collaborative development"),
                    ["C#", ".NET MAUI", ".NET 10", "XAML", "Shell Navigation", "CommunityToolkit.Maui"],
                    "https://github.com/GiancarloAlvarez/donante-app",
                    T("Ver repositorio del equipo", "View team repository"),
                    "/images/projects/donant-login.svg",
                    T("Pantalla inicial segura de la aplicación DonanT", "Safe opening screen of the DonanT application"),
                    "mobile",
                    T("Interfaz del prototipo · sin datos personales", "Prototype interface · no personal data"),
                    T("Pantalla inicial", "Opening screen"))
            ]
        };

        return View(viewModel);
    }
}
