using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chen_Perfect_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int num1=0, num2=0;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
                if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
                { //kullanıcının hangi kutuya büyük yazacağı belli olmadığı için
                    num2 = int.Parse(textBox1.Text);
                    num1 = int.Parse(textBox2.Text);
                }
                else
                {
                    num2 = int.Parse(textBox2.Text);
                    num1 = int.Parse(textBox1.Text);
                }
            if (radioButton2.Checked == true) // chain number
            {
                listBox2.Items.Clear();

                int chen = 0;
                int a=0;
               
                for (int i = num1; i <= num2; i++)
                {
                    chen = i + 2;
                    sum = 0;
                    for (int j = 1; j <= chen; j++)
                    {
                        if (i % j == 0)
                            sum += 1;    
                        
                        for (int m = 1; m <= chen; m++)
                        {
                            if (chen % m == 0)
                                a += 1;
                        }
                        
                    }
                    if (sum == 2)
                        listBox2.Items.Add(i.ToString());
                    if (a == 2 && sum == 2)
                        listBox2.Items.Add("(" + i + "," + chen + ")".ToString());

                }


            }
            else if (radioButton1.Checked == true) //perfect number
            {
                listBox1.Items.Clear();
                
               
               
                for (int i = num1; i <= num2; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            sum = sum + j;
                        }
                    }
                    if (i==sum)
                    {
                        listBox1.Items.Add(i);
                    }
                    sum = 0;
                }
              

            } 
            else  // seçilmemiş işlem 
            {
                MessageBox.Show("Hangi işlemi yapacağınıza karar vermediniz.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
          
        }

    }
}
