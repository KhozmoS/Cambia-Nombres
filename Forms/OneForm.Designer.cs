namespace CambiaNombres
{
    partial class OneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneForm));
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambiar = new MetroFramework.Controls.MetroButton();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(31, 98);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(163, 21);
            this.textNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(28, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Completo:";
            // 
            // textPath
            // 
            this.textPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPath.Location = new System.Drawing.Point(222, 98);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(185, 21);
            this.textPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(219, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion de la Carpeta";
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCambiar.Location = new System.Drawing.Point(31, 156);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(114, 23);
            this.btnCambiar.Style = MetroFramework.MetroColorStyle.White;
            this.btnCambiar.TabIndex = 5;
            this.btnCambiar.Text = "Cambiar Nombre";
            this.btnCambiar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCambiar.UseCustomBackColor = true;
            this.btnCambiar.UseMnemonic = false;
            this.btnCambiar.UseSelectable = true;
            this.btnCambiar.UseStyleColors = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReset.DisplayFocus = true;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(293, 156);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 23);
            this.btnReset.Style = MetroFramework.MetroColorStyle.White;
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Resetear";
            this.btnReset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReset.UseCustomBackColor = true;
            this.btnReset.UseMnemonic = false;
            this.btnReset.UseSelectable = true;
            this.btnReset.UseStyleColors = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // OneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(442, 215);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombre);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.MaximizeBox = false;
            this.Name = "OneForm";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Modifica una Carpeta";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnCambiar;
        private MetroFramework.Controls.MetroButton btnReset;
    }
}

