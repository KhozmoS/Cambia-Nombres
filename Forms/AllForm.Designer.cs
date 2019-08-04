namespace CambiaNombres.Forms
{
    partial class AllForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllForm));
            this.label2 = new System.Windows.Forms.Label();
            this.textPath = new System.Windows.Forms.TextBox();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.btnCambiar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Direccion de las Carpetas:";
            // 
            // textPath
            // 
            this.textPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPath.Location = new System.Drawing.Point(32, 91);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(255, 21);
            this.textPath.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.DisplayFocus = true;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(173, 146);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 23);
            this.btnReset.Style = MetroFramework.MetroColorStyle.White;
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Resetear";
            this.btnReset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReset.UseCustomBackColor = true;
            this.btnReset.UseMnemonic = false;
            this.btnReset.UseSelectable = true;
            this.btnReset.UseStyleColors = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCambiar.Location = new System.Drawing.Point(32, 146);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(114, 23);
            this.btnCambiar.Style = MetroFramework.MetroColorStyle.White;
            this.btnCambiar.TabIndex = 7;
            this.btnCambiar.Text = "Cambiar Nombre";
            this.btnCambiar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCambiar.UseCustomBackColor = true;
            this.btnCambiar.UseMnemonic = false;
            this.btnCambiar.UseSelectable = true;
            this.btnCambiar.UseStyleColors = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // AllForm
            // 
            this.AcceptButton = this.btnCambiar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(324, 192);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AllForm";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Modifica Varias Carpetas";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPath;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroButton btnCambiar;
    }
}