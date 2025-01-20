using System;
using System.Windows.Forms;

namespace калькулятор_процентов
{
    public partial class Form1 : Form
    {
        private object textbox1;

        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
            this.Controls.Add(textBox4);
            this.Controls.Add(textBox5);
            this.Controls.Add(textBox6);
            this.Controls.Add(textBox7);
            this.Controls.Add(textBox8);
            this.Controls.Add(res);
            this.Controls.Add(textBox10);
            this.Controls.Add(textBox11);
            this.Controls.Add(textBox12);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
            this.Controls.Add(button4);
            this.Controls.Add(button5);
            this.Controls.Add(button6);
            this.Controls.Add(button7);
            this.Controls.Add(button8);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;
            // Попытка преобразовать текст из полей ввода
            if (double.TryParse(textBox1.Text, out double mainNumber) && double.TryParse(textBox2.Text, out double percentage))
            {
                // Вычисление процента
                double result = (mainNumber * percentage) / 100;
                // Отображение результата
                res.Text = $"{percentage}% от {mainNumber} составляет {result}.";
            }
            else
            {
                // Если есть ошибка в вводе, выводим сообщение
                MessageBox.Show("Пожалуйста, введите корректные числа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
