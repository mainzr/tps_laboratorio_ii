using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        //---------constructores-------------
        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero) 
        {
            this.numero = numero;
        }

        public Operando(string strNumero) 
        {
            Numero = strNumero;
        }

        //------------setter/propiedades----------------
        public string Numero
        {
            set { this.numero = ValidarOperando(value); }
        }

        //---------chequea si es binario-----------
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
        public string BinarioDecimal(string binario)
        {

            string numero = string.Empty;
            int elevacion = 0;           
            string elevacion2 = "";

           /* double binarioResultado = Math.Abs(double.Parse(binario));
            int binarioEntero = (int)binarioResultado;
            binario = binarioEntero.ToString();*/
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
        public string DecimalBinario(double numero)
        {
            string resultado = "";
            //0 si el resultado de la división es par y un 1 si es impar          
            int numeroInt = Math.Abs((int)numero);
            
            if(numeroInt == 0)
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



        //--------- DECIMAL A BINARIO /PARAMTRO STRING-------------
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

  

        private double ValidarOperando(string strNumero)
        {
            double almacen;

            if(double.TryParse(strNumero, out almacen) == false)
            {
                almacen = 0;
            }

            return almacen;

        }

        //--------------------- sobrecarga operadores--------------
        public static double operator -(Operando n1, Operando n2)
        {
             return  n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            double resultado = n1.numero * n2.numero;

            if(resultado == -0)
            {
                resultado = 0;
            }

            return resultado;
        }

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

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
         
    }
}
