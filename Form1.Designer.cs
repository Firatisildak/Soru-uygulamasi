
namespace soru_uygulaması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btna = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.lbyanlış = new System.Windows.Forms.Label();
            this.lbdoğru = new System.Windows.Forms.Label();
            this.sorusayısı = new System.Windows.Forms.Label();
            this.lbyanlışsayısı = new System.Windows.Forms.Label();
            this.lbdoğrusayısı = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbdoğrucevap = new System.Windows.Forms.Label();
            this.btnsonrakisoru = new System.Windows.Forms.Button();
            this.lbişaretlenen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(61, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(393, 136);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
//            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btna
            // 
            this.btna.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btna.Location = new System.Drawing.Point(61, 179);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(159, 40);
            this.btna.TabIndex = 1;
            this.btna.Text = "A";
            this.btna.UseVisualStyleBackColor = true;
            this.btna.Visible = false;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // btnb
            // 
            this.btnb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnb.Location = new System.Drawing.Point(295, 179);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(159, 40);
            this.btnb.TabIndex = 2;
            this.btnb.Text = "B";
            this.btnb.UseVisualStyleBackColor = true;
            this.btnb.Visible = false;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btnc
            // 
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnc.Location = new System.Drawing.Point(61, 255);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(159, 40);
            this.btnc.TabIndex = 3;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Visible = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnd
            // 
            this.btnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnd.Location = new System.Drawing.Point(295, 255);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(159, 40);
            this.btnd.TabIndex = 4;
            this.btnd.Text = "D";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Visible = false;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // lbyanlış
            // 
            this.lbyanlış.AutoSize = true;
            this.lbyanlış.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbyanlış.Location = new System.Drawing.Point(579, 73);
            this.lbyanlış.Name = "lbyanlış";
            this.lbyanlış.Size = new System.Drawing.Size(75, 25);
            this.lbyanlış.TabIndex = 5;
            this.lbyanlış.Text = "yanlış:";
            this.lbyanlış.Visible = false;
            // 
            // lbdoğru
            // 
            this.lbdoğru.AutoSize = true;
            this.lbdoğru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbdoğru.Location = new System.Drawing.Point(579, 130);
            this.lbdoğru.Name = "lbdoğru";
            this.lbdoğru.Size = new System.Drawing.Size(74, 25);
            this.lbdoğru.TabIndex = 6;
            this.lbdoğru.Text = "doğru:";
            this.lbdoğru.Visible = false;
            // 
            // sorusayısı
            // 
            this.sorusayısı.AutoSize = true;
            this.sorusayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorusayısı.Location = new System.Drawing.Point(533, 24);
            this.sorusayısı.Name = "sorusayısı";
            this.sorusayısı.Size = new System.Drawing.Size(116, 25);
            this.sorusayısı.TabIndex = 7;
            this.sorusayısı.Text = "sorusayısı:";
            this.sorusayısı.Visible = false;
            // 
            // lbyanlışsayısı
            // 
            this.lbyanlışsayısı.AutoSize = true;
            this.lbyanlışsayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbyanlışsayısı.Location = new System.Drawing.Point(664, 73);
            this.lbyanlışsayısı.Name = "lbyanlışsayısı";
            this.lbyanlışsayısı.Size = new System.Drawing.Size(24, 25);
            this.lbyanlışsayısı.TabIndex = 8;
            this.lbyanlışsayısı.Text = "0";
            this.lbyanlışsayısı.Visible = false;
            // 
            // lbdoğrusayısı
            // 
            this.lbdoğrusayısı.AutoSize = true;
            this.lbdoğrusayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbdoğrusayısı.Location = new System.Drawing.Point(664, 130);
            this.lbdoğrusayısı.Name = "lbdoğrusayısı";
            this.lbdoğrusayısı.Size = new System.Drawing.Size(24, 25);
            this.lbdoğrusayısı.TabIndex = 9;
            this.lbdoğrusayısı.Text = "0";
            this.lbdoğrusayısı.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(664, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "0";
            this.label6.Visible = false;
            // 
            // lbdoğrucevap
            // 
            this.lbdoğrucevap.AutoSize = true;
            this.lbdoğrucevap.Location = new System.Drawing.Point(852, 570);
            this.lbdoğrucevap.Name = "lbdoğrucevap";
            this.lbdoğrucevap.Size = new System.Drawing.Size(83, 17);
            this.lbdoğrucevap.TabIndex = 11;
            this.lbdoğrucevap.Text = "doğrucevap";
            this.lbdoğrucevap.Visible = false;
//            this.lbdoğrucevap.Click += new System.EventHandler(this.lbdoğrucevap_Click);
            // 
            // btnsonrakisoru
            // 
            this.btnsonrakisoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsonrakisoru.Location = new System.Drawing.Point(538, 173);
            this.btnsonrakisoru.Name = "btnsonrakisoru";
            this.btnsonrakisoru.Size = new System.Drawing.Size(165, 53);
            this.btnsonrakisoru.TabIndex = 12;
            this.btnsonrakisoru.Text = "sonraki soru";
            this.btnsonrakisoru.UseVisualStyleBackColor = true;
            this.btnsonrakisoru.Visible = false;
            this.btnsonrakisoru.Click += new System.EventHandler(this.btnsonrakisoru_Click);
            // 
            // lbişaretlenen
            // 
            this.lbişaretlenen.AutoSize = true;
            this.lbişaretlenen.Location = new System.Drawing.Point(852, 553);
            this.lbişaretlenen.Name = "lbişaretlenen";
            this.lbişaretlenen.Size = new System.Drawing.Size(78, 17);
            this.lbişaretlenen.TabIndex = 13;
            this.lbişaretlenen.Text = "işaretlenen";
            this.lbişaretlenen.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(694, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(694, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(462, 232);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(393, 136);
            this.richTextBox2.TabIndex = 16;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(462, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 72);
            this.button1.TabIndex = 17;
            this.button1.Text = "soruları görmek için tıkla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbişaretlenen);
            this.Controls.Add(this.btnsonrakisoru);
            this.Controls.Add(this.lbdoğrucevap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbdoğrusayısı);
            this.Controls.Add(this.lbyanlışsayısı);
            this.Controls.Add(this.sorusayısı);
            this.Controls.Add(this.lbdoğru);
            this.Controls.Add(this.lbyanlış);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btna);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Label lbyanlış;
        private System.Windows.Forms.Label lbdoğru;
        private System.Windows.Forms.Label sorusayısı;
        private System.Windows.Forms.Label lbyanlışsayısı;
        private System.Windows.Forms.Label lbdoğrusayısı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbdoğrucevap;
        private System.Windows.Forms.Button btnsonrakisoru;
        private System.Windows.Forms.Label lbişaretlenen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
    }
}

