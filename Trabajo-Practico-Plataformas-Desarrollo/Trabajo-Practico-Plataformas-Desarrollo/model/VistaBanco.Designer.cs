namespace Trabajo_Practico_Plataformas_Desarrollo.model
{
    partial class VistaBanco
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
            this.btnDepositar = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btnCajaAhorro = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnDepositar
            // 
            this.btnDepositar.AutoSize = false;
            this.btnDepositar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDepositar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDepositar.Depth = 0;
            this.btnDepositar.HighEmphasis = true;
            this.btnDepositar.Icon = null;
            this.btnDepositar.Location = new System.Drawing.Point(38, 27);
            this.btnDepositar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDepositar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDepositar.Size = new System.Drawing.Size(143, 36);
            this.btnDepositar.TabIndex = 0;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDepositar.UseAccentColor = false;
            this.btnDepositar.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(38, 75);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(143, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Movimientos";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // btnCajaAhorro
            // 
            this.btnCajaAhorro.AutoSize = false;
            this.btnCajaAhorro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCajaAhorro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCajaAhorro.Depth = 0;
            this.btnCajaAhorro.HighEmphasis = true;
            this.btnCajaAhorro.Icon = null;
            this.btnCajaAhorro.Location = new System.Drawing.Point(38, 123);
            this.btnCajaAhorro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCajaAhorro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCajaAhorro.Name = "btnCajaAhorro";
            this.btnCajaAhorro.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCajaAhorro.Size = new System.Drawing.Size(143, 36);
            this.btnCajaAhorro.TabIndex = 2;
            this.btnCajaAhorro.Text = "Caja de Ahorro";
            this.btnCajaAhorro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCajaAhorro.UseAccentColor = false;
            this.btnCajaAhorro.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(38, 171);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(145, 36);
            this.materialButton2.TabIndex = 3;
            this.materialButton2.Text = "Plazo Fijo";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // VistaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(248, 236);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.btnCajaAhorro);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btnDepositar);
            this.Name = "VistaBanco";
            this.Text = "HomeBanking";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnDepositar;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btnCajaAhorro;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}