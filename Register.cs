using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarzCo
{
    internal class Register
    {
    }
    public class VechileRegister
    {
        List<Vechil> vechilesList = new List<Vechil>();
        IDictionary<int, Vechil> Invent = new Dictionary<int, Vechil>();


        public void AddListVechil(Vechil car)
        {
            vechilesList.Add(car);
        }

        public void AddDictionaryVechil(Vechil car)
        {
            Invent.Add( car.vinnnumber,car);

        }
        public void RemoveListVechil(Vechil car)
        {
            vechilesList.Remove(car);
        }
        public void RemoveDictionaryVechil(Vechil car)
        {
            Invent.Remove(car.vinnnumber);

        }
        public void SearchListVechil(string input)
        {
            foreach ( Vechil item in vechilesList)
            {
                 if (item.brand == input)
                {
                    item.ThisVechil();
                }
            }
        }
    }
}
