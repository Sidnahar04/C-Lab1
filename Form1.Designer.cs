namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rdoSalad = new RadioButton();
            rdoPizza = new RadioButton();
            rdoHamburger = new RadioButton();
            grpbox2 = new GroupBox();
            chkAddOn3 = new CheckBox();
            chkAddOn1 = new CheckBox();
            chkAddOn2 = new CheckBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            totaltxt = new TextBox();
            taxtxt = new TextBox();
            subtotaltxt = new TextBox();
            label1 = new Label();
            orderbtn = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            grpbox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoSalad);
            groupBox1.Controls.Add(rdoPizza);
            groupBox1.Controls.Add(rdoHamburger);
            groupBox1.Location = new Point(60, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Main Menu";
            // 
            // rdoSalad
            // 
            rdoSalad.AutoSize = true;
            rdoSalad.Location = new Point(6, 86);
            rdoSalad.Name = "rdoSalad";
            rdoSalad.Size = new Size(117, 24);
            rdoSalad.TabIndex = 4;
            rdoSalad.TabStop = true;
            rdoSalad.Text = "radioButton2";
            rdoSalad.UseVisualStyleBackColor = true;
            rdoSalad.CheckedChanged += rdoSalad_CheckedChanged;
            // 
            // rdoPizza
            // 
            rdoPizza.AutoSize = true;
            rdoPizza.Location = new Point(6, 56);
            rdoPizza.Name = "rdoPizza";
            rdoPizza.Size = new Size(117, 24);
            rdoPizza.TabIndex = 3;
            rdoPizza.TabStop = true;
            rdoPizza.Text = "radioButton1";
            rdoPizza.UseVisualStyleBackColor = true;
            rdoPizza.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // rdoHamburger
            // 
            rdoHamburger.AutoSize = true;
            rdoHamburger.Location = new Point(6, 26);
            rdoHamburger.Name = "rdoHamburger";
            rdoHamburger.Size = new Size(17, 16);
            rdoHamburger.TabIndex = 0;
            rdoHamburger.TabStop = true;
            rdoHamburger.UseVisualStyleBackColor = true;
            rdoHamburger.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // grpbox2
            // 
            grpbox2.Controls.Add(chkAddOn3);
            grpbox2.Controls.Add(chkAddOn1);
            grpbox2.Controls.Add(chkAddOn2);
            grpbox2.Location = new Point(482, 57);
            grpbox2.Name = "grpbox2";
            grpbox2.Size = new Size(250, 125);
            grpbox2.TabIndex = 1;
            grpbox2.TabStop = false;
            grpbox2.Text = "Add-ons";
            //grpbox2.Enter += groupBox2_Enter;
            // 
            // chkAddOn3
            // 
            chkAddOn3.AutoSize = true;
            chkAddOn3.Location = new Point(6, 86);
            chkAddOn3.Name = "chkAddOn3";
            chkAddOn3.Size = new Size(106, 24);
            chkAddOn3.TabIndex = 2;
            chkAddOn3.Text = "French fries";
            chkAddOn3.UseVisualStyleBackColor = true;
            chkAddOn3.CheckedChanged += chkAddOn3_CheckedChanged;
            // 
            // chkAddOn1
            // 
            chkAddOn1.AutoSize = true;
            chkAddOn1.Location = new Point(6, 26);
            chkAddOn1.Name = "chkAddOn1";
            chkAddOn1.Size = new Size(18, 17);
            chkAddOn1.TabIndex = 1;
            chkAddOn1.UseVisualStyleBackColor = true;
            chkAddOn1.CheckedChanged += chkAddOn1_CheckedChanged;
            // 
            // chkAddOn2
            // 
            chkAddOn2.AutoSize = true;
            chkAddOn2.Location = new Point(6, 57);
            chkAddOn2.Name = "chkAddOn2";
            chkAddOn2.Size = new Size(18, 17);
            chkAddOn2.TabIndex = 1;
            chkAddOn2.UseVisualStyleBackColor = true;
            chkAddOn2.CheckedChanged += chkAddOn2_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(totaltxt);
            groupBox3.Controls.Add(taxtxt);
            groupBox3.Controls.Add(subtotaltxt);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(60, 230);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(326, 145);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 103);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 5;
            label3.Text = "Order Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 68);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "Tax(5%)";
            // 
            // totaltxt
            // 
            totaltxt.ImeMode = ImeMode.NoControl;
            totaltxt.Location = new Point(119, 98);
            totaltxt.Name = "totaltxt";
            totaltxt.Size = new Size(141, 27);
            totaltxt.TabIndex = 3;
            // 
            // taxtxt
            // 
            taxtxt.ImeMode = ImeMode.NoControl;
            taxtxt.Location = new Point(119, 65);
            taxtxt.Name = "taxtxt";
            taxtxt.Size = new Size(141, 27);
            taxtxt.TabIndex = 2;
            // 
            // subtotaltxt
            // 
            subtotaltxt.Location = new Point(119, 32);
            subtotaltxt.Name = "subtotaltxt";
            subtotaltxt.Size = new Size(141, 27);
            subtotaltxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "SubTotal";
            // 
            // orderbtn
            // 
            orderbtn.Location = new Point(488, 239);
            orderbtn.Name = "orderbtn";
            orderbtn.Size = new Size(196, 46);
            orderbtn.TabIndex = 4;
            orderbtn.Text = "Place Order";
            orderbtn.UseVisualStyleBackColor = true;
            orderbtn.Click += placeorder_click;
            // 
            // button2
            // 
            button2.Location = new Point(488, 295);
            button2.Name = "button2";
            button2.Size = new Size(196, 46);
            button2.TabIndex = 5;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += reset_Click;
            // 
            // button3
            // 
            button3.Location = new Point(488, 347);
            button3.Name = "button3";
            button3.Size = new Size(196, 47);
            button3.TabIndex = 6;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += exit_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(orderbtn);
            Controls.Add(groupBox3);
            Controls.Add(grpbox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Lunch Order";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpbox2.ResumeLayout(false);
            grpbox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoHamburger;
        private GroupBox grpbox2;
        private CheckBox chkAddOn3;
        private CheckBox chkAddOn1;
        private CheckBox chkAddOn2;
        private RadioButton rdoPizza;
        private RadioButton rdoSalad;
        private GroupBox groupBox3;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox totaltxt;
        private TextBox taxtxt;
        private TextBox subtotaltxt;
        private Button orderbtn;
        private Button button2;
        private Button button3;
    }
}