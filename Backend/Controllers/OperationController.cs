using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]//Helper
    [ApiController]
    public class OperationController : ControllerBase
    {
        [HttpGet] //sirve cuando vas a obtener un recurso
        public decimal Get(decimal a, decimal b) 
        {
            return a + b;
        }

        [HttpPost] //sirve para hacer cambio en nuestro servidor,insertando algo un fichero
      //public decimal Add(decimal a, decimal b, Numbers numbers)

            public decimal Add(Numbers numbers, [FromHeader] string Host,
            [FromHeader(Name = "Content-Length")] string ContentLength,
            [FromHeader(Name = "X-Some")] string Some)
        {
            Console.WriteLine(Host);
            Console.WriteLine(ContentLength);
            Console.WriteLine(Some);
            return numbers.A - numbers.B;
        }

        [HttpPut] //sirve para actualizar propiedades

        public decimal Edit(decimal a, decimal b)
        {
            return a * b;
        }


        [HttpDelete] // elimina registros

        public decimal Delete(decimal a, decimal b)
        {
            return a / b;
        }
    }

    public class Numbers
    {
        public decimal A { get; set; }
        public decimal B { get; set; }
    }




}

