
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
namespace JamesApp
{
    public static class Dt_To_CSV
    {
        public static void WriteDataTable(DataTable sourceTable, TextWriter writer, bool includeHeaders)
        {
            if (includeHeaders)
            {
                IEnumerable<string> headerValues = sourceTable.Columns
                    .OfType<DataColumn>()
                    .Select(column => QuoteValue(column.ColumnName));

                writer.WriteLine(string.Join(",", headerValues));
            }

            IEnumerable<string> items = null;

            foreach (DataRow row in sourceTable.Rows)
            {
                items = row.ItemArray.Select(o => QuoteValue(o?.ToString() ?? string.Empty));
                writer.WriteLine(string.Join(",", items));
            }

            writer.Flush();
        }

        private static string QuoteValue(string value)
        {
            return string.Concat("\"",
            value.Replace("\"", "\"\""), "\"");
        }
    }
}
