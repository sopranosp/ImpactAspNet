using System;
using System.Text;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AspnetVS2017.Capitulo01.VetoresColecionaveis
{
    [TestClass]
    public class ColecoesTest
    {
        [TestMethod]
        public void ListTest()
        {
            var inteiros = new List<int>(50) { 2,1,2,6,125}; //manipulacao de listas

            inteiros.Add(22);

            var maisInteiros = new List<int> { 21, 72, 14,6 };
            inteiros.AddRange(maisInteiros);

            inteiros.Insert(0, 29);

            inteiros.Remove(2); // remove o elemento

            inteiros.RemoveAt(4); // remove o elemento pelo o seu indice

            inteiros.Sort(); // agrupa
            inteiros.First(); //lista o primeiro 
            var primeiro = inteiros.FirstOrDefault();

            var ultimos = inteiros.LastOrDefault();
            var ultimo = inteiros[inteiros.Count - 1];

            //foreach (var inteiro in inteiros)
            //{
            //    Console.WriteLine($"{inteiros.IndexOf(inteiro)}:{inteiro} ");
            //}



            //for (int i = 0; i < inteiros.Count; i++)
            //{
            //    Console.WriteLine("Inteiro = "  i );
            //}



        }


        [TestMethod]
        public void DicionarioTest()
        {

            var feriados = new Dictionary<DateTime, string>();

            feriados.Add(new DateTime(2018,12,25), "Natal");
            feriados.Add(new DateTime(2019, 1, 1), "Ano Novo");
            feriados.Add(new DateTime(2019, 3, 14), "Pascoa");

            var natal = feriados[new DateTime(2018, 12, 25)];


            foreach (var feriado in feriados)
            {
                Console.WriteLine(String.Format("{0:dd/MM}",feriado.Key,feriado.Value));
            }




            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime ("25/12/2018")));

            Console.WriteLine(feriados.ContainsValue("Ano Novo"));
 
        }


    }
}
