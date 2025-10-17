using System.Globalization;

namespace GPSSabores.API.Middleware
{
    public class CultureMilddleware
    {

        private readonly RequestDelegate _next;

        public CultureMilddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task Invoke(HttpContext context)
        {
            var supportedLanguages = CultureInfo.GetCultures(CultureTypes.AllCultures);
            var requestedCulture = context.Request.Headers.AcceptLanguage.FirstOrDefault();

            var cultureInfo = new CultureInfo("pt-BR");

            if (string.IsNullOrWhiteSpace(requestedCulture) == false && supportedLanguages.Any(c => c.Name.Equals(requestedCulture)))
            {
                cultureInfo = new CultureInfo(requestedCulture);
            }

            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;

            await _next(context);
        }
    }
}
