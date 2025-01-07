using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
        #region Attributes

        private int id;
        private string? model;
        private double speed;

        #endregion;

        #region properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string? Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion

        // if no user define constructor exists, compiler will always generate empty parameterless constructor

        public Car(int id, string? model, double speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;

            Console.WriteLine("Constructor 01");
        }

        public Car(int id, string? model) : this(id, model, 120) //Constructor Chaining
        {
            //this.id = id;
            //this.model = model;
            //this.speed = 120;

            Console.WriteLine("Constructor 02");
        }

        public Car(int id) : this(id, " Hyndai Verna 2010", 120)
        {
            // this.id = id;
            //  this.model = " Hyndai Verna 2010";
            //  this.speed = 100;
            Console.WriteLine("Constructor 03");

        }

        #region methods
        public override string ToString()
        {
            return $"Id={id}\n Model={model}\n Speed={speed}";
        }
        #endregion
    }
}
