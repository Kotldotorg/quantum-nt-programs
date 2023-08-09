// Copyright (c) Moise Tiberiu 2023

namespace Calculator
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
            TextBox = new TextBox();
            Seven = new Button();
            Four = new Button();
            One = new Button();
            Zero = new Button();
            Eight = new Button();
            Five = new Button();
            Two = new Button();
            Nine = new Button();
            Six = new Button();
            Three = new Button();
            Plus = new Button();
            Minus = new Button();
            Multiply = new Button();
            Divide = new Button();
            Equal = new Button();
            Dot = new Button();
            Clear = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.Font = new Font("Segoe UI", 15F);
            TextBox.Location = new Point(18, 26);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(318, 34);
            TextBox.TabIndex = 0;
            TextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Seven
            // 
            Seven.Font = new Font("Segoe UI", 12F);
            Seven.Location = new Point(18, 66);
            Seven.Name = "Seven";
            Seven.Size = new Size(75, 56);
            Seven.TabIndex = 1;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += button1_Click;
            // 
            // Four
            // 
            Four.Font = new Font("Segoe UI", 12F);
            Four.Location = new Point(18, 128);
            Four.Name = "Four";
            Four.Size = new Size(75, 56);
            Four.TabIndex = 2;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Four_Click;
            // 
            // One
            // 
            One.Font = new Font("Segoe UI", 12F);
            One.Location = new Point(18, 190);
            One.Name = "One";
            One.Size = new Size(75, 56);
            One.TabIndex = 3;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += One_Click;
            // 
            // Zero
            // 
            Zero.Font = new Font("Segoe UI", 12F);
            Zero.Location = new Point(18, 252);
            Zero.Name = "Zero";
            Zero.Size = new Size(75, 56);
            Zero.TabIndex = 4;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // Eight
            // 
            Eight.Font = new Font("Segoe UI", 12F);
            Eight.Location = new Point(99, 66);
            Eight.Name = "Eight";
            Eight.Size = new Size(75, 56);
            Eight.TabIndex = 5;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Eight_Click;
            // 
            // Five
            // 
            Five.Font = new Font("Segoe UI", 12F);
            Five.Location = new Point(99, 128);
            Five.Name = "Five";
            Five.Size = new Size(75, 56);
            Five.TabIndex = 6;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Five_Click;
            // 
            // Two
            // 
            Two.Font = new Font("Segoe UI", 12F);
            Two.Location = new Point(99, 190);
            Two.Name = "Two";
            Two.Size = new Size(75, 56);
            Two.TabIndex = 7;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Two_Click;
            // 
            // Nine
            // 
            Nine.Font = new Font("Segoe UI", 12F);
            Nine.Location = new Point(180, 66);
            Nine.Name = "Nine";
            Nine.Size = new Size(75, 56);
            Nine.TabIndex = 8;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Nine_Click;
            // 
            // Six
            // 
            Six.Font = new Font("Segoe UI", 12F);
            Six.Location = new Point(180, 128);
            Six.Name = "Six";
            Six.Size = new Size(75, 56);
            Six.TabIndex = 9;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Six_Click;
            // 
            // Three
            // 
            Three.Font = new Font("Segoe UI", 12F);
            Three.Location = new Point(180, 190);
            Three.Name = "Three";
            Three.Size = new Size(75, 56);
            Three.TabIndex = 10;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += Three_Click;
            // 
            // Plus
            // 
            Plus.Font = new Font("Segoe UI", 12F);
            Plus.Location = new Point(99, 252);
            Plus.Name = "Plus";
            Plus.Size = new Size(75, 56);
            Plus.TabIndex = 11;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Plus_Click;
            // 
            // Minus
            // 
            Minus.Font = new Font("Segoe UI", 12F);
            Minus.Location = new Point(180, 252);
            Minus.Name = "Minus";
            Minus.Size = new Size(75, 56);
            Minus.TabIndex = 12;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Minus_Click;
            // 
            // Multiply
            // 
            Multiply.Font = new Font("Segoe UI", 12F);
            Multiply.Location = new Point(261, 66);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(75, 56);
            Multiply.TabIndex = 13;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Multiply_Click;
            // 
            // Divide
            // 
            Divide.Font = new Font("Segoe UI", 12F);
            Divide.Location = new Point(261, 128);
            Divide.Name = "Divide";
            Divide.Size = new Size(75, 56);
            Divide.TabIndex = 14;
            Divide.Text = "÷";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // Equal
            // 
            Equal.Font = new Font("Segoe UI", 12F);
            Equal.Location = new Point(261, 252);
            Equal.Name = "Equal";
            Equal.Size = new Size(75, 56);
            Equal.TabIndex = 15;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // Dot
            // 
            Dot.Font = new Font("Segoe UI", 12F);
            Dot.Location = new Point(261, 190);
            Dot.Name = "Dot";
            Dot.Size = new Size(75, 56);
            Dot.TabIndex = 16;
            Dot.Text = ".";
            Dot.UseVisualStyleBackColor = true;
            Dot.Click += button16_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(261, 317);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 17;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(356, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(180, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(356, 352);
            Controls.Add(Clear);
            Controls.Add(Dot);
            Controls.Add(Equal);
            Controls.Add(Divide);
            Controls.Add(Multiply);
            Controls.Add(Minus);
            Controls.Add(Plus);
            Controls.Add(Three);
            Controls.Add(Six);
            Controls.Add(Nine);
            Controls.Add(Two);
            Controls.Add(Five);
            Controls.Add(Eight);
            Controls.Add(Zero);
            Controls.Add(One);
            Controls.Add(Four);
            Controls.Add(Seven);
            Controls.Add(TextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox;
        private Button Seven;
        private Button Four;
        private Button One;
        private Button Zero;
        private Button Eight;
        private Button Five;
        private Button Two;
        private Button Nine;
        private Button Six;
        private Button Three;
        private Button Plus;
        private Button Minus;
        private Button Multiply;
        private Button Divide;
        private Button Equal;
        private Button Dot;
        private Button Clear;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}