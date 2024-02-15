using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AdaFood.Filters
{
    public class AutorizacaoFiltro : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Request.Query.ContainsKey("UsuarioLogado"))
            {
                context.Result = new UnauthorizedObjectResult(new { Message = "Usuário não tem permissão" });
                return;
            }

            if (context.HttpContext.Request.Query.TryGetValue("UsuarioLogado", out var value) && value != "true")
            {
                context.Result = new UnauthorizedObjectResult(new { Message = "Usuário não tem permissão" });
                return;
            }
        }
    }
}
