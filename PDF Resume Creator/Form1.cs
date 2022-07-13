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
            public string email { get; set; }
            public string phone { get; set; }
            public string address { get; set; }
            public string barangay { get; set; }
            public string city { get; set; }
            public string region { get; set; }
            public string PostalCode { get; set; }
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
            string JsonFile;
            using (var reader = new StreamReader(PDF_Resume_Creator))
            {
                JsonFile = reader.ReadToEnd();
            }
            var resumeFromJson = JsonConvert.DeserializeObject<Resumecrtr>(JsonFile);

            string lastname = resumeFromJson.lastname;
            string firstname = resumeFromJson.firstname;
            string label = resumeFromJson.label;
            string Email = resumeFromJson.email;
            string Phone = resumeFromJson.phone;

            string address = resumeFromJson.address;
            string barangay = resumeFromJson.barangay;
            string city = resumeFromJson.city;
            string region = resumeFromJson.region;
            string postalcode = resumeFromJson.PostalCode;
            

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

                    graph.DrawRoundedRectangle(XBrushes.MistyRose, 0, 0, page.Width.Point, page.Height.Point, 30, 20);
                    graph.DrawRoundedRectangle(XBrushes.MistyRose, 200, 50, page.Width.Point, page.Height.Point, 100, 100);
                    graph.DrawRectangle(pen, 0, 0, page.Width.Point, page.Height.Point);

                    graph.DrawString("PROGRAMMER", bigfont, XBrushes.Chocolate, new XRect(0, 20, page.Width.Point - 20, page.Height.Point - 50), XStringFormats.TopRight);

                    int marginleft = 25;
                    int initialleft = 200;

                    string png = @"C:\Users\Melody\source\repos\PDF Resume Creator\PDF Resume Creator\melody.png";
                    XImage image = XImage.FromFile(png);
                    graph.DrawImage(image, marginleft, 50, 150, 150);

                    graph.DrawString("BASIC INFORMATION:", bigfont, XBrushes.Chocolate, new XRect(marginleft, initialleft + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(Email, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(Phone, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(label, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 130, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);


                    graph.DrawRectangle (linerleft, marginleft, initialleft + 50, 150, 1);
                    graph.DrawString("ADDRESS:", bigfont, XBrushes.Chocolate, new XRect(marginleft, initialleft + 160, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(address, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 190, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(barangay, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 210, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(city, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 210, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(region, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 250, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(postalcode, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 290, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    //3RD
                    int marginmiddle = 220;
                    int initialmiddle = 200;

                    graph.DrawString(firstname, titlefont, XBrushes.Black, new XRect(marginmiddle, initialmiddle - 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(lastname, titlefont, XBrushes.DarkGray, new XRect(marginmiddle, initialmiddle - 70, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(linerright, marginmiddle, initialmiddle - 10, 350, 1);
                    graph.DrawString("CONTACT:", bigfont, XBrushes.Chocolate, new XRect(marginmiddle, initialmiddle, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(media, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(username, smallfont, XBrushes.Black, new XRect(marginmiddle + 25, initialmiddle + 50, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(url, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 70, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    pdf.Save(saveFileDialog.FileName);
                }
            }
            Application.Restart();
            Environment.Exit(0);
        }
    }
}

