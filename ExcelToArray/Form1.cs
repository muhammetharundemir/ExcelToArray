using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace ExcelToArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        //
        //
        string DosyaYolu;
        string DosyaAdi;
        //
        StreamWriter file_writer;
		//StreamReader file_reader;
        //
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        //
        //
        //
        bool cSharp = false;
        bool cpp = false;
        bool excelToArray = false;
        bool cSharpWrite = false;
        bool cppWrite = false;
        //
        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası | *.xls; *.xlsx; *.xlsm";
            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = file.FileName;// seçilen dosyanın tüm yolunu verir
                DosyaAdi = file.SafeFileName;// seçilen dosyanın adını verir.
                labelConversionCompleted.Visible = false;
                buttonSelectFile.ForeColor = Color.DarkSeaGreen;
                cpp = true;
                cSharp = true;
            }
            else
            {
                buttonSelectFile.ForeColor = Color.LightGray;
                cpp = false;
                cSharp = false;
                excelToArray = false;
                //MessageBox.Show("Dosya Seçilmedi.");
            }
        }
        //
        //
        //
        private void buttonExcel2Text_Click(object sender, EventArgs e)
        {
            if (excelToArray)
            {
                labelConversionCompleted.Text = "Processing...";
                labelConversionCompleted.Location= new System.Drawing.Point(54, 93);
                labelConversionCompleted.Visible = true;
                try
                {
                    if (cSharpWrite)
                    {
                        OpenFileCSharp(DosyaYolu);
                    }
                    else if (cppWrite)
                    {
                        OpenFileCpp(DosyaYolu);
                    }
                    buttonExcel2Text.ForeColor = Color.DarkSeaGreen;
                    excelToArray = false;
                }
                catch
                {
                    labelConversionCompleted.Visible = false;
                }
            }
        }
        //
        //
        //
        public void OpenFileCSharp(string location)
        {
            string address = DosyaYolu + ".txt";
            Excel(location, 1);
            for (int j = 1; j < 10000; j++)
            {
                for (int i = 1; i < 10000; i++)
                {
                    if (ws.Cells[i, j].Value2 != null)
                    {
                        if (i == 1)
                        {
                            //richTextBox1.Text += ws.Cells[i, j].Value2 + " = { ";
                            file_writer = new StreamWriter(address, true);
                            file_writer.Write("double[] " + ws.Cells[i, j].Value2 + " = { ");
                            file_writer.Close();
                        }
                        else if (i == 2)
                        {
                            //richTextBox1.Text += ws.Cells[i, j].Value2;
                            file_writer = new StreamWriter(address, true);
                            file_writer.Write(ws.Cells[i, j].Value2);
                            file_writer.Close();
                        }
                        else
                        {
                            //richTextBox1.Text += ", " + ws.Cells[i, j].Value2;
                            file_writer = new StreamWriter(address, true);
                            file_writer.Write(", " + ws.Cells[i, j].Value2);
                            file_writer.Close();
                        }
                    }
                    else if (ws.Cells[1, j + 1].Value2 != null)
                    {
                        //richTextBox1.Text += " };\n";
                        file_writer = new StreamWriter(address, true);
                        file_writer.Write(" };\n");
                        file_writer.Close();
                        i = 10000;
                    }
                    else
                    {
                        //richTextBox1.Text += " };\n";
                        file_writer = new StreamWriter(address, true);
                        file_writer.Write(" };\n");
                        file_writer.Close();
                        labelConversionCompleted.Text = "Conversion Completed";
                        labelConversionCompleted.Location = new System.Drawing.Point(29, 93);
                        labelConversionCompleted.Visible = true;
                        i = 10000;
                        j = 10000;
                    }         
                }
            }
            Excel("0", 0);
        }
        //
        //
        //
        public void OpenFileCpp(string location)
        {
            string arrayName="";
            string address = DosyaYolu + ".txt";
            Excel(location, 1);
            for (int j = 1; j < 10000; j++)
            {
                for (int i = 1; i < 10000; i++)
                {
                    if (ws.Cells[i, j].Value2 != null)
                    {
                        if (i == 1)
                        {
                            //richTextBox1.Text += ws.Cells[i, j].Value2 + " = { ";
                            //file_writer.Write(ws.Cells[i, j].Value2 + " = { ");
                            //file_writer.Write("{ ");
                            //file_writer.Close();
                            arrayName = Convert.ToString(ws.Cells[i, j].Value2);
                            richTextBoxArray.Text = "{ ";
                        }
                        else if (i == 2)
                        {
                            //richTextBox1.Text += ws.Cells[i, j].Value2;
                            //file_writer = new StreamWriter(address, true);
                            //file_writer.Write(ws.Cells[i, j].Value2);
                            //file_writer.Close();
                            richTextBoxArray.Text += Convert.ToString(ws.Cells[i, j].Value2);
                        }
                        else
                        {
                            //richTextBox1.Text += ", " + ws.Cells[i, j].Value2;
                            //file_writer = new StreamWriter(address, true);
                            //file_writer.Write(", " + ws.Cells[i, j].Value2);
                            //file_writer.Close();
                            richTextBoxArray.Text += ", " + Convert.ToString(ws.Cells[i, j].Value2);
                        }
                    }
                    else if (ws.Cells[1, j + 1].Value2 != null)
                    {
                        //richTextBox1.Text += " };\n";
                        //file_writer = new StreamWriter(address, true);
                        //file_writer.Write(" };\n");
                        //file_writer.Close();
                        richTextBoxArray.Text += " };\n";
                        file_writer = new StreamWriter(address, true);
                        file_writer.Write("static array<double, 1>^" + Convert.ToString(arrayName) + " = gcnew array <double>(" + (i-2) + ") " + richTextBoxArray.Text);
                        file_writer.Close();
                        i = 10000;
                    }
                    else
                    {
                        //richTextBox1.Text += " };\n";
                        //file_writer = new StreamWriter(address, true);
                        //file_writer.Write(" };\n");
                        //file_writer.Close();
                        richTextBoxArray.Text += " };\n";
                        file_writer = new StreamWriter(address, true);
                        file_writer.Write("static array<double, 1>^" + Convert.ToString(arrayName) + " = gcnew array <double>(" + (i-2) + ") " + richTextBoxArray.Text);
                        file_writer.Close();
                        labelConversionCompleted.Text = "Conversion Completed";
                        labelConversionCompleted.Location = new System.Drawing.Point(29, 93);
                        labelConversionCompleted.Visible = true;
                        i = 10000;
                        j = 10000;
                    }
                }
            }
            Excel("0", 0);
        }
        //
        //
        //
        void Excel(string path, int Sheet)
        {
            if (Sheet == 0)
            {
                excel.Workbooks.Close();
            }
            else
            {
                this.path = path;
                wb = excel.Workbooks.Open(path);
                ws = wb.Worksheets[Sheet];
            }
        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            //System.Windows.Forms.Application.ExitThread();
            //this.Close();
        }
        //
        //
        //
        private bool enableMoving = false;
        private System.Drawing.Point initialClickedPoint;
        private void panelAbove_MouseDown(object sender, MouseEventArgs e)
        {
            enableMoving = true;
            initialClickedPoint = e.Location;
        }
        //
        //
        //
        private void panelAbove_MouseUp(object sender, MouseEventArgs e)
        {
            enableMoving = false;
        }
        //
        //
        //
        private void panelAbove_MouseMove(object sender, MouseEventArgs e)
        {
            if(enableMoving)
            {
                this.Location = new System.Drawing.Point(e.X + this.Left - initialClickedPoint.X, e.Y + this.Top - initialClickedPoint.Y);
            }
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            enableMoving = true;
            initialClickedPoint = e.Location;
        }

        private void labelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            enableMoving = false;
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (enableMoving)
            {
                this.Location = new System.Drawing.Point(e.X + this.Left - initialClickedPoint.X, e.Y + this.Top - initialClickedPoint.Y);
            }
        }
        private void buttonCSharp_Click(object sender, EventArgs e)
        {
            if(cSharp)
            {
                cSharpWrite = true;
                cppWrite = false;
                cpp = true;
                cSharp = false;
                buttonCSharp.ForeColor = Color.DarkSeaGreen;
                buttonCpp.ForeColor = Color.LightGray;
                buttonExcel2Text.ForeColor = Color.LightGray;
                labelConversionCompleted.Visible = false;
                excelToArray = true;

            }            
        }

        private void buttonCpp_Click(object sender, EventArgs e)
        {
            if (cpp)
            {
                cppWrite = true;
                cSharpWrite = false;                
                cSharp = true;
                cpp = false;
                buttonCpp.ForeColor = Color.DarkSeaGreen;
                buttonExcel2Text.ForeColor = Color.LightGray;
                buttonCSharp.ForeColor = Color.LightGray;
                labelConversionCompleted.Visible = false;
                excelToArray = true;
            }
        }
    }
}
