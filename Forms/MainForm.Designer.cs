namespace CambiaNombres.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.oneBtn = new MetroFramework.Controls.MetroButton();
            this.allBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // oneBtn
            // 
            this.oneBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.oneBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.oneBtn.Location = new System.Drawing.Point(32, 110);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(277, 37);
            this.oneBtn.TabIndex = 0;
            this.oneBtn.Text = "Modifica los capitulos de una carpeta";
            this.oneBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.oneBtn.UseCustomBackColor = true;
            this.oneBtn.UseMnemonic = false;
            this.oneBtn.UseSelectable = true;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // allBtn
            // 
            this.allBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.allBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.allBtn.Location = new System.Drawing.Point(32, 167);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(277, 37);
            this.allBtn.TabIndex = 1;
            this.allBtn.Text = "Modifica los capitulos de varias carpetas";
            this.allBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.allBtn.UseCustomBackColor = true;
            this.allBtn.UseMnemonic = false;
            this.allBtn.UseSelectable = true;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(340, 238);
            this.Controls.Add(this.allBtn);
            this.Controls.Add(this.oneBtn);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Piky Copy";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton oneBtn;
        private MetroFramework.Controls.MetroButton allBtn;
    }
}