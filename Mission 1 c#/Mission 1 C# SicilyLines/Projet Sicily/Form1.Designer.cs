
namespace Projet_Sicily
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb = new System.Windows.Forms.ListBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnInserer = new System.Windows.Forms.Button();
            this.tbInserer = new System.Windows.Forms.TextBox();
            this.tbModif = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.menuAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInserer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuppr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModif = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 17;
            this.lb.Location = new System.Drawing.Point(0, 26);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(240, 378);
            this.lb.TabIndex = 1;
            this.lb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_MouseClick);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppr.Location = new System.Drawing.Point(410, 180);
            this.btnSuppr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(74, 23);
            this.btnSuppr.TabIndex = 2;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnInserer
            // 
            this.btnInserer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnInserer.Location = new System.Drawing.Point(410, 280);
            this.btnInserer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInserer.Name = "btnInserer";
            this.btnInserer.Size = new System.Drawing.Size(74, 23);
            this.btnInserer.TabIndex = 3;
            this.btnInserer.Text = "Insérer";
            this.btnInserer.UseVisualStyleBackColor = true;
            this.btnInserer.Click += new System.EventHandler(this.btnInserer_Click);
            // 
            // tbInserer
            // 
            this.tbInserer.Location = new System.Drawing.Point(316, 255);
            this.tbInserer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbInserer.Name = "tbInserer";
            this.tbInserer.Size = new System.Drawing.Size(258, 20);
            this.tbInserer.TabIndex = 4;
            // 
            // tbModif
            // 
            this.tbModif.Location = new System.Drawing.Point(316, 255);
            this.tbModif.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbModif.Name = "tbModif";
            this.tbModif.Size = new System.Drawing.Size(258, 20);
            this.tbModif.TabIndex = 5;
            // 
            // btnModif
            // 
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnModif.Location = new System.Drawing.Point(410, 280);
            this.btnModif.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(74, 23);
            this.btnModif.TabIndex = 6;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // menuAccueil
            // 
            this.menuAccueil.Name = "menuAccueil";
            this.menuAccueil.Size = new System.Drawing.Size(58, 20);
            this.menuAccueil.Text = "Accueil";
            this.menuAccueil.Click += new System.EventHandler(this.menuAccueil_Click);
            // 
            // menuOp
            // 
            this.menuOp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInserer,
            this.menuSuppr,
            this.menuModif});
            this.menuOp.Name = "menuOp";
            this.menuOp.Size = new System.Drawing.Size(77, 20);
            this.menuOp.Text = "Opérations";
            // 
            // menuInserer
            // 
            this.menuInserer.Name = "menuInserer";
            this.menuInserer.Size = new System.Drawing.Size(129, 22);
            this.menuInserer.Text = "Insérer";
            this.menuInserer.Click += new System.EventHandler(this.menuInserer_Click);
            // 
            // menuSuppr
            // 
            this.menuSuppr.Name = "menuSuppr";
            this.menuSuppr.Size = new System.Drawing.Size(129, 22);
            this.menuSuppr.Text = "Supprimer";
            this.menuSuppr.Click += new System.EventHandler(this.menuSuppr_Click);
            // 
            // menuModif
            // 
            this.menuModif.Name = "menuModif";
            this.menuModif.Size = new System.Drawing.Size(129, 22);
            this.menuModif.Text = "Modifier";
            this.menuModif.Click += new System.EventHandler(this.menuModif_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAccueil,
            this.menuOp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "SicilyLines";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(245, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bienvenue sur votre espace administrateur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.tbModif);
            this.Controls.Add(this.tbInserer);
            this.Controls.Add(this.btnInserer);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Compagnie Sicily";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnInserer;
        private System.Windows.Forms.TextBox tbInserer;
        private System.Windows.Forms.TextBox tbModif;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.ToolStripMenuItem menuAccueil;
        private System.Windows.Forms.ToolStripMenuItem menuOp;
        private System.Windows.Forms.ToolStripMenuItem menuInserer;
        private System.Windows.Forms.ToolStripMenuItem menuSuppr;
        private System.Windows.Forms.ToolStripMenuItem menuModif;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

