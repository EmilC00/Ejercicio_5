using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejecutar_btn_Click(object sender, EventArgs e)
        {
            int[,] MatrizDos = new int[Convert.ToInt32(fila_txt.Text), Convert.ToInt32(col_txt.Text)];
            //Clase_Matriz_Random
            Random aleatorio = new Random();

            for (int fila = 0; fila < MatrizDos.GetLength(0); fila++)
            {
                for (int col = 0; col < MatrizDos.GetLength(1); col++)
                {
                    MatrizDos[fila, col] = aleatorio.Next(0, 100);
                }
            }

            for (int fila = 0; fila < MatrizDos.GetLength(0); fila++)
            {
                for (int col = 0; col < MatrizDos.GetLength(1); col++)
                {
                    MessageBox.Show("La posición es: " + fila + ", " + col + " = " + MatrizDos[fila, col].ToString());
                }
            }
        }
    }
}
