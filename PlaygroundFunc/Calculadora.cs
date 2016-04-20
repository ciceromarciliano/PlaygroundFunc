using System;

namespace PlaygroundFunc
{
    public class Calculadora
    {
        public int Calcular(int valorA, int valorB, Func<int, int, int> funcao, Predicate<int> validacao = null)
        {
            return funcao(valorA, valorB);
        }
    }
}
