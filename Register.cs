using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPlate
{
    class Register
    {
        private string numberPlate;
        private string type;
        private string nameOfOwner;
        private int yearOfProduction;
        private DateTime motTestValidity;
        private bool isGasoline;

        public string NumberPlate
        {
            get { return numberPlate; }
            set { numberPlate = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string NameOfOwner
        {
            get { return nameOfOwner; }
            set { nameOfOwner = value; }
        }

        public int YearOfProduction
        {
            get { return yearOfProduction; }
            set { yearOfProduction = value; }
        }

        public DateTime MotTestValidity
        {
            get { return motTestValidity; }
            set { motTestValidity = value; }
        }

        public bool IsGasoline
        {
            get { return isGasoline; }
            set
            {
                isGasoline = value;
            }
        }
    }
}
