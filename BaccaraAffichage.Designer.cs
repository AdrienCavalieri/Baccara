namespace Baccara
{
    partial class Baccara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baccara));
            this.boutonDémarrer = new System.Windows.Forms.Button();
            this.boutonPlusUn = new System.Windows.Forms.Button();
            this.boutonPlusDix = new System.Windows.Forms.Button();
            this.boutonPlusCent = new System.Windows.Forms.Button();
            this.boutonAnnulerMise = new System.Windows.Forms.Button();
            this.labelSolde = new System.Windows.Forms.Label();
            this.labelMise = new System.Windows.Forms.Label();
            this.labelJoueur = new System.Windows.Forms.Label();
            this.labelBanque = new System.Windows.Forms.Label();
            this.textBoxCartesJoueur1 = new System.Windows.Forms.TextBox();
            this.textBoxCartesBanque1 = new System.Windows.Forms.TextBox();
            this.BoutonRadioJoueur = new System.Windows.Forms.RadioButton();
            this.BoutonRadioEgalité = new System.Windows.Forms.RadioButton();
            this.BoutonRadioBanque = new System.Windows.Forms.RadioButton();
            this.textBoxScoreJoueur = new System.Windows.Forms.TextBox();
            this.textBoxScoreBanque = new System.Windows.Forms.TextBox();
            this.textboxPrincipale = new System.Windows.Forms.TextBox();
            this.textBoxSolde = new System.Windows.Forms.TextBox();
            this.textBoxMise = new System.Windows.Forms.TextBox();
            this.groupBoxAffichage = new System.Windows.Forms.GroupBox();
            this.textBoxCartesBanque3 = new System.Windows.Forms.TextBox();
            this.textBoxCartesBanque2 = new System.Windows.Forms.TextBox();
            this.textBoxCartesJoueur3 = new System.Windows.Forms.TextBox();
            this.textBoxCartesJoueur2 = new System.Windows.Forms.TextBox();
            this.Scores = new System.Windows.Forms.Label();
            this.groupBoxMises = new System.Windows.Forms.GroupBox();
            this.boutonPlusMille = new System.Windows.Forms.Button();
            this.freqTriche = new System.Windows.Forms.GroupBox();
            this.labelActivationTriche = new System.Windows.Forms.Label();
            this.trackBarTriche = new System.Windows.Forms.TrackBar();
            this.programmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaccara = new System.Windows.Forms.MenuStrip();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAffichage.SuspendLayout();
            this.groupBoxMises.SuspendLayout();
            this.freqTriche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTriche)).BeginInit();
            this.menuBaccara.SuspendLayout();
            this.SuspendLayout();
            // 
            // boutonDémarrer
            // 
            this.boutonDémarrer.Location = new System.Drawing.Point(123, 102);
            this.boutonDémarrer.Name = "boutonDémarrer";
            this.boutonDémarrer.Size = new System.Drawing.Size(184, 27);
            this.boutonDémarrer.TabIndex = 0;
            this.boutonDémarrer.Text = "Démarrer";
            this.boutonDémarrer.UseVisualStyleBackColor = true;
            this.boutonDémarrer.Click += new System.EventHandler(this.boutonDémarrer_Click);
            // 
            // boutonPlusUn
            // 
            this.boutonPlusUn.Location = new System.Drawing.Point(94, 60);
            this.boutonPlusUn.Name = "boutonPlusUn";
            this.boutonPlusUn.Size = new System.Drawing.Size(57, 25);
            this.boutonPlusUn.TabIndex = 1;
            this.boutonPlusUn.Text = "+1";
            this.boutonPlusUn.UseVisualStyleBackColor = true;
            this.boutonPlusUn.Click += new System.EventHandler(this.boutonPlusUn_Click);
            // 
            // boutonPlusDix
            // 
            this.boutonPlusDix.Location = new System.Drawing.Point(188, 60);
            this.boutonPlusDix.Name = "boutonPlusDix";
            this.boutonPlusDix.Size = new System.Drawing.Size(57, 25);
            this.boutonPlusDix.TabIndex = 2;
            this.boutonPlusDix.Text = "+10";
            this.boutonPlusDix.UseVisualStyleBackColor = true;
            this.boutonPlusDix.Click += new System.EventHandler(this.boutonPlusDix_Click);
            // 
            // boutonPlusCent
            // 
            this.boutonPlusCent.Location = new System.Drawing.Point(284, 60);
            this.boutonPlusCent.Name = "boutonPlusCent";
            this.boutonPlusCent.Size = new System.Drawing.Size(57, 25);
            this.boutonPlusCent.TabIndex = 3;
            this.boutonPlusCent.Text = "+100";
            this.boutonPlusCent.UseVisualStyleBackColor = true;
            this.boutonPlusCent.Click += new System.EventHandler(this.boutonPlusCent_Click);
            // 
            // boutonAnnulerMise
            // 
            this.boutonAnnulerMise.Location = new System.Drawing.Point(10, 60);
            this.boutonAnnulerMise.Name = "boutonAnnulerMise";
            this.boutonAnnulerMise.Size = new System.Drawing.Size(57, 25);
            this.boutonAnnulerMise.TabIndex = 4;
            this.boutonAnnulerMise.Text = "RàZ";
            this.boutonAnnulerMise.UseVisualStyleBackColor = true;
            this.boutonAnnulerMise.Click += new System.EventHandler(this.boutonAnnulerMise_Click);
            // 
            // labelSolde
            // 
            this.labelSolde.AutoSize = true;
            this.labelSolde.Location = new System.Drawing.Point(4, 23);
            this.labelSolde.Name = "labelSolde";
            this.labelSolde.Size = new System.Drawing.Size(34, 13);
            this.labelSolde.TabIndex = 5;
            this.labelSolde.Text = "Solde";
            // 
            // labelMise
            // 
            this.labelMise.AutoSize = true;
            this.labelMise.Location = new System.Drawing.Point(409, 23);
            this.labelMise.Name = "labelMise";
            this.labelMise.Size = new System.Drawing.Size(29, 13);
            this.labelMise.TabIndex = 6;
            this.labelMise.Text = "Mise";
            // 
            // labelJoueur
            // 
            this.labelJoueur.AutoSize = true;
            this.labelJoueur.Location = new System.Drawing.Point(4, 77);
            this.labelJoueur.Name = "labelJoueur";
            this.labelJoueur.Size = new System.Drawing.Size(39, 13);
            this.labelJoueur.TabIndex = 7;
            this.labelJoueur.Text = "Joueur";
            // 
            // labelBanque
            // 
            this.labelBanque.AutoSize = true;
            this.labelBanque.Location = new System.Drawing.Point(394, 77);
            this.labelBanque.Name = "labelBanque";
            this.labelBanque.Size = new System.Drawing.Size(44, 13);
            this.labelBanque.TabIndex = 8;
            this.labelBanque.Text = "Banque";
            // 
            // textBoxCartesJoueur1
            // 
            this.textBoxCartesJoueur1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCartesJoueur1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxCartesJoueur1.Location = new System.Drawing.Point(6, 97);
            this.textBoxCartesJoueur1.Name = "textBoxCartesJoueur1";
            this.textBoxCartesJoueur1.ReadOnly = true;
            this.textBoxCartesJoueur1.Size = new System.Drawing.Size(32, 20);
            this.textBoxCartesJoueur1.TabIndex = 9;
            this.textBoxCartesJoueur1.TextChanged += new System.EventHandler(this.textBoxCartesTextChanged);
            // 
            // textBoxCartesBanque1
            // 
            this.textBoxCartesBanque1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCartesBanque1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxCartesBanque1.Location = new System.Drawing.Point(406, 97);
            this.textBoxCartesBanque1.Name = "textBoxCartesBanque1";
            this.textBoxCartesBanque1.ReadOnly = true;
            this.textBoxCartesBanque1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCartesBanque1.Size = new System.Drawing.Size(32, 20);
            this.textBoxCartesBanque1.TabIndex = 10;
            this.textBoxCartesBanque1.TextChanged += new System.EventHandler(this.textBoxCartesTextChanged);
            // 
            // BoutonRadioJoueur
            // 
            this.BoutonRadioJoueur.AutoSize = true;
            this.BoutonRadioJoueur.Checked = true;
            this.BoutonRadioJoueur.Location = new System.Drawing.Point(10, 23);
            this.BoutonRadioJoueur.Name = "BoutonRadioJoueur";
            this.BoutonRadioJoueur.Size = new System.Drawing.Size(57, 17);
            this.BoutonRadioJoueur.TabIndex = 11;
            this.BoutonRadioJoueur.TabStop = true;
            this.BoutonRadioJoueur.Text = "Joueur\r\n";
            this.BoutonRadioJoueur.UseVisualStyleBackColor = true;
            this.BoutonRadioJoueur.CheckedChanged += new System.EventHandler(this.BoutonRadioJoueur_CheckedChanged);
            // 
            // BoutonRadioEgalité
            // 
            this.BoutonRadioEgalité.AutoSize = true;
            this.BoutonRadioEgalité.Location = new System.Drawing.Point(188, 23);
            this.BoutonRadioEgalité.Name = "BoutonRadioEgalité";
            this.BoutonRadioEgalité.Size = new System.Drawing.Size(57, 17);
            this.BoutonRadioEgalité.TabIndex = 12;
            this.BoutonRadioEgalité.Text = "Egalité";
            this.BoutonRadioEgalité.UseVisualStyleBackColor = true;
            this.BoutonRadioEgalité.CheckedChanged += new System.EventHandler(this.BoutonRadioEgalité_CheckedChanged);
            // 
            // BoutonRadioBanque
            // 
            this.BoutonRadioBanque.AutoSize = true;
            this.BoutonRadioBanque.Location = new System.Drawing.Point(378, 23);
            this.BoutonRadioBanque.Name = "BoutonRadioBanque";
            this.BoutonRadioBanque.Size = new System.Drawing.Size(62, 17);
            this.BoutonRadioBanque.TabIndex = 13;
            this.BoutonRadioBanque.Text = "Banque";
            this.BoutonRadioBanque.UseVisualStyleBackColor = true;
            this.BoutonRadioBanque.CheckedChanged += new System.EventHandler(this.BoutonRadioBanque_CheckedChanged);
            // 
            // textBoxScoreJoueur
            // 
            this.textBoxScoreJoueur.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxScoreJoueur.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxScoreJoueur.Location = new System.Drawing.Point(175, 97);
            this.textBoxScoreJoueur.Name = "textBoxScoreJoueur";
            this.textBoxScoreJoueur.ReadOnly = true;
            this.textBoxScoreJoueur.Size = new System.Drawing.Size(21, 20);
            this.textBoxScoreJoueur.TabIndex = 14;
            // 
            // textBoxScoreBanque
            // 
            this.textBoxScoreBanque.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxScoreBanque.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxScoreBanque.Location = new System.Drawing.Point(251, 97);
            this.textBoxScoreBanque.Name = "textBoxScoreBanque";
            this.textBoxScoreBanque.ReadOnly = true;
            this.textBoxScoreBanque.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxScoreBanque.Size = new System.Drawing.Size(21, 20);
            this.textBoxScoreBanque.TabIndex = 15;
            // 
            // textboxPrincipale
            // 
            this.textboxPrincipale.BackColor = System.Drawing.SystemColors.Window;
            this.textboxPrincipale.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textboxPrincipale.Location = new System.Drawing.Point(7, 126);
            this.textboxPrincipale.Multiline = true;
            this.textboxPrincipale.Name = "textboxPrincipale";
            this.textboxPrincipale.ReadOnly = true;
            this.textboxPrincipale.Size = new System.Drawing.Size(432, 40);
            this.textboxPrincipale.TabIndex = 16;
            // 
            // textBoxSolde
            // 
            this.textBoxSolde.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSolde.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxSolde.Location = new System.Drawing.Point(6, 39);
            this.textBoxSolde.Name = "textBoxSolde";
            this.textBoxSolde.ReadOnly = true;
            this.textBoxSolde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSolde.Size = new System.Drawing.Size(106, 20);
            this.textBoxSolde.TabIndex = 17;
            this.textBoxSolde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cacherBarre);
            // 
            // textBoxMise
            // 
            this.textBoxMise.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMise.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxMise.Location = new System.Drawing.Point(326, 39);
            this.textBoxMise.Name = "textBoxMise";
            this.textBoxMise.ReadOnly = true;
            this.textBoxMise.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxMise.Size = new System.Drawing.Size(112, 20);
            this.textBoxMise.TabIndex = 18;
            // 
            // groupBoxAffichage
            // 
            this.groupBoxAffichage.Controls.Add(this.textBoxCartesBanque3);
            this.groupBoxAffichage.Controls.Add(this.textBoxCartesBanque2);
            this.groupBoxAffichage.Controls.Add(this.textBoxCartesJoueur3);
            this.groupBoxAffichage.Controls.Add(this.textBoxCartesJoueur2);
            this.groupBoxAffichage.Controls.Add(this.Scores);
            this.groupBoxAffichage.Controls.Add(this.labelSolde);
            this.groupBoxAffichage.Controls.Add(this.textboxPrincipale);
            this.groupBoxAffichage.Controls.Add(this.textBoxMise);
            this.groupBoxAffichage.Controls.Add(this.textBoxScoreJoueur);
            this.groupBoxAffichage.Controls.Add(this.textBoxScoreBanque);
            this.groupBoxAffichage.Controls.Add(this.textBoxSolde);
            this.groupBoxAffichage.Controls.Add(this.labelMise);
            this.groupBoxAffichage.Controls.Add(this.labelBanque);
            this.groupBoxAffichage.Controls.Add(this.textBoxCartesJoueur1);
            this.groupBoxAffichage.Controls.Add(this.textBoxCartesBanque1);
            this.groupBoxAffichage.Controls.Add(this.labelJoueur);
            this.groupBoxAffichage.Location = new System.Drawing.Point(9, 27);
            this.groupBoxAffichage.Name = "groupBoxAffichage";
            this.groupBoxAffichage.Size = new System.Drawing.Size(446, 176);
            this.groupBoxAffichage.TabIndex = 19;
            this.groupBoxAffichage.TabStop = false;
            this.groupBoxAffichage.Text = "Affichage";
            // 
            // textBoxCartesBanque3
            // 
            this.textBoxCartesBanque3.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCartesBanque3.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxCartesBanque3.Location = new System.Drawing.Point(326, 97);
            this.textBoxCartesBanque3.Name = "textBoxCartesBanque3";
            this.textBoxCartesBanque3.ReadOnly = true;
            this.textBoxCartesBanque3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCartesBanque3.Size = new System.Drawing.Size(34, 20);
            this.textBoxCartesBanque3.TabIndex = 26;
            this.textBoxCartesBanque3.TextChanged += new System.EventHandler(this.textBoxCartesTextChanged);
            // 
            // textBoxCartesBanque2
            // 
            this.textBoxCartesBanque2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCartesBanque2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxCartesBanque2.Location = new System.Drawing.Point(366, 97);
            this.textBoxCartesBanque2.Name = "textBoxCartesBanque2";
            this.textBoxCartesBanque2.ReadOnly = true;
            this.textBoxCartesBanque2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCartesBanque2.Size = new System.Drawing.Size(34, 20);
            this.textBoxCartesBanque2.TabIndex = 25;
            // 
            // textBoxCartesJoueur3
            // 
            this.textBoxCartesJoueur3.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCartesJoueur3.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxCartesJoueur3.Location = new System.Drawing.Point(81, 97);
            this.textBoxCartesJoueur3.Name = "textBoxCartesJoueur3";
            this.textBoxCartesJoueur3.ReadOnly = true;
            this.textBoxCartesJoueur3.Size = new System.Drawing.Size(31, 20);
            this.textBoxCartesJoueur3.TabIndex = 22;
            this.textBoxCartesJoueur3.TextChanged += new System.EventHandler(this.textBoxCartesTextChanged);
            // 
            // textBoxCartesJoueur2
            // 
            this.textBoxCartesJoueur2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCartesJoueur2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBoxCartesJoueur2.Location = new System.Drawing.Point(44, 97);
            this.textBoxCartesJoueur2.Name = "textBoxCartesJoueur2";
            this.textBoxCartesJoueur2.ReadOnly = true;
            this.textBoxCartesJoueur2.Size = new System.Drawing.Size(31, 20);
            this.textBoxCartesJoueur2.TabIndex = 20;
            this.textBoxCartesJoueur2.TextChanged += new System.EventHandler(this.textBoxCartesTextChanged);
            // 
            // Scores
            // 
            this.Scores.Location = new System.Drawing.Point(202, 100);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(43, 23);
            this.Scores.TabIndex = 19;
            this.Scores.Text = "Scores";
            // 
            // groupBoxMises
            // 
            this.groupBoxMises.Controls.Add(this.boutonDémarrer);
            this.groupBoxMises.Controls.Add(this.boutonPlusMille);
            this.groupBoxMises.Controls.Add(this.BoutonRadioBanque);
            this.groupBoxMises.Controls.Add(this.boutonPlusDix);
            this.groupBoxMises.Controls.Add(this.boutonPlusCent);
            this.groupBoxMises.Controls.Add(this.boutonAnnulerMise);
            this.groupBoxMises.Controls.Add(this.BoutonRadioEgalité);
            this.groupBoxMises.Controls.Add(this.boutonPlusUn);
            this.groupBoxMises.Controls.Add(this.BoutonRadioJoueur);
            this.groupBoxMises.Location = new System.Drawing.Point(9, 209);
            this.groupBoxMises.Name = "groupBoxMises";
            this.groupBoxMises.Size = new System.Drawing.Size(446, 151);
            this.groupBoxMises.TabIndex = 19;
            this.groupBoxMises.TabStop = false;
            this.groupBoxMises.Text = "Mises";
            // 
            // boutonPlusMille
            // 
            this.boutonPlusMille.Location = new System.Drawing.Point(378, 60);
            this.boutonPlusMille.Name = "boutonPlusMille";
            this.boutonPlusMille.Size = new System.Drawing.Size(57, 25);
            this.boutonPlusMille.TabIndex = 14;
            this.boutonPlusMille.Text = "+1000";
            this.boutonPlusMille.UseVisualStyleBackColor = true;
            this.boutonPlusMille.Click += new System.EventHandler(this.boutonPlusMille_Click);
            // 
            // freqTriche
            // 
            this.freqTriche.Controls.Add(this.labelActivationTriche);
            this.freqTriche.Controls.Add(this.trackBarTriche);
            this.freqTriche.Location = new System.Drawing.Point(9, 366);
            this.freqTriche.Name = "freqTriche";
            this.freqTriche.Size = new System.Drawing.Size(447, 71);
            this.freqTriche.TabIndex = 21;
            this.freqTriche.TabStop = false;
            this.freqTriche.Text = "Contrôle de la triche";
            // 
            // labelActivationTriche
            // 
            this.labelActivationTriche.AutoSize = true;
            this.labelActivationTriche.Location = new System.Drawing.Point(208, 51);
            this.labelActivationTriche.Name = "labelActivationTriche";
            this.labelActivationTriche.Size = new System.Drawing.Size(0, 13);
            this.labelActivationTriche.TabIndex = 27;
            // 
            // trackBarTriche
            // 
            this.trackBarTriche.Location = new System.Drawing.Point(6, 19);
            this.trackBarTriche.Maximum = 100;
            this.trackBarTriche.Minimum = -100;
            this.trackBarTriche.Name = "trackBarTriche";
            this.trackBarTriche.Size = new System.Drawing.Size(428, 45);
            this.trackBarTriche.TabIndex = 0;
            this.trackBarTriche.TickFrequency = 10;
            this.trackBarTriche.Scroll += new System.EventHandler(this.TrackBarTricheScroll);
            // 
            // programmeToolStripMenuItem
            // 
            this.programmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePartieToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.programmeToolStripMenuItem.Name = "programmeToolStripMenuItem";
            this.programmeToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.programmeToolStripMenuItem.Text = "Programme";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // menuBaccara
            // 
            this.menuBaccara.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuBaccara.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmeToolStripMenuItem});
            this.menuBaccara.Location = new System.Drawing.Point(0, 0);
            this.menuBaccara.Name = "menuBaccara";
            this.menuBaccara.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuBaccara.Size = new System.Drawing.Size(467, 24);
            this.menuBaccara.TabIndex = 22;
            this.menuBaccara.Text = "menuBaccara";
            this.menuBaccara.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cacherBarre);
            // 
            // nouvellePartieToolStripMenuItem
            // 
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.nouvellePartieToolStripMenuItem.Text = "Nouvelle partie";
            this.nouvellePartieToolStripMenuItem.Click += new System.EventHandler(this.nouvellePartieToolStripMenuItem_Click);
            // 
            // Baccara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(467, 449);
            this.Controls.Add(this.freqTriche);
            this.Controls.Add(this.groupBoxMises);
            this.Controls.Add(this.groupBoxAffichage);
            this.Controls.Add(this.menuBaccara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBaccara;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Baccara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baccara";
            this.TextChanged += new System.EventHandler(this.textBoxCartesTextChanged);
            this.groupBoxAffichage.ResumeLayout(false);
            this.groupBoxAffichage.PerformLayout();
            this.groupBoxMises.ResumeLayout(false);
            this.groupBoxMises.PerformLayout();
            this.freqTriche.ResumeLayout(false);
            this.freqTriche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTriche)).EndInit();
            this.menuBaccara.ResumeLayout(false);
            this.menuBaccara.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TrackBar trackBarTriche;
        private System.Windows.Forms.GroupBox freqTriche;
        private System.Windows.Forms.Label Scores;
        private System.Windows.Forms.Button boutonPlusMille;
        private System.Windows.Forms.GroupBox groupBoxMises;
        private System.Windows.Forms.GroupBox groupBoxAffichage;

        #endregion

        private System.Windows.Forms.Button boutonDémarrer;
        private System.Windows.Forms.Button boutonPlusUn;
        private System.Windows.Forms.Button boutonPlusDix;
        private System.Windows.Forms.Button boutonPlusCent;
        private System.Windows.Forms.Button boutonAnnulerMise;
        private System.Windows.Forms.Label labelSolde;
        private System.Windows.Forms.Label labelMise;
        private System.Windows.Forms.Label labelJoueur;
        private System.Windows.Forms.Label labelBanque;
        private System.Windows.Forms.TextBox textBoxCartesJoueur1;
        private System.Windows.Forms.TextBox textBoxCartesBanque1;
        private System.Windows.Forms.RadioButton BoutonRadioJoueur;
        private System.Windows.Forms.RadioButton BoutonRadioEgalité;
        private System.Windows.Forms.RadioButton BoutonRadioBanque;
        private System.Windows.Forms.TextBox textBoxScoreJoueur;
        private System.Windows.Forms.TextBox textBoxScoreBanque;
        private System.Windows.Forms.TextBox textboxPrincipale;
        private System.Windows.Forms.TextBox textBoxSolde;
        private System.Windows.Forms.TextBox textBoxMise;
        private System.Windows.Forms.TextBox textBoxCartesJoueur3;
        private System.Windows.Forms.TextBox textBoxCartesJoueur2;
        private System.Windows.Forms.TextBox textBoxCartesBanque2;
        private System.Windows.Forms.TextBox textBoxCartesBanque3;
        private System.Windows.Forms.Label labelActivationTriche;
        private System.Windows.Forms.ToolStripMenuItem programmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuBaccara;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
    }
}

