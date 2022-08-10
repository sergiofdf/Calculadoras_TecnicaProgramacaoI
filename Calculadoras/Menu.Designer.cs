namespace Calculadoras
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnImc = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.pcbLogoImc = new System.Windows.Forms.PictureBox();
            this.pcbLogoCalc = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoImc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenuTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMenuTitle.Location = new System.Drawing.Point(31, 18);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(336, 63);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "Bem Vindo\r\n\r\nEscolha a calculadora que deseja acessar";
            // 
            // btnImc
            // 
            this.btnImc.BackColor = System.Drawing.Color.IndianRed;
            this.btnImc.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImc.Location = new System.Drawing.Point(221, 128);
            this.btnImc.Name = "btnImc";
            this.btnImc.Size = new System.Drawing.Size(146, 56);
            this.btnImc.TabIndex = 1;
            this.btnImc.Text = "IMC";
            this.btnImc.UseVisualStyleBackColor = false;
            this.btnImc.Click += new System.EventHandler(this.btnImc_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.SlateGray;
            this.btnCalc.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalc.Location = new System.Drawing.Point(221, 244);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(146, 56);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculadora Simples";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // pcbLogoImc
            // 
            this.pcbLogoImc.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogoImc.Image")));
            this.pcbLogoImc.Location = new System.Drawing.Point(31, 110);
            this.pcbLogoImc.Name = "pcbLogoImc";
            this.pcbLogoImc.Size = new System.Drawing.Size(164, 92);
            this.pcbLogoImc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoImc.TabIndex = 3;
            this.pcbLogoImc.TabStop = false;
            // 
            // pcbLogoCalc
            // 
            this.pcbLogoCalc.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogoCalc.Image")));
            this.pcbLogoCalc.Location = new System.Drawing.Point(31, 226);
            this.pcbLogoCalc.Name = "pcbLogoCalc";
            this.pcbLogoCalc.Size = new System.Drawing.Size(164, 92);
            this.pcbLogoCalc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoCalc.TabIndex = 4;
            this.pcbLogoCalc.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(95, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(412, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcbLogoCalc);
            this.Controls.Add(this.pcbLogoImc);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnImc);
            this.Controls.Add(this.lblMenuTitle);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoImc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMenuTitle;
        private Button btnImc;
        private Button btnCalc;
        private PictureBox pcbLogoImc;
        private PictureBox pcbLogoCalc;
        private Button button1;
    }
}