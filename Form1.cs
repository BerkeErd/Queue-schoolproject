using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Yigin yigin = new Yigin(15);
        BagliListe bliste = new BagliListe();
        Kuyruk kuyruk = new Kuyruk(100);
        Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            yigin.Push("Siyah");
            yigin.Push("Beyaz");
            yigin.Push("Yeşil");
            yigin.Push("Mor");
            yigin.Push("Mavi");
            yigin.Push("Kırmızı");
            yigin.Push("Sarı");
            yigin.Push("Altın");
            yigin.Push("Gümüş");
            yigin.Push("Bronz");
            yigin.Push("Kahverengi");
            yigin.Push("Turkuaz");
            yigin.Push("Lacivert");
            yigin.Push("Pembe");
            yigin.Push("Lila");
            kuyruk.Insert("Gül");
            kuyruk.Insert("Mandalina");
            kuyruk.Insert("Pas");
            kuyruk.Insert("Altuni");
            kuyruk.Insert("Yosun");
            kuyruk.Insert("Kabak");
            kuyruk.Insert("Ametist");
            kuyruk.Insert("Orkide");
            kuyruk.Insert("Kiraz");
            kuyruk.Insert("Armut");
            kuyruk.Insert("Nar");
            kuyruk.Insert("Yesim");
            kuyruk.Insert("Teal");
            kuyruk.Insert("Cyan");
            kuyruk.Insert("Kobalt");
            bliste.InsertFirst("Turuncu");
            bliste.InsertFirst("Viridian");
            bliste.InsertFirst("Mercan");
            bliste.InsertFirst("Kardinal");
            bliste.InsertFirst("Limoni");
            bliste.InsertFirst("Kremrengi");
            bliste.InsertFirst("Gri");
            bliste.InsertFirst("Galibarda");
            bliste.InsertFirst("Camgöbeği");
            bliste.InsertFirst("Bordo");
            bliste.InsertFirst("Bej");
            bliste.InsertFirst("Bakir");
            bliste.InsertFirst("Burgonya");
            bliste.InsertFirst("Hardal");
            bliste.InsertFirst("Leylak");

           
            for(int i=0; i<15; i++)
            {
                txt1Kat.Text += kuyruk.Bkuyruk[i] + Environment.NewLine;
                txt2Kat.Text += yigin.items[i] + Environment.NewLine;
                txtBodrum.Text = bliste.DisplayElements();


            }

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            int yuzdeElli;
            txtCikan1.Text = kuyruk.Bkuyruk[kuyruk.front] +"";
            kuyruk.Remove();
            yuzdeElli = r.Next(0, 100);
            if (yigin.IsEmpty())
            {
                yuzdeElli = 99;
            }
            if (bliste.Head == null)
            {
                yuzdeElli = 1;
            }
            if (bliste.Head == null && yigin.IsEmpty())
            {
                txt1Kat.Text = "";
                for (int j = 0; j < kuyruk.Bkuyruk.Length; j++)
                {
                    if (kuyruk.Bkuyruk[j] == null)
                    {
                        continue;
                    }
                    txt1Kat.Text += kuyruk.Bkuyruk[j] + Environment.NewLine;
                }
            }
            if(kuyruk.IsEmpty())
            {
                MessageBox.Show("SON ÇIKAN ARABA :"+txtCikan1.Text+" Renktir");
            }
            if (yuzdeElli<=50)
            {
                if(yigin.IsEmpty())
                {
                    
                }
                else
                { 
                txtCikan2.Text = yigin.items[yigin.Top] +"";
                kuyruk.Insert(yigin.items[yigin.Top]);
                txt2Kat.Text = "";
                for (int i = 0; i < yigin.Top; i++)
                {
                    txt2Kat.Text += yigin.items[i] + Environment.NewLine;
                }
                yigin.Pop();

                txt1Kat.Text = "";
                
                for (int j = 0; j < kuyruk.Bkuyruk.Length; j++)
                {
                        if(kuyruk.Bkuyruk[j]==null)
                        {
                            continue;
                        }
                    txt1Kat.Text += kuyruk.Bkuyruk[j] + Environment.NewLine;
                }
                }
            }
            else
            {
                if(bliste.Head==null)
                {
                    
                }
                else
                {                     
                txtCikanBodrum.Text = bliste.Head.Data;
                kuyruk.Insert(bliste.Head.Data);
                txtBodrum.Text = "";               
                bliste.DeleteFirst();
                for (int i = 0; i < bliste.Size; i++)
                {
                    txtBodrum.Text = bliste.DisplayElements();
                }
                txt1Kat.Text = "";
                
                for (int j = 0; j < kuyruk.Bkuyruk.Length; j++)
                {
                        if (kuyruk.Bkuyruk[j] == null)
                        {
                            continue;
                               }
                        txt1Kat.Text += kuyruk.Bkuyruk[j] + Environment.NewLine;
                }
                }
            }
        }
    }
}
