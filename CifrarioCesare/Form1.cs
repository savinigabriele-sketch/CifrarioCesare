using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifrarioCesare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cifra_Click(object sender, EventArgs e)
        {
            string testo = txt_testo1.Text.ToUpper();
            string risultato = "";
            int chiave = int.Parse(txt_chiave1.Text);

            foreach (char carattere in testo)
            {
                if (carattere >= 'A' && carattere <= 'Z')
                {
                    int posizione = carattere - 'A';

                    int nuovaPosizione = (posizione + chiave) % 26;

                    char nuovaLettera = (char)('A' + nuovaPosizione);

                    risultato += nuovaLettera;
                }
                    
                else
                    {
                        risultato += carattere;
                    }

            }

            lbl_risultato1.Text = "Risultato: " + risultato;

        }

        private void btn_decifra_Click(object sender, EventArgs e)
        {
            string testo = txt_testo2.Text;
            string risultato = "";
            int chiave = int.Parse(txt_chiave2.Text);

            foreach (char carattere in testo)
            {
                if (carattere >= 'A' && carattere <= 'Z')
                {
                    int posizione = carattere - 'A';

                    int nuovaPosizione = (posizione - chiave) % 26;

                    char nuovaLettera = (char)('A' + nuovaPosizione);

                    risultato += nuovaLettera;
                }

                else
                {
                    risultato += carattere;
                }

            }

            lbl_risultato2.Text = "Risultato: " + risultato;

        }
    }
}
