
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
            this.menuAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInserer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuppr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModif = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBDepart = new System.Windows.Forms.TextBox();
            this.TBArrivee = new System.Windows.Forms.TextBox();
            this.TBTemps = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonChange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 22;
            this.lb.Location = new System.Drawing.Point(0, 54);
            this.lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(1040, 158);
            this.lb.TabIndex = 1;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppr.Location = new System.Drawing.Point(547, 222);
            this.btnSuppr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(99, 28);
            this.btnSuppr.TabIndex = 2;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // menuAccueil
            // 
            this.menuAccueil.Name = "menuAccueil";
            this.menuAccueil.Size = new System.Drawing.Size(71, 24);
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
            this.menuOp.Size = new System.Drawing.Size(96, 24);
            this.menuOp.Text = "Opérations";
            // 
            // menuInserer
            // 
            this.menuInserer.Name = "menuInserer";
            this.menuInserer.Size = new System.Drawing.Size(161, 26);
            this.menuInserer.Text = "Insérer";
            this.menuInserer.Click += new System.EventHandler(this.menuInserer_Click);
            // 
            // menuSuppr
            // 
            this.menuSuppr.Name = "menuSuppr";
            this.menuSuppr.Size = new System.Drawing.Size(161, 26);
            this.menuSuppr.Text = "Supprimer";
            this.menuSuppr.Click += new System.EventHandler(this.menuSuppr_Click);
            // 
            // menuModif
            // 
            this.menuModif.Name = "menuModif";
            this.menuModif.Size = new System.Drawing.Size(161, 26);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "SicilyLines";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(327, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(662, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bienvenue sur votre espace administrateur";
            // 
            // TBDepart
            // 
            this.TBDepart.Location = new System.Drawing.Point(14, 32);
            this.TBDepart.Name = "TBDepart";
            this.TBDepart.Size = new System.Drawing.Size(100, 22);
            this.TBDepart.TabIndex = 9;
            // 
            // TBArrivee
            // 
            this.TBArrivee.Location = new System.Drawing.Point(132, 32);
            this.TBArrivee.Name = "TBArrivee";
            this.TBArrivee.Size = new System.Drawing.Size(100, 22);
            this.TBArrivee.TabIndex = 10;
            // 
            // TBTemps
            // 
            this.TBTemps.Location = new System.Drawing.Point(247, 32);
            this.TBTemps.Name = "TBTemps";
            this.TBTemps.Size = new System.Drawing.Size(100, 22);
            this.TBTemps.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonChange);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBTemps);
            this.panel1.Controls.Add(this.TBDepart);
            this.panel1.Controls.Add(this.TBArrivee);
            this.panel1.Location = new System.Drawing.Point(399, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 74);
            this.panel1.TabIndex = 12;
            // 
            // ButtonChange
            // 
            this.ButtonChange.Location = new System.Drawing.Point(372, 32);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(75, 23);
            this.ButtonChange.TabIndex = 15;
            this.ButtonChange.Text = "button1";
            this.ButtonChange.UseVisualStyleBackColor = true;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Temps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ville Arrivée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ville Départ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Compagnie Sicily";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.ToolStripMenuItem menuAccueil;
        private System.Windows.Forms.ToolStripMenuItem menuOp;
        private System.Windows.Forms.ToolStripMenuItem menuInserer;
        private System.Windows.Forms.ToolStripMenuItem menuSuppr;
        private System.Windows.Forms.ToolStripMenuItem menuModif;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBDepart;
        private System.Windows.Forms.TextBox TBArrivee;
        private System.Windows.Forms.TextBox TBTemps;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

