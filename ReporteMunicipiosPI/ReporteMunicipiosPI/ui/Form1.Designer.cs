
namespace ReporteMunicipiosPI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1052, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar archivo de datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(176, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(819, 31);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDepartamento,
            this.codigoMunicipio,
            this.nombreDepartamento,
            this.nombreMunicipio,
            this.tipoArea});
            this.dataGridView1.Location = new System.Drawing.Point(38, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1373, 463);
            this.dataGridView1.TabIndex = 2;
            // 
            // codigoDepartamento
            // 
            this.codigoDepartamento.HeaderText = "Código departamento";
            this.codigoDepartamento.MinimumWidth = 10;
            this.codigoDepartamento.Name = "codigoDepartamento";
            this.codigoDepartamento.ReadOnly = true;
            this.codigoDepartamento.Width = 200;
            // 
            // codigoMunicipio
            // 
            this.codigoMunicipio.HeaderText = "Código Municipio";
            this.codigoMunicipio.MinimumWidth = 10;
            this.codigoMunicipio.Name = "codigoMunicipio";
            this.codigoMunicipio.ReadOnly = true;
            this.codigoMunicipio.Width = 200;
            // 
            // nombreDepartamento
            // 
            this.nombreDepartamento.HeaderText = "Nombre del departamento";
            this.nombreDepartamento.MinimumWidth = 10;
            this.nombreDepartamento.Name = "nombreDepartamento";
            this.nombreDepartamento.ReadOnly = true;
            this.nombreDepartamento.Width = 200;
            // 
            // nombreMunicipio
            // 
            this.nombreMunicipio.HeaderText = "Nombre del municipio";
            this.nombreMunicipio.MinimumWidth = 10;
            this.nombreMunicipio.Name = "nombreMunicipio";
            this.nombreMunicipio.ReadOnly = true;
            this.nombreMunicipio.Width = 200;
            // 
            // tipoArea
            // 
            this.tipoArea.HeaderText = "Tipo: Municipio/Isla/Área no municipada";
            this.tipoArea.MinimumWidth = 10;
            this.tipoArea.Name = "tipoArea";
            this.tipoArea.ReadOnly = true;
            this.tipoArea.Width = 200;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(758, 612);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Municipio",
            "Isla",
            "Área no municipada"});
            this.comboBox1.Location = new System.Drawing.Point(229, 626);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(434, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1033, 612);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 49);
            this.button3.TabIndex = 5;
            this.button3.Text = "Generar gráfico";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 687);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoArea;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

