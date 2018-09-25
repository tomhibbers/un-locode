using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Text;
using LumenWorks.Framework.IO.Csv;
using UNLOCODE.Models;

namespace UNLOCODE.Tools
{
    public static class Util
    {
        public static IEnumerable<Code> ParseUnlocodecsv(StreamReader reader)
        {
            using (var csv = new CachedCsvReader(reader, hasHeaders: true))
            {
                var e = new DbEnumerator(csv);
                while (e.MoveNext())
                {
                    if (e.Current == null) continue;
                    var record = (IDataRecord)e.Current;

                    if (record.FieldCount == 0) continue;
                    var code = new Code()
                    {
                        Country = (string)record.GetValue(1),
                        Location = (string)record.GetValue(2),
                        Name = (string)record.GetValue(3),
                        NameWoDiacritics = (string)record.GetValue(4),
                    };
                    yield return code;
                }
            }
        }
    }
}
