using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        //---------constructores-------------
        /// <summary>
        /// inicializacion del atributo numero
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// inicializacion de atributo nuemero
        /// </summary>
        /// <param name="numero">nuemro de tipo double recibido por parametro</param>
        public Operando(double numero) 
        {
            this.numero = numero;
        }

        /// <summary>
        /// inicializacion de atributo nuemero
        /// </summary>
        /// <param name="strNumero">nuemro de tipo string recibido por parametro</param>
        public Operando(string strNumero) 
        {
            Numero = strNumero;
        }

        //------------setter/propiedades----------------
        /// <summary>
        /// setea el valor correspondiente a la variable nuemero
        /// </summary>
        public string Numero
        {
            set { this.numero = ValidarOperando(value); }
        }

        //---------chequea si es binario-----------
        /// <summary>
        /// verifica que el numero que se le pasa por parametro sea binario
        /// </summary>
        /// <param name="binario">variable de tipo string a verificar</param>
        /// <returns>retorna true si la varibale es binario, false si no es vinario</returns>
        private bool EsBinario(string binario)
        {
            bool respuesta = true;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    respuesta = false;
                    break;
                }
            }

            return respuesta;
            
        }
        //---------------------convierte bianario a decimal------------------------
        /// <summary>
        /// convierte el nuemro de bianario a decimal
        /// </summary>
        /// <param name="binario">numero en binario recibido por parametro</param>
        /// <returns>retorna el numero en deicmal</returns>
        public string BinarioDecimal(string binario)
        {

            string numero = string.Empty;
            int elevacion = 0;           
            string elevacion2 = "";

            int tamNum = binario.Length;

            if (EsBinario(binario) == true)
            {
                
                foreach (char caracteresNum in binario)
                {
                    tamNum--;
                    if (caracteresNum == '1')
                    {
                        elevacion += (int)Math.Pow(2, tamNum);
                    }

                }
                elevacion2 += elevacion;
            }
            else
            {
                elevacion2 = "valor invalido";
            }
            return elevacion2;

        }    
        //---------------------CONVIERTE DECIMAL A BINARIO-------------------
        /// <summary>
        /// convierte el numero pasado por parametro a binario
        /// </summary>
        /// <param name="numero">numero a convertir</param>
        /// <returns>retorna el numero binario convertido</returns>
        public string DecimalBinario(double numero)
        {
            string resultado = "";
            //0 si el resultado de la división es par y un 1 si es impar
            double numeroDouble = Math.Abs(numero);
            int numeroInt = (int)numeroDouble;
            
            if(numeroInt > 0)
            {
                while (numeroInt != 0)
                {
                    if ((numeroInt % 2) == 0)
                    {
                        resultado = 0 + resultado;
                    }
                    else
                    {
                        if ((numeroInt % 2) == 1)
                        {
                            resultado = 1 + resultado;
                        }
                    }
                    numeroInt = numeroInt / 2;
                }            
            }
            else
            {
                resultado = "Valor invalido";
            }

            return resultado;
          
        }



        /// <summary>
        /// convierte el numero decimal a binaro
        /// </summary>
        /// <param name="numero">variable decimal de tipo string</param>
        /// <returns>retorna el numero convertido a bianario</returns>
        public string DecimalBinario(string numero) 
        {
            double variable;
            string resultado= "";

            if(double.TryParse(numero, out variable))
            {
                resultado = DecimalBinario(variable);
            }

            return resultado;
        }

  
        /// <summary>
        /// valida que el numero ingresando sea valido
        /// </summary>
        /// <param name="strNumero">numero ingresado</param>
        /// <returns>retorna el numero en caso de ser invalido retorna 0</returns>
        private double ValidarOperando(string strNumero)
        {
            double almacen;
           
            

            if (double.TryParse(strNumero, out almacen) == false )
            {
                almacen = 0;
            }

            return almacen;

        }

        /// <summary>
        /// realiza la operacion - 
        /// </summary>
        /// <param name="n1">primero objeto ingresado</param>
        /// <param name="n2">segundo objeto ingreasdo</param>
        /// <return> retoran el resultado de la resta</returns>
        public static double operator -(Operando n1, Operando n2)
        {
             return  n1.numero - n2.numero;
        }
        /// <summary>
        /// realiza operacion de multiplicacion
        /// </summary>
        /// <param name="n1">priemer operado</param>
        /// <param name="n2">segundo operando</param>
        /// <returns>retorna resultado de multiplicacion</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            double resultado = n1.numero * n2.numero;

            if(resultado == -0)
            {
                resultado = 0;
            }

            return resultado;
        }
        /// <summary>
        /// realiza operacion de division
        /// </summary>
        /// <param name="n1">pprimer operador</param>
        /// <param name="n2">segund operador</param>
        /// <returns>retrona el resulado de la division</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double resultado;
            if(n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numero / n2.numero; 
            }

            return resultado;
        }
        /// <summary>
        /// realiza la operacion suma
        /// </summary>
        /// <param name="n1">primer operador</param>
        /// <param name="n2">segundo operdaor</param>
        /// <returns>retorna el resultado de la suma</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
         
    }
}
