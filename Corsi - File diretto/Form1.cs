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

namespace Corsi___File_diretto
{
    public partial class Form1 : Form
    {
        public struct prodotto
        {
            public string nome;
            public float prezzo;
        }
        string file, appoggio;
        string line;
        byte[] br;
        int recordLength;
        public prodotto P;
        int indice;
        string verità;
        public Form1()
        {
            InitializeComponent();
            file = @"File.csv";
            appoggio = @"FileAppoggio.csv";
            recordLength = 64;
            indice = 0;
            verità = "true";
        }

        private void salva_Click(object sender, EventArgs e)
        {
            P.nome = textBox1.Text;
            P.prezzo = float.Parse(textBox2.Text);
            scriviAppend(ToString(P, verità), file);
            indice++;
        }
        private void stampa_Click(object sender, EventArgs e)
        {
            var f = new FileStream(file, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);
            f.Seek(0, SeekOrigin.Begin);
            listView1.Clear();
            while (f.Position < f.Length)
            {
                br = reader.ReadBytes(recordLength);
                line = Encoding.ASCII.GetString(br, 0, br.Length);
                listView1.Items.Add(line);
                
            }
            f.Close();
        }
        private void cancella_Click(object sender, EventArgs e)
        {
            var f = new FileStream(file, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);



                f.Seek(0, SeekOrigin.Begin);
                br = Encoding.ASCII.GetBytes(line);
                reader.BaseStream.Write(br, 0, br.Length);
                f.Close();
        }

        private void svuota_Click(object sender, EventArgs e)
        {
            File.Delete(file);
            listView1.Clear();
        }


        public static string ToString(prodotto P, string verità)
        {
            string sep = ";";
            return (P.nome + sep + P.prezzo + sep + verità).PadRight(60) + "##";

        }
        public static void scriviAppend(string line, string file)
        {
            var oStream = new FileStream(file, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(line);
            sw.Close();
        }
        public static string cercaSuFile(string file)
        {
            StreamReader sr = new StreamReader(file);
            string line = "";
             
            while (!sr.EndOfStream)
            {
               


            }

            sr.Close();

            return line;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
