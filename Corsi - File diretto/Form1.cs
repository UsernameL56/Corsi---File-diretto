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
        string file;
        string line;
        byte[] br;
        int recordLength;
        public prodotto[] P;
        int indice;
        int linea;
        public Form1()
        {
            InitializeComponent();
            file = @"File.csv";
            recordLength = 64;
            indice = 0;
            linea = 0;
            P = new prodotto[100];
        }

        private void salva_Click(object sender, EventArgs e)
        {
            P[indice].nome = textBox1.Text;
            P[indice].prezzo = float.Parse(textBox2.Text);
            scriviAppend(ToString(P, indice), file);
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
                String[] split = line.Split(';');
                if (split[2] == "true")
                listView1.Items.Add(line);


            }
            f.Close();
        }
        private void cancella_Click(object sender, EventArgs e)
        {
            string sep = ";";
            cercaSuFile(file, textBox1.Text, ref linea);
            var f = new FileStream(file, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);
            f.Seek(recordLength * linea, SeekOrigin.Begin);
            line = Encoding.ASCII.GetString(br, 0, br.Length);
            br = Encoding.ASCII.GetBytes((P[linea].nome + sep + P[linea].prezzo + sep + "false" + sep).PadRight(60) + "##");
            reader.BaseStream.Write(br, 0, br.Length);
            f.Close();
        }
        private void ripristino_Click(object sender, EventArgs e)
        {
            string sep = ";";
            cercaSuFile(file, textBox1.Text, ref linea);
            var f = new FileStream(file, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);
            f.Seek(recordLength * linea, SeekOrigin.Begin);
            line = Encoding.ASCII.GetString(br, 0, br.Length);
            br = Encoding.ASCII.GetBytes((P[linea].nome + sep + P[linea].prezzo + sep + "true" + sep).PadRight(60) + "##");
            reader.BaseStream.Write(br, 0, br.Length);
            f.Close();
        }
        private void definitivo_Click(object sender, EventArgs e)
        {

        }
        private void svuota_Click(object sender, EventArgs e)
        {
            File.Delete(file);
            listView1.Clear();
        }


        public static string ToString(prodotto[] P, int indice)
        {
            string sep = ";";
            return (P[indice].nome + sep + P[indice].prezzo + sep + "true" + sep).PadRight(60) + "##";

        }
        public static void scriviAppend(string line, string file)
        {
            var oStream = new FileStream(file, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(line);
            sw.Close();
        }
        public static int cercaSuFile(string file, string input, ref int linea)
        {
            StreamReader sr = new StreamReader(file);
            string line = "";
            linea = 0;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                String[] split = line.Split(';');
                
                if(split[0] == input)
                {
                    break;
                }
                linea++;
            }

            sr.Close();

            return linea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


    }
}
