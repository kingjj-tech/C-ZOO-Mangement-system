
namespace Zoo_management_System
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
        /// 

        
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
        
        private ComboBox comboBoxHabitat;

        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            comboBoxHabitat = new ComboBox();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(219, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBoxHabitat
            // 
            comboBoxHabitat.FormattingEnabled = true;
            comboBoxHabitat.Location = new Point(219, 181);
            comboBoxHabitat.Name = "comboBoxHabitat";
            comboBoxHabitat.Size = new Size(150, 28);
            comboBoxHabitat.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 227);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(219, 269);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(219, 321);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(678, 382);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 5;
            button1.Text = "Add Animal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(766, 346);
            button2.Name = "button2";
            button2.Size = new Size(150, 30);
            button2.TabIndex = 6;
            button2.Text = "Interactions";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Peru;
            button3.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(573, 346);
            button3.Name = "button3";
            button3.Size = new Size(165, 30);
            button3.TabIndex = 7;
            button3.Text = "View Animals";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(601, 130);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(284, 184);
            listBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(37, 177);
            label1.Name = "label1";
            label1.Size = new Size(83, 29);
            label1.TabIndex = 9;
            label1.Text = "habitat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(37, 126);
            label2.Name = "label2";
            label2.Size = new Size(127, 29);
            label2.TabIndex = 10;
            label2.Text = "Animal type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(32, 232);
            label3.Name = "label3";
            label3.Size = new Size(154, 22);
            label3.TabIndex = 11;
            label3.Text = "Animal name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(32, 276);
            label4.Name = "label4";
            label4.Size = new Size(49, 22);
            label4.TabIndex = 12;
            label4.Text = "age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(32, 328);
            label5.Name = "label5";
            label5.Size = new Size(88, 22);
            label5.TabIndex = 13;
            label5.Text = "weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Ravie", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(279, 36);
            label6.Name = "label6";
            label6.Size = new Size(417, 38);
            label6.TabIndex = 14;
            label6.Text = "Welcome to zootopia ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(32, 382);
            label7.Name = "label7";
            label7.Size = new Size(158, 22);
            label7.TabIndex = 15;
            label7.Text = "animal Sound";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 381);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 27);
            textBox2.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AMBOSELI_PARK;
            ClientSize = new Size(940, 490);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(comboBoxHabitat);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Zoo Management System";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Empty implementation
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Empty implementation
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Empty implementation
        }





        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
       
        private Label label1;
        private Label label2;
        
        private Label label3;
        private Label label4;
       
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
    }
}
