namespace Gestion_Ecole
{
    partial class FormEtudiant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtcredit = new System.Windows.Forms.TextBox();
            this.txtannee = new System.Windows.Forms.TextBox();
            this.txtreglement = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.bntupadate = new System.Windows.Forms.Button();
            this.btnyear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtnom);
            this.panel1.Controls.Add(this.txtcredit);
            this.panel1.Controls.Add(this.txtannee);
            this.panel1.Controls.Add(this.txtreglement);
            this.panel1.Controls.Add(this.txtprenom);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 446);
            this.panel1.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Indigo;
            this.btnsearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(194, 8);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(141, 27);
            this.btnsearch.TabIndex = 15;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "IdEtu";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(145, 48);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(166, 20);
            this.txtid.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Classe:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 400);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(145, 151);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(166, 20);
            this.txtnom.TabIndex = 9;
            // 
            // txtcredit
            // 
            this.txtcredit.Location = new System.Drawing.Point(145, 225);
            this.txtcredit.Multiline = true;
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Size = new System.Drawing.Size(166, 20);
            this.txtcredit.TabIndex = 8;
            // 
            // txtannee
            // 
            this.txtannee.Location = new System.Drawing.Point(145, 347);
            this.txtannee.Multiline = true;
            this.txtannee.Name = "txtannee";
            this.txtannee.Size = new System.Drawing.Size(166, 20);
            this.txtannee.TabIndex = 7;
            // 
            // txtreglement
            // 
            this.txtreglement.Location = new System.Drawing.Point(145, 292);
            this.txtreglement.Multiline = true;
            this.txtreglement.Name = "txtreglement";
            this.txtreglement.Size = new System.Drawing.Size(166, 20);
            this.txtreglement.TabIndex = 6;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(145, 95);
            this.txtprenom.Multiline = true;
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(166, 20);
            this.txtprenom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "AnneeScolaire:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reglement:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prenom:";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Indigo;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(17, 469);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(141, 36);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "VALIDER";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(358, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 446);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 442);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Indigo;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(643, 469);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(141, 36);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "EFFACER";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Indigo;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(419, 469);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(141, 36);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "SUPPRIMER";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // bntupadate
            // 
            this.bntupadate.BackColor = System.Drawing.Color.Indigo;
            this.bntupadate.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntupadate.ForeColor = System.Drawing.Color.White;
            this.bntupadate.Location = new System.Drawing.Point(224, 469);
            this.bntupadate.Name = "bntupadate";
            this.bntupadate.Size = new System.Drawing.Size(141, 36);
            this.bntupadate.TabIndex = 13;
            this.bntupadate.Text = "MODIFIER";
            this.bntupadate.UseVisualStyleBackColor = false;
            this.bntupadate.Click += new System.EventHandler(this.bntupadate_Click);
            // 
            // btnyear
            // 
            this.btnyear.BackColor = System.Drawing.Color.Indigo;
            this.btnyear.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyear.ForeColor = System.Drawing.Color.White;
            this.btnyear.Location = new System.Drawing.Point(818, 469);
            this.btnyear.Name = "btnyear";
            this.btnyear.Size = new System.Drawing.Size(159, 36);
            this.btnyear.TabIndex = 16;
            this.btnyear.Text = "SEARCHByYear";
            this.btnyear.UseVisualStyleBackColor = false;
            this.btnyear.Click += new System.EventHandler(this.btnyear_Click);
            // 
            // FormEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 517);
            this.Controls.Add(this.btnyear);
            this.Controls.Add(this.bntupadate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnadd);
            this.Name = "FormEtudiant";
            this.Text = "FormEtudiant";
            this.Load += new System.EventHandler(this.FormEtudiant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtcredit;
        private System.Windows.Forms.TextBox txtannee;
        private System.Windows.Forms.TextBox txtreglement;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button bntupadate;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnyear;
    }
}