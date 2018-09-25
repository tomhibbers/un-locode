using System;
using System.Linq;

namespace UNLOCODE.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var codes = UNLOCODE.Repositories.Repository.UNLOCODEs.Where(z => z.Name.Contains("South"))?.ToList();
        }
    }
}
