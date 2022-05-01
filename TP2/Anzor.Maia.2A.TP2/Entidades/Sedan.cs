﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        private ETipo tipo;

        public enum ETipo 
        {
            CuatroPuertas, 
            CincoPuertas 
        }


        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
         public Sedan(EMarca marca, string chasis, ConsoleColor color) : this(marca, chasis, color, ETipo.CuatroPuertas)
         {
             //this.tipo = ETipo.CuatroPuertas;
         }

         public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(chasis, marca,color)
         {
             this.tipo = tipo;
         }

        /*public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            this.tipo = ETipo.CuatroPuertas ;
        }

        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : this(marca, chasis, color)
        {
            this.tipo = tipo;
        }*/

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Mediano;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendFormat("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
