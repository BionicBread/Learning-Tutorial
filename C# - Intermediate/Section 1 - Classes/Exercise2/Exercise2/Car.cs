using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Car
    {
        private string _make;
        private string _model;
        private int _year;

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this._model = model;
            this._year = year;

        }

        public string Make 
        {
            get 
            { 
                return _make; 
            }
            set 
            {
                _make = value.ToLower();
                
            } 
        }

    }
}
