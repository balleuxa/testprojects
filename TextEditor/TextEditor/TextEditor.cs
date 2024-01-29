using System.Diagnostics;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }
        private static string? filePath;
        private void btnNewText_Click(object sender, EventArgs e)
        {
            rtxtInput.Text = string.Empty;
        }

        private void CreateHmtlFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Save file as... ";
            sfd.Filter = "HTML files (*.html)|*.html";
            sfd.ShowDialog();
            filePath = sfd.FileName;
            File.WriteAllText(filePath, rtxtInput.Text);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                rtxtInput.Text = File.ReadAllText(ofd.FileName);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateHtml_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            string[] htmlExemples = new string[5];
            htmlExemples[0] = "<!DOCTYPE html>\r\n\r\n<html>\r\n    <head>\r\n        <title>Testing HTML</title>\r\n    </head>\r\n    <body>\r\n        <h1>Welcome to Testing HTML</h1>\r\n\r\n        <p>\r\n            This is a paragraph of sample HTML content.\r\n        </p>\r\n\r\n        <ul>\r\n            <li>Test item 1</li>\r\n            <li>Test item 2</li>\r\n            <li>Test item 3</li>\r\n        </ul>\r\n    </body>\r\n</html>";
            htmlExemples[1] = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n  <title>My Webpage</title>\r\n</head>\r\n<body>\r\n  <h1>Welcome to My Webpage</h1>\r\n  <p>This is a paragraph of text.</p>\r\n  <p>This is another paragraph of text.</p>\r\n</body>\r\n</html>";
            htmlExemples[2] = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n  <title>My Webpage with List and Form</title>\r\n</head>\r\n<body>\r\n  <h1>Welcome to My Webpage</h1>\r\n  <h2>My Favorite Things</h2>\r\n  <ul>\r\n    <li>Apples</li>\r\n    <li>Bananas</li>\r\n    <li>Oranges</li>\r\n  </ul>\r\n  <h2>Contact Me</h2>\r\n  <form>\r\n    <label for=\"name\">Name:</label>\r\n    <input type=\"text\" id=\"name\" name=\"name\"><br><br>\r\n    <label for=\"email\">Email:</label>\r\n    <input type=\"email\" id=\"email\" name=\"email\"><br><br>\r\n    <input type=\"submit\" value=\"Submit\">\r\n  </form>\r\n</body>\r\n</html>";
            htmlExemples[3] = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n  <title>Simple Webpage</title>\r\n</head>\r\n<body>\r\n  <h1>Welcome to My Webpage</h1>\r\n  <p>This is a paragraph of text.</p>\r\n  <ul>\r\n    <li>Item 1</li>\r\n    <li>Item 2</li>\r\n    <li>Item 3</li>\r\n  </ul>\r\n</body>\r\n</html>";
            htmlExemples[4] = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n  <title>My Webpage with Image and Link</title>\r\n</head>\r\n<body>\r\n  <h1>Welcome to My Webpage</h1>\r\n  <p>This is a paragraph of text.</p>\r\n  <img src=\"image.jpg\" alt=\"Description of the image\">\r\n  <p>Click <a href=\"https://www.example.com\">here</a> to visit Example.com</p>\r\n</body>\r\n</html>";
            rtxtInput.Text = htmlExemples[rnd.Next(5)];
        }

        private string ExtractHTMLtag(string input)
        {
            Regex rgx = new(@"<[^>]+>");
            string htlmTags = string.Empty;

            MatchCollection matchCollection = rgx.Matches(input);
            foreach (Match match in matchCollection)
            {
                htlmTags += match;
            }
            return htlmTags;
        }

        private void ModifyHTML()
        {
            string[] lns = rtxtInput.Lines;

            string convertedString = "";
            for (int i = 0; i < lns.Length; i++)
            {
                string tag = "<p></p>";
                int firstIndex = Array.FindIndex(lns, line => !string.IsNullOrWhiteSpace(line) && line.Contains("<body>"));
                int lastIndex = Array.FindLastIndex(lns, line => !string.IsNullOrWhiteSpace(line) && line.Contains("</body>"));
                if (i > firstIndex && i < lastIndex && ExtractHTMLtag(lns[i]) != "")
                {
                    tag = ExtractHTMLtag(lns[i]);
                }
                string htmlCode = HttpUtility.HtmlEncode(lns[i]);

                convertedString += tag.Insert(tag.IndexOf('>') + 1, htmlCode) + "\n";

            }

            rtxtInput.Text = convertedString;
            rtxtInput.Text = "<html>\n<body>\n\n" + rtxtInput.Text + "\n\n";
            rtxtInput.Text += ("</body>\n</html>");
        }

        private void bthPreview_Click(object sender, EventArgs e)
        {
            ModifyHTML();
            webBrowser1.DocumentText = rtxtInput.Text;
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            try
            {
                CreateHmtlFile();
                if (filePath != null)
                {
                    ProcessStartInfo psi = new(filePath);
                    psi.UseShellExecute = true;
                    Process.Start(psi);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtxtInput_TextChanged(object sender, EventArgs e)
        {
            if (rtxtInput.Text.Contains("&lt;") || rtxtInput.Text.Contains("&gt;"))
            {
                bthPreview.Enabled = false;
            }
            else
            {
                bthPreview.Enabled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }
    }
}