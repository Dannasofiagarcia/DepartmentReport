using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReporteMunicipiosPI.Model
{
    class GraphGenerator
    {
        List<Department> graphInfo;

        public GraphGenerator()
        {
            graphInfo = new List<Department>();
        }

        public List<Department> GraphInfo
        {
            get => graphInfo;
        }

        public void GenerateGraphInfo(string filePath)
        {

            string[] lines = System.IO.File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {

                for (int i = 1; i < lines.Length; i++)
                {
                    //This will ignore commas between double quotes in the CSV file
                    string[] dataLine = Regex.Split(lines[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    for (int j = 0; j < dataLine.Length; j++)
                    {
                        if (graphInfo.Count == 0)
                        {
                            graphInfo.Add(new Department(dataLine[2], 1));
                        }
                        else
                        {
                            bool found = false;

                            for (int k = 0; k < graphInfo.Count && !found; k++)
                            {
                                if (graphInfo[k].Name == dataLine[2])
                                {
                                    graphInfo[k].CountMun++;
                                    found = true;
                                }
                            }

                            if (!found)
                            {
                                graphInfo.Add(new Department(dataLine[2], 1));
                            }

                        }

                    }
                }

            }

        }
    }
}
