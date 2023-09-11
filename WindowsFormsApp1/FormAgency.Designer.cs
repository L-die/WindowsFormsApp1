namespace WindowsFormsApp1
{
    partial class FormAgency
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesignAgency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAgency = new System.Windows.Forms.Button();
            this.btnCancelAgency = new System.Windows.Forms.Button();
            this.cboStatut = new System.Windows.Forms.ComboBox();
            this.txtLocalisation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Statut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Localisation";
            // 
            // txtDesignAgency
            // 
            this.txtDesignAgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignAgency.Location = new System.Drawing.Point(185, 110);
            this.txtDesignAgency.Name = "txtDesignAgency";
            this.txtDesignAgency.Size = new System.Drawing.Size(242, 35);
            this.txtDesignAgency.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Designation";
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
            this.dataGridView1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 71);
            this.panel1.TabIndex = 11;
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
            // btnAddAgency
            // 
            this.btnAddAgency.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAgency.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAgency.Location = new System.Drawing.Point(517, 175);
            this.btnAddAgency.Name = "btnAddAgency";
            this.btnAddAgency.Size = new System.Drawing.Size(141, 37);
            this.btnAddAgency.TabIndex = 19;
            this.btnAddAgency.Text = "Add";
            this.btnAddAgency.UseVisualStyleBackColor = false;
            this.btnAddAgency.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancelAgency
            // 
            this.btnCancelAgency.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancelAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAgency.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelAgency.Location = new System.Drawing.Point(713, 175);
            this.btnCancelAgency.Name = "btnCancelAgency";
            this.btnCancelAgency.Size = new System.Drawing.Size(141, 37);
            this.btnCancelAgency.TabIndex = 20;
            this.btnCancelAgency.Text = "Cancel";
            this.btnCancelAgency.UseVisualStyleBackColor = false;
            // 
            // cboStatut
            // 
            this.cboStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatut.FormattingEnabled = true;
            this.cboStatut.Location = new System.Drawing.Point(612, 108);
            this.cboStatut.Name = "cboStatut";
            this.cboStatut.Size = new System.Drawing.Size(242, 37);
            this.cboStatut.TabIndex = 22;
            // 
            // txtLocalisation
            // 
            this.txtLocalisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalisation.Location = new System.Drawing.Point(185, 177);
            this.txtLocalisation.Name = "txtLocalisation";
            this.txtLocalisation.Size = new System.Drawing.Size(242, 35);
            this.txtLocalisation.TabIndex = 23;
            // 
            // FormAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(924, 533);
            this.Controls.Add(this.txtLocalisation);
            this.Controls.Add(this.cboStatut);
            this.Controls.Add(this.btnCancelAgency);
            this.Controls.Add(this.btnAddAgency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesignAgency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormAgency";
            this.Text = "FormAgency";
            this.Load += new System.EventHandler(this.FormAgency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesignAgency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAgency;
        private System.Windows.Forms.Button btnCancelAgency;
        private System.Windows.Forms.ComboBox cboStatut;
        private System.Windows.Forms.TextBox txtLocalisation;
    }
}