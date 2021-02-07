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
        private GraphCreator graphCreator;

        public Form2(string path)
        {
            InitializeComponent();
            graphCreator = new GraphCreator();
            graphCreator.GenerateGraphInfo(path);
            Form2_load();
        }

    }
}


