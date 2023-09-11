namespace WindowsFormsApp1
{
    partial class FormSettings
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
            this.cboStatut = new System.Windows.Forms.ComboBox();
            this.txtCanStatut = new System.Windows.Forms.Button();
            this.btnAddAgency = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddStatut = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboStatut
            // 
            this.cboStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatut.FormattingEnabled = true;
            this.cboStatut.Location = new System.Drawing.Point(612, 108);
            this.cboStatut.Name = "cboStatut";
            this.cboStatut.Size = new System.Drawing.Size(242, 37);
            this.cboStatut.TabIndex = 30;
            // 
            // txtCanStatut
            // 
            this.txtCanStatut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtCanStatut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCanStatut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCanStatut.Location = new System.Drawing.Point(286, 175);
            this.txtCanStatut.Name = "txtCanStatut";
            this.txtCanStatut.Size = new System.Drawing.Size(141, 37);
            this.txtCanStatut.TabIndex = 29;
            this.txtCanStatut.Text = "Cancel";
            this.txtCanStatut.UseVisualStyleBackColor = false;
            // 
            // btnAddAgency
            // 
            this.btnAddAgency.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAgency.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAgency.Location = new System.Drawing.Point(112, 175);
            this.btnAddAgency.Name = "btnAddAgency";
            this.btnAddAgency.Size = new System.Drawing.Size(141, 37);
            this.btnAddAgency.TabIndex = 28;
            this.btnAddAgency.Text = "Add";
            this.btnAddAgency.UseVisualStyleBackColor = false;
            this.btnAddAgency.Click += new System.EventHandler(this.btnAddAgency_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Statut";
            // 
            // txtAddStatut
            // 
            this.txtAddStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStatut.Location = new System.Drawing.Point(185, 110);
            this.txtAddStatut.Name = "txtAddStatut";
            this.txtAddStatut.Size = new System.Drawing.Size(242, 35);
            this.txtAddStatut.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(924, 255);
            this.dataGridView1.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 71);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Register Agency";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatut.Location = new System.Drawing.Point(23, 117);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(60, 22);
            this.lblStatut.TabIndex = 32;
            this.lblStatut.Text = "Statut";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(718, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 34;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(544, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 37);
            this.button2.TabIndex = 33;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblStatut);
            this.Controls.Add(this.cboStatut);
            this.Controls.Add(this.txtCanStatut);
            this.Controls.Add(this.btnAddAgency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddStatut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboStatut;
        private System.Windows.Forms.Button txtCanStatut;
        private System.Windows.Forms.Button btnAddAgency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddStatut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}