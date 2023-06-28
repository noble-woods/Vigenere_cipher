using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Vigenere_cipher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//暗号化
        {
            char[] str = textBox1.Text.ToCharArray();
            char[] key = textBox3.Text.ToCharArray();
            int[] istr = new int[str.Length];
            int[] ikey = new int[str.Length];
            int i;

            if ((!Regex.Match(textBox1.Text, "^[a-z]+$").Success) || (!Regex.Match(textBox3.Text, "^[a-z]+$").Success))
            {
                MessageBox.Show("半角英小文字のみ入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);// 半角英字以外の文字が含まれています。
                return;
            }

            //平文を数字に変換
            for (i = 0; i < str.Length; i++)
            {
                istr[i] = henkan(str[i]);

            }

            //鍵を数字に変換
            for (i = 0; i < str.Length; i++)
            {
                if (i < key.Length)
                {
                    ikey[i] = henkan(key[i]);
                }
                else
                {
                    ikey[i] = henkan(key[i % key.Length]);
                }


            }

            //平文と鍵を足し算
            for (i = 0; i < str.Length; i++)
            {
                istr[i] = istr[i] + ikey[i];
            }

            //数字を暗号文に
            for (i = 0; i < str.Length; i++)
            {
                if (istr[i] < 26)
                {
                    str[i] = henkan(istr[i]);
                }
                else
                {
                    istr[i] = istr[i] % 26;
                    str[i] = henkan(istr[i]);
                }

            }

            string text = new string(str);
            textBox2.Text = text;

        }
        private void button2_Click(object sender, EventArgs e)//復号
        {
            char[] str = textBox2.Text.ToCharArray();
            char[] key = textBox3.Text.ToCharArray();
            int[] istr = new int[str.Length];
            int[] ikey = new int[str.Length];
            int i;

            if ((!Regex.Match(textBox2.Text, "^[a-z]+$").Success) || (!Regex.Match(textBox3.Text, "^[a-z]+$").Success))
            {
                MessageBox.Show("半角英小文字のみ入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);// 半角英字以外の文字が含まれています。
                return;
            }

            //暗号文を数字に変換
            for (i = 0; i < str.Length; i++)
            {
                istr[i] = henkan(str[i]);

            }

            //鍵を数字に変換
            for (i = 0; i < str.Length; i++)
            {
                if (i < key.Length)
                {
                    ikey[i] = henkan(key[i]);
                }
                else
                {
                    ikey[i] = henkan(key[i % key.Length]);
                }


            }

            //暗号文と鍵を足し算
            for (i = 0; i < str.Length; i++)
            {
                istr[i] = istr[i] - ikey[i];
            }

            //数字を暗号文に
            for (i = 0; i < str.Length; i++)
            {
                if (istr[i] >= 0)
                {
                    str[i] = henkan(istr[i]);
                }
                else
                {
                    istr[i] = istr[i] + 26;
                    str[i] = henkan(istr[i]);
                }

            }

            string text = new string(str);
            textBox1.Text = text;

        }
        private int henkan(char s)
        {
            switch (s)
            {
                case 'a':
                    return 0;

                case 'b':
                    return 1;

                case 'c':
                    return 2;

                case 'd':
                    return 3;

                case 'e':
                    return 4;

                case 'f':
                    return 5;

                case 'g':
                    return 6;

                case 'h':
                    return 7;

                case 'i':
                    return 8;

                case 'j':
                    return 9;

                case 'k':
                    return 10;

                case 'l':
                    return 11;

                case 'm':
                    return 12;

                case 'n':
                    return 13;

                case 'o':
                    return 14;

                case 'p':
                    return 15;

                case 'q':
                    return 16;

                case 'r':
                    return 17;

                case 's':
                    return 18;

                case 't':
                    return 19;

                case 'u':
                    return 20;

                case 'v':
                    return 21;

                case 'w':
                    return 22;

                case 'x':
                    return 23;

                case 'y':
                    return 24;

                case 'z':
                    return 25;

            }
            return -1;
        }

        private char henkan(int i)
        {
            switch (i)
            {
                case 0:
                    return 'a';

                case 1:
                    return 'b';

                case 2:
                    return 'c';

                case 3:
                    return 'd';

                case 4:
                    return 'e';

                case 5:
                    return 'f';

                case 6:
                    return 'g';

                case 7:
                    return 'h';

                case 8:
                    return 'i';

                case 9:
                    return 'j';

                case 10:
                    return 'k';

                case 11:
                    return 'l';

                case 12:
                    return 'm';

                case 13:
                    return 'n';

                case 14:
                    return 'o';

                case 15:
                    return 'p';

                case 16:
                    return 'q';

                case 17:
                    return 'r';

                case 18:
                    return 's';

                case 19:
                    return 't';

                case 20:
                    return 'u';

                case 21:
                    return 'v';

                case 22:
                    return 'w';

                case 23:
                    return 'x';

                case 24:
                    return 'y';

                case 25:
                    return 'z';

            }
            return '-';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("readme.txt");
        }
    }
}
