namespace LaboratorioScienze
{
    partial class AddMonth
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
            this.month = new System.Windows.Forms.NumericUpDown();
            this.lbl_Mese = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            this.SuspendLayout();
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(51, 7);
            this.month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(82, 20);
            this.month.TabIndex = 0;
            this.month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl_Mese
            // 
            this.lbl_Mese.AutoSize = true;
            this.lbl_Mese.Location = new System.Drawing.Point(139, 9);
            this.lbl_Mese.Name = "lbl_Mese";
            this.lbl_Mese.Size = new System.Drawing.Size(53, 13);
            this.lbl_Mese.TabIndex = 1;
            this.lbl_Mese.Text = "(Gennaio)";
            this.lbl_Mese.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mese";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inserisci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 81);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Mese);
            this.Controls.Add(this.month);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 120);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(240, 120);
            this.Name = "AddMonth";
            this.Text = "Inserisci Mese";
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown month;
        private System.Windows.Forms.Label lbl_Mese;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

    }
}