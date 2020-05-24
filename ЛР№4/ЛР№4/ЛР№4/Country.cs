using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР_4
{
    class Country
    {
        public string nameCountry;
        public int population;
        protected int numberCities;
        private double area;

        public string NameCountry { get => nameCountry; set => nameCountry = value; }
        public int Population { get => population; set => population = value; }
        protected int NumberCities { set => numberCities = value; }
        private double A { set; get; }

        public int getNumberCities()
        {
            return numberCities;
        }
        protected void SetArea(double ar)
        {
            area = ar;
        }
        private void AddToPopulation(int kol)
        {
            population += kol;
        }

        public Country()
        {
            nameCountry = "Россия";
            population = 144500000;
            numberCities = 1117;
            area = 17100000;
        }

        private Country(string name, int popul, int numCont, double ar)
        {
            nameCountry = name;
            population = popul;
            numberCities = numCont;
            area = ar;
        }
    }
}
