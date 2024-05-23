# ASP.NET CORE
> [!NOTE]
> In work
## WebApplication WebApplicationBuilder
*   Создаем пустой проект => его структура
    *   connected services = сервисы из азура
    *   dependencies = пакеты и библиотеки в проекте
    *   Properties: узел, который содержит некоторые настройки проекта. В частности, в файле launchSettings.json описаны настройки запуска проекта, например, адреса, по которым будет запускаться приложение
    *   appsetting.json = конфиг проекта в json
    *   appsettings.Development.json = конфиг проекта во время разработки
    *   program.cs = точка входа
*   var builder = WebApplication.CreateBuilder() = WebApplicationBuilder = один из основных обьектов в разработке
    *   можно к нему добавить опции WebApplicationOptions options = new() { Args= args };WebApplicationBuilder builder = WebApplication.CreateBuilder(options);
    *   его задачи:
        *   конфиг приложения
        *   добавление сервисов
        *   настройка логгирования
        *   установка окружения приложения
        *   конфигурация IHOSTBUILDER IWEBHOSTBUILDER
    *   св-ва
        *   Configuration = ConfigurationManager
        *   Environment
        *   Host = IHostBuilder
        *   Services
        *   WebHost = IWebHostBuilder
*   WebApplication = основной класс: создается из класса WebApplicationBuilder WebApplication app = builder.Build();
    *   что делает
        *   в нем устанавливаются маршруты
        *   логика обработки запроса
        *   получение сервисов
        *   т.д.
    *   Интерфейсы
        *   IHost = запуск остановка хоста
        *   IApplicationBuilder = утсановки компонентов которые будут в обработке запросе
        *   IEndpointRouteBuilder = установка маршрутов
    *   св-ва
        *   configuration = IConfiguration
        *   Environment = IWebHostEnvironment
        *   Lifetime = уведомления о жизненном цикле прижожения
        *   Logger = логер по умолчанию
        *   Services = сервисы приложения
        *   Urls = адреса сервера
    *   методы
        *   Run() = синхронно , блокирует поток
        *   RunAsync() = асинхронно, добавить async в main = серв работает
        *   start() = синхронно, не блокирует поток = после запуска завершается
        *   StartAsync() = асинхронно не ждет завершения работы сервера = после запуска завершается
        *   Stop() = остановить програмнно
## Конвеер middlewear
*   обработка входящий запросов
*   создание компонентов = middleware
*   конвеер один обрабатывает либо отдает вверх = терминальный, либо дальше по конвееру
*   встраиваются с помощью IApplicationBuilder в WebApplication
    *   Run()
    *   Map()
    *   Use()
*   делегат для встраивания:public delegate Task RequestDelegate(HttpContext context);
*   HttpContext context - обьект
*   реализация либо inline либо отдельный класс
*   у HttpContext = свои свойста а также есть свои компоненты middleware
## Метод Run и определение терминального middleware
*   IApplicationBuilder.Run(RequestDelegate handler)
*   public delegate Task RequestDelegate(HttpContext context); = только в конце программы , метод run это терминальный компонент
*   примеры: app.Run(async (context) => await context.Response.WriteAsync("Hello METANIT.COM"));
*    async static Task HandleRequest(HttpContext context)
 {
     await context.Response.WriteAsync("Hello oleg");
 }
*    Компоненты middleware создаются один раз и существуют в течение всего жизненного цикла приложения. То есть для последующей обработки запросов используются одни и те же компоненты, важно это учитывать int x = 2;
app.Run(async (context) =>
{
    x = x * 2;  //  2 * 2 = 4
    await context.Response.WriteAsync($"Result: {x}");
});
app.Run();
## HttpResponse. Отправка ответа
*   свойство класса HttpContext.response
*   можно редиректить и писать текст и задавать метаданные и заголовки и встраивать html код
*   примеры:app.MapGet("/headers", async (context) =>
{
    var response = context.Response;
    response.Headers.ContentLanguage = "ru-RU";
    response.ContentType = "text/plain; charset=utf-8";
    response.Headers.Append("secret-id", "256"); // Добавление кастомного заголовка
    await response.WriteAsync("Привет METANIT.COM");
});
*       app.MapGet("/cssstyle", async (context) =>
    {
        var response = context.Response;
        response.Headers.ContentLanguage = "ru-RU";
        response.ContentType = "text/html; charset=utf-8";
        response.Headers.Append("secret-id", "256"); // Добавление кастомного заголовка

        var htmlContent = @"
<!DOCTYPE html>
<html lang='ru'>
<head>
    <meta charset='UTF-8'>
    <title>Привет METANIT.COM</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
            color: #333;
        }
        h1 {
            color: #007acc;
        }
    </style>
</head>
<body>
    <h1>Привет METANIT.COM</h1>
    <p>Это пример HTML-контента с CSS-стилями.</p>
</body>
</html>";

        await response.WriteAsync(htmlContent);
    });
## HttpRequest. Получение данных запроса
*   свойсвто HttpContext = HttpContext.request