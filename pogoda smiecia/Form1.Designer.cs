namespace pogoda_smiecia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            TemperatureTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            WilgorTextbox = new TextBox();
            PogodaTextBox = new TextBox();
            PredkoscTextBox = new TextBox();
            KierunekTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(23, 219);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(291, 219);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(342, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "POGODA!!!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TemperatureTextBox
            // 
            TemperatureTextBox.Location = new Point(175, 18);
            TemperatureTextBox.Name = "TemperatureTextBox";
            TemperatureTextBox.Size = new Size(100, 23);
            TemperatureTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 21);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Temperatura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 56);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 4;
            label2.Text = "Wilgor(Wilgoc):";
            // 
            // WilgorTextbox
            // 
            WilgorTextbox.Location = new Point(175, 56);
            WilgorTextbox.Name = "WilgorTextbox";
            WilgorTextbox.Size = new Size(100, 23);
            WilgorTextbox.TabIndex = 5;
            // 
            // PogodaTextBox
            // 
            PogodaTextBox.Location = new Point(175, 94);
            PogodaTextBox.Name = "PogodaTextBox";
            PogodaTextBox.Size = new Size(139, 23);
            PogodaTextBox.TabIndex = 6;
            // 
            // PredkoscTextBox
            // 
            PredkoscTextBox.Location = new Point(175, 134);
            PredkoscTextBox.Name = "PredkoscTextBox";
            PredkoscTextBox.Size = new Size(100, 23);
            PredkoscTextBox.TabIndex = 7;
            // 
            // KierunekTextBox
            // 
            KierunekTextBox.Location = new Point(175, 178);
            KierunekTextBox.Name = "KierunekTextBox";
            KierunekTextBox.Size = new Size(100, 23);
            KierunekTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 97);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 9;
            label3.Text = "Pogoda(kod WMO):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 134);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 10;
            label4.Text = "predkosc wiatru:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 181);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 11;
            label5.Text = "kierunek wiatru: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(KierunekTextBox);
            Controls.Add(PredkoscTextBox);
            Controls.Add(PogodaTextBox);
            Controls.Add(WilgorTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TemperatureTextBox);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox TemperatureTextBox;
        private Label label1;
        private Label label2;
        private TextBox WilgorTextbox;
        private TextBox PogodaTextBox;
        private TextBox PredkoscTextBox;
        private TextBox KierunekTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
