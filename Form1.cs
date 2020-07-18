using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Over_Under_Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numLabel.Text = Numbers.oldNum.ToString();
            scoreLabel.Text = Count.count.ToString();
        }

        static class Decision
        {
            public static string decision;
        }

        static class Count
        {
            public static int count = 0;
        }

        static class Numbers
        {
            
            public static int newNum = NewNumber(Numbers.oldNum);
            public static int oldNum = 5;
        }

        public static int NewNumber(int oldNum)
        {
            Random num = new Random();
            int Num = num.Next(10);
            if(Num == Numbers.oldNum)
            {
                Num = num.Next(10);
            }
            return Num;
        }

        public static bool Correct(int oldNum, int newNum, string decision)
        {
            if((oldNum > newNum && Decision.decision == "Under") || (oldNum < newNum && Decision.decision == "Over"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Score(bool Correct, int oldNum, int newNum)
        {
            if(Correct == true)
            {
                Count.count ++;
                Numbers.oldNum = Numbers.newNum;
                Numbers.newNum = NewNumber(Numbers.oldNum);
            }
            else
            {
                MessageBox.Show("Wrong. The Number was " + Numbers.newNum + ". Your score is " + Count.count);
                Numbers.oldNum = 5;
                Numbers.newNum = NewNumber(Numbers.oldNum);
                Count.count = 0;
            }
        }
        private void newNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void overButton_CheckedChanged(object sender, EventArgs e)
        {
            if(overButton.Checked == true)
            {
                Decision.decision = "Over";
            }
        }

        private void underButton_CheckedChanged(object sender, EventArgs e)
        {
            if(underButton.Checked == true)
            {
                Decision.decision = "Under";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            overButton.Checked = false;
            underButton.Checked = false;
            Score(Correct(Numbers.oldNum, Numbers.newNum, Decision.decision), Numbers.oldNum, Numbers.newNum);
            numLabel.Text = Numbers.oldNum.ToString();
            scoreLabel.Text = Count.count.ToString();
        }

        private void numLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
