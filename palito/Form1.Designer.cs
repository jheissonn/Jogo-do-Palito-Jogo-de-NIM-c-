namespace palito
{
    partial class Formpalito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formpalito));
            this.labelquanpalito = new System.Windows.Forms.Label();
            this.numericUpDownquantpali = new System.Windows.Forms.NumericUpDown();
            this.buttonjogar = new System.Windows.Forms.Button();
            this.labelretirada = new System.Windows.Forms.Label();
            this.buttonretiradapali = new System.Windows.Forms.Button();
            this.maskedTextBoxpalitos = new System.Windows.Forms.MaskedTextBox();
            this.richTextBoxmostratudo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownquantpali)).BeginInit();
            this.SuspendLayout();
            // 
            // labelquanpalito
            // 
            this.labelquanpalito.AutoSize = true;
            this.labelquanpalito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelquanpalito.Location = new System.Drawing.Point(41, 12);
            this.labelquanpalito.Name = "labelquanpalito";
            this.labelquanpalito.Size = new System.Drawing.Size(203, 16);
            this.labelquanpalito.TabIndex = 0;
            this.labelquanpalito.Text = "escolha a quantidade de palitos:";
            // 
            // numericUpDownquantpali
            // 
            this.numericUpDownquantpali.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownquantpali.Location = new System.Drawing.Point(272, 8);
            this.numericUpDownquantpali.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownquantpali.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownquantpali.Name = "numericUpDownquantpali";
            this.numericUpDownquantpali.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownquantpali.TabIndex = 1;
            this.numericUpDownquantpali.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // buttonjogar
            // 
            this.buttonjogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonjogar.Location = new System.Drawing.Point(438, 8);
            this.buttonjogar.Name = "buttonjogar";
            this.buttonjogar.Size = new System.Drawing.Size(75, 32);
            this.buttonjogar.TabIndex = 2;
            this.buttonjogar.Text = "jogar";
            this.buttonjogar.UseVisualStyleBackColor = true;
            this.buttonjogar.Click += new System.EventHandler(this.buttonjogar_Click);
            // 
            // labelretirada
            // 
            this.labelretirada.AutoSize = true;
            this.labelretirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelretirada.Location = new System.Drawing.Point(13, 53);
            this.labelretirada.Name = "labelretirada";
            this.labelretirada.Size = new System.Drawing.Size(238, 16);
            this.labelretirada.TabIndex = 3;
            this.labelretirada.Text = "escolha  quantos palitos deseja retirar:";
            // 
            // buttonretiradapali
            // 
            this.buttonretiradapali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonretiradapali.Location = new System.Drawing.Point(438, 46);
            this.buttonretiradapali.Name = "buttonretiradapali";
            this.buttonretiradapali.Size = new System.Drawing.Size(75, 23);
            this.buttonretiradapali.TabIndex = 4;
            this.buttonretiradapali.Text = "retirar";
            this.buttonretiradapali.UseVisualStyleBackColor = true;
            this.buttonretiradapali.Click += new System.EventHandler(this.buttonretiradapali_Click);
            // 
            // maskedTextBoxpalitos
            // 
            this.maskedTextBoxpalitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxpalitos.Location = new System.Drawing.Point(272, 48);
            this.maskedTextBoxpalitos.Mask = "0";
            this.maskedTextBoxpalitos.Name = "maskedTextBoxpalitos";
            this.maskedTextBoxpalitos.Size = new System.Drawing.Size(120, 20);
            this.maskedTextBoxpalitos.TabIndex = 5;
            // 
            // richTextBoxmostratudo
            // 
            this.richTextBoxmostratudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxmostratudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxmostratudo.Location = new System.Drawing.Point(0, 116);
            this.richTextBoxmostratudo.Name = "richTextBoxmostratudo";
            this.richTextBoxmostratudo.Size = new System.Drawing.Size(832, 321);
            this.richTextBoxmostratudo.TabIndex = 6;
            this.richTextBoxmostratudo.Text = "";
            this.richTextBoxmostratudo.TextChanged += new System.EventHandler(this.richTextBoxmostratudo_TextChanged);
            // 
            // Formpalito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 437);
            this.Controls.Add(this.richTextBoxmostratudo);
            this.Controls.Add(this.maskedTextBoxpalitos);
            this.Controls.Add(this.buttonretiradapali);
            this.Controls.Add(this.labelretirada);
            this.Controls.Add(this.buttonjogar);
            this.Controls.Add(this.numericUpDownquantpali);
            this.Controls.Add(this.labelquanpalito);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formpalito";
            this.Text = "Jogo do Palito!!!";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownquantpali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelquanpalito;
        private System.Windows.Forms.NumericUpDown numericUpDownquantpali;
        private System.Windows.Forms.Button buttonjogar;
        private System.Windows.Forms.Label labelretirada;
        private System.Windows.Forms.Button buttonretiradapali;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxpalitos;
        private System.Windows.Forms.RichTextBox richTextBoxmostratudo;
    }
}

