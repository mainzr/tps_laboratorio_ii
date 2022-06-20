using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void ClientesIguales_RetornaTrueSiClietesSonIguales()
        {
            //Arrege
            bool esperado = true;
            Registro r = new Registro();
            Cliente c2 = new Cliente("Maria", "Agnora", "Piedras", "1298007421", "maria@gmail.com", "1080", new ComidaJaponesa("Udon", "Japonesa", 1500));
            Cliente c = new Cliente("Maria", "Agnora", "Piedras", "1298007421", "maria@gmail.com", "1080", new ComidaJaponesa("Udon", "Japonesa", 1500));
            bool actual;
            //Act
            actual = (c == c2);
            //assert
            Assert.AreEqual(esperado, actual);

        }

        [TestMethod]
        public void BuscarCliente_RetornaTrueSiClienteFueEncontrado()
        {
            //Arrege
            bool esperado = true;
            Registro r = new Registro();
            Cliente c = new Cliente("Maria", "Agnora", "Piedras", "1298007421", "maria@gmail.com", "1080", new ComidaJaponesa("Udon", "Japonesa", 1500));
            r.Lista.Add(c);
            bool actual;
            //Act
            actual = r.BuscarCliente("1080");
            //assert
            Assert.AreEqual(esperado, actual);

        }
    }
}
