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
            public string profile { get; set; }
            public string profile1 { get; set; }
            public string profile2 { get; set; }
            public string label { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string link { get; set; }
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
            public string skills { get; set; }
            public string skills1 { get; set; }
            public string skills2 { get; set; }
            public string skills3 { get; set; }
            public string skills4 { get; set; }
            public string skills5 { get; set; }
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
            string profile = resumeFromJson.profile;
            string profile1 = resumeFromJson.profile1;
            string profile2 = resumeFromJson.profile2;
            string label = resumeFromJson.label;
            string Email = resumeFromJson.Email;
            string Phone = resumeFromJson.Phone;
            string link = resumeFromJson.link;

            string Address = resumeFromJson.Address;
            string barangay = resumeFromJson.barangay;
            string city = resumeFromJson.city;
            string region = resumeFromJson.region;
            string postalcode = resumeFromJson.postalCode;
            

            string school = resumeFromJson.institution;
            string course = resumeFromJson.course;
            string skills = resumeFromJson.skills;
            string skills1 = resumeFromJson.skills1;
            string skills2 = resumeFromJson.skills2;
            string skills3 = resumeFromJson.skills3;
            string skills4 = resumeFromJson.skills4;
            string skills5 = resumeFromJson.skills5;

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
                    XGraphics draw = XGraphics.FromPdfPage(addpage);

                    //font
                    XFont largefont = new XFont("SoinSans", 30, XFontStyle.Bold);
                    XFont smallfont = new XFont("SoinSans", 12, XFontStyle.Regular);
                    XFont titlefont = new XFont("SoinSans", 16, XFontStyle.Bold);

                    
                    XPen colorpen = new XPen(XColors.LightCoral, 20);
                    XPen lineinleft = new XPen(XColors.Snow, 1); ;
                    XPen lineinright = new XPen(XColors.Snow, 1);

                    //page
                    draw.DrawRoundedRectangle(XBrushes.MistyRose, 0, 0, addpage.Width.Point, addpage.Height.Point, 30, 20);
                    draw.DrawRoundedRectangle(XBrushes.MistyRose, 200, 50, addpage.Width.Point, addpage.Height.Point, 100, 100);
                    draw.DrawRectangle(colorpen, 0, 0, addpage.Width.Point, addpage.Height.Point);


                    //name
                    draw.DrawString(lastname +"," + " "+ firstname, largefont, XBrushes.Chocolate, new XRect(30, 30, addpage.Width.Point - 315, addpage.Height.Point - 50), XStringFormats.TopLeft);

                    //profile
                    draw.DrawString("PROFILE", titlefont, XBrushes.RosyBrown, new XRect(30, 70, addpage.Width.Point - 390, addpage.Height.Point - 200), XStringFormats.TopLeft);
                    draw.DrawString(profile, smallfont, XBrushes.Brown, new XRect(30, 100, addpage.Width.Point - 397, addpage.Height.Point - 280), XStringFormats.TopLeft);
                    draw.DrawString(profile1, smallfont, XBrushes.Brown, new XRect(30, 120, addpage.Width.Point - 397, addpage.Height.Point - 280), XStringFormats.TopLeft);
                    draw.DrawString(profile2, smallfont, XBrushes.Brown, new XRect(30, 140, addpage.Width.Point - 397, addpage.Height.Point - 280), XStringFormats.TopLeft);


                    //basic info
                    draw.DrawString("BASIC INFORMATION", titlefont, XBrushes.RosyBrown, new XRect(30, 170, addpage.Width.Point - 390, addpage.Height.Point - 200), XStringFormats.TopLeft);
                    draw.DrawString(Email, smallfont, XBrushes.Brown, new XRect(30, 190, addpage.Width.Point - 397, addpage.Height.Point - 280), XStringFormats.TopLeft);
                    draw.DrawString(Phone, smallfont, XBrushes.Brown, new XRect(30, 210, addpage.Width.Point - 485, addpage.Height.Point - 280), XStringFormats.TopLeft);
                    draw.DrawString(link, smallfont, XBrushes.Brown, new XRect(30, 230, addpage.Width.Point - 395, addpage.Height.Point - 280), XStringFormats.TopLeft);

                    //location
                    draw.DrawString("LOCATION", titlefont, XBrushes.RosyBrown, new XRect(30, 270, addpage.Width.Point - 500, addpage.Height.Point - 200), XStringFormats.TopLeft);
                    draw.DrawString(Address, smallfont, XBrushes.Brown, new XRect(30, 290, addpage.Width.Point - 200, addpage.Height.Point - 290), XStringFormats.TopLeft);
                    draw.DrawString(barangay, smallfont, XBrushes.Brown, new XRect(30, 310, addpage.Width.Point - 500, addpage.Height.Point - 280), XStringFormats.TopLeft);
                    draw.DrawString(city, smallfont, XBrushes.Brown, new XRect(30, 330, addpage.Width.Point - 500, addpage.Height.Point - 280), XStringFormats.TopLeft);
                    draw.DrawString(region, smallfont, XBrushes.Brown, new XRect(30, 350, addpage.Width.Point - 500, addpage.Height.Point - 280), XStringFormats.TopLeft );
                    draw.DrawString(postalcode, smallfont, XBrushes.Brown, new XRect(30, 370, addpage.Width.Point - 500, addpage.Height.Point - 280), XStringFormats.TopLeft);

                    //college
                    draw.DrawString("SCHOOL", titlefont, XBrushes.RosyBrown, new XRect(30, 400, addpage.Width.Point - 500, addpage.Height.Point - 200), XStringFormats.TopLeft);
                    draw.DrawString(school, smallfont, XBrushes.Brown, new XRect(30, 420, addpage.Width.Point - 200, addpage.Height.Point - 290), XStringFormats.TopLeft);
                    draw.DrawString(course, smallfont, XBrushes.Brown, new XRect(30, 440, addpage.Width.Point - 200, addpage.Height.Point - 290), XStringFormats.TopLeft);

                    //skills
                    draw.DrawString("HARD SKILLS", titlefont, XBrushes.RosyBrown, new XRect(30, 470, addpage.Width.Point - 500, addpage.Height.Point - 200), XStringFormats.TopLeft);
                    draw.DrawString(skills, smallfont, XBrushes.Brown, new XRect(30, 490, addpage.Width.Point - 200, addpage.Height.Point - 290), XStringFormats.TopLeft);
                    draw.DrawString(skills1, smallfont, XBrushes.Brown, new XRect(30, 510, addpage.Width.Point - 200, addpage.Height.Point - 290), XStringFormats.TopLeft);
                    draw.DrawString(skills2, smallfont, XBrushes.Brown, new XRect(30, 530, addpage.Width.Point - 200, addpage.Height.Point - 290), XStringFormats.TopLeft);

                    //skills
                    draw.DrawString("SOFT SKILLS", titlefont, XBrushes.RosyBrown, new XRect(30, 560, addpage.Width.Point - 500, addpage.Height.Point - 200), XStringFormats.TopLeft);
                    draw.DrawString(skills3, smallfont, XBrushes.Brown, new XRect(30, 580, addpage.Width.Point - 200, addpage.Height.Point - 290), XStringFormats.TopLeft);
                    draw.DrawString(skills4, smallfont, XBrushes.Brown, new XRect(30, 600, addpage.Width.Point - 200, addpage.Height.Point - 290), XStringFormats.TopLeft);
                    draw.DrawString(skills5, smallfont, XBrushes.Brown, new XRect(30, 620, addpage.Width.Point - 200, addpage.Height.Point - 290), XStringFormats.TopLeft);


                    int onright = 375;

                    string jpg = @"C:\Users\Melody\source\repos\PDF Resume Creator\PDF Resume Creator\melody.jpg";
                    XImage img = XImage.FromFile(jpg);
                    draw.DrawImage(img, onright, 25, 200, 200);



                    
                    pdf.Save(saveFileDialog.FileName);
                }
            }
            Application.Restart();
            Environment.Exit(0);
        }
    }
}

