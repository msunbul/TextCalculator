
namespace CalculateApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDilSecim = new System.Windows.Forms.Label();
            this.lblGecerliDil = new System.Windows.Forms.Label();
            this.lblKullaniciGiris = new System.Windows.Forms.Label();
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.lblİkinciSayi = new System.Windows.Forms.Label();
            this.lblSonuç = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnÇıkar = new System.Windows.Forms.Button();
            this.btnÇarp = new System.Windows.Forms.Button();
            this.btnBöl = new System.Windows.Forms.Button();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.txtİkinciSayi = new System.Windows.Forms.TextBox();
            this.txtSonuç = new System.Windows.Forms.TextBox();
            this.cbGeçerliDil = new System.Windows.Forms.ComboBox();
            this.txtGeçerliDil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDilSecim
            // 
            resources.ApplyResources(this.lblDilSecim, "lblDilSecim");
            this.lblDilSecim.Name = "lblDilSecim";
            // 
            // lblGecerliDil
            // 
            resources.ApplyResources(this.lblGecerliDil, "lblGecerliDil");
            this.lblGecerliDil.Name = "lblGecerliDil";
            // 
            // lblKullaniciGiris
            // 
            resources.ApplyResources(this.lblKullaniciGiris, "lblKullaniciGiris");
            this.lblKullaniciGiris.Name = "lblKullaniciGiris";
            // 
            // lblBirinciSayi
            // 
            resources.ApplyResources(this.lblBirinciSayi, "lblBirinciSayi");
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            // 
            // lblİkinciSayi
            // 
            resources.ApplyResources(this.lblİkinciSayi, "lblİkinciSayi");
            this.lblİkinciSayi.Name = "lblİkinciSayi";
            // 
            // lblSonuç
            // 
            resources.ApplyResources(this.lblSonuç, "lblSonuç");
            this.lblSonuç.Name = "lblSonuç";
            // 
            // btnTopla
            // 
            resources.ApplyResources(this.btnTopla, "btnTopla");
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnÇıkar
            // 
            resources.ApplyResources(this.btnÇıkar, "btnÇıkar");
            this.btnÇıkar.Name = "btnÇıkar";
            this.btnÇıkar.UseVisualStyleBackColor = true;
            this.btnÇıkar.Click += new System.EventHandler(this.btnÇıkar_Click);
            // 
            // btnÇarp
            // 
            resources.ApplyResources(this.btnÇarp, "btnÇarp");
            this.btnÇarp.Name = "btnÇarp";
            this.btnÇarp.UseVisualStyleBackColor = true;
            this.btnÇarp.Click += new System.EventHandler(this.btnÇarp_Click);
            // 
            // btnBöl
            // 
            resources.ApplyResources(this.btnBöl, "btnBöl");
            this.btnBöl.Name = "btnBöl";
            this.btnBöl.UseVisualStyleBackColor = true;
            this.btnBöl.Click += new System.EventHandler(this.btnBöl_Click);
            // 
            // txtBirinciSayi
            // 
            resources.ApplyResources(this.txtBirinciSayi, "txtBirinciSayi");
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            // 
            // txtİkinciSayi
            // 
            resources.ApplyResources(this.txtİkinciSayi, "txtİkinciSayi");
            this.txtİkinciSayi.Name = "txtİkinciSayi";
            // 
            // txtSonuç
            // 
            resources.ApplyResources(this.txtSonuç, "txtSonuç");
            this.txtSonuç.Name = "txtSonuç";
            // 
            // cbGeçerliDil
            // 
            resources.ApplyResources(this.cbGeçerliDil, "cbGeçerliDil");
            this.cbGeçerliDil.FormattingEnabled = true;
            this.cbGeçerliDil.Items.AddRange(new object[] {
            resources.GetString("cbGeçerliDil.Items"),
            resources.GetString("cbGeçerliDil.Items1")});
            this.cbGeçerliDil.Name = "cbGeçerliDil";
            this.cbGeçerliDil.SelectedIndexChanged += new System.EventHandler(this.cbGeçerliDil_SelectedIndexChanged);
            // 
            // txtGeçerliDil
            // 
            resources.ApplyResources(this.txtGeçerliDil, "txtGeçerliDil");
            this.txtGeçerliDil.Name = "txtGeçerliDil";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtGeçerliDil);
            this.Controls.Add(this.cbGeçerliDil);
            this.Controls.Add(this.txtSonuç);
            this.Controls.Add(this.txtİkinciSayi);
            this.Controls.Add(this.txtBirinciSayi);
            this.Controls.Add(this.btnBöl);
            this.Controls.Add(this.btnÇarp);
            this.Controls.Add(this.btnÇıkar);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.lblSonuç);
            this.Controls.Add(this.lblİkinciSayi);
            this.Controls.Add(this.lblBirinciSayi);
            this.Controls.Add(this.lblKullaniciGiris);
            this.Controls.Add(this.lblGecerliDil);
            this.Controls.Add(this.lblDilSecim);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDilSecim;
        private System.Windows.Forms.Label lblGecerliDil;
        private System.Windows.Forms.Label lblKullaniciGiris;
        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.Label lblİkinciSayi;
        private System.Windows.Forms.Label lblSonuç;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnÇıkar;
        private System.Windows.Forms.Button btnÇarp;
        private System.Windows.Forms.Button btnBöl;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.TextBox txtİkinciSayi;
        private System.Windows.Forms.TextBox txtSonuç;
        private System.Windows.Forms.ComboBox cbGeçerliDil;
        private System.Windows.Forms.TextBox txtGeçerliDil;
    }
}

