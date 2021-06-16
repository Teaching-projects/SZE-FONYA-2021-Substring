using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fonya2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "*    Az automata kezdőállapota minden esetben a State1, ahogy azt a start felirat nyila is mutatja. \n**   Az automata elfogadó állapotai a nagy 'A' betűvel kezdődő állapotok. \n***  A nagy S-sel kezdődő állapotok a páros számú magánhangzót tartalmazó állapotok, a kis s-sel kezdődők a páratlan db magánhangzót tartalmazó állapotok. \n**** Ha egy állapotból egy betűvel két irányba is lehetne lépni, akkor mindkét irányba tenni kell 1 - 1 lépést.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            string[] states = new string[word.Length + 1];
            string osszes = null;
            string evenautomata = null;
            string oddautomata = null;
            string lastrow = null;
            int egysorhossz;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Meg kell adnia egy szót a szövegdobozban!");
            }
            else {
                if (radioButton1.Checked == true)
                {
                    for (int i = 0; i < word.Length + 1; i++)
                    {
                        states[i] = "State" + (i + 1);
                    }
                    for (int i = 0; i < word.Length; i++)
                    {
                        evenautomata = evenautomata + states[i] + " --" + word[i].ToString() + "-->  ";
                    }
                    evenautomata = evenautomata + "A" + states[word.Length];
                    egysorhossz = evenautomata.Length;

                    for (int i = 0; i < egysorhossz; i++)
                    {
                        oddautomata = oddautomata + " ";
                    }
                    StringBuilder strb = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb[i] = '^';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb[i] = '^';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb[i] = '^';
                        }
                    }
                    StringBuilder strb1 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb1[i] = '|';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb1[i] = '|';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb1[i] = '|';
                        }
                    }
                    StringBuilder strb2 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb2[i] = 'a';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb2[i] = 'a';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb2[i] = 'a';
                        }
                    }
                    StringBuilder strb3 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb3[i] = 'á';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb3[i] = 'á';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb3[i] = 'á';
                        }
                    }
                    StringBuilder strb4 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb4[i] = 'e';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb4[i] = 'e';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb4[i] = 'e';
                        }
                    }
                    StringBuilder strb5 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb5[i] = 'é';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb5[i] = 'é';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb5[i] = 'é';
                        }
                    }
                    StringBuilder strb6 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb6[i] = 'i';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb6[i] = 'i';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb6[i] = 'i';
                        }
                    }
                    StringBuilder strb7 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb7[i] = 'í';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb7[i] = 'í';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb7[i] = 'í';
                        }
                    }
                    StringBuilder strb8 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb8[i] = 'o';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb8[i] = 'o';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb8[i] = 'o';
                        }
                    }
                    StringBuilder strb9 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb9[i] = 'ó';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb9[i] = 'ó';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb9[i] = 'ó';
                        }
                    }
                    StringBuilder strb10 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb10[i] = 'ö';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb10[i] = 'ö';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb10[i] = 'ö';
                        }
                    }
                    StringBuilder strb11 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb11[i] = 'ő';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb11[i] = 'ő';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb11[i] = 'ő';
                        }
                    }
                    StringBuilder strb12 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb12[i] = 'u';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb12[i] = 'u';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb12[i] = 'u';
                        }
                    }
                    StringBuilder strb13 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb13[i] = 'ú';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb13[i] = 'ú';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb13[i] = 'ú';
                        }
                    }
                    StringBuilder strb14 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb14[i] = 'ü';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb14[i] = 'ü';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb14[i] = 'ü';
                        }
                    }
                    StringBuilder strb15 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb15[i] = 'ű';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb15[i] = 'ű';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb15[i] = 'ű';
                        }
                    }
                    StringBuilder strb16 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb16[i] = '|';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb16[i] = '|';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb16[i] = '|';
                        }
                    }
                    StringBuilder strb17 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb17[i] = 'ˇ';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb17[i] = 'ˇ';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb17[i] = 'ˇ';
                        }
                    }
                    for (int i = 0; i < word.Length; i++)
                    {
                        lastrow = lastrow + states[i].Replace('S', 's') + " --" + word[i].ToString() + "-->  ";
                    }
                    lastrow = lastrow + states[word.Length].Replace('S', 's');
                    evenautomata = "Start\n" + "   ˇ\n" + evenautomata + "\n" + strb + "\n" + strb1 + "\n" + strb2 + "\n" + strb3 + "\n" + strb4 + "\n" + strb5 + "\n" + strb6 + "\n" + strb7 + "\n" + strb8 + "\n" + strb9 + "\n" + strb10 + "\n" + strb11 + "\n" + strb12 + "\n" + strb13 + "\n" + strb14 + "\n" + strb15 + "\n" + strb16 + "\n" + strb17 + "\n" + lastrow;
                }
                else if (radioButton2.Checked == true)
                {
                    for (int i = 0; i < word.Length + 1; i++)
                    {
                        states[i] = "State" + (i + 1);
                    }
                    for (int i = 0; i < word.Length; i++)
                    {
                        evenautomata = evenautomata + states[i] + " --" + word[i].ToString() + "-->  ";
                    }
                    evenautomata = evenautomata + states[word.Length];
                    egysorhossz = evenautomata.Length;

                    for (int i = 0; i < egysorhossz; i++)
                    {
                        oddautomata = oddautomata + " ";
                    }
                    StringBuilder strb = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb[i] = '^';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb[i] = '^';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb[i] = '^';
                        }
                    }
                    StringBuilder strb1 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb1[i] = '|';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb1[i] = '|';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb1[i] = '|';
                        }
                    }
                    StringBuilder strb2 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb2[i] = 'a';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb2[i] = 'a';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb2[i] = 'a';
                        }
                    }
                    StringBuilder strb3 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb3[i] = 'á';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb3[i] = 'á';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb3[i] = 'á';
                        }
                    }
                    StringBuilder strb4 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb4[i] = 'e';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb4[i] = 'e';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb4[i] = 'e';
                        }
                    }
                    StringBuilder strb5 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb5[i] = 'é';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb5[i] = 'é';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb5[i] = 'é';
                        }
                    }
                    StringBuilder strb6 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb6[i] = 'i';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb6[i] = 'i';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb6[i] = 'i';
                        }
                    }
                    StringBuilder strb7 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb7[i] = 'í';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb7[i] = 'í';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb7[i] = 'í';
                        }
                    }
                    StringBuilder strb8 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb8[i] = 'o';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb8[i] = 'o';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb8[i] = 'o';
                        }
                    }
                    StringBuilder strb9 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb9[i] = 'ó';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb9[i] = 'ó';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb9[i] = 'ó';
                        }
                    }
                    StringBuilder strb10 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb10[i] = 'ö';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb10[i] = 'ö';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb10[i] = 'ö';
                        }
                    }
                    StringBuilder strb11 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb11[i] = 'ő';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb11[i] = 'ő';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb11[i] = 'ő';
                        }
                    }
                    StringBuilder strb12 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb12[i] = 'u';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb12[i] = 'u';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb12[i] = 'u';
                        }
                    }
                    StringBuilder strb13 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb13[i] = 'ú';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb13[i] = 'ú';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb13[i] = 'ú';
                        }
                    }
                    StringBuilder strb14 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb14[i] = 'ü';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb14[i] = 'ü';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb14[i] = 'ü';
                        }
                    }
                    StringBuilder strb15 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb15[i] = 'ű';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb15[i] = 'ű';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb15[i] = 'ű';
                        }
                    }
                    StringBuilder strb16 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb16[i] = '|';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb16[i] = '|';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb16[i] = '|';
                        }
                    }
                    StringBuilder strb17 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb17[i] = 'ˇ';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb17[i] = 'ˇ';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb17[i] = 'ˇ';
                        }
                    }
                    for (int i = 0; i < word.Length; i++)
                    {
                        lastrow = lastrow + states[i].Replace('S', 's') + " --" + word[i].ToString() + "-->  ";
                    }
                    lastrow = lastrow + "A" + states[word.Length].Replace('S', 's');
                    evenautomata = "Start\n" + "   ˇ\n" + evenautomata + "\n" + strb + "\n" + strb1 + "\n" + strb2 + "\n" + strb3 + "\n" + strb4 + "\n" + strb5 + "\n" + strb6 + "\n" + strb7 + "\n" + strb8 + "\n" + strb9 + "\n" + strb10 + "\n" + strb11 + "\n" + strb12 + "\n" + strb13 + "\n" + strb14 + "\n" + strb15 + "\n" + strb16 + "\n" + strb17 + "\n" + lastrow;
                }
                else
                {
                    for (int i = 0; i < word.Length + 1; i++)
                    {
                        states[i] = "State" + (i + 1);
                    }
                    for (int i = 0; i < word.Length; i++)
                    {
                        evenautomata = evenautomata + states[i] + " --" + word[i].ToString() + "-->  ";
                    }
                    evenautomata = evenautomata + "A" + states[word.Length];
                    egysorhossz = evenautomata.Length;

                    for (int i = 0; i < egysorhossz; i++)
                    {
                        oddautomata = oddautomata + " ";
                    }
                    StringBuilder strb = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb[i] = '^';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb[i] = '^';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb[i] = '^';
                        }
                    }
                    StringBuilder strb1 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb1[i] = '|';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb1[i] = '|';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb1[i] = '|';
                        }
                    }
                    StringBuilder strb2 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb2[i] = 'a';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb2[i] = 'a';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb2[i] = 'a';
                        }
                    }
                    StringBuilder strb3 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb3[i] = 'á';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb3[i] = 'á';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb3[i] = 'á';
                        }
                    }
                    StringBuilder strb4 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb4[i] = 'e';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb4[i] = 'e';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb4[i] = 'e';
                        }
                    }
                    StringBuilder strb5 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb5[i] = 'é';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb5[i] = 'é';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb5[i] = 'é';
                        }
                    }
                    StringBuilder strb6 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb6[i] = 'i';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb6[i] = 'i';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb6[i] = 'i';
                        }
                    }
                    StringBuilder strb7 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb7[i] = 'í';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb7[i] = 'í';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb7[i] = 'í';
                        }
                    }
                    StringBuilder strb8 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb8[i] = 'o';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb8[i] = 'o';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb8[i] = 'o';
                        }
                    }
                    StringBuilder strb9 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb9[i] = 'ó';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb9[i] = 'ó';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb9[i] = 'ó';
                        }
                    }
                    StringBuilder strb10 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb10[i] = 'ö';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb10[i] = 'ö';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb10[i] = 'ö';
                        }
                    }
                    StringBuilder strb11 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb11[i] = 'ő';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb11[i] = 'ő';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb11[i] = 'ő';
                        }
                    }
                    StringBuilder strb12 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb12[i] = 'u';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb12[i] = 'u';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb12[i] = 'u';
                        }
                    }
                    StringBuilder strb13 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb13[i] = 'ú';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb13[i] = 'ú';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb13[i] = 'ú';
                        }
                    }
                    StringBuilder strb14 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb14[i] = 'ü';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb14[i] = 'ü';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb14[i] = 'ü';
                        }
                    }
                    StringBuilder strb15 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb15[i] = 'ű';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb15[i] = 'ű';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb15[i] = 'ű';
                        }
                    }
                    StringBuilder strb16 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb16[i] = '|';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb16[i] = '|';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb16[i] = '|';
                        }
                    }
                    StringBuilder strb17 = new StringBuilder(oddautomata);
                    if (egysorhossz <= 142)
                    {
                        for (int i = 3; i < egysorhossz; i = i + 15)
                        {
                            strb17[i] = 'ˇ';
                        }
                    }
                    else
                    {
                        for (int i = 3; i < 142; i = i + 15)
                        {
                            strb17[i] = 'ˇ';
                        }
                        for (int i = 154; i < egysorhossz; i = i + 16)
                        {
                            strb17[i] = 'ˇ';
                        }
                    }
                    for (int i = 0; i < word.Length; i++)
                    {
                        lastrow = lastrow + states[i].Replace('S', 's') + " --" + word[i].ToString() + "-->  ";
                    }
                    lastrow = lastrow + "A" + states[word.Length].Replace('S', 's');
                    evenautomata = "Start\n" + "   ˇ\n" + evenautomata + "\n" + strb + "\n" + strb1 + "\n" + strb2 + "\n" + strb3 + "\n" + strb4 + "\n" + strb5 + "\n" + strb6 + "\n" + strb7 + "\n" + strb8 + "\n" + strb9 + "\n" + strb10 + "\n" + strb11 + "\n" + strb12 + "\n" + strb13 + "\n" + strb14 + "\n" + strb15 + "\n" + strb16 + "\n" + strb17 + "\n" + lastrow;
                }

                richTextBox1.Text = evenautomata;
            }
        }
    }
}
