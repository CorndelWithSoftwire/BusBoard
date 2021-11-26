using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.Api
{
    static class UserInput
    {
        public static string GetInput(string query)
        {
            Console.WriteLine(query);
            return Console.ReadLine();
        }
    }
}
