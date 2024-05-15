namespace Gestion_Ecole
{
    partial class FormClasse
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
            this.txtsave = new System.Windows.Forms.Button();
            this.combospecialite = new System.Windows.Forms.ComboBox();
            this.comboniveau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtsave);
            this.panel1.Controls.Add(this.combospecialite);
            this.panel1.Controls.Add(this.comboniveau);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 447);
            this.panel1.TabIndex = 0;
            // 
            // txtsave
            // 
            this.txtsave.BackColor = System.Drawing.Color.Indigo;
            this.txtsave.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsave.ForeColor = System.Drawing.Color.White;
            this.txtsave.Location = new System.Drawing.Point(74, 301);
            this.txtsave.Name = "txtsave";
            this.txtsave.Size = new System.Drawing.Size(119, 34);
            this.txtsave.TabIndex = 5;
            this.txtsave.Text = "Enrigistrer";
            this.txtsave.UseVisualStyleBackColor = false;
            this.txtsave.Click += new System.EventHandler(this.txtsave_Click);
            // 
            // combospecialite
            // 
            this.combospecialite.FormattingEnabled = true;
            this.combospecialite.Items.AddRange(new object[] {
            "Choisir une specialite",
            "Informatique de gestion",
            "genie logiciel",
            "finance compta",
            "Commerce Internationnale",
            "Reseau informatique"});
            this.combospecialite.Location = new System.Drawing.Point(34, 213);
            this.combospecialite.Name = "combospecialite";
            this.combospecialite.Size = new System.Drawing.Size(192, 21);
            this.combospecialite.TabIndex = 4;
            // 
            // comboniveau
            // 
            this.comboniveau.FormattingEnabled = true;
            this.comboniveau.Items.AddRange(new object[] {
            "Choisir le niveau de la classe",
            "L1",
            "L2",
            "L3",
            "Master1",
            "Master2"});
            this.comboniveau.Location = new System.Drawing.Point(38, 82);
            this.comboniveau.Name = "comboniveau";
            this.comboniveau.Size = new System.Drawing.Size(188, 21);
            this.comboniveau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Specialite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Niveau:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(340, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 447);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormClasse";
            this.Text = "FormClasse";
            this.Load += new System.EventHandler(this.FormClasse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboniveau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtsave;
        private System.Windows.Forms.ComboBox combospecialite;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}