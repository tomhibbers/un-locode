using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UNLOCODE.Models;
using UNLOCODE.Tools;

namespace UNLOCODE.Repositories
{
    public static class Repository
    {
        public static IEnumerable<Code> UNLOCODEs { get; set; }

        static Repository()
        {
            UNLOCODEs=Util.ParseUnlocodecsv(new StreamReader(@"Data\code-list_csv.csv"));
        }
    }
}
