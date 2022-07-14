using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace PDF_Resume_Creator
{
    public partial class generatePage : Form
    {
        private readonly string PDF_Resume_Creator = (@"C:\Users\Melody\source\repos\PDF Resume Creator\PDF Resume Creator\Resumecrtr.json");
        public generatePage()
        {
            InitializeComponent();
        }

        public class Resumecrtr
        {
            public string lastname { get; set; }
            public string firstname { get; set; }
            public string label { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string barangay { get; set; }
            public string city { get; set; }
            public string region { get; set; }
            public string postalCode { get; set; }
            public string media { get; set; }
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
            string JsonFile;
            using (var reader = new StreamReader(PDF_Resume_Creator))
            {
                JsonFile = reader.ReadToEnd();
            }
            var resumeFromJson = JsonConvert.DeserializeObject<Resumecrtr>(JsonFile);

            string lastname = resumeFromJson.lastname;
            string firstname = resumeFromJson.firstname;
            string label = resumeFromJson.label;
            string Email = resumeFromJson.Email;
            string Phone = resumeFromJson.Phone;

            string Address = resumeFromJson.Address;
            string barangay = resumeFromJson.barangay;
            string city = resumeFromJson.city;
            string region = resumeFromJson.region;
            string postalcode = resumeFromJson.postalCode;
            

            string media = resumeFromJson.media;
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
                saveFileDialog.FileName = lastname + "_" + firstname + ".pdf";
                saveFileDialog.Filter = "PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = lastname + "_" + "Resume";
                    PdfPage addpage = pdf.AddPage();

                    //page
                    XGraphics graph = XGraphics.FromPdfPage(addpage);

                    //font
                    XFont largefont = new XFont("SoinSans", 20, XFontStyle.Bold);
                    XFont smallfont = new XFont("SoinSans", 16, XFontStyle.Regular);
                    XFont titlefont = new XFont("SoinSans", 30, XFontStyle.Bold);

                    
                    XPen colorpen = new XPen(XColors.LightCoral, 20);
                    XPen lineinleft = new XPen(XColors.Snow, 1); ;
                    XPen lineinright = new XPen(XColors.Snow, 1);

                    //page
                    graph.DrawRoundedRectangle(XBrushes.MistyRose, 0, 0, addpage.Width.Point, addpage.Height.Point, 30, 20);
                    graph.DrawRoundedRectangle(XBrushes.MistyRose, 200, 50, addpage.Width.Point, addpage.Height.Point, 100, 100);
                    graph.DrawRectangle(colorpen, 0, 0, addpage.Width.Point, addpage.Height.Point);

                    graph.DrawString("PROGRAMMER", largefont, XBrushes.Chocolate, new XRect(0, 20, addpage.Width.Point - 20, addpage.Height.Point - 50), XStringFormats.TopRight);

                    int onleft = 25;
                    int initialleft = 200;

                    string jpg = @"C:\Users\Melody\source\repos\PDF Resume Creator\PDF Resume Creator\melody.jpg";
                    XImage img = XImage.FromFile(jpg);
                    graph.DrawImage(img, onleft, 100, 200, 300);

                    pdf.Save(saveFileDialog.FileName);
                }
            }
            Application.Restart();
            Environment.Exit(0);
        }
    }
}

