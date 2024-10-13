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

        public void AddListVechil(Vechil vechil)
        {
            vechilesList.Add(vechil);
        }

    }
}
