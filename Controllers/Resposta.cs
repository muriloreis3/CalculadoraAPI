using System;
namespace CalculadoraAPI.Controllers
{
    public class Resposta
    {
        double resp;
        public Resposta(double r)
        {
            Resp = r;
        }

        public double Resp { get => resp; set => resp = value; }
    }
}
