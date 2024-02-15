using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace AdaFood.Filters
{
    public class TratamentoErroFiltro : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is NotImplementedException)
            {
                context.Result = new BadRequestObjectResult(new { Messege = "Erro :(" });
            }
        }
    }

}
