using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendor_Machine
{
    public partial class Form1 : Form
    {
        double x=0;
        public Form1()
        {
            InitializeComponent();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
            radioButton9.Enabled = false;
            radioButton10.Enabled = false;
            radioButton11.Enabled = false;
            radioButton15.Enabled = false;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //Test Case 19-----------------------------------------------------------------
            //Users have to insert a number. If they do not, try-catch functions catch an exception.
            try
            {
                string y;
                y = textBox1.Text;
                x += Convert.ToInt32(y);
            }
            catch (Exception c)
            {

                MessageBox.Show("Please insert the positive number !\n","FAIL", MessageBoxButtons.OK);
            }

            // Test Case 20-----------------------------------------------
            //Number that inserted by user must be a positive number.
            if (x > 0)
            {
                MessageBox.Show("Inserting is success !\n", "Success", MessageBoxButtons.OK);
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
                radioButton6.Enabled = true;
                radioButton7.Enabled = true;
                radioButton8.Enabled = true;
                radioButton9.Enabled = true;
                radioButton10.Enabled = true;
                radioButton11.Enabled = true;
                radioButton15.Enabled = true;
                textBox1.Text = "";
                label10.Text = x.ToString();
            }
           else
            {
                MessageBox.Show("Please insert the positive number !\n", "FAIL", MessageBoxButtons.OK);
                x = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)//Coca Cola Classic
            {
                int count = Convert.ToInt32(label4.Text);//kalan ürün text
                double price = 2;
                string name = "Coca Cola Classic";
                int count_update=Calculate(x,price, name, count);
                label4.Text = count_update.ToString();

            }

            else if (radioButton9.Checked == true)//Coca Cola Zero  
            {
                int count = Convert.ToInt32(label24.Text);//kalan ürün text
                double price = 2.5;
                string name = "Coca Cola Zero";
                int count_update = Calculate(x,price, name, count);
                label24.Text = count_update.ToString();

            }
            else if (radioButton5.Checked == true)//Coca Cola Light 
            {
                int count = Convert.ToInt32(label18.Text);//kalan ürün text
                double price = 3.5;
                string name = "Coca Cola Light";
                int count_update = Calculate(x,price, name, count);
                label18.Text = count_update.ToString();

            }
            else if (radioButton8.Checked == true)//Fanta
            {
                int count = Convert.ToInt32(label6.Text);//kalan ürün text
                double price = 2;
                string name = "Fanta";
                int count_update = Calculate(x,price, name, count);
                label6.Text = count_update.ToString();

            }
            else if (radioButton3.Checked == true)//Cappy
            {
                int count = Convert.ToInt32(label14.Text);//kalan ürün text
                double price = 3.5;
                string name = "Cappy";
                int count_update = Calculate(x,price, name, count);
                label14.Text = count_update.ToString();

            }
            else if (radioButton6.Checked == true)//Sprite
            {
                int count = Convert.ToInt32(label20.Text);//kalan ürün text
                double price = 2.5;
                string name = "Sprite";
                int count_update = Calculate(x,price, name, count);
                label20.Text = count_update.ToString();

            }
            else if (radioButton10.Checked == true)//Sprite Zero
            {
                int count = Convert.ToInt32(label26.Text);//kalan ürün text
                double price = 2.5;
                string name = "Sprite Zero";
                int count_update = Calculate(x,price, name, count);
                label26.Text = count_update.ToString();

            }
            else if (radioButton15.Checked == true)//Water
            {
                int count = Convert.ToInt32(label8.Text);//kalan ürün text
                double price = 2;
                string name = "Water";
                int count_update = Calculate(x,price, name, count);
                label8.Text = count_update.ToString();

            }
            else if (radioButton4.Checked == true)//Fusetea Seftali 
            {
                int count = Convert.ToInt32(label16.Text);//kalan ürün text
                double price = 2.5;
                string name = "Fusetea Seftali";
                int count_update = Calculate(x,price, name, count);
                label16.Text = count_update.ToString();

            }
            else if (radioButton7.Checked == true)//Fusetea Limon
            {
                int count = Convert.ToInt32(label22.Text);//kalan ürün text
                double price = 3;
                string name = "Fusetea Limon";
                int count_update = Calculate(x,price, name, count);
                label22.Text = count_update.ToString();

            }
            else if (radioButton11.Checked == true)//Fusetea Mango
            {
                int count = Convert.ToInt32(label28.Text);//kalan ürün text
                double price = 2;
                string name = "Fusetea Mango";
                int count_update = Calculate(x,price, name, count);
                label28.Text = count_update.ToString();

            }

            else if (radioButton2.Checked == true)//Fusetea Karpuz
            {
                int count = Convert.ToInt32(label28.Text);//kalan ürün text
                double price = 2;
                string name = "Fusetea Karpuz";
                int count_update = Calculate(x,price, name, count);
                label28.Text = count_update.ToString();

            }

        }

        //Calculate funtion used to calculate price and given coins.
        public int Calculate(double coin, double price, string name, int count)
        {
            //coin = x;
            if (count != 0 && coin >= price)
            {
                coin -= price;
                count--;
                label10.Text = coin.ToString();
                DialogResult d = MessageBox.Show("Product is preparing !\n Take " + coin + "TL Back in Charge !", "SUCCESS", MessageBoxButtons.OK);
                if (d == DialogResult.OK)
                {
                    coin = 0;
                    textBox1.Text = "";
                    label10.Text = "0";//coin
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                    radioButton5.Enabled = false;
                    radioButton6.Enabled = false;
                    radioButton7.Enabled = false;
                    radioButton8.Enabled = false;
                    radioButton9.Enabled = false;
                    radioButton10.Enabled = false;
                    radioButton11.Enabled = false;
                    radioButton15.Enabled = false;
                    x = coin;
                    return count;
                    
                }
                x = coin;
                return count;
            }
            else
            {
                if (count == 0)
                {
                    MessageBox.Show("There are not "+name+" !", "Empty", MessageBoxButtons.OK);
                    x = coin;
                    return count;
                }
                else if (coin < price)
                {
                    MessageBox.Show("Not enought money!\nAdd some coin", "MOney", MessageBoxButtons.OK);
                    x = coin;
                    return count;
                }
                x = coin;
                return count;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
