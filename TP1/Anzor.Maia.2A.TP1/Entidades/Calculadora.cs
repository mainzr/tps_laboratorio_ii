using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// valida que el operador ingresado valido solo sea +, -, /, *
        /// </summary>
        /// <param name="operador">Operador seleccionado a validar</param>
        /// <returns>Devuelve el mismo operador en caso de ser valido o + en caso de ser invalido</returns>
        private static char ValidarOperador(char operador)
        {
            char resultado = ' ';

            if(operador != '+' && operador != '-' && operador != '/' && operador != '*' )
            {
                resultado = '+';
            }
            else
            {
                resultado = operador;
            }

            return resultado;
        }

        /// <summary>
        /// realiza la operacion dependiendo la operacion seleccionada
        /// </summary>
        /// <param name="num1">primer operador recibido</param>
        /// <param name="num2">segudno operador recibido</param>
        /// <param name="operador">operacion seleccionada</param>
        /// <returns>devuelve el resultado de la operacion</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            
            switch(ValidarOperador(operador))
            {
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                case '+':
                    resultado = num1 + num2;
                    break;
                case '*':
                    resultado = num1 * num2; 
                    break;
            }

            return resultado;
        }
    }
}
