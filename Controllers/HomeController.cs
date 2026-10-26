using Microsoft.AspNetCore.Mvc;
using PortfolioAlexander.Models;

namespace PortfolioAlexander.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new PortfolioViewModel
        {
            Projects =
            [
                new ProjectItem(
                    "01",
                    "GoGo Delivery RD",
                    "Trabajo actual · Aplicación móvil para comercios",
                    "Colaboro dentro del equipo en la aplicación Flutter para comercios del ecosistema de pedidos de GOGO DELIVERY RD, incluyendo compatibilidad con la API central y flujos de acceso, verificación y documentación.",
                    "En desarrollo",
                    ["Flutter", "Dart", "Riverpod", "Dio", "go_router", "Pruebas móviles"],
                    null,
                    "Proyecto privado",
                    "/images/projects/gogo-delivery-safe.svg",
                    "Pantalla inicial segura de la aplicación para comercios de GoGo Delivery RD",
                    "desktop",
                    "Sin contenido operativo ni datos internos",
                    "Pantalla inicial"),
                new ProjectItem(
                    "02",
                    "MiSalónYa",
                    "Producto propio · Plataforma para salones",
                    "Piloto web para descubrir salones, solicitar citas y apartar productos. Incluye agenda, panel de propietaria, reseñas verificadas, conversación sobre cambios de horario, moderación y operaciones sin obligar a la clienta a crear una cuenta.",
                    "Piloto privado en desarrollo",
                    ["C#", "ASP.NET Core MVC", ".NET 10", "Entity Framework Core", "SQLite", "xUnit", "Docker"],
                    null,
                    "Caso privado",
                    "/images/projects/misalonya-home-mobile.png",
                    "Portada móvil de MiSalónYa con el mensaje Tu salón, tu cita, tu momento",
                    "mobile",
                    "Demo temporal · versión móvil"),
                new ProjectItem(
                    "03",
                    "Gym Mejorada",
                    "Proyecto freelance · Gestión web",
                    "Sistema con portales diferenciados para administración, entrenadores y clientes. Gestiona membresías, pagos, clases y rutinas, con autorización por rol, contraseñas protegidas y pruebas automatizadas.",
                    "Proyecto privado mejorado",
                    ["C#", "ASP.NET Core MVC", ".NET 8", "Entity Framework Core", "SQL Server", "BCrypt", "xUnit"],
                    null,
                    "Caso privado",
                    "/images/projects/gym-login.svg",
                    "Pantalla de acceso seguro de Gym Mejorada con la marca Fit Portal",
                    "desktop",
                    "Acceso seguro · datos de demostración"),
                new ProjectItem(
                    "04",
                    "SmartFitAssistant",
                    "IA aplicada · Asistente de entrenamiento",
                    "Asistente de entrenamiento físico con un modelo local de Ollama. Adapta las consultas al nivel y objetivo del usuario, conserva el historial de la sesión y permite comparar cuatro técnicas de prompting.",
                    "Repositorio público",
                    ["C#", "ASP.NET Core MVC", ".NET 8", "Microsoft.Extensions.AI", "Ollama", "Prompt engineering"],
                    "https://github.com/AlexanderDiazRz/SmartFitAssistant-",
                    "Ver código",
                    "/images/projects/smartfit-assistant.svg",
                    "Interfaz de SmartFitAssistant con perfil, consulta y cuatro técnicas de prompting",
                    "desktop",
                    "Ollama local · cuatro técnicas"),
                new ProjectItem(
                    "05",
                    "DonanT",
                    "Proyecto · Aplicación móvil",
                    "Prototipo móvil para registrar y localizar donantes, gestionar solicitudes de sangre y consultar el historial. Desarrollado en conjunto como una solución enfocada en los principales flujos de gestión de donantes.",
                    "Repositorio público · desarrollo en conjunto",
                    ["C#", ".NET MAUI", ".NET 10", "XAML", "Shell Navigation", "CommunityToolkit.Maui"],
                    "https://github.com/GiancarloAlvarez/donante-app",
                    "Ver repositorio del equipo",
                    "/images/projects/donant-login.svg",
                    "Pantalla inicial segura de la aplicación DonanT",
                    "mobile",
                    "Interfaz del prototipo · sin datos personales",
                    "Pantalla inicial")
            ]
        };

        return View(viewModel);
    }
}
