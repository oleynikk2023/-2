using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛАБА2
{
    internal class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private string house;
        private int apartament;
        public int Index
        {
            get { return index; }
            set { index = value; }

        }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public StringDictionary Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string House { get => house; set => house = value; }
        public string Apartment { get => apartment; set => apartment = value; }




    }
}
    }
}
