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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] str = textBox1.Text.ToCharArray();
            char[] key = textBox3.Text.ToCharArray();
            int[] istr = new int[str.Length];
            int[] ikey = new int[str.Length];
            int i;

            if ((!Regex.Match(textBox1.Text, "^[ぁ-わをんー]+$").Success) || (!Regex.Match(textBox3.Text, "^[ぁ-わをんー]+$").Success))
            {
                MessageBox.Show("ひらがなのみ入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);// ひらがな以外の文字が含まれています。
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
                if (istr[i] < 82)
                {
                    str[i] = henkan(istr[i]);
                }
                else
                {
                    istr[i] = istr[i] % 82;
                    str[i] = henkan(istr[i]);
                }

            }

            string text = new string(str);
            textBox2.Text = text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] str = textBox2.Text.ToCharArray();
            char[] key = textBox3.Text.ToCharArray();
            int[] istr = new int[str.Length];
            int[] ikey = new int[str.Length];
            int i;

            if ((!Regex.Match(textBox2.Text, "^[ぁ-わをんー]+$").Success) || (!Regex.Match(textBox3.Text, "^[ぁ-わをんー]+$").Success))
            {
                MessageBox.Show("ひらがなのみ入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);// ひらがな以外の文字が含まれています。
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
                    istr[i] = istr[i] + 82;
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
                case 'あ':
                    return 0;

                case 'い':
                    return 1;

                case 'う':
                    return 2;

                case 'え':
                    return 3;

                case 'お':
                    return 4;

                case 'か':
                    return 5;

                case 'き':
                    return 6;

                case 'く':
                    return 7;

                case 'け':
                    return 8;

                case 'こ':
                    return 9;

                case 'さ':
                    return 10;

                case 'し':
                    return 11;

                case 'す':
                    return 12;

                case 'せ':
                    return 13;

                case 'そ':
                    return 14;

                case 'た':
                    return 15;

                case 'ち':
                    return 16;

                case 'つ':
                    return 17;

                case 'て':
                    return 18;

                case 'と':
                    return 19;

                case 'な':
                    return 20;

                case 'に':
                    return 21;

                case 'ぬ':
                    return 22;

                case 'ね':
                    return 23;

                case 'の':
                    return 24;

                case 'は':
                    return 25;

                case 'ひ':
                    return 26;

                case 'ふ':
                    return 27;

                case 'へ':
                    return 28;

                case 'ほ':
                    return 29;

                case 'ま':
                    return 30;

                case 'み':
                    return 31;

                case 'む':
                    return 32;

                case 'め':
                    return 33;

                case 'も':
                    return 34;

                case 'や':
                    return 35;

                case 'ゆ':
                    return 36;

                case 'よ':
                    return 37;

                case 'ら':
                    return 38;

                case 'り':
                    return 39;

                case 'る':
                    return 40;

                case 'れ':
                    return 41;

                case 'ろ':
                    return 42;

                case 'わ':
                    return 43;

                case 'を':
                    return 44;

                case 'ん':
                    return 45;

                case 'が':
                    return 46;

                case 'ぎ':
                    return 47;

                case 'ぐ':
                    return 48;

                case 'げ':
                    return 49;

                case 'ご':
                    return 50;

                case 'ざ':
                    return 51;

                case 'じ':
                    return 52;

                case 'ず':
                    return 53;

                case 'ぜ':
                    return 54;

                case 'ぞ':
                    return 55;

                case 'だ':
                    return 56;

                case 'ぢ':
                    return 57;

                case 'づ':
                    return 58;

                case 'で':
                    return 59;

                case 'ど':
                    return 60;

                case 'ば':
                    return 61;

                case 'び':
                    return 62;

                case 'ぶ':
                    return 63;

                case 'べ':
                    return 64;

                case 'ぼ':
                    return 65;

                case 'ぱ':
                    return 66;

                case 'ぴ':
                    return 67;

                case 'ぷ':
                    return 68;

                case 'ぺ':
                    return 69;

                case 'ぽ':
                    return 70;

                case 'ぁ':
                    return 71;

                case 'ぃ':
                    return 72;

                case 'ぅ':
                    return 73;

                case 'ぇ':
                    return 74;

                case 'ぉ':
                    return 75;

                case 'っ':
                    return 76;

                case 'ゃ':
                    return 77;

                case 'ゅ':
                    return 78;

                case 'ょ':
                    return 79;

                case 'ゎ':
                    return 80;

                case 'ー':
                    return 81;

            }
            return -1;
        }

        private char henkan(int i)
        {
            switch (i)
            {
                case 0:
                    return 'あ';

                case 1:
                    return 'い';

                case 2:
                    return 'う';

                case 3:
                    return 'え';

                case 4:
                    return 'お';

                case 5:
                    return 'か';

                case 6:
                    return 'き';

                case 7:
                    return 'く';

                case 8:
                    return 'け';

                case 9:
                    return 'こ';

                case 10:
                    return 'さ';

                case 11:
                    return 'し';

                case 12:
                    return 'す';

                case 13:
                    return 'せ';

                case 14:
                    return 'そ';

                case 15:
                    return 'た';

                case 16:
                    return 'ち';

                case 17:
                    return 'つ';

                case 18:
                    return 'て';

                case 19:
                    return 'と';

                case 20:
                    return 'な';

                case 21:
                    return 'に';

                case 22:
                    return 'ぬ';

                case 23:
                    return 'ね';

                case 24:
                    return 'の';

                case 25:
                    return 'は';

                case 26:
                    return 'ひ';

                case 27:
                    return 'ふ';

                case 28:
                    return 'へ';

                case 29:
                    return 'ほ';

                case 30:
                    return 'ま';

                case 31:
                    return 'み';

                case 32:
                    return 'む';

                case 33:
                    return 'め';

                case 34:
                    return 'も';

                case 35:
                    return 'や';

                case 36:
                    return 'ゆ';

                case 37:
                    return 'よ';

                case 38:
                    return 'ら';

                case 39:
                    return 'り';

                case 40:
                    return 'る';

                case 41:
                    return 'れ';

                case 42:
                    return 'ろ';

                case 43:
                    return 'わ';

                case 44:
                    return 'を';

                case 45:
                    return 'ん';

                case 46:
                    return 'が';

                case 47:
                    return 'ぎ';

                case 48:
                    return 'ぐ';

                case 49:
                    return 'げ';

                case 50:
                    return 'ご';

                case 51:
                    return 'ざ';

                case 52:
                    return 'じ';

                case 53:
                    return 'ず';

                case 54:
                    return 'ぜ';

                case 55:
                    return 'ぞ';

                case 56:
                    return 'だ';

                case 57:
                    return 'ぢ';

                case 58:
                    return 'づ';

                case 59:
                    return 'で';

                case 60:
                    return 'ど';

                case 61:
                    return 'ば';

                case 62:
                    return 'び';

                case 63:
                    return 'ぶ';

                case 64:
                    return 'べ';

                case 65:
                    return 'ぼ';

                case 66:
                    return 'ぱ';

                case 67:
                    return 'ぴ';

                case 68:
                    return 'ぷ';

                case 69:
                    return 'ぺ';

                case 70:
                    return 'ぽ';

                case 71:
                    return 'ぁ';

                case 72:
                    return 'ぃ';

                case 73:
                    return 'ぅ';

                case 74:
                    return 'ぇ';

                case 75:
                    return 'ぉ';

                case 76:
                    return 'っ';

                case 77:
                    return 'ゃ';

                case 78:
                    return 'ゅ';

                case 79:
                    return 'ょ';

                case 80:
                    return 'ゎ';

                case 81:
                    return 'ー';


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
