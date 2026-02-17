using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Temperatura03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_max.Enabled = false;
            txt_3min.Enabled = false;
            txt_desviacion.Enabled = false;
            txt_max.Enabled = false;
            txt_min.Enabled = false;
            txt_prom.Enabled = false;
            txtVar.Enabled = false;
            txt_suma.Enabled = false;
            btn_Calcular.Enabled = false;
            btn_Generar.Visible = false;
        }

        #region
        int[] Temp;
        int[] Asc;
        int[] Desc;
        int i, j, min, max, sum = 0, no;
        double prom_f, vari, desv;
        #endregion

        public int suma()
        {
            sum = 0;
            for (int i = 0; i < Temp.Length; i++)
            {
                sum += Temp[i];
            }
            return sum;
        }
        public int maximo()
        {
            for (int i = 0;i < Temp.Length; i++)
            {
                if(i == 0)
                {
                    max = Temp[i];
                }
                else
                {
                    if(max < Temp[i])
                    {
                        max = Temp[i];
                    }
                }
            }
            return max;
        }

        public int minimo()
        {
            for (int i = 0; i < Temp.Length; i++)
            {
                if (i == 0)
                {
                    min = Temp[i];
                }
                else
                {
                    if (min > Temp[i])
                    {
                        min = Temp[i];
                    }
                }
            }
            return min;
        }
        public double promedio()
        {
            int total = suma();
            prom_f = total / no;
            return prom_f;
        }

        public double varianza()
        {
            double media = promedio(),
                sum_c = 0;
            for (i = 0; i < Temp.Length; i++)
            {
                sum_c += Math.Pow(Temp[i] - media, 2);
            }
            vari = sum_c / no - 1;
            return vari;
        }

        public double desviacion()
        {
            return desv = Math.Sqrt(varianza());
        }

        public void OrdenarAscendente()
        {
            Asc = (int[])Temp.Clone();
            for (int i = 0; i < Asc.Length - 1; i++)
            {
                for (int j = 0; j < Asc.Length - i - 1; j++)
                {
                    if (Asc[j] > Asc[j + 1])
                    {
                        int temp = Asc[j];
                        Asc[j] = Asc[j + 1];
                        Asc[j + 1] = temp;
                    }
                }
            }
        }

        public void OrdenarDescendente()
        {
            Desc = (int[])Temp.Clone();
            for (int i = 0; i < Desc.Length - 1; i++)
            {
                for (int j = 0; j < Desc.Length - i - 1; j++)
                {
                    if (Desc[j] < Desc[j + 1])
                    {
                        int temp = Desc[j];
                        Desc[j] = Desc[j + 1];
                        Desc[j + 1] = temp;
                    }
                }
            }
        }

        public string tresMaximas()
        {
            if (Desc == null || Desc.Length == 0) return "";
            int count = Math.Min(3, Desc.Length);
            string resultado = "";
            for (int i = 0; i < count; i++)
            {
                resultado += Desc[i] + " ";
            }
            return resultado.Trim();
        }

        public string tresMinimas()
        {
            if (Asc == null || Asc.Length == 0) return "";
            int count = Math.Min(3, Asc.Length);
            string resultado = "";
            for (int i = 0; i < count; i++)
            {
                resultado += Asc[i] + " ";
            }
            return resultado.Trim();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txt_suma.Text = suma().ToString();
            txt_max.Text = maximo().ToString();
            txt_min.Text = minimo().ToString();
            txt_prom.Text = promedio().ToString();
            txtVar.Text = varianza().ToString();
            txt_desviacion.Text = desviacion().ToString();

            if (Temp.Length >= 3)
            {
                txt_3max.Text = tresMaximas();
                txt_3min.Text = tresMinimas();
            }
            else
            {
                MessageBox.Show("No hay suficientes datos para mostrar las 3 máximas y 3 mínimas.");
                txt_3max.Text = "";
                txt_3min.Text = "";
            }
        }

        private void btn_Graficar_Click(object sender, EventArgs e)
        {
            if (Temp == null || Temp.Length == 0)
            {
                MessageBox.Show("No hay datos para graficar. Genera las temperaturas primero.");
                return;
            }

            chart1.Series.Clear();
            var serie = new Series("Temperaturas");
            serie.ChartType = SeriesChartType.Line;
            serie.Color = Color.Blue;
            serie.BorderWidth = 2;

            for (int index = 0; index < Temp.Length; index++)
            {
                serie.Points.AddXY(index + 1, Temp[index]);
                serie.Points[serie.Points.Count - 1].MarkerSize = 8;
                serie.Points[serie.Points.Count - 1].MarkerStyle = MarkerStyle.Circle;
            }

            chart1.Series.Add(serie);
        }



        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            tem1.Columns.Add("Temperaturas", "Temperaturas");
            

            for (i = 0; i < no; i++)
            {
                Temp[i] = r.Next(-2, 33);
                combo_temp.Items.Add(Temp[i]);
                lis.Items.Add(Temp[i]);
                tem1.Rows.Add(1);
            }

            OrdenarAscendente();
            OrdenarDescendente();
            btn_Generar.Enabled = false;
            btn_Calcular.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtNum.Text.Trim() != "")
            {
                no = Convert.ToInt32(txtNum.Text);
                Temp = new int[no];
                btn_Crear.Enabled = false;
                txtNum.Enabled = false;
                btn_Generar.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Ingrese número de temperaturas");
                txtNum.Focus();
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            
            txt_max.Clear();
            txt_min.Clear();
            txt_prom.Clear();
            txt_suma.Clear();
            txtVar.Clear();
            txt_desviacion.Clear();
            txt_3max.Clear();
            txt_3min.Clear();
            txtNum.Clear();

            combo_temp.Items.Clear();
            lis.Items.Clear();

            chart1.Series.Clear();

            if (tem1 != null)
            {
                tem1.Rows.Clear();
                tem1.Columns.Clear();
            }

            btn_Crear.Enabled = true;
            btn_Generar.Enabled = true;
            btn_Calcular.Enabled = false;
            txtNum.Enabled = true;
            btn_Generar.Visible = false;

            Temp = null;
            Asc = null;
            Desc = null;
            sum = 0;
            max = 0;
            min = 0;
            no = 0;
            prom_f = 0;
            vari = 0;
            desv = 0;
        }

    }
}
