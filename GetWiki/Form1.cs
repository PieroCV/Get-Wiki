using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetWiki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebBrowser navegador = new WebBrowser();

        private void button1_Click(object sender, EventArgs e)
        {
            string search = tb_InputLink.Text.Replace(" ", "%20");
            navegador.Navigate("https://www.google.com/search?q=" + search);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            navegador.ScriptErrorsSuppressed = true;
            navegador.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Load_Data_Wiki);
        }

        private void Load_Data_Search(object sender, EventArgs e)
        {

        }

        private
        private void Load_Data_Wiki(object sender, EventArgs e)
        {
            tb_ShowTittle.Text = navegador.Document.GetElementById("section_0").InnerText;
            HtmlElementCollection text = navegador.Document.GetElementsByTagName("p");
            foreach (HtmlElement realtext in text)
            {
                tb_ShowText.Text = realtext.GetAttribute("InnerText");
                break;
            }
            

        }
    }
}
