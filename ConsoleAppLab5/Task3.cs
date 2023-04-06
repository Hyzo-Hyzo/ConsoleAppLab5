using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab5
{
    public class City
    {
        private string name;
        private int population;

        public City(string name, int population)
        {
            this.name = name;
            this.population = population;
        }

        public string Name
        {
            get { return name; }
        }

        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public static City operator +(City city, int value)
        {
            return new City(city.name, city.population + value);
        }

        public static City operator -(City city, int value)
        {
            return new City(city.name, city.population - value);
        }

        public static bool operator ==(City city1, City city2)
        {
            if (ReferenceEquals(city1, city2))
            {
                return true;
            }

            if (city1 is null || city2 is null)
            {
                return false;
            }

            return city1.population == city2.population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return !(city1 == city2);
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.population > city2.population;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.population < city2.population;
        }

        public override bool Equals(object obj)
        {
            if (obj is City otherCity)
            {
                return this.population == otherCity.population;
            }
            else
            {
                return false;
            }
        }
    }
}

