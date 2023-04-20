using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            combo_operaciones.Items.Add("Numeros Primos");
            combo_operaciones.Items.Add("Numeros Perfectos");
            combo_operaciones.Items.Add("Serie Fibonacci");
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            int numero = Convert.ToInt32(txt_ingresar.Text);
            string seleccionador = combo_operaciones.Text;
            if(seleccionador == "Numeros Primos")
            {
                int div = 2;
                int divi = 1;
                int cont = 0;
                while(div <= numero) 
                {
                    while (divi <= div)
                    {
                        if (div % divi == 0)
                        {
                            cont++;
                        }
                        divi++;
                    }
                    if (cont == 2)
                    {
                        listBox.Items.Add(div);
                    }
                    div++;
                    divi = 1;
                    cont = 0;
                }
            }
            if(seleccionador == "Serie Fibonacci")
            {
                int num = 0;
                int num1 = 1;
                listBox.Items.Add(num);
                for(int i = 0;i < numero; i++)
                {
                    int temp = num;
                    num = num1;
                    num1 = temp + num;
                    listBox.Items.Add(num);
                }
            }
            if(seleccionador == "Numeros Perfectos")
            {
                int num2;
                string divisores = "";
                for(int i = 1; i <= numero; i++)
                {
                    num2 = 0;
                    for(int j = 1; j <= (i / 2); j++)
                    {
                        if (i % j == 0)
                        {
                            num2 += j;
                            divisores += j;
                        }
                    }
                    if(num2 == i)
                        listBox.Items.Add(divisores);
                    divisores = "";

                }
            }
        }
    }
}
