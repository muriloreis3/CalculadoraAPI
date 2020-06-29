using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using org.mariuszgromada.math.mxparser;

namespace CalculadoraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CalculadoraController : ControllerBase
    {
        [HttpPost]
        public double Post(Expressao e)
        {
            return new Expression(e.Expr).calculate();
        }

    }
}
