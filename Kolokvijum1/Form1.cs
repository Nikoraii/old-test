using Kolokvijum1.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Kolokvijum1
{
    public partial class Form1 : Form
    {
        protected List<Knjiga> knjige = new List<Knjiga>();
        public int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbListaKnjiga.Items.Clear();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var naslov = tbNaslov.Text;
            var autor = tbAutor.Text;
            var godinaizdanja = tbGodinaIzdanja.Text;
            int godinaizdanjaint = int.Parse(godinaizdanja);
            var listazanrova = tbListaZanrova.Text;
            var listaocena = tbListaOcena.Text;
            //List<Knjiga> knjige = new List<Knjiga>();

            if (listazanrova == string.Empty)
            {
                MessageBox.Show("Morate uneti barem jedan zanr!");
            } else if(listaocena == string.Empty)
            {
                MessageBox.Show("Morate uneti barem jednu ocenu!");
            }
            else
            {
                string[] ocene = listaocena.Split(',');
                int[] oceneint = new int[ocene.Length];
                int k = 0;
                bool d = true;
                foreach (var ocena in ocene)
                {
                    var ocenaint = Convert.ToInt32(ocena);
                    oceneint[k] = ocenaint;
                    k++;
                }
                foreach (var ocenaint in oceneint)
                {
                    if (ocenaint > 5 || ocenaint < 1)
                    {
                        MessageBox.Show("Pogresna ocena!");
                        d = false;
                        break;
                    }
                }
                if (d == true)
                {
                    if (naslov == string.Empty) naslov = "Nepoznat naslov";
                    if (autor == string.Empty) autor = "Nepoznat autor";
                    knjige.Add(new Knjiga(naslov, autor, godinaizdanjaint, listazanrova, listaocena));
                    lbListaKnjiga.Items.Add(knjige[i]);
                    i++;
                    tbNaslov.Text = "";
                    tbAutor.Text = "";
                    tbGodinaIzdanja.Text = "";
                    tbListaZanrova.Text = "";
                    tbListaOcena.Text = "";
                }
                else if (d == false)
                {
                    //d = false;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpisFajl_Click(object sender, EventArgs e)
        {
            var file = tbUpisFajl.Text;
            var fileX = file + ".xml";
            var putanja = $@"F:\FAKULTET\Programiranje moblinih komunikacija\Kolokvijum1\Fajlovi\Knjige\{fileX}";
            if(file == string.Empty)
            {
                MessageBox.Show("Unesite ime fajla!");
            }
            else
            {
                tbNaslov.Text = "";
                tbAutor.Text = "";
                tbGodinaIzdanja.Text = "";
                tbListaZanrova.Text = "";
                tbListaOcena.Text = "";
                using (var swriter = new StreamWriter(putanja))
                {
                    XmlSerializer xmlSerializerKnjige = new XmlSerializer(typeof(List<Knjiga>));
                    xmlSerializerKnjige.Serialize(swriter, knjige);
                }
                tbUpisFajl.Text = "";
                lbListaKnjiga.Items.Clear();
                MessageBox.Show("Uspesno ste uneli listu u fajl!");
            }
        }

        private void btnUcitajFajl_Click(object sender, EventArgs e)
        {
            lbListaKnjiga.Items.Clear();
            var file = tbUpisFajl.Text;
            var fileX = file + ".xml";
            var putanja = $@"F:\FAKULTET\Programiranje moblinih komunikacija\Kolokvijum1\Fajlovi\Knjige\{fileX}";
            if (file == string.Empty)
            {
                MessageBox.Show("Unesite ime fajla!");
            }
            else
            {
                using (var sreader = new StreamReader(putanja))
                {
                    XmlSerializer xmlSerializerKnjige = new XmlSerializer(typeof(List<Knjiga>));
                    knjige = (List<Knjiga>)xmlSerializerKnjige.Deserialize(sreader);
                    foreach (var knjiga in knjige)
                    {
                        lbListaKnjiga.Items.Add(knjiga);
                    }
                }
            }
        }
    }
}
