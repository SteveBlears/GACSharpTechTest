using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GATechTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        double keyPress = .100;
        double keyPause = .5;
        double minumumDuration = 0;
        private void Calculate_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            StringBuilder keySequence = new StringBuilder();
            bool keyPaused;
            bool validkey;
            char[] stringToAnalyse = textBox1.Text.ToUpper().ToCharArray();
            int i = 0;
            int keysPressed = 0;
            string input = "";
            while (i < stringToAnalyse.Length )
            {
                keyPaused = false;
                validkey = true;
                switch (stringToAnalyse[i])
                {
                    case 'A':
                        input = "2";
                        keysPressed = 1;
                        if (keySequence.Length> 0 && keySequence.ToString().EndsWith("2"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'B':
                        input = "22";
                        keysPressed = 2;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("2"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'C':
                        input = "222";
                        keysPressed = 3;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("2"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'D':
                        input = "3";
                        keysPressed = 1;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("3"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'E':
                        input = "33";
                        keysPressed = 2;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("3"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'F':
                        input = "333";
                        keysPressed = 3;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("3"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'G':
                        input = "4";
                        keysPressed = 1;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("4"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'H':
                        input = "44";
                        keysPressed = 2;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("4"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'I':
                        input = "444";
                        keysPressed = 3;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("4"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'J':
                        input = "5";
                        keysPressed = 1;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("5"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'K':
                        input = "55";
                        keysPressed = 2;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("5"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'L':
                        input = "555";
                        keysPressed = 3;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("5"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'M':
                        input = "6";
                        keysPressed = 1;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("6"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'N':
                        input = "66";
                        keysPressed = 2;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("6"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'O':
                        input = "666";
                        keysPressed = 3;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("6"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'P':
                        input = "7";
                        keysPressed = 1;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("7"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'Q':
                        input = "77";
                        keysPressed = 2;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("7"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'R':
                        input = "777";
                        keysPressed = 3;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("7"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'S':
                        input = "7777";
                        keysPressed = 4;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("7"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'T':
                        input = "8";
                        keysPressed = 1;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("8"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'U':
                        input = "88";
                        keysPressed = 2;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("8"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'V':
                        input = "888";
                        keysPressed = 3;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("8"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'W':
                        input = "9";
                        keysPressed = 1;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("9"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'X':
                        input = "99";
                        keysPressed = 2;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("9"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'Y':
                        input = "999";
                        keysPressed = 3;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("9"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case 'Z':
                        input = "9999";
                        keysPressed = 4;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("9"))
                        {
                            keyPaused = true;
                        }
                        break;
                    case ' ':
                        input = "0";
                        keysPressed = 1;
                        if (keySequence.Length > 0 && keySequence.ToString().EndsWith("0"))
                        {
                            keyPaused = true;
                        }
                        break;
                    default:
                        validkey = false;
                        input = "";
                        break;
                 
               }
                if (validkey)
                {
                    minumumDuration = minumumDuration + (keyPress * keysPressed);
                    if (keyPaused)
                    {
                        minumumDuration = minumumDuration + keyPause;
                    }
                }
                keySequence.Append(input);
                i++;
            }
            textBox2.Text = keySequence.ToString();
            textBox3.Text = minumumDuration.ToString();
        }


    }
}
