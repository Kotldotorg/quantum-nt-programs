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
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox.Location = new Point(18, 12);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(318, 34);
            TextBox.TabIndex = 0;
            TextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Seven
            // 
            Seven.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Seven.Location = new Point(18, 52);
            Seven.Name = "Seven";
            Seven.Size = new Size(75, 56);
            Seven.TabIndex = 1;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += button1_Click;
            // 
            // Four
            // 
            Four.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Four.Location = new Point(18, 114);
            Four.Name = "Four";
            Four.Size = new Size(75, 56);
            Four.TabIndex = 2;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Four_Click;
            // 
            // One
            // 
            One.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            One.Location = new Point(18, 176);
            One.Name = "One";
            One.Size = new Size(75, 56);
            One.TabIndex = 3;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += One_Click;
            // 
            // Zero
            // 
            Zero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Zero.Location = new Point(18, 238);
            Zero.Name = "Zero";
            Zero.Size = new Size(75, 56);
            Zero.TabIndex = 4;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // Eight
            // 
            Eight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Eight.Location = new Point(99, 52);
            Eight.Name = "Eight";
            Eight.Size = new Size(75, 56);
            Eight.TabIndex = 5;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Eight_Click;
            // 
            // Five
            // 
            Five.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Five.Location = new Point(99, 114);
            Five.Name = "Five";
            Five.Size = new Size(75, 56);
            Five.TabIndex = 6;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Five_Click;
            // 
            // Two
            // 
            Two.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Two.Location = new Point(99, 176);
            Two.Name = "Two";
            Two.Size = new Size(75, 56);
            Two.TabIndex = 7;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Two_Click;
            // 
            // Nine
            // 
            Nine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nine.Location = new Point(180, 52);
            Nine.Name = "Nine";
            Nine.Size = new Size(75, 56);
            Nine.TabIndex = 8;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Nine_Click;
            // 
            // Six
            // 
            Six.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Six.Location = new Point(180, 114);
            Six.Name = "Six";
            Six.Size = new Size(75, 56);
            Six.TabIndex = 9;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Six_Click;
            // 
            // Three
            // 
            Three.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Three.Location = new Point(180, 176);
            Three.Name = "Three";
            Three.Size = new Size(75, 56);
            Three.TabIndex = 10;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += Three_Click;
            // 
            // Plus
            // 
            Plus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Plus.Location = new Point(99, 238);
            Plus.Name = "Plus";
            Plus.Size = new Size(75, 56);
            Plus.TabIndex = 11;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Plus_Click;
            // 
            // Minus
            // 
            Minus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Minus.Location = new Point(180, 238);
            Minus.Name = "Minus";
            Minus.Size = new Size(75, 56);
            Minus.TabIndex = 12;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Minus_Click;
            // 
            // Multiply
            // 
            Multiply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Multiply.Location = new Point(261, 52);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(75, 56);
            Multiply.TabIndex = 13;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Multiply_Click;
            // 
            // Divide
            // 
            Divide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Divide.Location = new Point(261, 114);
            Divide.Name = "Divide";
            Divide.Size = new Size(75, 56);
            Divide.TabIndex = 14;
            Divide.Text = "÷";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // Equal
            // 
            Equal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Equal.Location = new Point(261, 238);
            Equal.Name = "Equal";
            Equal.Size = new Size(75, 56);
            Equal.TabIndex = 15;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // Dot
            // 
            Dot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Dot.Location = new Point(261, 176);
            Dot.Name = "Dot";
            Dot.Size = new Size(75, 56);
            Dot.TabIndex = 16;
            Dot.Text = ".";
            Dot.UseVisualStyleBackColor = true;
            Dot.Click += button16_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(261, 300);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 17;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(356, 339);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculator";
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
    }
}