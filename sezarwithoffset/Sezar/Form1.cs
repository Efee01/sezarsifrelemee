using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "";
            cumle =cumlelabeli.Text;//sifrelenecek mesajı textten kullanıcıdan aldırdım
            char[] chars = cumle.ToCharArray();//burda yazılan cümleyi chara çevirdim
            foreach (char i in chars)
            {
                
               sifrelemelabeli.Text += Convert.ToChar(i + 3).ToString();
                //chara dönüşen 3 birim ötelenmiş şifreyi
               //diğer texte yazdırsın diye foreach döngüsü oluşturdum 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cozum = "";
            cozum = cumlelabeli.Text;//sifrelenmiş mesajı textten kullanıcıdan aldırdım
            char[] chars = cozum.ToCharArray();
            foreach (char i2 in chars)
            {
                
                sifrelemelabeli.Text += Convert.ToChar(i2 -3).ToString();
                //3 birim ötelenen şifreyi geri çözmesi için 3 azaltıp
                //asıl cümleyi bulması için tekrar foreach döngüsü oluşturdum 
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cumlelabeli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
