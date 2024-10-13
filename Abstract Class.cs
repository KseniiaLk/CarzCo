using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarzCo
{
    internal class Abstract_Class
    {
    }
        public interface IDrive

        {
            void ThisVechil();
            void Drive();
        }
        public abstract class Vechil

        {
            protected Vechil(string brand, string model, int vinnnumber, int productionnum)
            {
                this.brand = brand;
                this.model = model;
                this.vinnnumber = vinnnumber;
                this.productionnum = productionnum;
            }

            public string brand { get; set; }
            public string model { get; set; }
            public int vinnnumber { get; set; }
            public int productionnum { get; set; }
            public string vechiltype { get; set; }
            public string vechil_class { get; set; }

            public void ThisVechil()
            {
                Console.WriteLine($" {brand}, {model}, {vinnnumber}");
            }
            public void Drive()
            {
                Console.WriteLine($"The {vechiltype} is driving");
            }
        }

        public class Car : Vechil, IDrive
        {
            public Car(string brand, string model, int vinnnumber, int productionnum) : base(brand, model, vinnnumber, productionnum)
            {
                this.vechiltype = "car";
                this.vechil_class = "private";
            }
        }
        public class Motorbike : Vechil, IDrive
        {
            public Motorbike(string brand, string model, int vinnnumber, int productionnum) : base(brand, model, vinnnumber, productionnum)
            {
                this.vechiltype = "motorbike";
                this.vechil_class = "public";
            }
        }
        public class Truck : Vechil, IDrive
        {
            public Truck(string brand, string model, int vinnnumber, int productionnum) : base(brand, model, vinnnumber, productionnum)
            {
                this.vechiltype = "truck";
                this.vechil_class = "private";
            }
        }
        public class Bicycle : Vechil, IDrive
        {
            public int gear { get; set; }
            public Bicycle(string brand, string model, int vinnnumber, int productionnum, int gear) : base(brand, model, vinnnumber, productionnum)
            {
                this.vechiltype = "bicycle";
                this.vechil_class = "company";
                this.gear = gear;
            }
        }
        public class Crain : Vechil, IDrive
        {
            public int maxreach  { get; set; }
            public Crain(string brand, string model, int vinnnumber, int productionnum) : base(brand, model, vinnnumber, productionnum)
            {
                this.vechiltype = "crain";
                this.vechil_class = "industrial";
                this.maxreach = 20 ;

            }
        }
    }


