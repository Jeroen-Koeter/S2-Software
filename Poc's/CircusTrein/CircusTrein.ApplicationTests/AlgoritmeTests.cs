using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using CircusTrein.Application;

namespace CircusTrein.Tests
{
    [TestClass()]
    public class AlgoritmeTests
    {
        [TestMethod()]
        public void RunAlgoritmeTest()
        {
            //arrange
            List<Dier> dieren = new List<Dier>();
            dieren.Add(new Dier("herbivoor klein 1", Dier.Dieet.herbivoor, Dier.Grote.klein));
            dieren.Add(new Dier("herbivoor klein 2", Dier.Dieet.herbivoor, Dier.Grote.klein));
            dieren.Add(new Dier("herbivoor middel 1", Dier.Dieet.herbivoor, Dier.Grote.middel));
            dieren.Add(new Dier("herbivoor middel 2", Dier.Dieet.herbivoor, Dier.Grote.middel));
            dieren.Add(new Dier("herbivoor groot 1", Dier.Dieet.herbivoor, Dier.Grote.groot));
            dieren.Add(new Dier("herbivoor groot 2", Dier.Dieet.herbivoor, Dier.Grote.groot));
            dieren.Add(new Dier("herbivoor groot 3", Dier.Dieet.herbivoor, Dier.Grote.groot));
            dieren.Add(new Dier("carnivoor klein", Dier.Dieet.carnivoor, Dier.Grote.klein));
            dieren.Add(new Dier("carnivoor middel", Dier.Dieet.carnivoor, Dier.Grote.middel));
            dieren.Add(new Dier("carnivoor groot 1", Dier.Dieet.carnivoor, Dier.Grote.groot));
            dieren.Add(new Dier("carnivoor groot 2", Dier.Dieet.carnivoor, Dier.Grote.groot));
            dieren.Add(new Dier("carnivoor groot 3", Dier.Dieet.carnivoor, Dier.Grote.groot));
            dieren.Add(new Dier("carnivoor groot 4", Dier.Dieet.carnivoor, Dier.Grote.groot));

            //act
            List<Wagon> wagons = Algoritme.RunAlgoritme(dieren);

            //assert 
            Assert.IsNotNull(wagons);
        }
    }
}