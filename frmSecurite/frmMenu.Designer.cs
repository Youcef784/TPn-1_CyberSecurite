namespace frmSecurite
{
    partial class frmMenu
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
            grpProfil = new GroupBox();
            txtNiveau = new TextBox();
            lblNiveau = new Label();
            txtID = new TextBox();
            lbid = new Label();
            btnValider = new Button();
            MFAcheck = new CheckBox();
            grpUtilisateur = new GroupBox();
            lsbUtilisateur = new ListBox();
            btnValide = new Button();
            cmbIDprofil = new ComboBox();
            txtMdp = new TextBox();
            txtemail = new TextBox();
            txtnom = new TextBox();
            txtID1 = new TextBox();
            lblIDprofil = new Label();
            lblmdp = new Label();
            lblemail = new Label();
            lblnom = new Label();
            lblID = new Label();
            grpProfil.SuspendLayout();
            grpUtilisateur.SuspendLayout();
            SuspendLayout();
            // 
            // grpProfil
            // 
            grpProfil.Controls.Add(txtNiveau);
            grpProfil.Controls.Add(lblNiveau);
            grpProfil.Controls.Add(txtID);
            grpProfil.Controls.Add(lbid);
            grpProfil.Controls.Add(btnValider);
            grpProfil.Controls.Add(MFAcheck);
            grpProfil.Location = new Point(12, 27);
            grpProfil.Name = "grpProfil";
            grpProfil.Size = new Size(309, 208);
            grpProfil.TabIndex = 0;
            grpProfil.TabStop = false;
            grpProfil.Text = "Profil";
            // 
            // txtNiveau
            // 
            txtNiveau.Location = new Point(78, 82);
            txtNiveau.Name = "txtNiveau";
            txtNiveau.Size = new Size(150, 31);
            txtNiveau.TabIndex = 5;
            // 
            // lblNiveau
            // 
            lblNiveau.AutoSize = true;
            lblNiveau.Location = new Point(6, 79);
            lblNiveau.Name = "lblNiveau";
            lblNiveau.Size = new Size(66, 25);
            lblNiveau.TabIndex = 4;
            lblNiveau.Text = "Niveau";
            // 
            // txtID
            // 
            txtID.Location = new Point(78, 45);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 3;
            // 
            // lbid
            // 
            lbid.AutoSize = true;
            lbid.Location = new Point(6, 38);
            lbid.Name = "lbid";
            lbid.Size = new Size(30, 25);
            lbid.TabIndex = 2;
            lbid.Text = "ID";
            // 
            // btnValider
            // 
            btnValider.Location = new Point(69, 154);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(112, 34);
            btnValider.TabIndex = 1;
            btnValider.Text = "valider";
            btnValider.UseVisualStyleBackColor = true;
            // 
            // MFAcheck
            // 
            MFAcheck.AutoSize = true;
            MFAcheck.Location = new Point(83, 119);
            MFAcheck.Name = "MFAcheck";
            MFAcheck.Size = new Size(74, 29);
            MFAcheck.TabIndex = 0;
            MFAcheck.Text = "MFA";
            MFAcheck.UseVisualStyleBackColor = true;
            // 
            // grpUtilisateur
            // 
            grpUtilisateur.Controls.Add(lsbUtilisateur);
            grpUtilisateur.Controls.Add(btnValide);
            grpUtilisateur.Controls.Add(cmbIDprofil);
            grpUtilisateur.Controls.Add(txtMdp);
            grpUtilisateur.Controls.Add(txtemail);
            grpUtilisateur.Controls.Add(txtnom);
            grpUtilisateur.Controls.Add(txtID1);
            grpUtilisateur.Controls.Add(lblIDprofil);
            grpUtilisateur.Controls.Add(lblmdp);
            grpUtilisateur.Controls.Add(lblemail);
            grpUtilisateur.Controls.Add(lblnom);
            grpUtilisateur.Controls.Add(lblID);
            grpUtilisateur.Location = new Point(488, 27);
            grpUtilisateur.Name = "grpUtilisateur";
            grpUtilisateur.Size = new Size(300, 411);
            grpUtilisateur.TabIndex = 0;
            grpUtilisateur.TabStop = false;
            grpUtilisateur.Text = "Utilisateur";
            // 
            // lsbUtilisateur
            // 
            lsbUtilisateur.FormattingEnabled = true;
            lsbUtilisateur.Location = new Point(84, 276);
            lsbUtilisateur.Name = "lsbUtilisateur";
            lsbUtilisateur.Size = new Size(180, 129);
            lsbUtilisateur.TabIndex = 1;
            lsbUtilisateur.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnValide
            // 
            btnValide.Location = new Point(114, 236);
            btnValide.Name = "btnValide";
            btnValide.Size = new Size(112, 34);
            btnValide.TabIndex = 1;
            btnValide.Text = "Valider";
            btnValide.UseVisualStyleBackColor = true;
            // 
            // cmbIDprofil
            // 
            cmbIDprofil.FormattingEnabled = true;
            cmbIDprofil.Location = new Point(99, 197);
            cmbIDprofil.Name = "cmbIDprofil";
            cmbIDprofil.Size = new Size(182, 33);
            cmbIDprofil.TabIndex = 12;
            cmbIDprofil.SelectedIndexChanged += cmbIDprofil_SelectedIndexChanged;
            // 
            // txtMdp
            // 
            txtMdp.Location = new Point(114, 157);
            txtMdp.Name = "txtMdp";
            txtMdp.Size = new Size(150, 31);
            txtMdp.TabIndex = 10;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(114, 119);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(150, 31);
            txtemail.TabIndex = 9;
            // 
            // txtnom
            // 
            txtnom.Location = new Point(114, 82);
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(150, 31);
            txtnom.TabIndex = 8;
            // 
            // txtID1
            // 
            txtID1.Location = new Point(114, 38);
            txtID1.Name = "txtID1";
            txtID1.Size = new Size(150, 31);
            txtID1.TabIndex = 7;
            // 
            // lblIDprofil
            // 
            lblIDprofil.AutoSize = true;
            lblIDprofil.Location = new Point(6, 205);
            lblIDprofil.Name = "lblIDprofil";
            lblIDprofil.Size = new Size(72, 25);
            lblIDprofil.TabIndex = 6;
            lblIDprofil.Text = "IDprofil";
            // 
            // lblmdp
            // 
            lblmdp.AutoSize = true;
            lblmdp.Location = new Point(6, 159);
            lblmdp.Name = "lblmdp";
            lblmdp.Size = new Size(50, 25);
            lblmdp.TabIndex = 4;
            lblmdp.Text = "Mdp";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(6, 119);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(54, 25);
            lblemail.TabIndex = 3;
            lblemail.Text = "Email";
            // 
            // lblnom
            // 
            lblnom.AutoSize = true;
            lblnom.Location = new Point(6, 79);
            lblnom.Name = "lblnom";
            lblnom.Size = new Size(52, 25);
            lblnom.TabIndex = 2;
            lblnom.Text = "Nom";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(6, 38);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 25);
            lblID.TabIndex = 1;
            lblID.Text = "ID";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpUtilisateur);
            Controls.Add(grpProfil);
            Name = "frmMenu";
            Text = "Form1";
            Load += frmMenu_Load;
            grpProfil.ResumeLayout(false);
            grpProfil.PerformLayout();
            grpUtilisateur.ResumeLayout(false);
            grpUtilisateur.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpProfil;
        private GroupBox grpUtilisateur;
        private Label lbid;
        private Button btnValider;
        private CheckBox MFAcheck;
        private Label lblNiveau;
        private TextBox txtID;
        private TextBox txtNiveau;
        private Button btnValide;
        private ComboBox cmbIDprofil;
        private TextBox txtMdp;
        private TextBox txtemail;
        private TextBox txtnom;
        private TextBox txtID1;
        private Label lblIDprofil;
        private Label lblmdp;
        private Label lblemail;
        private Label lblnom;
        private Label lblID;
        private ListBox lsbUtilisateur;
    }
}
