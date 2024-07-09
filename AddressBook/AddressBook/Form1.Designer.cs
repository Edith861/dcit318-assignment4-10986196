namespace AddressBook
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
            textBoxName3 = new TextBox();
            textBoxEmail3 = new TextBox();
            textBoxPhone3 = new TextBox();
            textBoxName1 = new TextBox();
            textBoxEmail1 = new TextBox();
            textBoxPhone1 = new TextBox();
            textBoxName2 = new TextBox();
            textBoxEmail2 = new TextBox();
            textBoxPhone2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxName3
            // 
            textBoxName3.Location = new Point(50, 224);
            textBoxName3.Name = "textBoxName3";
            textBoxName3.Size = new Size(150, 23);
            textBoxName3.TabIndex = 0;
            // 
            // textBoxEmail3
            // 
            textBoxEmail3.Location = new Point(215, 224);
            textBoxEmail3.Name = "textBoxEmail3";
            textBoxEmail3.Size = new Size(150, 23);
            textBoxEmail3.TabIndex = 1;
            // 
            // textBoxPhone3
            // 
            textBoxPhone3.Location = new Point(382, 224);
            textBoxPhone3.Name = "textBoxPhone3";
            textBoxPhone3.Size = new Size(150, 23);
            textBoxPhone3.TabIndex = 2;
            // 
            // textBoxName1
            // 
            textBoxName1.Location = new Point(50, 97);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(150, 23);
            textBoxName1.TabIndex = 3;
            // 
            // textBoxEmail1
            // 
            textBoxEmail1.Location = new Point(215, 97);
            textBoxEmail1.Name = "textBoxEmail1";
            textBoxEmail1.Size = new Size(150, 23);
            textBoxEmail1.TabIndex = 4;
            // 
            // textBoxPhone1
            // 
            textBoxPhone1.Location = new Point(382, 97);
            textBoxPhone1.Name = "textBoxPhone1";
            textBoxPhone1.Size = new Size(150, 23);
            textBoxPhone1.TabIndex = 5;
            textBoxPhone1.TextChanged += textBox6_TextChanged;
            // 
            // textBoxName2
            // 
            textBoxName2.Location = new Point(50, 163);
            textBoxName2.Name = "textBoxName2";
            textBoxName2.Size = new Size(150, 23);
            textBoxName2.TabIndex = 6;
            // 
            // textBoxEmail2
            // 
            textBoxEmail2.Location = new Point(215, 163);
            textBoxEmail2.Name = "textBoxEmail2";
            textBoxEmail2.Size = new Size(150, 23);
            textBoxEmail2.TabIndex = 7;
            // 
            // textBoxPhone2
            // 
            textBoxPhone2.Location = new Point(382, 163);
            textBoxPhone2.Name = "textBoxPhone2";
            textBoxPhone2.Size = new Size(150, 23);
            textBoxPhone2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 19);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 9;
            label1.Text = "Address Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 69);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 10;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 69);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 11;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 69);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 12;
            label4.Text = "Phone Number";
            // 
            // button1
            // 
            button1.Location = new Point(243, 303);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 419);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPhone2);
            Controls.Add(textBoxEmail2);
            Controls.Add(textBoxName2);
            Controls.Add(textBoxPhone1);
            Controls.Add(textBoxEmail1);
            Controls.Add(textBoxName1);
            Controls.Add(textBoxPhone3);
            Controls.Add(textBoxEmail3);
            Controls.Add(textBoxName3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName3;
        private TextBox textBoxEmail3;
        private TextBox textBoxPhone3;
        private TextBox textBoxName1;
        private TextBox textBoxEmail1;
        private TextBox textBoxPhone1;
        private TextBox textBoxName2;
        private TextBox textBoxEmail2;
        private TextBox textBoxPhone2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
