//Grading ID: R2226
// Program 2
// 03/ 10/ 2022
// CIS 199 - 02

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            //These are all the variables that will be used in the program
            int guests;
            int nights = 0;
            int costperNight = 0;
            int guestsNum;
            double nightSum;
            double totalcost;
            double starcostfactor;

            if (int.TryParse(guestsTxt.Text, out guests) && guests > 0 && guests < 7)// The if statement for the number of guests
            {
                if (int.TryParse(nightsTxt.Text, out nights) && nights > 0)// The int Try parse if statement for the number of nights
                {
                    if (comboBoxName.SelectedIndex > 0)// the if statement for the combobox selected name

                    {
                        //These are the if situations for what will be added for the selected Index based on the selected value from the combo box
                        if (comboBoxName.SelectedIndex == 1)
                        {
                            starcostfactor = 1;
                        }
                        else if (comboBoxName.SelectedIndex == 2)
                        {
                            starcostfactor = 1.5;
                        }
                        else if (comboBoxName.SelectedIndex == 3)
                        {
                            starcostfactor = 2.5;
                        }
                        else if (comboBoxName.SelectedIndex == 4)
                        {
                            starcostfactor = 3;
                        }
                        else 
                        {
                            starcostfactor = 4;
                        }
                        // used the if-else  statements for the guests and the number that the amount of guests would equal for as well
                        if (guests == 1)
                        {
                            guestsNum = 100;
                        }
                        else if (guests == 2)
                        {
                            guestsNum = 150;
                        }
                        else if (guests == 3)
                        {
                            guestsNum = 250;
                        }
                        else
                        {
                            guestsNum = 400;
                        }
                        // Used these if-else statements to describe the cost of the nights for how many nights that guest would be staying at the hotel
                        if (nights >= 1 && nights <= 6)
                        {
                            costperNight = 100;
                        }
                        else if (nights >= 7 && nights <= 30)
                        {
                            costperNight =  75;
                        }
                        else 
                        {
                            costperNight = 25;
                        }

                        nightSum = nights * costperNight;// Used to calculate the amount of nights stayed by the cost per night
                        totalcost = (nightSum + guestsNum) * starcostfactor;// Used to calculate the complete total cost using the variables above
                        costLbL.Text = $"{totalcost:C2}";// This is to show what the output label will show based of what the total cost was
                    }
                    else

                    {
                        Console.WriteLine("Invalid Input"); // these last else statements are for what will be shown if any of the inputs do not equal what the perimeter was given.
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
} 
