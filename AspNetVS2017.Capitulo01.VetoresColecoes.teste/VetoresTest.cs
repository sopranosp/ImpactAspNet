using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.VetoresColecoes.teste
{
    [TestClass]
    public class VetoresTest
    {
        [TestMethod]
        public void InicializacaoTest()
        {

            var strings = new string[10]; // criando vetor 
            strings[0] = "A";
            strings[1] = "Outra Coisa";
            strings[2] = "B";
            strings[3] = "C";
            strings[4] = "D";

            var decimais = new decimal[3] { 0.5m, 0.78m, 1.59m };


            ///  decimal[] novodeciaml = { 2, 3, 5.9m };   ---> é aceito 

            foreach (var @numero in decimais)
            {
                Console.WriteLine(@numero);
            }


            Console.WriteLine($" Tamanho do Vetor: {decimais.Length}");

        }


        [TestMethod]
        public void RedimensionamentoTest()
        {
            var decimais = new decimal[] { 0.5m, 78, 1.5m };
            Array.Resize(ref decimais, 5);
            decimais[3] = 20.01m;



        }


        [TestMethod]
        public void OrdenacaoTest()
        {

            var decimais = new decimal[] { 35.89m, 0.5m, 1.5m };
            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], 0.5m);


        }



        //private decimal Media(decimal v1, decimal v2)
        //{
        //    return (v1 + v2) / 2;

        //}

        private decimal Media(decimal[] valores)
        {

            decimal media = 0;
            var qtdItens = valores.Length;
            decimal total = 0;

            foreach (var @decimal in valores)
            {
                total += @decimal;
            }
            media = total / qtdItens;
            return media;


        }



        //    [TestMethod]
        //    public void ParamsTest()
        //    {


        //        Console.WriteLine(Media());
        //    }

        //    private decimal Media(decimal v1, decimal v2)
        //    {
        //        return
        //    }
        //}





        [TestMethod]
        public void TodaStringehUMVetorTest()
        {
            const string nome = "Hejsberg";
            Assert.AreEqual(nome[0], 'H');

            foreach (var @char in nome)
            {
                Console.WriteLine(@char);
            }


        }

    }
}
