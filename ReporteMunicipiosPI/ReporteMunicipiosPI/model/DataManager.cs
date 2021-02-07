using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReporteMunicipiosPI.Model
{
    class DataManager
    {
        private DataTable table;

        public DataTable Table
        {
            get => table;
        }

        public void refresh()
        {
            table.Clear();
        }

        public void filterByType(string filePath, string tipo)
        {

            string[] lines = System.IO.File.ReadAllLines(filePath);

            if (lines.Length > 1)
            {

                for (int i = 1; i < lines.Length; i++)
                {

                    string[] data = Regex.Split(lines[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    if (data.Length > 0)
                    {
                        if (data[6].Equals(tipo))
                        {
                            DataRow row = table.NewRow();
                            for (int j = 0; j < data.Length; j++)
                            {
                                try
                                {
                                    row[j] = data[j];
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("WARNING");
                                }
                            }

                            table.Rows.Add(row);
                        }
                    }


                }

            }


        }

        public void createTable(string filePath)
        {

            table = new DataTable();

            string[] lines = System.IO.File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                string firstLine = lines[0];

                string[] labels = Regex.Split(firstLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                foreach (string header in labels)
                {
                    table.Columns.Add(new DataColumn(header));
                }

                for (int i = 1; i < lines.Length; i++)
                {


                    string[] dataLine = Regex.Split(lines[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    DataRow row = table.NewRow();

                    for (int j = 0; j < dataLine.Length; j++)
                    {
                        try
                        {

                            row[j] = dataLine[j];
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("WARNING");
                        }
                    }

                    table.Rows.Add(row);
                }

            }

        }
    }
}
