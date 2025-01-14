﻿
namespace FijnstofGIP.FormsMenu
{
    partial class InstellingenGebuiker
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGebruikerForm = new System.Windows.Forms.Panel();
            this.pnlGebruikerMenuLinks = new System.Windows.Forms.Panel();
            this.BtnQRCodeAanmaken = new FontAwesome.Sharp.IconButton();
            this.btnEmailVeranderen = new FontAwesome.Sharp.IconButton();
            this.btnGebruikersnaamVeranderen = new FontAwesome.Sharp.IconButton();
            this.btnWWAanpassen = new FontAwesome.Sharp.IconButton();
            this.btnAdresVeranderen = new FontAwesome.Sharp.IconButton();
            this.btnTerugkeren = new System.Windows.Forms.Button();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.pnlGebruikerForm.SuspendLayout();
            this.pnlGebruikerMenuLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(265, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gebruikers instellingen";
            // 
            // pnlGebruikerForm
            // 
            this.pnlGebruikerForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGebruikerForm.Controls.Add(this.pnlGebruikerMenuLinks);
            this.pnlGebruikerForm.Location = new System.Drawing.Point(12, 61);
            this.pnlGebruikerForm.Name = "pnlGebruikerForm";
            this.pnlGebruikerForm.Size = new System.Drawing.Size(736, 463);
            this.pnlGebruikerForm.TabIndex = 2;
            // 
            // pnlGebruikerMenuLinks
            // 
            this.pnlGebruikerMenuLinks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGebruikerMenuLinks.Controls.Add(this.BtnQRCodeAanmaken);
            this.pnlGebruikerMenuLinks.Controls.Add(this.btnEmailVeranderen);
            this.pnlGebruikerMenuLinks.Controls.Add(this.btnGebruikersnaamVeranderen);
            this.pnlGebruikerMenuLinks.Controls.Add(this.btnWWAanpassen);
            this.pnlGebruikerMenuLinks.Controls.Add(this.btnAdresVeranderen);
            this.pnlGebruikerMenuLinks.Location = new System.Drawing.Point(3, 39);
            this.pnlGebruikerMenuLinks.Name = "pnlGebruikerMenuLinks";
            this.pnlGebruikerMenuLinks.Size = new System.Drawing.Size(267, 402);
            this.pnlGebruikerMenuLinks.TabIndex = 0;
            // 
            // BtnQRCodeAanmaken
            // 
            this.BtnQRCodeAanmaken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnQRCodeAanmaken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQRCodeAanmaken.FlatAppearance.BorderSize = 0;
            this.BtnQRCodeAanmaken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQRCodeAanmaken.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQRCodeAanmaken.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnQRCodeAanmaken.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.BtnQRCodeAanmaken.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnQRCodeAanmaken.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnQRCodeAanmaken.IconSize = 34;
            this.BtnQRCodeAanmaken.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnQRCodeAanmaken.Location = new System.Drawing.Point(3, 261);
            this.BtnQRCodeAanmaken.Name = "BtnQRCodeAanmaken";
            this.BtnQRCodeAanmaken.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.BtnQRCodeAanmaken.Size = new System.Drawing.Size(252, 60);
            this.BtnQRCodeAanmaken.TabIndex = 6;
            this.BtnQRCodeAanmaken.Text = "QR Code aanmaken";
            this.BtnQRCodeAanmaken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQRCodeAanmaken.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQRCodeAanmaken.UseVisualStyleBackColor = true;
            this.BtnQRCodeAanmaken.Click += new System.EventHandler(this.BtnQRCodeAanmaken_Click);
            // 
            // btnEmailVeranderen
            // 
            this.btnEmailVeranderen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEmailVeranderen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmailVeranderen.FlatAppearance.BorderSize = 0;
            this.btnEmailVeranderen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmailVeranderen.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailVeranderen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEmailVeranderen.IconChar = FontAwesome.Sharp.IconChar.At;
            this.btnEmailVeranderen.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEmailVeranderen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmailVeranderen.IconSize = 34;
            this.btnEmailVeranderen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEmailVeranderen.Location = new System.Drawing.Point(3, 204);
            this.btnEmailVeranderen.Name = "btnEmailVeranderen";
            this.btnEmailVeranderen.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.btnEmailVeranderen.Size = new System.Drawing.Size(252, 60);
            this.btnEmailVeranderen.TabIndex = 5;
            this.btnEmailVeranderen.Text = "Email veranderen";
            this.btnEmailVeranderen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmailVeranderen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmailVeranderen.UseVisualStyleBackColor = true;
            this.btnEmailVeranderen.Click += new System.EventHandler(this.btnEmailVeranderen_Click);
            // 
            // btnGebruikersnaamVeranderen
            // 
            this.btnGebruikersnaamVeranderen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGebruikersnaamVeranderen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGebruikersnaamVeranderen.FlatAppearance.BorderSize = 0;
            this.btnGebruikersnaamVeranderen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGebruikersnaamVeranderen.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGebruikersnaamVeranderen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGebruikersnaamVeranderen.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnGebruikersnaamVeranderen.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGebruikersnaamVeranderen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGebruikersnaamVeranderen.IconSize = 34;
            this.btnGebruikersnaamVeranderen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGebruikersnaamVeranderen.Location = new System.Drawing.Point(3, 138);
            this.btnGebruikersnaamVeranderen.Name = "btnGebruikersnaamVeranderen";
            this.btnGebruikersnaamVeranderen.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.btnGebruikersnaamVeranderen.Size = new System.Drawing.Size(255, 60);
            this.btnGebruikersnaamVeranderen.TabIndex = 4;
            this.btnGebruikersnaamVeranderen.Text = "Gebruikersnaam veranderen";
            this.btnGebruikersnaamVeranderen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGebruikersnaamVeranderen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGebruikersnaamVeranderen.UseVisualStyleBackColor = true;
            this.btnGebruikersnaamVeranderen.Click += new System.EventHandler(this.btnGebruikersnaamVeranderen_Click);
            // 
            // btnWWAanpassen
            // 
            this.btnWWAanpassen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWWAanpassen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWWAanpassen.FlatAppearance.BorderSize = 0;
            this.btnWWAanpassen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWWAanpassen.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWWAanpassen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnWWAanpassen.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.btnWWAanpassen.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnWWAanpassen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWWAanpassen.IconSize = 34;
            this.btnWWAanpassen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnWWAanpassen.Location = new System.Drawing.Point(3, 6);
            this.btnWWAanpassen.Name = "btnWWAanpassen";
            this.btnWWAanpassen.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.btnWWAanpassen.Size = new System.Drawing.Size(252, 60);
            this.btnWWAanpassen.TabIndex = 2;
            this.btnWWAanpassen.Text = "Wachtwoord veranderen";
            this.btnWWAanpassen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWWAanpassen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWWAanpassen.UseVisualStyleBackColor = true;
            this.btnWWAanpassen.Click += new System.EventHandler(this.btnWWAanpassen_Click);
            // 
            // btnAdresVeranderen
            // 
            this.btnAdresVeranderen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdresVeranderen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdresVeranderen.FlatAppearance.BorderSize = 0;
            this.btnAdresVeranderen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdresVeranderen.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdresVeranderen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdresVeranderen.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.btnAdresVeranderen.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdresVeranderen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdresVeranderen.IconSize = 34;
            this.btnAdresVeranderen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdresVeranderen.Location = new System.Drawing.Point(3, 72);
            this.btnAdresVeranderen.Name = "btnAdresVeranderen";
            this.btnAdresVeranderen.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.btnAdresVeranderen.Size = new System.Drawing.Size(252, 60);
            this.btnAdresVeranderen.TabIndex = 3;
            this.btnAdresVeranderen.Text = "Adres veranderen";
            this.btnAdresVeranderen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdresVeranderen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdresVeranderen.UseVisualStyleBackColor = true;
            this.btnAdresVeranderen.Click += new System.EventHandler(this.btnAdresVeranderen_Click);
            // 
            // btnTerugkeren
            // 
            this.btnTerugkeren.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTerugkeren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerugkeren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerugkeren.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerugkeren.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTerugkeren.Location = new System.Drawing.Point(624, 487);
            this.btnTerugkeren.Name = "btnTerugkeren";
            this.btnTerugkeren.Size = new System.Drawing.Size(129, 34);
            this.btnTerugkeren.TabIndex = 6;
            this.btnTerugkeren.Text = "Terugkeren";
            this.btnTerugkeren.UseVisualStyleBackColor = true;
            this.btnTerugkeren.Visible = false;
            this.btnTerugkeren.Click += new System.EventHandler(this.btnTerugkeren_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(780, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 19;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // InstellingenGebuiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(807, 540);
            this.Controls.Add(this.btnTerugkeren);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGebruikerForm);
            this.Name = "InstellingenGebuiker";
            this.Text = "InstellingenGebuiker";
            this.pnlGebruikerForm.ResumeLayout(false);
            this.pnlGebruikerMenuLinks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGebruikerForm;
        private FontAwesome.Sharp.IconButton btnWWAanpassen;
        private FontAwesome.Sharp.IconButton btnGebruikersnaamVeranderen;
        private FontAwesome.Sharp.IconButton btnAdresVeranderen;
        private System.Windows.Forms.Panel pnlGebruikerMenuLinks;
        private System.Windows.Forms.Button btnTerugkeren;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconButton btnEmailVeranderen;
        private FontAwesome.Sharp.IconButton BtnQRCodeAanmaken;
    }
}