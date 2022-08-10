namespace Calculadoras
{
    partial class FormImcCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImcCalculator));
            this.lgoForm = new System.Windows.Forms.PictureBox();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblGenericResult = new System.Windows.Forms.Label();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.lblHeightUnit = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lgoForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lgoForm
            // 
            this.lgoForm.Image = ((System.Drawing.Image)(resources.GetObject("lgoForm.Image")));
            this.lgoForm.Location = new System.Drawing.Point(130, 15);
            this.lgoForm.Name = "lgoForm";
            this.lgoForm.Size = new System.Drawing.Size(145, 77);
            this.lgoForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lgoForm.TabIndex = 0;
            this.lgoForm.TabStop = false;
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleForm.Location = new System.Drawing.Point(74, 114);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(256, 24);
            this.lblTitleForm.TabIndex = 1;
            this.lblTitleForm.Text = "Sistema de Cáculo de IMC";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.Location = new System.Drawing.Point(86, 163);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(49, 20);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Peso:";
            // 
            // txbWeight
            // 
            this.txbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbWeight.Location = new System.Drawing.Point(144, 160);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(116, 26);
            this.txbWeight.TabIndex = 1;
            this.txbWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbHeight
            // 
            this.txbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbHeight.Location = new System.Drawing.Point(144, 205);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(116, 26);
            this.txbHeight.TabIndex = 2;
            this.txbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeight.Location = new System.Drawing.Point(86, 208);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(55, 20);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Altura:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DimGray;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.Location = new System.Drawing.Point(66, 250);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(81, 35);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Red;
            this.btnClean.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClean.Location = new System.Drawing.Point(157, 250);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(81, 35);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lblGenericResult
            // 
            this.lblGenericResult.AutoSize = true;
            this.lblGenericResult.BackColor = System.Drawing.Color.LightGray;
            this.lblGenericResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenericResult.Location = new System.Drawing.Point(74, 315);
            this.lblGenericResult.Name = "lblGenericResult";
            this.lblGenericResult.Size = new System.Drawing.Size(0, 24);
            this.lblGenericResult.TabIndex = 9;
            this.lblGenericResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeightUnit.Location = new System.Drawing.Point(262, 160);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(26, 20);
            this.lblWeightUnit.TabIndex = 12;
            this.lblWeightUnit.Text = "kg";
            // 
            // lblHeightUnit
            // 
            this.lblHeightUnit.AutoSize = true;
            this.lblHeightUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeightUnit.Location = new System.Drawing.Point(262, 208);
            this.lblHeightUnit.Name = "lblHeightUnit";
            this.lblHeightUnit.Size = new System.Drawing.Size(30, 20);
            this.lblHeightUnit.TabIndex = 13;
            this.lblHeightUnit.Text = "cm";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.OrangeRed;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Location = new System.Drawing.Point(249, 250);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(81, 35);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Text = "Voltar Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // FormImcCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.CancelButton = this.btnClean;
            this.ClientSize = new System.Drawing.Size(415, 380);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblHeightUnit);
            this.Controls.Add(this.lblWeightUnit);
            this.Controls.Add(this.lblGenericResult);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txbHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txbWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblTitleForm);
            this.Controls.Add(this.lgoForm);
            this.Name = "FormImcCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora IMC";
            this.Load += new System.EventHandler(this.FormImcCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lgoForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox lgoForm;
        private Label lblTitleForm;
        private Label lblWeight;
        private TextBox txbWeight;
        private TextBox txbHeight;
        private Label lblHeight;
        private Button btnCalculate;
        private Button btnClean;
        private Label lblGenericResult;
        private Label lblWeightUnit;
        private Label lblHeightUnit;
        private Button btnMenu;
    }
}