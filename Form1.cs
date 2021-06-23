using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Bill;
        double Number_of_people;
        double Tip;
        double Tip_per_person;
        double Total_per_person;


        private void Calculate_Click(object sender, EventArgs e)
        {
            textBox_total.Text = "";
            



                double Bill, Number_of_people, Tip, Tip_per_person, Total_per_person;
                try
                {
                    Bill = double.Parse(textBox_bill.Text);
                    try
                    {
                        Tip = double.Parse(textBox_Tippercentage.Text);
                        try
                        {
                            Number_of_people = double.Parse(textBox_numberofPeople.Text);
                            try
                            {
                                Tip_per_person = double.Parse(textBox_Tip.Text);
                                Tip_per_person = Bill * (Tip / 100);
                                Total_per_person = (Bill + Tip_per_person) / (Number_of_people);
                                textBox_total.Text = Total_per_person.ToString("c2");
                          

                            }
                            // catches error with Tip_per_person = double.Parse(textBox_Tip.Text);;
                            catch
                            {
                                MessageBox.Show("Please enter  for the tip per person amount");
                                textBox_Tip.Focus();
                                textBox_Tip.SelectAll();
                            }

                        }
                        // catches error with  Number_of_people = double.Parse(textBox_numberofPeople.Text);;
                        catch
                        {
                            MessageBox.Show("Please enter the Number of person");
                            textBox_numberofPeople.Focus();
                            textBox_numberofPeople.SelectAll();
                        }



                    }
                    // catches error with Tip = double.Parse(textBox_Tippercentage.Text); ;
                    catch
                    {
                        MessageBox.Show("Please enter the Tip amount");
                        textBox_Tippercentage.Focus();
                        textBox_Tippercentage.SelectAll();
                    }

                }

                // catches error with  Bill = double.Parse(textBox_bill.Text);

                catch
                {
                    MessageBox.Show("Please enter the bill amount");
                    textBox_bill.Focus();
                    textBox_bill.SelectAll();
                }
            }
            

    }
}
