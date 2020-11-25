using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerDemoApi.Controllers
{
    public class ResultController : ApiBaseController
    {
        [HttpGet]
        public async Task<Result> MCA()
        {
            return await Task.Run<Result>(() =>
            {
                return new Result() { Sem1 = "1000", Sem2 = "2000" };
            });
        }
        [HttpGet]
        public Result BCA()
        {
            Result result = new() { Sem1 = "10", Sem2 = "30" };
            return result;
        }

        [HttpGet]
        public string GetDate(string name)
        {
            
            return $"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} This is lucky time for {name}";
        }

        [HttpPost]
        public Result PostData(Result result)
        {

            return result;
        }
    }
}
