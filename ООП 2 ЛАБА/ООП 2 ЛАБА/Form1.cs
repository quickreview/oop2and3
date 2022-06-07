using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_2_ЛАБА
{
    public partial class FruitShop : Form
    {
        public FruitShop()
        {
            InitializeComponent();

            monthCalendar1_DateChanged(this, null);

            comboBox1_SelectedIndexChanged(this, null);

            textBox1_TextChanged(this, null);
            LabelEnable();

        }

        private void LabelEnable()
        {
            label1_Click(this, null);
            label2_Click(this, null);
            label3_Click(this, null);
            label4_Click(this, null);
            label5_Click(this, null);
            label6_Click(this, null);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
              
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Sorted = true; 

            comboBox1.Items.Add("Банан");
            comboBox1.Items.Add("Апельсин");
            comboBox1.Items.Add("Авокадо");
            comboBox1.Items.Add("Лимон");
            comboBox1.Items.Add("Гранат");
            comboBox1.Items.Add("Яблоко");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
          // окно вывода 
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // ввод кг за р 
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Выберите продукт :";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Выберите дату завоза :";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Введите стоимость фрукта за 1кг :";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "Окно вывода информации о фруктах :";
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            
            InformationOnFruit informations = new InformationOnFruit(comboBox1.Text, sizeGroup.Text ,
                 CostFruit.Text , countryCreate.Text , monthCalendar1.SelectionEnd);
          

            WindowOutPut.Text += informations.InformationOnFruitOut( ); 
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            // размер партии
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "Размер партиии : ";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = "Страна производства : ";
        }

        private void FruitShop_Load(object sender, EventArgs e)
        {

        }
    }
}
