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
            string testo = txt_testo1.Text;
            string risultato = "";
            int chiave = int.Parse(txt_chiave1.Text);

            // Uso il foreach per analizzare ogni carattere singolarmente. Verifico al suo interno se siano lettere e se siano maiuscole o minuscole.\\
            foreach (char carattere in testo)
            {
                if (carattere >= 'A' && carattere <= 'Z')
                {
                    int posizione = carattere - 'A';

                    int nuovaPosizione = (posizione + chiave) % 26;

                    char nuovaLettera = (char)('A' + nuovaPosizione);

                    risultato += nuovaLettera;
                }
                else if (carattere >= 'a' && carattere <= 'z')
                {
                    int posizione = carattere - 'a';

                    int nuovaPosizione = (posizione + chiave) % 26;

                    char nuovaLettera = (char)('a' + nuovaPosizione);

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
                //Faccio l'if per verificare se sia maiuscola e nel caso aggiungo il carattere al risultato\\
                if (carattere >= 'A' && carattere <= 'Z')
                {
                    int posizione = carattere - 'A';
                    int nuovaPosizione = (posizione - chiave + 26) % 26;
                    char nuovaLettera = (char)('A' + nuovaPosizione);

                    risultato += nuovaLettera;
                }
                else if (carattere >= 'a' && carattere <= 'z')
                    //Faccio l'else if per verificare se sia minuscola e nel caso aggiungo il carattere al risultato\\
                {
                    int posizione = carattere - 'a';
                    int nuovaPosizione = (posizione - chiave + 26) % 26;
                    char nuovaLettera = (char)('a' + nuovaPosizione);

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
