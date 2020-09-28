using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Chapter3
{

    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong"
            };
            var query = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var length in query)
            {
                Console.WriteLine(length);
            }
        }
    }
}
