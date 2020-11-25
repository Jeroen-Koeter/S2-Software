using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein.Tests
{
    [TestClass()]
    public class AddAnimalTest
    {
        [TestMethod()]
        public void AddAnimalTest1()
        {
            // arrange
            string voedselkeuze = "1";
            string grote = "3";
            string naam = "testdier";

            // act
            Dier dier = Algoritme.AddAnimal(naam, voedselkeuze, grote);

            // assert
            Assert.IsNotNull(dier);
        }
    }
} 