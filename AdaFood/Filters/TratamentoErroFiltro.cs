using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace AdaFood.Filters
{
    public class TratamentoErroFiltro : IAsyncExceptionFilter
    {
        public async Task OnExceptionAsync(ExceptionContext context)
        {
            var objectResponse = new
            {
                ErrorMessege = "Erro :("
            };
            context.Result = new ObjectResult(objectResponse)
            {
            StatusCode = 500
            };

            await Task.CompletedTask;
        }
    }

}
