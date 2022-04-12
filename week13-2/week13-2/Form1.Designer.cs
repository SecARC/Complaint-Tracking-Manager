
namespace week13_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsJanuary = new System.Windows.Forms.ToolStripButton();
            this.tsFebruary = new System.Windows.Forms.ToolStripButton();
            this.tsMarch = new System.Windows.Forms.ToolStripButton();
            this.tsApril = new System.Windows.Forms.ToolStripButton();
            this.tsMay = new System.Windows.Forms.ToolStripButton();
            this.tsJune = new System.Windows.Forms.ToolStripButton();
            this.tsJuly = new System.Windows.Forms.ToolStripButton();
            this.tsAugust = new System.Windows.Forms.ToolStripButton();
            this.tsSeptember = new System.Windows.Forms.ToolStripButton();
            this.tsOctober = new System.Windows.Forms.ToolStripButton();
            this.tsNovember = new System.Windows.Forms.ToolStripButton();
            this.tsDecember = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsJanuary,
            this.tsFebruary,
            this.tsMarch,
            this.tsApril,
            this.tsMay,
            this.tsJune,
            this.tsJuly,
            this.tsAugust,
            this.tsSeptember,
            this.tsOctober,
            this.tsNovember,
            this.tsDecember});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsJanuary
            // 
            this.tsJanuary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsJanuary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsJanuary.Name = "tsJanuary";
            this.tsJanuary.Size = new System.Drawing.Size(51, 22);
            this.tsJanuary.Text = "January";
            this.tsJanuary.Click += new System.EventHandler(this.ts_Click);
            // 
            // tsFebruary
            // 
            this.tsFebruary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFebruary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFebruary.Name = "tsFebruary";
            this.tsFebruary.Size = new System.Drawing.Size(57, 22);
            this.tsFebruary.Text = "February";
            this.tsFebruary.Click += new System.EventHandler(this.ts_Click);
            // 
            // tsMarch
            // 
            this.tsMarch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMarch.Image = ((System.Drawing.Image)(resources.GetObject("tsMarch.Image")));
            this.tsMarch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMarch.Name = "tsMarch";
            this.tsMarch.Size = new System.Drawing.Size(45, 22);
            this.tsMarch.Text = "March";
            this.tsMarch.Click += new System.EventHandler(this.ts_Click);
            // 
            // tsApril
            // 
            this.tsApril.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsApril.Image = ((System.Drawing.Image)(resources.GetObject("tsApril.Image")));
            this.tsApril.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsApril.Name = "tsApril";
            this.tsApril.Size = new System.Drawing.Size(36, 22);
            this.tsApril.Text = "April";
            this.tsApril.Click += new System.EventHandler(this.ts_Click);
            // 
            // tsMay
            // 
            this.tsMay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMay.Image = ((System.Drawing.Image)(resources.GetObject("tsMay.Image")));
            this.tsMay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMay.Name = "tsMay";
            this.tsMay.Size = new System.Drawing.Size(34, 22);
            this.tsMay.Text = "May";
            this.tsMay.Click += new System.EventHandler(this.ts_Click);
            // 
            // tsJune
            // 
            this.tsJune.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsJune.Image = ((System.Drawing.Image)(resources.GetObject("tsJune.Image")));
            this.tsJune.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsJune.Name = "tsJune";
            this.tsJune.Size = new System.Drawing.Size(35, 22);
            this.tsJune.Text = "June";
            this.tsJune.Click += new System.EventHandler(this.ts_Click);
            // 
            // tsJuly
            // 
            this.tsJuly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsJuly.Image = ((System.Drawing.Image)(resources.GetObject("tsJuly.Image")));
            this.tsJuly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsJuly.Name = "tsJuly";
            this.tsJuly.Size = new System.Drawing.Size(31, 22);
            this.tsJuly.Text = "July";
            this.tsJuly.Click += new System.EventHandler(this.ts_Click);
            // 
            // tsAugust
            // 
            this.tsAugust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsAugust.Image = ((System.Drawing.Image)(resources.GetObject("tsAugust.Image")));
            this.tsAugust.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAugust.Name = "tsAugust";
            this.tsAugust.Size = new System.Drawing.Size(49, 22);
            this.tsAugust.Text = "August";
            this.tsAugust.Click += new System.EventHandler(this.ts_Click);
            // 
            // tsSeptember
            // 
            this.tsSeptember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSeptember.Image = ((System.Drawing.Image)(resources.GetObject("tsSeptember.Image")));
            this.tsSeptember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSeptember.Name = "tsSeptember";
            this.tsSeptember.Size = new System.Drawing.Size(68, 22);
            this.tsSeptember.Text = "September";
            this.tsSeptember.Click += new System.EventHandler(this.ts_Click);
            // 
            // tsOctober
            // 
            this.tsOctober.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsOctober.Image = ((System.Drawing.Image)(resources.GetObject("tsOctober.Image")));
            this.tsOctober.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOctober.Name = "tsOctober";
            this.tsOctober.Size = new System.Drawing.Size(54, 22);
            this.tsOctober.Text = "October";
            this.tsOctober.Click += new System.EventHandler(this.ts_Click);
            // 
            // tsNovember
            // 
            this.tsNovember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsNovember.Image = ((System.Drawing.Image)(resources.GetObject("tsNovember.Image")));
            this.tsNovember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNovember.Name = "tsNovember";
            this.tsNovember.Size = new System.Drawing.Size(67, 22);
            this.tsNovember.Text = "November";
            this.tsNovember.Click += new System.EventHandler(this.ts_Click);
            // 
            // tsDecember
            // 
            this.tsDecember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDecember.Image = ((System.Drawing.Image)(resources.GetObject("tsDecember.Image")));
            this.tsDecember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDecember.Name = "tsDecember";
            this.tsDecember.Size = new System.Drawing.Size(65, 22);
            this.tsDecember.Text = "December";
            this.tsDecember.Click += new System.EventHandler(this.ts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Complaints";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "C1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "C2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "C3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "C4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "C5";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 26);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 26);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(257, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(25, 26);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(294, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(25, 26);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(331, 138);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(25, 26);
            this.textBox5.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(383, 138);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(40, 26);
            this.textBox7.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 174);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Percentage";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(183, 171);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(25, 26);
            this.textBox8.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(220, 171);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(25, 26);
            this.textBox9.TabIndex = 19;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(257, 171);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(25, 26);
            this.textBox10.TabIndex = 20;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(294, 171);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(25, 26);
            this.textBox11.TabIndex = 21;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(331, 171);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(25, 26);
            this.textBox12.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(484, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 120);
            this.label11.TabIndex = 24;
            this.label11.Text = "Complaint Types Description\r\nC1: Login Problem\r\nC2: Email Problem\r\nC3: Printer Pr" +
    "oblem\r\nC4: Hardware Problem\r\nC5: Software Problem";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(109, 247);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(136, 28);
            this.btnSaveChanges.TabIndex = 25;
            this.btnSaveChanges.Text = "&Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(251, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 28);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(346, 247);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(134, 28);
            this.btnReload.TabIndex = 27;
            this.btnReload.Text = "&Reload Data";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 290);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Complaint Tracking Manager / 20170301006 / Tuğra GÜNDÜZ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsJanuary;
        private System.Windows.Forms.ToolStripButton tsFebruary;
        private System.Windows.Forms.ToolStripButton tsMarch;
        private System.Windows.Forms.ToolStripButton tsApril;
        private System.Windows.Forms.ToolStripButton tsMay;
        private System.Windows.Forms.ToolStripButton tsJune;
        private System.Windows.Forms.ToolStripButton tsJuly;
        private System.Windows.Forms.ToolStripButton tsAugust;
        private System.Windows.Forms.ToolStripButton tsSeptember;
        private System.Windows.Forms.ToolStripButton tsOctober;
        private System.Windows.Forms.ToolStripButton tsNovember;
        private System.Windows.Forms.ToolStripButton tsDecember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

