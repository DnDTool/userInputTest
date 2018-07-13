using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;


namespace userInputTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Are you sure you want to exit?", "Character builder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // --##-- Reset function --##--
        private void ResetTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        // --##-- Reset button --##--
        private void button2_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }
        private void CreateNewCharacter_Click(object sender, EventArgs e)
        {
            Character character = new Character();

            character.Strength = int.Parse(txtStrength.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            string filePath;
            dlg.Filter = "PDF Files(*.PDF)|*.PDF|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filePath = dlg.FileName.ToString();


                string strText = string.Empty;
                try
                {
                    PdfReader reader = new PdfReader(filePath);
                    for (int page = 1; page <= reader.NumberOfPages; page++)
                    {
                        ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.lo
                        String s = PdfTextExtractor.GetTextFromPage(reader, page, its);

                        s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default,))
                        strText = strText + s;
                        richTextBox1.Text = strText;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PDF files|*.pdf", ValidateNames = true, Multiselect = false })
            //{
                //if(ofd.ShowDialog() == DialogResult.OK)
                //{
                    
                    //try
                    //{
                        
                        //iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(ofd.FileName);
                        //Console.WriteLine(reader);
                        //StringBuilder sb = new StringBuilder();
                        //Console.WriteLine(sb);
                        //for (int i = 1; i <= 10; i++)
                        //{
                        //    sb.Append(reader.GetPdfObject(i));
                        //    sb.AppendLine();
                        // }
                        //sb.Append(reader.GetPdfObject(1));
                        //sb.AppendLine();
                        //sb.Append(reader.GetPdfObject(2));
                        //sb.Append(reader.GetPdfObject(3));
                        //sb.Append(reader.ToString());
                        //for (int i = 1; i <= reader.NumberOfPages; i++)
                        //{
                        //sb.Append(iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(reader, 1));

                    //}
                        //richTextBox1.Text = sb.ToString();
                        //reader.Close();
                    //}
                    //catch(Exception ex)
                    //{
                        //MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                //}
            //}
        }
        private void CreatePDF_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.A4);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();//Open Document to write

            Paragraph paragraph = new Paragraph("This is my first line using Paragraph.\nhi hello");

            doc.Add(paragraph);

            List list = new List(List.UNORDERED);

            list.IndentationLeft = 30f;

            list.Add(new ListItem("One"));
            list.Add("Two");
            list.Add("Three");
            list.Add("Four");
            list.Add("Five");

            doc.Add(list);

            doc.Close(); //Close Document 
            System.Diagnostics.Process.Start("Test.pdf");
        }
    }
}
