namespace WindowsFormsAppCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.PanelHistory = new System.Windows.Forms.Panel();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonMenu = new System.Windows.Forms.Button();
            this.ButtonHistory = new System.Windows.Forms.Button();
            this.textDisplay2 = new System.Windows.Forms.TextBox();
            this.textDisplay1 = new System.Windows.Forms.TextBox();
            this.buttonBackSpace = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonMMinus = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.button1x = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.PanelTitle.SuspendLayout();
            this.PanelHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.Controls.Add(this.ButtonMinimize);
            this.PanelTitle.Controls.Add(this.ButtonExit);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(350, 40);
            this.PanelTitle.TabIndex = 0;
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMinimize.Image")));
            this.ButtonMinimize.Location = new System.Drawing.Point(260, 0);
            this.ButtonMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(45, 40);
            this.ButtonMinimize.TabIndex = 4;
            this.ButtonMinimize.UseVisualStyleBackColor = true;
            this.ButtonMinimize.Click += new System.EventHandler(this.BtnCollapse_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.Location = new System.Drawing.Point(305, 0);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(45, 40);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PanelHistory
            // 
            this.PanelHistory.AutoScroll = true;
            this.PanelHistory.Controls.Add(this.RtBoxDisplayHistory);
            this.PanelHistory.Controls.Add(this.buttonClearHistory);
            this.PanelHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelHistory.Location = new System.Drawing.Point(0, 565);
            this.PanelHistory.Name = "PanelHistory";
            this.PanelHistory.Size = new System.Drawing.Size(350, 5);
            this.PanelHistory.TabIndex = 1;
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.Color.Silver;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(350, 0);
            this.RtBoxDisplayHistory.TabIndex = 6;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonClearHistory.FlatAppearance.BorderSize = 0;
            this.buttonClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonClearHistory.Image")));
            this.buttonClearHistory.Location = new System.Drawing.Point(0, -35);
            this.buttonClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(350, 40);
            this.buttonClearHistory.TabIndex = 5;
            this.buttonClearHistory.UseVisualStyleBackColor = true;
            this.buttonClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonMenu);
            this.panel1.Controls.Add(this.ButtonHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 2;
            // 
            // ButtonMenu
            // 
            this.ButtonMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonMenu.FlatAppearance.BorderSize = 0;
            this.ButtonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMenu.Location = new System.Drawing.Point(0, 0);
            this.ButtonMenu.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMenu.Name = "ButtonMenu";
            this.ButtonMenu.Size = new System.Drawing.Size(45, 40);
            this.ButtonMenu.TabIndex = 4;
            this.ButtonMenu.UseVisualStyleBackColor = true;
            // 
            // ButtonHistory
            // 
            this.ButtonHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonHistory.FlatAppearance.BorderSize = 0;
            this.ButtonHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHistory.Image = ((System.Drawing.Image)(resources.GetObject("ButtonHistory.Image")));
            this.ButtonHistory.Location = new System.Drawing.Point(305, 0);
            this.ButtonHistory.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.Size = new System.Drawing.Size(45, 40);
            this.ButtonHistory.TabIndex = 2;
            this.ButtonHistory.UseVisualStyleBackColor = true;
            this.ButtonHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // textDisplay2
            // 
            this.textDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textDisplay2.Font = new System.Drawing.Font("Gadugi", 14F);
            this.textDisplay2.ForeColor = System.Drawing.Color.Silver;
            this.textDisplay2.Location = new System.Drawing.Point(0, 80);
            this.textDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.textDisplay2.Multiline = true;
            this.textDisplay2.Name = "textDisplay2";
            this.textDisplay2.Size = new System.Drawing.Size(350, 25);
            this.textDisplay2.TabIndex = 3;
            this.textDisplay2.Text = "0";
            this.textDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textDisplay1
            // 
            this.textDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textDisplay1.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold);
            this.textDisplay1.ForeColor = System.Drawing.Color.Silver;
            this.textDisplay1.Location = new System.Drawing.Point(0, 105);
            this.textDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.textDisplay1.Multiline = true;
            this.textDisplay1.Name = "textDisplay1";
            this.textDisplay1.Size = new System.Drawing.Size(350, 50);
            this.textDisplay1.TabIndex = 4;
            this.textDisplay1.Text = "0";
            this.textDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonBackSpace
            // 
            this.buttonBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBackSpace.FlatAppearance.BorderSize = 0;
            this.buttonBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackSpace.ForeColor = System.Drawing.Color.White;
            this.buttonBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("buttonBackSpace.Image")));
            this.buttonBackSpace.Location = new System.Drawing.Point(264, 224);
            this.buttonBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackSpace.Name = "buttonBackSpace";
            this.buttonBackSpace.Size = new System.Drawing.Size(78, 50);
            this.buttonBackSpace.TabIndex = 5;
            this.buttonBackSpace.UseVisualStyleBackColor = false;
            this.buttonBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // buttonMS
            // 
            this.buttonMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonMS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMS.FlatAppearance.BorderSize = 0;
            this.buttonMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMS.ForeColor = System.Drawing.Color.White;
            this.buttonMS.Location = new System.Drawing.Point(233, 181);
            this.buttonMS.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(50, 30);
            this.buttonMS.TabIndex = 7;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = false;
            this.buttonMS.Click += new System.EventHandler(this.BtnMS_Click);
            // 
            // buttonMMinus
            // 
            this.buttonMMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonMMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMMinus.FlatAppearance.BorderSize = 0;
            this.buttonMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMMinus.ForeColor = System.Drawing.Color.White;
            this.buttonMMinus.Location = new System.Drawing.Point(177, 181);
            this.buttonMMinus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMMinus.Name = "buttonMMinus";
            this.buttonMMinus.Size = new System.Drawing.Size(50, 30);
            this.buttonMMinus.TabIndex = 8;
            this.buttonMMinus.Text = "M-";
            this.buttonMMinus.UseVisualStyleBackColor = false;
            this.buttonMMinus.Click += new System.EventHandler(this.BtnMMinus_Click);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonMPlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMPlus.FlatAppearance.BorderSize = 0;
            this.buttonMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMPlus.ForeColor = System.Drawing.Color.White;
            this.buttonMPlus.Location = new System.Drawing.Point(121, 181);
            this.buttonMPlus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(50, 30);
            this.buttonMPlus.TabIndex = 9;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = false;
            this.buttonMPlus.Click += new System.EventHandler(this.BtnMPlus_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonMR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMR.FlatAppearance.BorderSize = 0;
            this.buttonMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMR.ForeColor = System.Drawing.Color.White;
            this.buttonMR.Location = new System.Drawing.Point(65, 181);
            this.buttonMR.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(50, 30);
            this.buttonMR.TabIndex = 10;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = false;
            this.buttonMR.Click += new System.EventHandler(this.BtnMR_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonMC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMC.FlatAppearance.BorderSize = 0;
            this.buttonMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMC.ForeColor = System.Drawing.Color.White;
            this.buttonMC.Location = new System.Drawing.Point(9, 181);
            this.buttonMC.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(50, 30);
            this.buttonMC.TabIndex = 11;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = false;
            this.buttonMC.Click += new System.EventHandler(this.BtnMC_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonPercent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPercent.FlatAppearance.BorderSize = 0;
            this.buttonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPercent.ForeColor = System.Drawing.Color.White;
            this.buttonPercent.Location = new System.Drawing.Point(0, 224);
            this.buttonPercent.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(78, 50);
            this.buttonPercent.TabIndex = 12;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = false;
            this.buttonPercent.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonCE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCE.FlatAppearance.BorderSize = 0;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCE.ForeColor = System.Drawing.Color.White;
            this.buttonCE.Location = new System.Drawing.Point(88, 224);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(78, 50);
            this.buttonCE.TabIndex = 13;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.ForeColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(176, 224);
            this.buttonC.Margin = new System.Windows.Forms.Padding(0);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(78, 50);
            this.buttonC.TabIndex = 14;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSqrt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSqrt.FlatAppearance.BorderSize = 0;
            this.buttonSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSqrt.ForeColor = System.Drawing.Color.White;
            this.buttonSqrt.Location = new System.Drawing.Point(176, 278);
            this.buttonSqrt.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(78, 50);
            this.buttonSqrt.TabIndex = 18;
            this.buttonSqrt.Text = "√x";
            this.buttonSqrt.UseVisualStyleBackColor = false;
            this.buttonSqrt.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSquare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSquare.FlatAppearance.BorderSize = 0;
            this.buttonSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSquare.ForeColor = System.Drawing.Color.White;
            this.buttonSquare.Location = new System.Drawing.Point(88, 278);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(78, 50);
            this.buttonSquare.TabIndex = 17;
            this.buttonSquare.Text = "x^2";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // button1x
            // 
            this.button1x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1x.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1x.FlatAppearance.BorderSize = 0;
            this.button1x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1x.ForeColor = System.Drawing.Color.White;
            this.button1x.Location = new System.Drawing.Point(0, 278);
            this.button1x.Margin = new System.Windows.Forms.Padding(0);
            this.button1x.Name = "button1x";
            this.button1x.Size = new System.Drawing.Size(78, 50);
            this.button1x.TabIndex = 16;
            this.button1x.Text = "1/x";
            this.button1x.UseVisualStyleBackColor = false;
            this.button1x.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDivision.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDivision.FlatAppearance.BorderSize = 0;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.ForeColor = System.Drawing.Color.White;
            this.buttonDivision.Location = new System.Drawing.Point(264, 278);
            this.buttonDivision.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(78, 50);
            this.buttonDivision.TabIndex = 15;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // buttonNum9
            // 
            this.buttonNum9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonNum9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNum9.FlatAppearance.BorderSize = 0;
            this.buttonNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum9.ForeColor = System.Drawing.Color.White;
            this.buttonNum9.Location = new System.Drawing.Point(176, 333);
            this.buttonNum9.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(78, 50);
            this.buttonNum9.TabIndex = 22;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = false;
            this.buttonNum9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonNum8
            // 
            this.buttonNum8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonNum8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNum8.FlatAppearance.BorderSize = 0;
            this.buttonNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum8.ForeColor = System.Drawing.Color.White;
            this.buttonNum8.Location = new System.Drawing.Point(88, 333);
            this.buttonNum8.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(78, 50);
            this.buttonNum8.TabIndex = 21;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = false;
            this.buttonNum8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonNum7
            // 
            this.buttonNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonNum7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNum7.FlatAppearance.BorderSize = 0;
            this.buttonNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum7.ForeColor = System.Drawing.Color.White;
            this.buttonNum7.Location = new System.Drawing.Point(0, 333);
            this.buttonNum7.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(78, 50);
            this.buttonNum7.TabIndex = 20;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = false;
            this.buttonNum7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonMultiply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMultiply.FlatAppearance.BorderSize = 0;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.ForeColor = System.Drawing.Color.White;
            this.buttonMultiply.Location = new System.Drawing.Point(264, 333);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(78, 50);
            this.buttonMultiply.TabIndex = 19;
            this.buttonMultiply.Text = "×";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // buttonNum6
            // 
            this.buttonNum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonNum6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNum6.FlatAppearance.BorderSize = 0;
            this.buttonNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum6.ForeColor = System.Drawing.Color.White;
            this.buttonNum6.Location = new System.Drawing.Point(176, 388);
            this.buttonNum6.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(78, 50);
            this.buttonNum6.TabIndex = 26;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = false;
            this.buttonNum6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonNum5
            // 
            this.buttonNum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonNum5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNum5.FlatAppearance.BorderSize = 0;
            this.buttonNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum5.ForeColor = System.Drawing.Color.White;
            this.buttonNum5.Location = new System.Drawing.Point(88, 388);
            this.buttonNum5.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(78, 50);
            this.buttonNum5.TabIndex = 25;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = false;
            this.buttonNum5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonNum4
            // 
            this.buttonNum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonNum4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNum4.FlatAppearance.BorderSize = 0;
            this.buttonNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum4.ForeColor = System.Drawing.Color.White;
            this.buttonNum4.Location = new System.Drawing.Point(0, 388);
            this.buttonNum4.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(78, 50);
            this.buttonNum4.TabIndex = 24;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = false;
            this.buttonNum4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSubtract.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSubtract.FlatAppearance.BorderSize = 0;
            this.buttonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtract.ForeColor = System.Drawing.Color.White;
            this.buttonSubtract.Location = new System.Drawing.Point(264, 388);
            this.buttonSubtract.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(78, 50);
            this.buttonSubtract.TabIndex = 23;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonDecimal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDecimal.FlatAppearance.BorderSize = 0;
            this.buttonDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecimal.ForeColor = System.Drawing.Color.White;
            this.buttonDecimal.Location = new System.Drawing.Point(175, 498);
            this.buttonDecimal.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(78, 50);
            this.buttonDecimal.TabIndex = 34;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = false;
            this.buttonDecimal.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonNum0
            // 
            this.buttonNum0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonNum0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNum0.FlatAppearance.BorderSize = 0;
            this.buttonNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum0.ForeColor = System.Drawing.Color.White;
            this.buttonNum0.Location = new System.Drawing.Point(87, 498);
            this.buttonNum0.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(78, 50);
            this.buttonNum0.TabIndex = 33;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = false;
            this.buttonNum0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonPlusMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlusMinus.FlatAppearance.BorderSize = 0;
            this.buttonPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlusMinus.ForeColor = System.Drawing.Color.White;
            this.buttonPlusMinus.Location = new System.Drawing.Point(-1, 498);
            this.buttonPlusMinus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(78, 50);
            this.buttonPlusMinus.TabIndex = 32;
            this.buttonPlusMinus.Text = "±";
            this.buttonPlusMinus.UseVisualStyleBackColor = false;
            this.buttonPlusMinus.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEquals.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEquals.FlatAppearance.BorderSize = 0;
            this.buttonEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquals.ForeColor = System.Drawing.Color.White;
            this.buttonEquals.Location = new System.Drawing.Point(263, 498);
            this.buttonEquals.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(78, 50);
            this.buttonEquals.TabIndex = 31;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // buttonNum3
            // 
            this.buttonNum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonNum3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNum3.FlatAppearance.BorderSize = 0;
            this.buttonNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum3.ForeColor = System.Drawing.Color.White;
            this.buttonNum3.Location = new System.Drawing.Point(175, 443);
            this.buttonNum3.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(78, 50);
            this.buttonNum3.TabIndex = 30;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = false;
            this.buttonNum3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonNum2
            // 
            this.buttonNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonNum2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNum2.FlatAppearance.BorderSize = 0;
            this.buttonNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum2.ForeColor = System.Drawing.Color.White;
            this.buttonNum2.Location = new System.Drawing.Point(87, 443);
            this.buttonNum2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(78, 50);
            this.buttonNum2.TabIndex = 29;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = false;
            this.buttonNum2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonNum1
            // 
            this.buttonNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonNum1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNum1.FlatAppearance.BorderSize = 0;
            this.buttonNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum1.ForeColor = System.Drawing.Color.White;
            this.buttonNum1.Location = new System.Drawing.Point(-1, 443);
            this.buttonNum1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(78, 50);
            this.buttonNum1.TabIndex = 28;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = false;
            this.buttonNum1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(263, 443);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 50);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 570);
            this.Controls.Add(this.PanelHistory);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.buttonNum0);
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonNum3);
            this.Controls.Add(this.buttonNum2);
            this.Controls.Add(this.buttonNum1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonNum6);
            this.Controls.Add(this.buttonNum5);
            this.Controls.Add(this.buttonNum4);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonNum9);
            this.Controls.Add(this.buttonNum8);
            this.Controls.Add(this.buttonNum7);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.button1x);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.buttonMMinus);
            this.Controls.Add(this.buttonMS);
            this.Controls.Add(this.buttonBackSpace);
            this.Controls.Add(this.textDisplay1);
            this.Controls.Add(this.textDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelTitle.ResumeLayout(false);
            this.PanelHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel PanelHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonMenu;
        private System.Windows.Forms.Button ButtonHistory;
        private System.Windows.Forms.TextBox textDisplay2;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        private System.Windows.Forms.Button buttonClearHistory;
        private System.Windows.Forms.TextBox textDisplay1;
        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonMMinus;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button button1x;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonNum9;
        private System.Windows.Forms.Button buttonNum8;
        private System.Windows.Forms.Button buttonNum7;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonNum6;
        private System.Windows.Forms.Button buttonNum5;
        private System.Windows.Forms.Button buttonNum4;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonNum3;
        private System.Windows.Forms.Button buttonNum2;
        private System.Windows.Forms.Button buttonNum1;
        private System.Windows.Forms.Button buttonAdd;
    }
}

