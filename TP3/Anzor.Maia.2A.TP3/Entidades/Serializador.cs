using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;

namespace Entidades
{
    public class Serializador
    {
        public bool SerializarXml(string ruta, List<Cliente> lista)
        {
            bool retorno = true;
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    XmlSerializer xmlSerializador = new XmlSerializer(typeof(List<Cliente>));

                    xmlSerializador.Serialize(sw, lista);
                }
                retorno = true;
            }
            catch (ExceptionControllers e)
            {
                throw new ExceptionControllers("Excepcion controlada...", e);
            }
            return retorno;
        }

        public List<Cliente> DeserializarXml(string ruta)
        {
            //string lista = String.Empty;
            List<Cliente> lista = new List<Cliente>();
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    XmlSerializer xmlDeserializador = new XmlSerializer(typeof(List<Cliente>));
                    lista = xmlDeserializador.Deserialize(sr) as List<Cliente>;
                }
            }
            catch (ExceptionControllers e)
            {

                throw new InvalidOperationException("Excepcion controlada", e);
            }

            return lista;
        }

        public bool SerializarJson(string ruta, List<Cliente> lista)
        {
            bool retorno = true;
            string serializado = String.Empty;
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    serializado = JsonSerializer.Serialize(lista);
                    sw.WriteLine(serializado);
                    retorno = true;
                }
               
            }
            catch (ExceptionControllers e)
            {

                throw new ExceptionControllers("Excepcion controlada...", e);
            }
            return retorno;
        }
    }
}
