using System;
using System.Diagnostics;
using System.Drawing;

namespace Calc
{
    partial class main
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonPI = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonCP = new System.Windows.Forms.Button();
            this.buttonOP = new System.Windows.Forms.Button();
            this.buttonSQRT = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRTP = new System.Windows.Forms.Button();
            this.buttonLn = new System.Windows.Forms.Button();
            this.buttonDigit7 = new System.Windows.Forms.Button();
            this.buttonDigit8 = new System.Windows.Forms.Button();
            this.buttonDigit9 = new System.Windows.Forms.Button();
            this.buttonDigit4 = new System.Windows.Forms.Button();
            this.buttonDigit5 = new System.Windows.Forms.Button();
            this.buttonDigit6 = new System.Windows.Forms.Button();
            this.buttonDigit1 = new System.Windows.Forms.Button();
            this.buttonDigit2 = new System.Windows.Forms.Button();
            this.buttonDigit3 = new System.Windows.Forms.Button();
            this.buttonDigit0 = new System.Windows.Forms.Button();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonBackSpace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLog.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonLog.FlatAppearance.BorderSize = 2;
            this.buttonLog.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonLog.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("Dubai", 13F, System.Drawing.FontStyle.Bold);
            this.buttonLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLog.Location = new System.Drawing.Point(41, 257);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 75);
            this.buttonLog.TabIndex = 26;
            this.buttonLog.Text = "log";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonPI
            // 
            this.buttonPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPI.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonPI.FlatAppearance.BorderSize = 2;
            this.buttonPI.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonPI.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPI.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonPI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPI.Location = new System.Drawing.Point(141, 257);
            this.buttonPI.Name = "buttonPI";
            this.buttonPI.Size = new System.Drawing.Size(75, 75);
            this.buttonPI.TabIndex = 25;
            this.buttonPI.Text = "π";
            this.buttonPI.UseVisualStyleBackColor = false;
            this.buttonPI.Click += new System.EventHandler(this.buttonPI_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonE.FlatAppearance.BorderSize = 2;
            this.buttonE.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonE.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonE.Location = new System.Drawing.Point(241, 257);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(75, 75);
            this.buttonE.TabIndex = 24;
            this.buttonE.Text = "e";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonCP
            // 
            this.buttonCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCP.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonCP.FlatAppearance.BorderSize = 2;
            this.buttonCP.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonCP.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCP.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonCP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCP.Location = new System.Drawing.Point(241, 357);
            this.buttonCP.Name = "buttonCP";
            this.buttonCP.Size = new System.Drawing.Size(75, 75);
            this.buttonCP.TabIndex = 23;
            this.buttonCP.Text = ")";
            this.buttonCP.UseVisualStyleBackColor = false;
            this.buttonCP.Click += new System.EventHandler(this.buttonCP_Click);
            // 
            // buttonOP
            // 
            this.buttonOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonOP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOP.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonOP.FlatAppearance.BorderSize = 2;
            this.buttonOP.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonOP.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOP.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonOP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonOP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOP.Location = new System.Drawing.Point(141, 357);
            this.buttonOP.Name = "buttonOP";
            this.buttonOP.Size = new System.Drawing.Size(75, 75);
            this.buttonOP.TabIndex = 22;
            this.buttonOP.Text = "(";
            this.buttonOP.UseVisualStyleBackColor = false;
            this.buttonOP.Click += new System.EventHandler(this.buttonOP_Click);
            // 
            // buttonSQRT
            // 
            this.buttonSQRT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonSQRT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSQRT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSQRT.FlatAppearance.BorderSize = 2;
            this.buttonSQRT.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonSQRT.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSQRT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonSQRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSQRT.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSQRT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonSQRT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSQRT.Location = new System.Drawing.Point(41, 357);
            this.buttonSQRT.Name = "buttonSQRT";
            this.buttonSQRT.Size = new System.Drawing.Size(75, 75);
            this.buttonSQRT.TabIndex = 21;
            this.buttonSQRT.Text = "√";
            this.buttonSQRT.UseVisualStyleBackColor = false;
            this.buttonSQRT.Click += new System.EventHandler(this.buttonSQRT_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonClear.FlatAppearance.BorderSize = 2;
            this.buttonClear.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClear.Location = new System.Drawing.Point(341, 257);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 75);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "с";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRTP
            // 
            this.buttonRTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonRTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRTP.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonRTP.FlatAppearance.BorderSize = 2;
            this.buttonRTP.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonRTP.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonRTP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonRTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRTP.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonRTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonRTP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRTP.Location = new System.Drawing.Point(341, 357);
            this.buttonRTP.Name = "buttonRTP";
            this.buttonRTP.Size = new System.Drawing.Size(75, 75);
            this.buttonRTP.TabIndex = 18;
            this.buttonRTP.Text = "^";
            this.buttonRTP.UseVisualStyleBackColor = false;
            this.buttonRTP.Click += new System.EventHandler(this.buttonRTP_Click);
            // 
            // buttonLn
            // 
            this.buttonLn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonLn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonLn.FlatAppearance.BorderSize = 2;
            this.buttonLn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonLn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLn.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonLn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonLn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLn.Location = new System.Drawing.Point(41, 457);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(75, 75);
            this.buttonLn.TabIndex = 14;
            this.buttonLn.Text = "ln";
            this.buttonLn.UseVisualStyleBackColor = false;
            this.buttonLn.Click += new System.EventHandler(this.buttonLn_Click);
            // 
            // buttonDigit7
            // 
            this.buttonDigit7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonDigit7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigit7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDigit7.FlatAppearance.BorderSize = 2;
            this.buttonDigit7.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonDigit7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDigit7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDigit7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigit7.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDigit7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonDigit7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDigit7.Location = new System.Drawing.Point(141, 457);
            this.buttonDigit7.Name = "buttonDigit7";
            this.buttonDigit7.Size = new System.Drawing.Size(75, 75);
            this.buttonDigit7.TabIndex = 13;
            this.buttonDigit7.Text = "7";
            this.buttonDigit7.UseVisualStyleBackColor = false;
            this.buttonDigit7.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonDigit8
            // 
            this.buttonDigit8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonDigit8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigit8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDigit8.FlatAppearance.BorderSize = 2;
            this.buttonDigit8.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonDigit8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDigit8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDigit8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigit8.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDigit8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonDigit8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDigit8.Location = new System.Drawing.Point(241, 457);
            this.buttonDigit8.Name = "buttonDigit8";
            this.buttonDigit8.Size = new System.Drawing.Size(75, 75);
            this.buttonDigit8.TabIndex = 12;
            this.buttonDigit8.Text = "8";
            this.buttonDigit8.UseVisualStyleBackColor = false;
            this.buttonDigit8.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonDigit9
            // 
            this.buttonDigit9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonDigit9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigit9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDigit9.FlatAppearance.BorderSize = 2;
            this.buttonDigit9.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonDigit9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDigit9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDigit9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigit9.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDigit9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonDigit9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDigit9.Location = new System.Drawing.Point(341, 457);
            this.buttonDigit9.Name = "buttonDigit9";
            this.buttonDigit9.Size = new System.Drawing.Size(75, 75);
            this.buttonDigit9.TabIndex = 11;
            this.buttonDigit9.Text = "9";
            this.buttonDigit9.UseVisualStyleBackColor = false;
            this.buttonDigit9.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonDigit4
            // 
            this.buttonDigit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonDigit4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigit4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDigit4.FlatAppearance.BorderSize = 2;
            this.buttonDigit4.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonDigit4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDigit4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDigit4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigit4.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDigit4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonDigit4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDigit4.Location = new System.Drawing.Point(141, 557);
            this.buttonDigit4.Name = "buttonDigit4";
            this.buttonDigit4.Size = new System.Drawing.Size(75, 75);
            this.buttonDigit4.TabIndex = 8;
            this.buttonDigit4.Text = "4";
            this.buttonDigit4.UseVisualStyleBackColor = false;
            this.buttonDigit4.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonDigit5
            // 
            this.buttonDigit5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonDigit5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigit5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDigit5.FlatAppearance.BorderSize = 2;
            this.buttonDigit5.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonDigit5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDigit5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDigit5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigit5.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDigit5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonDigit5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDigit5.Location = new System.Drawing.Point(241, 557);
            this.buttonDigit5.Name = "buttonDigit5";
            this.buttonDigit5.Size = new System.Drawing.Size(75, 75);
            this.buttonDigit5.TabIndex = 7;
            this.buttonDigit5.Text = "5";
            this.buttonDigit5.UseVisualStyleBackColor = false;
            this.buttonDigit5.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonDigit6
            // 
            this.buttonDigit6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonDigit6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigit6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDigit6.FlatAppearance.BorderSize = 2;
            this.buttonDigit6.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonDigit6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDigit6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDigit6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigit6.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDigit6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonDigit6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDigit6.Location = new System.Drawing.Point(341, 557);
            this.buttonDigit6.Name = "buttonDigit6";
            this.buttonDigit6.Size = new System.Drawing.Size(75, 75);
            this.buttonDigit6.TabIndex = 6;
            this.buttonDigit6.Text = "6";
            this.buttonDigit6.UseVisualStyleBackColor = false;
            this.buttonDigit6.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonDigit1
            // 
            this.buttonDigit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonDigit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigit1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDigit1.FlatAppearance.BorderSize = 2;
            this.buttonDigit1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonDigit1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDigit1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDigit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigit1.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDigit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonDigit1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDigit1.Location = new System.Drawing.Point(141, 657);
            this.buttonDigit1.Name = "buttonDigit1";
            this.buttonDigit1.Size = new System.Drawing.Size(75, 75);
            this.buttonDigit1.TabIndex = 5;
            this.buttonDigit1.Text = "1";
            this.buttonDigit1.UseVisualStyleBackColor = false;
            this.buttonDigit1.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonDigit2
            // 
            this.buttonDigit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonDigit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigit2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDigit2.FlatAppearance.BorderSize = 2;
            this.buttonDigit2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonDigit2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDigit2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDigit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigit2.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDigit2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonDigit2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDigit2.Location = new System.Drawing.Point(241, 657);
            this.buttonDigit2.Name = "buttonDigit2";
            this.buttonDigit2.Size = new System.Drawing.Size(75, 75);
            this.buttonDigit2.TabIndex = 4;
            this.buttonDigit2.Text = "2";
            this.buttonDigit2.UseVisualStyleBackColor = false;
            this.buttonDigit2.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonDigit3
            // 
            this.buttonDigit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonDigit3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigit3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDigit3.FlatAppearance.BorderSize = 2;
            this.buttonDigit3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonDigit3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDigit3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDigit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigit3.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDigit3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonDigit3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDigit3.Location = new System.Drawing.Point(341, 657);
            this.buttonDigit3.Name = "buttonDigit3";
            this.buttonDigit3.Size = new System.Drawing.Size(75, 75);
            this.buttonDigit3.TabIndex = 3;
            this.buttonDigit3.Text = "3";
            this.buttonDigit3.UseVisualStyleBackColor = false;
            this.buttonDigit3.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonDigit0
            // 
            this.buttonDigit0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonDigit0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigit0.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDigit0.FlatAppearance.BorderSize = 2;
            this.buttonDigit0.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonDigit0.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDigit0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDigit0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigit0.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDigit0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonDigit0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDigit0.Location = new System.Drawing.Point(241, 757);
            this.buttonDigit0.Name = "buttonDigit0";
            this.buttonDigit0.Size = new System.Drawing.Size(75, 75);
            this.buttonDigit0.TabIndex = 1;
            this.buttonDigit0.Text = "0";
            this.buttonDigit0.UseVisualStyleBackColor = false;
            this.buttonDigit0.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonSwap
            // 
            this.buttonSwap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonSwap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSwap.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSwap.FlatAppearance.BorderSize = 2;
            this.buttonSwap.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonSwap.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSwap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwap.Font = new System.Drawing.Font("Dubai", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSwap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonSwap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSwap.Location = new System.Drawing.Point(141, 757);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(77, 75);
            this.buttonSwap.TabIndex = 2;
            this.buttonSwap.Text = "+/-";
            this.buttonSwap.UseVisualStyleBackColor = false;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDot.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDot.FlatAppearance.BorderSize = 2;
            this.buttonDot.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonDot.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonDot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDot.Location = new System.Drawing.Point(341, 757);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(75, 75);
            this.buttonDot.TabIndex = 0;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(39)))));
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input.Font = new System.Drawing.Font("Arial", 44F);
            this.input.ForeColor = System.Drawing.Color.White;
            this.input.Location = new System.Drawing.Point(0, 0);
            this.input.MaxLength = 19;
            this.input.Name = "input";
            this.input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.input.Size = new System.Drawing.Size(632, 165);
            this.input.TabIndex = 27;
            this.input.Text = "";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(39)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(598, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 165);
            this.panel1.TabIndex = 28;
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonEqual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEqual.BackgroundImage")));
            this.buttonEqual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEqual.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonEqual.FlatAppearance.BorderSize = 2;
            this.buttonEqual.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonEqual.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonEqual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEqual.Location = new System.Drawing.Point(441, 757);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(150, 75);
            this.buttonEqual.TabIndex = 9;
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonPlus.BackgroundImage = global::Calc.Properties.Resources.plus;
            this.buttonPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonPlus.FlatAppearance.BorderSize = 2;
            this.buttonPlus.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonPlus.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPlus.Location = new System.Drawing.Point(441, 657);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(150, 75);
            this.buttonPlus.TabIndex = 10;
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinus.BackgroundImage")));
            this.buttonMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonMinus.FlatAppearance.BorderSize = 2;
            this.buttonMinus.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonMinus.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMinus.Location = new System.Drawing.Point(441, 557);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(150, 75);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonMultiply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMultiply.BackgroundImage")));
            this.buttonMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonMultiply.FlatAppearance.BorderSize = 2;
            this.buttonMultiply.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonMultiply.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMultiply.Location = new System.Drawing.Point(441, 457);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(150, 75);
            this.buttonMultiply.TabIndex = 16;
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonDivide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDivide.BackgroundImage")));
            this.buttonDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDivide.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDivide.FlatAppearance.BorderSize = 2;
            this.buttonDivide.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonDivide.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonDivide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDivide.Location = new System.Drawing.Point(441, 357);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(150, 75);
            this.buttonDivide.TabIndex = 17;
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonBackSpace
            // 
            this.buttonBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.buttonBackSpace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackSpace.BackgroundImage")));
            this.buttonBackSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBackSpace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonBackSpace.FlatAppearance.BorderSize = 2;
            this.buttonBackSpace.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.buttonBackSpace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBackSpace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackSpace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.buttonBackSpace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBackSpace.Location = new System.Drawing.Point(441, 257);
            this.buttonBackSpace.Name = "buttonBackSpace";
            this.buttonBackSpace.Size = new System.Drawing.Size(150, 75);
            this.buttonBackSpace.TabIndex = 19;
            this.buttonBackSpace.UseVisualStyleBackColor = false;
            this.buttonBackSpace.Click += new System.EventHandler(this.buttonBackSpace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "HEX: 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 27);
            this.label2.TabIndex = 30;
            this.label2.Text = "BIN: 0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = "DEC: 0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(638, 844);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonDigit0);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.buttonDigit3);
            this.Controls.Add(this.buttonDigit2);
            this.Controls.Add(this.buttonDigit1);
            this.Controls.Add(this.buttonDigit6);
            this.Controls.Add(this.buttonDigit5);
            this.Controls.Add(this.buttonDigit4);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonDigit9);
            this.Controls.Add(this.buttonDigit8);
            this.Controls.Add(this.buttonDigit7);
            this.Controls.Add(this.buttonLn);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonRTP);
            this.Controls.Add(this.buttonBackSpace);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSQRT);
            this.Controls.Add(this.buttonOP);
            this.Controls.Add(this.buttonCP);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonPI);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonPI;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonCP;
        private System.Windows.Forms.Button buttonOP;
        private System.Windows.Forms.Button buttonSQRT;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.Button buttonRTP;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonLn;
        private System.Windows.Forms.Button buttonDigit7;
        private System.Windows.Forms.Button buttonDigit8;
        private System.Windows.Forms.Button buttonDigit9;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDigit4;
        private System.Windows.Forms.Button buttonDigit5;
        private System.Windows.Forms.Button buttonDigit6;
        private System.Windows.Forms.Button buttonDigit1;
        private System.Windows.Forms.Button buttonDigit2;
        private System.Windows.Forms.Button buttonDigit3;
        private System.Windows.Forms.Button buttonDigit0;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

