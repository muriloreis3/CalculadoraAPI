using System;
namespace CalculadoraAPI.Controllers
{
    public class Expressao
    {
        private String expr;
        public Expressao(String s)
        {
            expr = s;
        }

        public string Expr { get => expr; set => expr = value; }
    }
}
