namespace ExcelToArray
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonExcel2Text = new System.Windows.Forms.Button();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.labelConversionCompleted = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMinimized = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelAbove = new System.Windows.Forms.Panel();
            this.buttonCSharp = new System.Windows.Forms.Button();
            this.buttonCpp = new System.Windows.Forms.Button();
            this.richTextBoxArray = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAbove.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonExcel2Text
            // 
            this.buttonExcel2Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcel2Text.ForeColor = System.Drawing.Color.LightGray;
            this.buttonExcel2Text.Location = new System.Drawing.Point(125, 40);
            this.buttonExcel2Text.Name = "buttonExcel2Text";
            this.buttonExcel2Text.Size = new System.Drawing.Size(65, 50);
            this.buttonExcel2Text.TabIndex = 0;
            this.buttonExcel2Text.TabStop = false;
            this.buttonExcel2Text.Text = "Excel to Text";
            this.buttonExcel2Text.UseVisualStyleBackColor = true;
            this.buttonExcel2Text.Click += new System.EventHandler(this.buttonExcel2Text_Click);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectFile.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSelectFile.Location = new System.Drawing.Point(10, 40);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(65, 50);
            this.buttonSelectFile.TabIndex = 2;
            this.buttonSelectFile.TabStop = false;
            this.buttonSelectFile.Text = "Select File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // labelConversionCompleted
            // 
            this.labelConversionCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConversionCompleted.AutoSize = true;
            this.labelConversionCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConversionCompleted.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.labelConversionCompleted.Location = new System.Drawing.Point(54, 93);
            this.labelConversionCompleted.Name = "labelConversionCompleted";
            this.labelConversionCompleted.Size = new System.Drawing.Size(90, 17);
            this.labelConversionCompleted.TabIndex = 3;
            this.labelConversionCompleted.Text = "Processing...";
            this.labelConversionCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelConversionCompleted.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.ForeColor = System.Drawing.Color.LightGray;
            this.buttonExit.Location = new System.Drawing.Point(164, -2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(39, 33);
            this.buttonExit.TabIndex = 307;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "x";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMinimized
            // 
            this.buttonMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonMinimized.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonMinimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.buttonMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimized.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMinimized.ForeColor = System.Drawing.Color.LightGray;
            this.buttonMinimized.Location = new System.Drawing.Point(126, -8);
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.Size = new System.Drawing.Size(38, 39);
            this.buttonMinimized.TabIndex = 308;
            this.buttonMinimized.TabStop = false;
            this.buttonMinimized.Text = "_";
            this.buttonMinimized.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimized.UseVisualStyleBackColor = false;
            this.buttonMinimized.Click += new System.EventHandler(this.buttonMinimized_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.LightGray;
            this.labelTitle.Location = new System.Drawing.Point(12, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 15);
            this.labelTitle.TabIndex = 309;
            this.labelTitle.Text = "Array";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseMove);
            this.labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseUp);
            // 
            // panelAbove
            // 
            this.panelAbove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelAbove.Controls.Add(this.label1);
            this.panelAbove.Controls.Add(this.buttonExit);
            this.panelAbove.Controls.Add(this.labelTitle);
            this.panelAbove.Controls.Add(this.buttonMinimized);
            this.panelAbove.Location = new System.Drawing.Point(-1, -1);
            this.panelAbove.Name = "panelAbove";
            this.panelAbove.Size = new System.Drawing.Size(202, 32);
            this.panelAbove.TabIndex = 310;
            this.panelAbove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAbove_MouseDown);
            this.panelAbove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAbove_MouseMove);
            this.panelAbove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelAbove_MouseUp);
            // 
            // buttonCSharp
            // 
            this.buttonCSharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCSharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCSharp.ForeColor = System.Drawing.Color.LightGray;
            this.buttonCSharp.Location = new System.Drawing.Point(80, 40);
            this.buttonCSharp.Name = "buttonCSharp";
            this.buttonCSharp.Size = new System.Drawing.Size(40, 24);
            this.buttonCSharp.TabIndex = 311;
            this.buttonCSharp.TabStop = false;
            this.buttonCSharp.Text = "C#";
            this.buttonCSharp.UseVisualStyleBackColor = true;
            this.buttonCSharp.Click += new System.EventHandler(this.buttonCSharp_Click);
            // 
            // buttonCpp
            // 
            this.buttonCpp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCpp.ForeColor = System.Drawing.Color.LightGray;
            this.buttonCpp.Location = new System.Drawing.Point(80, 66);
            this.buttonCpp.Name = "buttonCpp";
            this.buttonCpp.Size = new System.Drawing.Size(40, 24);
            this.buttonCpp.TabIndex = 312;
            this.buttonCpp.TabStop = false;
            this.buttonCpp.Text = "C++";
            this.buttonCpp.UseVisualStyleBackColor = true;
            this.buttonCpp.Click += new System.EventHandler(this.buttonCpp_Click);
            // 
            // richTextBoxArray
            // 
            this.richTextBoxArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBoxArray.Location = new System.Drawing.Point(400, 100);
            this.richTextBoxArray.Name = "richTextBoxArray";
            this.richTextBoxArray.ReadOnly = true;
            this.richTextBoxArray.Size = new System.Drawing.Size(1, 1);
            this.richTextBoxArray.TabIndex = 313;
            this.richTextBoxArray.Text = "";
            this.richTextBoxArray.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(47, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 310;
            this.label1.Text = "Excel to Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(200, 115);
            this.Controls.Add(this.richTextBoxArray);
            this.Controls.Add(this.buttonCpp);
            this.Controls.Add(this.buttonCSharp);
            this.Controls.Add(this.panelAbove);
            this.Controls.Add(this.labelConversionCompleted);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.buttonExcel2Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel to Text";
            this.panelAbove.ResumeLayout(false);
            this.panelAbove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonExcel2Text;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Label labelConversionCompleted;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimized;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelAbove;
        private System.Windows.Forms.Button buttonCSharp;
        private System.Windows.Forms.Button buttonCpp;
        private System.Windows.Forms.RichTextBox richTextBoxArray;
        private System.Windows.Forms.Label label1;
    }
}

