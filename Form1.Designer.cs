namespace Temperatura03
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel_temp = new System.Windows.Forms.Panel();
            this.btn_Generar = new System.Windows.Forms.Button();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_temp = new System.Windows.Forms.ComboBox();
            this.lis = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Graficar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_suma = new System.Windows.Forms.TextBox();
            this.txt_3min = new System.Windows.Forms.TextBox();
            this.txt_3max = new System.Windows.Forms.TextBox();
            this.txt_desviacion = new System.Windows.Forms.TextBox();
            this.txtVar = new System.Windows.Forms.TextBox();
            this.txt_prom = new System.Windows.Forms.TextBox();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.tem2 = new System.Windows.Forms.DataGridView();
            this.tem3 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tem1 = new System.Windows.Forms.DataGridView();
            this.Panel_temp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tem1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_temp
            // 
            this.Panel_temp.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Panel_temp.Controls.Add(this.btn_Generar);
            this.Panel_temp.Controls.Add(this.btn_Crear);
            this.Panel_temp.Controls.Add(this.txtNum);
            this.Panel_temp.Controls.Add(this.label1);
            this.Panel_temp.Location = new System.Drawing.Point(15, 102);
            this.Panel_temp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_temp.Name = "Panel_temp";
            this.Panel_temp.Size = new System.Drawing.Size(233, 125);
            this.Panel_temp.TabIndex = 0;
            // 
            // btn_Generar
            // 
            this.btn_Generar.Location = new System.Drawing.Point(133, 69);
            this.btn_Generar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(84, 29);
            this.btn_Generar.TabIndex = 3;
            this.btn_Generar.Text = "Generar";
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(21, 68);
            this.btn_Crear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(84, 29);
            this.btn_Crear.TabIndex = 2;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(147, 14);
            this.txtNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(70, 26);
            this.txtNum.TabIndex = 1;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Temperatura: ";
            // 
            // combo_temp
            // 
            this.combo_temp.FormattingEnabled = true;
            this.combo_temp.Location = new System.Drawing.Point(270, 112);
            this.combo_temp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_temp.Name = "combo_temp";
            this.combo_temp.Size = new System.Drawing.Size(136, 28);
            this.combo_temp.TabIndex = 1;
            this.combo_temp.Text = "Temperaturas";
            // 
            // lis
            // 
            this.lis.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lis.FormattingEnabled = true;
            this.lis.ItemHeight = 20;
            this.lis.Location = new System.Drawing.Point(270, 153);
            this.lis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lis.Name = "lis";
            this.lis.Size = new System.Drawing.Size(185, 64);
            this.lis.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(496, 102);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(338, 375);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chrTem";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightPink;
            this.groupBox1.Controls.Add(this.btn_Graficar);
            this.groupBox1.Controls.Add(this.btn_Calcular);
            this.groupBox1.Controls.Add(this.txt_suma);
            this.groupBox1.Controls.Add(this.txt_3min);
            this.groupBox1.Controls.Add(this.txt_3max);
            this.groupBox1.Controls.Add(this.txt_desviacion);
            this.groupBox1.Controls.Add(this.txtVar);
            this.groupBox1.Controls.Add(this.txt_prom);
            this.groupBox1.Controls.Add(this.txt_min);
            this.groupBox1.Controls.Add(this.txt_max);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(856, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(266, 375);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btn_Graficar
            // 
            this.btn_Graficar.Location = new System.Drawing.Point(160, 328);
            this.btn_Graficar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Graficar.Name = "btn_Graficar";
            this.btn_Graficar.Size = new System.Drawing.Size(84, 29);
            this.btn_Graficar.TabIndex = 22;
            this.btn_Graficar.Text = "Graficar";
            this.btn_Graficar.UseVisualStyleBackColor = true;
            this.btn_Graficar.Click += new System.EventHandler(this.btn_Graficar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(28, 328);
            this.btn_Calcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(84, 29);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txt_suma
            // 
            this.txt_suma.Enabled = false;
            this.txt_suma.Location = new System.Drawing.Point(132, 279);
            this.txt_suma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_suma.Name = "txt_suma";
            this.txt_suma.Size = new System.Drawing.Size(112, 26);
            this.txt_suma.TabIndex = 21;
            // 
            // txt_3min
            // 
            this.txt_3min.Enabled = false;
            this.txt_3min.Location = new System.Drawing.Point(132, 244);
            this.txt_3min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_3min.Name = "txt_3min";
            this.txt_3min.Size = new System.Drawing.Size(112, 26);
            this.txt_3min.TabIndex = 20;
            // 
            // txt_3max
            // 
            this.txt_3max.Enabled = false;
            this.txt_3max.Location = new System.Drawing.Point(132, 209);
            this.txt_3max.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_3max.Name = "txt_3max";
            this.txt_3max.Size = new System.Drawing.Size(112, 26);
            this.txt_3max.TabIndex = 19;
            // 
            // txt_desviacion
            // 
            this.txt_desviacion.Enabled = false;
            this.txt_desviacion.Location = new System.Drawing.Point(132, 174);
            this.txt_desviacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_desviacion.Name = "txt_desviacion";
            this.txt_desviacion.Size = new System.Drawing.Size(112, 26);
            this.txt_desviacion.TabIndex = 18;
            // 
            // txtVar
            // 
            this.txtVar.Enabled = false;
            this.txtVar.Location = new System.Drawing.Point(132, 139);
            this.txtVar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVar.Name = "txtVar";
            this.txtVar.Size = new System.Drawing.Size(112, 26);
            this.txtVar.TabIndex = 17;
            // 
            // txt_prom
            // 
            this.txt_prom.Enabled = false;
            this.txt_prom.Location = new System.Drawing.Point(132, 104);
            this.txt_prom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_prom.Name = "txt_prom";
            this.txt_prom.Size = new System.Drawing.Size(112, 26);
            this.txt_prom.TabIndex = 16;
            // 
            // txt_min
            // 
            this.txt_min.Enabled = false;
            this.txt_min.Location = new System.Drawing.Point(132, 69);
            this.txt_min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(112, 26);
            this.txt_min.TabIndex = 15;
            // 
            // txt_max
            // 
            this.txt_max.Enabled = false;
            this.txt_max.Location = new System.Drawing.Point(132, 34);
            this.txt_max.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(112, 26);
            this.txt_max.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Suma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "3 Mínimas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Desv.Estandar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "3 Máximas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Varianza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Promedio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mínimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Máximo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 71);
            this.label2.TabIndex = 6;
            this.label2.Text = "Temperatura";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(496, 505);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(84, 29);
            this.btn_Limpiar.TabIndex = 23;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(749, 505);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(84, 29);
            this.btn_Salir.TabIndex = 24;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tem2
            // 
            this.tem2.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.tem2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tem2.Location = new System.Drawing.Point(336, 402);
            this.tem2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tem2.Name = "tem2";
            this.tem2.RowHeadersWidth = 51;
            this.tem2.RowTemplate.Height = 24;
            this.tem2.Size = new System.Drawing.Size(143, 132);
            this.tem2.TabIndex = 25;
            // 
            // tem3
            // 
            this.tem3.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.tem3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tem3.Location = new System.Drawing.Point(336, 241);
            this.tem3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tem3.Name = "tem3";
            this.tem3.RowHeadersWidth = 51;
            this.tem3.RowTemplate.Height = 24;
            this.tem3.Size = new System.Drawing.Size(143, 139);
            this.tem3.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // tem1
            // 
            this.tem1.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.tem1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tem1.Location = new System.Drawing.Point(15, 244);
            this.tem1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tem1.Name = "tem1";
            this.tem1.RowHeadersWidth = 51;
            this.tem1.RowTemplate.Height = 24;
            this.tem1.Size = new System.Drawing.Size(304, 290);
            this.tem1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1136, 618);
            this.Controls.Add(this.tem1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tem3);
            this.Controls.Add(this.tem2);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lis);
            this.Controls.Add(this.combo_temp);
            this.Controls.Add(this.Panel_temp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel_temp.ResumeLayout(false);
            this.Panel_temp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_temp;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_temp;
        private System.Windows.Forms.ListBox lis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Graficar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_suma;
        private System.Windows.Forms.TextBox txt_3min;
        private System.Windows.Forms.TextBox txt_3max;
        private System.Windows.Forms.TextBox txt_desviacion;
        private System.Windows.Forms.TextBox txtVar;
        private System.Windows.Forms.TextBox txt_prom;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView tem2;
        private System.Windows.Forms.DataGridView tem3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tem1;
    }
}

