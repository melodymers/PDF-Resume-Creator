using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace PDF_Resume_Creator
{
    public partial class generatePage : Form
    {
        private readonly string fileName = (@"C:\Users\Melody\source\repos\PDF Resume Creator\PDF Resume Creator\Resumecrtr.json");
        public generatePage()
        {
            InitializeComponent();
        }

        public class ResumeGen
        {
            public string name { get; set; }
            public string label { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string address { get; set; }
            public string PostalCode { get; set; }
            public string city { get; set; }
            public string SocialMedia { get; set; }
            public string username { get; set; }
            public string URL { get; set; }
            public string institution { get; set; }
            public string course { get; set; }
            public string language { get; set; }
            public string interest { get; set; }
            public string keywords { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
