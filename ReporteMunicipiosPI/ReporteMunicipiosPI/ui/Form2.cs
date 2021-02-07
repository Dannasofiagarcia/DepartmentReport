using ReporteMunicipiosPI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteMunicipiosPI.ui
{
    public partial class Form2 : Form
    {
        private GraphGenerator graphCreator;

        public Form2(string path)
        {
            InitializeComponent();
            graphCreator = new GraphGenerator();
            graphCreator.GenerateGraphInfo(path);
            Form2_load();
        }
        public void Form2_load()
        {

            List<Department> infoList = graphCreator.GraphInfo;

            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < infoList.Count; i++)
            {
                chart1.Series["Cantidad de municipios"].Points.AddXY(infoList[i].Name, infoList[i].CountMun);
            }

        }

    }
}


