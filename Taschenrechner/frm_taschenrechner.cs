using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class frm_Taschenrechner : Form
    {
        string eingabe = "";
        string ergebnis = "";

        public frm_Taschenrechner()
        {
            InitializeComponent();
        }

        private string BerechneErgebnis()
        {
            try
            {
                if (tb_ergebnis.Text.Contains("=") && tb_ergebnis.Text.Length > 0)
                {
                    if (tb_ergebnis.SelectionStart > tb_ergebnis.Text.IndexOf("=") && !tb_ergebnis.Text.Contains("E"))
                        eingabe = tb_ergebnis.Text.Replace(tb_ergebnis.Text.Substring(0, tb_ergebnis.Text.IndexOf("=") + 1), "");
                    else
                        eingabe = tb_ergebnis.Text.Replace(tb_ergebnis.Text.Substring(tb_ergebnis.Text.IndexOf("=")), "");
                }
                else
                    eingabe = tb_ergebnis.Text;

                Nebenrechner Ausrechner = new Nebenrechner();
                
                ergebnis = Ausrechner.ArbeiteAb(eingabe);
                tb_ergebnis.Text = eingabe + "=" + ergebnis;
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie eine gültige Rechenaufgabe ein!", "Fehler: Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tb_ergebnis.Text;
        }

        private void tb_ergebnis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Return))
            {
                btn_gleichheitszeichen.PerformClick();
            }

            if (e.KeyValue == Convert.ToChar(Keys.Back))
            {
                btn_löschen.PerformClick();
            }

            if (e.KeyValue == Convert.ToChar(Keys.Delete))
            {
                try
                {
                    int einfügezeichenPosition = tb_ergebnis.SelectionStart;
                    tb_ergebnis.Text = tb_ergebnis.Text.Remove(tb_ergebnis.SelectionStart, 1);
                    tb_ergebnis.SelectionStart = einfügezeichenPosition;
                }
                catch{}
            }
        }

        private void tb_ergebnis_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tastenDruck = e.KeyChar.ToString();
            switch (tastenDruck)
            {
                case "0": btn_0.PerformClick(); break;
                case "1": btn_1.PerformClick(); break;
                case "2": btn_2.PerformClick(); break;
                case "3": btn_3.PerformClick(); break;
                case "4": btn_4.PerformClick(); break;
                case "5": btn_5.PerformClick(); break;
                case "6": btn_6.PerformClick(); break;
                case "7": btn_7.PerformClick(); break;
                case "8": btn_8.PerformClick(); break;
                case "9": btn_9.PerformClick(); break;
                case "+": btn_plus.PerformClick(); break;
                case "-": btn_minus.PerformClick(); break;
                case "*": btn_mal.PerformClick(); break;
                case "/": case ":": btn_durch.PerformClick(); break;
                case ",": btn_komma.PerformClick(); break;
                case "(": btn_klammerAuf.PerformClick(); break;
                case ")": btn_klammerZu.PerformClick(); break;
                case "c": case "C": btn_c.PerformClick(); break;
                case "=": btn_gleichheitszeichen.PerformClick(); break;
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("0");
            tb_ergebnis.Select();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("1");
            tb_ergebnis.Select();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("2");
            tb_ergebnis.Select();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("3");
            tb_ergebnis.Select();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("4");
            tb_ergebnis.Select();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("5");
            tb_ergebnis.Select();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("6");
            tb_ergebnis.Select();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("7");
            tb_ergebnis.Select();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("8");
            tb_ergebnis.Select();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("9");
            tb_ergebnis.Select();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("+");
            tb_ergebnis.Select();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("-");
            tb_ergebnis.Select();
        }

        private void btn_mal_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("*");
            tb_ergebnis.Select();
        }

        private void btn_durch_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("/");
            tb_ergebnis.Select();
        }

        private void btn_gleichheitszeichen_Click(object sender, EventArgs e)
        {
            BerechneErgebnis();
            tb_ergebnis.Select();
            SendKeys.Send("{END}");
        }

        private void btn_komma_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste(",");
            tb_ergebnis.Select();
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Clear();
            tb_ergebnis.Select();
        }

        private void btn_löschen_Click(object sender, EventArgs e)
        {
            int einfügezeichenPosition = tb_ergebnis.SelectionStart;
            try
            {
                tb_ergebnis.Text = tb_ergebnis.Text.Remove(tb_ergebnis.SelectionStart - 1, 1);
                tb_ergebnis.SelectionStart = einfügezeichenPosition - 1;
            }
            catch{}
            tb_ergebnis.Select();
        }

        private void btn_klammerAuf_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste("(");
            tb_ergebnis.Select();
        }

        private void btn_klammerZu_Click(object sender, EventArgs e)
        {
            tb_ergebnis.Paste(")");
            tb_ergebnis.Select();
        }
    }


    public class Nebenrechner
    {
        string rechenString;

        public string ArbeiteAb(string s)
        {
            rechenString = s;
            Überprüfe();
            LöseKlammernAuf();
            return rechenString;
        }

        private void Überprüfe()
        {          
            int tmp;

            switch (rechenString[0].ToString())
            {
                case "+": rechenString = rechenString.Insert(0, "0"); break;
                case "-": rechenString = rechenString.Insert(0, "0"); break;
                case "(": rechenString = rechenString.Insert(0, "1"); break;
            }

            for (int i = 0; i < rechenString.Length; i++)
            {
                if (rechenString[i] == ',' && !int.TryParse(rechenString[i - 1].ToString(), out tmp))
                {
                    rechenString = rechenString.Remove(i);
                }

                if (rechenString[i].ToString() == "(")
                {
                    if (int.TryParse(rechenString[i - 1].ToString(), out tmp))
                        rechenString = rechenString.Insert(i, "*");
                    if (rechenString[i - 1].ToString() == ")")
                    {
                        rechenString = rechenString.Insert(i, "*");
                    }
                }

                if (rechenString[i].ToString() == ")" && i <= rechenString.Length -2)
                {
                    if (int.TryParse(rechenString[i + 1].ToString(), out tmp))
                        rechenString = rechenString.Insert(i+1, "*");

                    if (rechenString[i + 1].ToString() == "(")
                    {
                        rechenString = rechenString.Insert(i+1, "*");
                    }
                }
            }
        }

        void LöseKlammernAuf()
        {
            int klammerAuf = -1;
            for (int i = 0; i < rechenString.Length; i++)
            {
                if (rechenString[i].ToString() == "(")
                {
                    klammerAuf = (i);
                }

                if (rechenString[i].ToString() == ")")
                {
                    string s = "";
                    int j = klammerAuf;

                    for (int n = i; n >= j; n--)
                    {
                        s = s.Insert(0, rechenString[n].ToString());
                        rechenString = rechenString.Remove(n, 1);
                    }

                    s = s.Replace("(", "").Replace(")", "");
                    string r = Rechnen(s);

                    if (r.Contains("#DIV/0"))
                    {
                        rechenString = "#DIV/0";
                        break;
                    }

                    rechenString = rechenString.Insert(j, r);                    
                    klammerAuf = -1;
                    i = -1;
                }
                
            }
            rechenString = Rechnen(rechenString);

            if (rechenString.Contains("#DIV/0"))
            {
                rechenString = "#DIV/0";
            }
        }

        string Rechnen(string s)
        {
            
            List<string> list = ErstelleListe(s);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "/")
                {
                    if (list [i+1] == "0")
                    {
                        return "#DIV/0";
                    }

                    list[i - 1] = (Convert.ToDouble(list[i - 1]) / Convert.ToDouble(list[i + 1])).ToString();
                    list.RemoveAt(i + 1);
                    list.RemoveAt(i);
                    i = -1;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "*")
                {
                    list[i - 1] = (Convert.ToDouble(list[i - 1]) * Convert.ToDouble(list[i + 1])).ToString();
                    list.RemoveAt(i + 1);
                    list.RemoveAt(i);
                    i = -1;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "-")
                {
                    list[i - 1] = (Convert.ToDouble(list[i - 1]) - Convert.ToDouble(list[i + 1])).ToString();
                    list.RemoveAt(i + 1);
                    list.RemoveAt(i);
                    i = -1;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "+")
                {
                    list[i - 1] = (Convert.ToDouble(list[i - 1]) + Convert.ToDouble(list[i + 1])).ToString();
                    list.RemoveAt(i + 1);
                    list.RemoveAt(i);
                    i = -1;
                }
            }
            return (Convert.ToDouble(list[0])).ToString();
        }

        List<string> ErstelleListe(string t)
        {
            string s = ErstelleBerechenbarenString(t);
            List<string> list = new List<string>();
            list.Add("");
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i].ToString())
                {
                    case "+": list.Add("+"); list.Add(""); break;
                    case "-": list.Add("-"); list.Add(""); break;
                    case "*": list.Add("*"); list.Add(""); break;
                    case "/": list.Add("/"); list.Add(""); break;
                    case "m": list[list.Count - 1] += "-"; break;
                    case ",": list[list.Count - 1] += ","; break;
                    default: list[list.Count - 1] += s[i].ToString(); break;
                }
            }
            return list;
        }

        string ErstelleBerechenbarenString(string s)
        {
            int tmp;

            switch (s[0].ToString())
            {
                case "+": s = s.Insert(0, "0"); break;
                case "-": s = s.Insert(0, "0"); break;
                case "(": s = s.Insert(0, "1"); break;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '+' && s[i + 1] == '+')
                {
                    s = s.Remove(i+1, 1);

                    i = 0;
                }

                if (s[i] == '+' && s[i + 1] == '-')
                {
                    s = s.Remove(i, 2);
                    s = s.Insert(i, "-");

                    i = 0;
                }

                if (s[i] == '-' && s[i + 1] == '+')
                {
                    s = s.Remove(i, 2);
                    s = s.Insert(i, "-");

                    i = 0;
                }

                if (s[i] == '-' && s[i + 1] == '-')
                {
                    s = s.Remove(i, 2);
                    s = s.Insert(i, "+");

                    i = 0;
                }

                if (s[i] == '*' && s[i + 1] == '+')
                {
                    s = s.Remove(i + 1, 1);

                    i = 0;
                }

                if (s[i] == '/' && s[i + 1] == '+')
                {
                    s = s.Remove(i + 1, 1);

                    i = 0;
                }

                if (s[i] == '*' && s[i + 1] == '-')
                {
                    s = s.Remove(i+1, 1);
                    s = s.Insert(i+1, "m");

                    i = 0;
                }

                if (s[i] == '/' && s[i + 1] == '-')
                {
                    s = s.Remove(i + 1, 1);
                    s = s.Insert(i + 1, "m");

                    i = 0;
                }

                if (s[i] == ',' && !int.TryParse(s[i - 1].ToString(), out tmp))
                {
                    s = s.Remove(i);
                }
            }
            return s;
        }
    }
}