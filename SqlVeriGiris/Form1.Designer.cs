
namespace SqlVeriGiris
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonVerileriGetir = new System.Windows.Forms.Button();
            this.buttonKayıt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxFirma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSemt = new System.Windows.Forms.ComboBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 437);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(562, 300);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Firma";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Semt";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "id";
            // 
            // buttonVerileriGetir
            // 
            this.buttonVerileriGetir.Location = new System.Drawing.Point(120, 355);
            this.buttonVerileriGetir.Name = "buttonVerileriGetir";
            this.buttonVerileriGetir.Size = new System.Drawing.Size(157, 61);
            this.buttonVerileriGetir.TabIndex = 12;
            this.buttonVerileriGetir.Text = "Verileri Getir";
            this.buttonVerileriGetir.UseVisualStyleBackColor = true;
            this.buttonVerileriGetir.Click += new System.EventHandler(this.buttonVerileriGetir_Click);
            // 
            // buttonKayıt
            // 
            this.buttonKayıt.Location = new System.Drawing.Point(120, 277);
            this.buttonKayıt.Name = "buttonKayıt";
            this.buttonKayıt.Size = new System.Drawing.Size(157, 61);
            this.buttonKayıt.TabIndex = 22;
            this.buttonKayıt.Text = "Kaydet";
            this.buttonKayıt.UseVisualStyleBackColor = true;
            this.buttonKayıt.Click += new System.EventHandler(this.buttonKayıt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(152, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad Soyad :";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxAdSoyad.Location = new System.Drawing.Point(308, 79);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(130, 26);
            this.textBoxAdSoyad.TabIndex = 1;
            // 
            // textBoxFirma
            // 
            this.textBoxFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxFirma.Location = new System.Drawing.Point(308, 127);
            this.textBoxFirma.Name = "textBoxFirma";
            this.textBoxFirma.Size = new System.Drawing.Size(130, 26);
            this.textBoxFirma.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(152, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Firma :";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxTelefon.Location = new System.Drawing.Point(308, 182);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(130, 26);
            this.textBoxTelefon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(152, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(152, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Semt :";
            // 
            // comboBoxSemt
            // 
            this.comboBoxSemt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxSemt.FormattingEnabled = true;
            this.comboBoxSemt.Items.AddRange(new object[] {
            "Kadıköy",
            "Üsküdar",
            "Ataşehir",
            "Kartal",
            "Maltepe",
            "Pendik",
            "Tuzla"});
            this.comboBoxSemt.Location = new System.Drawing.Point(308, 234);
            this.comboBoxSemt.Name = "comboBoxSemt";
            this.comboBoxSemt.Size = new System.Drawing.Size(130, 28);
            this.comboBoxSemt.TabIndex = 4;
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(308, 355);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(157, 61);
            this.buttonSil.TabIndex = 32;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(152, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Id:";
            // 
            // textBoxid
            // 
            this.textBoxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxid.Location = new System.Drawing.Point(308, 31);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(130, 26);
            this.textBoxid.TabIndex = 0;
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Location = new System.Drawing.Point(308, 277);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(157, 61);
            this.btnDuzelt.TabIndex = 15;
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 806);
            this.Controls.Add(this.btnDuzelt);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.comboBoxSemt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFirma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKayıt);
            this.Controls.Add(this.buttonVerileriGetir);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonVerileriGetir;
        private System.Windows.Forms.Button buttonKayıt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.TextBox textBoxFirma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSemt;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Button btnDuzelt;
    }
}

