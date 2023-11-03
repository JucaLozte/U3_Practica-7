using System.Diagnostics.CodeAnalysis;

namespace U3_Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rangoinf, rangosup, suma = 0;

            rangoinf = int.Parse(textBox1.Text);
            rangosup = int.Parse(textBox2.Text);

            for (int i = rangoinf ; i <= rangosup; i++)
            {
                listBox1.Items.Add(i);
                suma = suma + i;
            }
            textBox3.Text = suma.ToString();
        }   
    }
}