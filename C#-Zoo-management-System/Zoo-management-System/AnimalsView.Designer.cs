namespace Zoo_management_System
{
    partial class AnimalsView
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            listBox1 = new ListBox();
            button6 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(21, 28);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(715, 424);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Speak";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Peru;
            button3.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(706, 379);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Move";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Peru;
            button4.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(395, 379);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Feed";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Peru;
            button5.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(536, 424);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "Sleep";
            button5.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(372, 126);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(466, 204);
            listBox1.TabIndex = 11;
            // 
            // button6
            // 
            button6.BackColor = Color.OrangeRed;
            button6.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(495, 379);
            button6.Name = "button6";
            button6.Size = new Size(205, 29);
            button6.TabIndex = 12;
            button6.Text = "Remove Animal";
            button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ravie", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 48);
            label1.Name = "label1";
            label1.Size = new Size(282, 24);
            label1.TabIndex = 13;
            label1.Text = "Interact with animals";
            // 
            // AnimalsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lions_lion_female_wild1;
            ClientSize = new Size(917, 504);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AnimalsView";
            Text = "AnimalsView";
            Load += AnimalsView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private Button button6;
        private Label label1;
    }


}