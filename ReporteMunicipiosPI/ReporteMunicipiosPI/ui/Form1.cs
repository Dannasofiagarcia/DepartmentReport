using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteMunicipiosPI
{
    public partial class Form1 : Form
    {

        private Model.DataManager dataManager;

        public Form1()
        {
            InitializeComponent();
            dataManager = new Model.dataManager;
        }

        //Button 1 cargar archivo de datos
        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();

            textBox1.Text = openFileDialog1.FileName;

            string path = textBox1.Text;

            dataManager.createTable(path);

            if (dataManager.Table != null)
                dataGridView1.DataSource = dataManager.Table;
        }

        //Button 2 generar gráfico
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != null)
            {
                textBox1.Text = openFileDialog1.FileName;
                Form2 form2 = new Form2(textBox1.Text.ToString());
                form2.ShowDialog();
            }
        }


        //Combox de tipo para filtrar
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
