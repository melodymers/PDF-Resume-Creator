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

        public class Resumecrtr
        {
            public string lastname { get; set; }
            public string firstname { get; set; }
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
            string jsonFile;
            using (var reader = new StreamReader(fileName))
            {
                jsonFile = reader.ReadToEnd();
            }
            var resumeFromJson = JsonConvert.DeserializeObject<Resumecrtr>(jsonFile);

            string lastname = resumeFromJson.lastname;
            string firstname = resumeFromJson.lastname;
            string label = resumeFromJson.label;
            string Email = resumeFromJson.email;
            string Phone = resumeFromJson.phone;

            string address = resumeFromJson.address;
            string postalcode = resumeFromJson.PostalCode;
            string city = resumeFromJson.city;

            string media = resumeFromJson.SocialMedia;
            string username = resumeFromJson.username;
            string url = resumeFromJson.URL;

            string school = resumeFromJson.institution;
            string course = resumeFromJson.course;

            string language = resumeFromJson.language;
            string interest = resumeFromJson.interest;
            string keywords = resumeFromJson.keywords;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = @"C:\Users\Melody\source\repos\PDF Resume Creator\PDF Resume Creator";
                saveFileDialog.FileName = lastname + " " + firstname + ".pdf";
                saveFileDialog.Filter = "PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = lastname + "_" + "Resume";
                    PdfPage page = pdf.AddPage();

                    XGraphics graph = XGraphics.FromPdfPage(page);
                    XFont bigfont = new XFont("SoinSans", 20, XFontStyle.Bold);
                    XFont smallfont = new XFont("SoinSans", 16, XFontStyle.Regular);
                    XFont titlefont = new XFont("SoinSans", 30, XFontStyle.Bold);

                    XPen pen = new XPen(XColors.LightCoral, 20);
                    XPen linerleft = new XPen(XColors.Snow, 1); ;
                    XPen linerright = new XPen(XColors.Snow, 1);

                    pdf.Save(saveFileDialog.FileName);
                }
            }
            Application.Restart();
            Environment.Exit(0);
        }
    }
}

