namespace AS2122_4E_INF_GiacchettiManuel_GestioneArticoli
{
    partial class FrmMain
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
            this.lblcodice = new System.Windows.Forms.Label();
            this.lbldescrizione = new System.Windows.Forms.Label();
            this.lblunitadimisura = new System.Windows.Forms.Label();
            this.lblprezzo = new System.Windows.Forms.Label();
            this.txtcodice = new System.Windows.Forms.TextBox();
            this.txtdescrizione = new System.Windows.Forms.TextBox();
            this.txtprezzo = new System.Windows.Forms.TextBox();
            this.btnaggiungimodicaarticoli = new System.Windows.Forms.Button();
            this.cmbunitadimisura = new System.Windows.Forms.ComboBox();
            this.cmbViusalizza = new System.Windows.Forms.ComboBox();
            this.btnvisualizza = new System.Windows.Forms.Button();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            this.grbDettagliarticolo = new System.Windows.Forms.GroupBox();
            this.lblArticoli = new System.Windows.Forms.Label();
            this.grbDettagliarticolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcodice
            // 
            this.lblcodice.AutoSize = true;
            this.lblcodice.Location = new System.Drawing.Point(34, 38);
            this.lblcodice.Name = "lblcodice";
            this.lblcodice.Size = new System.Drawing.Size(44, 15);
            this.lblcodice.TabIndex = 0;
            this.lblcodice.Text = "Codice";
            // 
            // lbldescrizione
            // 
            this.lbldescrizione.AutoSize = true;
            this.lbldescrizione.Location = new System.Drawing.Point(33, 91);
            this.lbldescrizione.Name = "lbldescrizione";
            this.lbldescrizione.Size = new System.Drawing.Size(67, 15);
            this.lbldescrizione.TabIndex = 1;
            this.lbldescrizione.Text = "Descrizione";
            // 
            // lblunitadimisura
            // 
            this.lblunitadimisura.AutoSize = true;
            this.lblunitadimisura.Location = new System.Drawing.Point(34, 144);
            this.lblunitadimisura.Name = "lblunitadimisura";
            this.lblunitadimisura.Size = new System.Drawing.Size(87, 15);
            this.lblunitadimisura.TabIndex = 2;
            this.lblunitadimisura.Text = "Unita di Misura";
            // 
            // lblprezzo
            // 
            this.lblprezzo.AutoSize = true;
            this.lblprezzo.Location = new System.Drawing.Point(37, 195);
            this.lblprezzo.Name = "lblprezzo";
            this.lblprezzo.Size = new System.Drawing.Size(41, 15);
            this.lblprezzo.TabIndex = 3;
            this.lblprezzo.Text = "Prezzo";
            // 
            // txtcodice
            // 
            this.txtcodice.Location = new System.Drawing.Point(191, 38);
            this.txtcodice.Name = "txtcodice";
            this.txtcodice.Size = new System.Drawing.Size(100, 23);
            this.txtcodice.TabIndex = 4;
            // 
            // txtdescrizione
            // 
            this.txtdescrizione.Location = new System.Drawing.Point(191, 88);
            this.txtdescrizione.Name = "txtdescrizione";
            this.txtdescrizione.Size = new System.Drawing.Size(100, 23);
            this.txtdescrizione.TabIndex = 5;
            // 
            // txtprezzo
            // 
            this.txtprezzo.Location = new System.Drawing.Point(191, 187);
            this.txtprezzo.Name = "txtprezzo";
            this.txtprezzo.Size = new System.Drawing.Size(100, 23);
            this.txtprezzo.TabIndex = 6;
            // 
            // btnaggiungimodicaarticoli
            // 
            this.btnaggiungimodicaarticoli.Location = new System.Drawing.Point(95, 237);
            this.btnaggiungimodicaarticoli.Name = "btnaggiungimodicaarticoli";
            this.btnaggiungimodicaarticoli.Size = new System.Drawing.Size(153, 46);
            this.btnaggiungimodicaarticoli.TabIndex = 7;
            this.btnaggiungimodicaarticoli.Text = "Aggiungi Modifica Articoli";
            this.btnaggiungimodicaarticoli.UseVisualStyleBackColor = true;
            // 
            // cmbunitadimisura
            // 
            this.cmbunitadimisura.FormattingEnabled = true;
            this.cmbunitadimisura.Location = new System.Drawing.Point(191, 141);
            this.cmbunitadimisura.Name = "cmbunitadimisura";
            this.cmbunitadimisura.Size = new System.Drawing.Size(121, 23);
            this.cmbunitadimisura.TabIndex = 8;
            // 
            // cmbViusalizza
            // 
            this.cmbViusalizza.FormattingEnabled = true;
            this.cmbViusalizza.Location = new System.Drawing.Point(562, 50);
            this.cmbViusalizza.Name = "cmbViusalizza";
            this.cmbViusalizza.Size = new System.Drawing.Size(121, 23);
            this.cmbViusalizza.TabIndex = 9;
            // 
            // btnvisualizza
            // 
            this.btnvisualizza.Location = new System.Drawing.Point(713, 49);
            this.btnvisualizza.Name = "btnvisualizza";
            this.btnvisualizza.Size = new System.Drawing.Size(28, 24);
            this.btnvisualizza.TabIndex = 10;
            this.btnvisualizza.Text = "...";
            this.btnvisualizza.UseVisualStyleBackColor = true;
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 15;
            this.lstVisualizza.Location = new System.Drawing.Point(562, 91);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(226, 259);
            this.lstVisualizza.TabIndex = 11;
            // 
            // grbDettagliarticolo
            // 
            this.grbDettagliarticolo.Controls.Add(this.txtcodice);
            this.grbDettagliarticolo.Controls.Add(this.txtdescrizione);
            this.grbDettagliarticolo.Controls.Add(this.cmbunitadimisura);
            this.grbDettagliarticolo.Controls.Add(this.txtprezzo);
            this.grbDettagliarticolo.Controls.Add(this.lblcodice);
            this.grbDettagliarticolo.Controls.Add(this.lbldescrizione);
            this.grbDettagliarticolo.Controls.Add(this.lblunitadimisura);
            this.grbDettagliarticolo.Controls.Add(this.lblprezzo);
            this.grbDettagliarticolo.Controls.Add(this.btnaggiungimodicaarticoli);
            this.grbDettagliarticolo.Location = new System.Drawing.Point(61, 49);
            this.grbDettagliarticolo.Name = "grbDettagliarticolo";
            this.grbDettagliarticolo.Size = new System.Drawing.Size(396, 299);
            this.grbDettagliarticolo.TabIndex = 12;
            this.grbDettagliarticolo.TabStop = false;
            this.grbDettagliarticolo.Text = "Dettagli articolo";
            // 
            // lblArticoli
            // 
            this.lblArticoli.AutoSize = true;
            this.lblArticoli.Location = new System.Drawing.Point(91, 382);
            this.lblArticoli.Name = "lblArticoli";
            this.lblArticoli.Size = new System.Drawing.Size(45, 15);
            this.lblArticoli.TabIndex = 13;
            this.lblArticoli.Text = "Articoli";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArticoli);
            this.Controls.Add(this.grbDettagliarticolo);
            this.Controls.Add(this.lstVisualizza);
            this.Controls.Add(this.btnvisualizza);
            this.Controls.Add(this.cmbViusalizza);
            this.Name = "FrmMain";
            this.Text = "Prova singola 4E 18/05/2022 su form e dizionari, classi e utilizzo di GIT";
            this.grbDettagliarticolo.ResumeLayout(false);
            this.grbDettagliarticolo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblcodice;
        private Label lbldescrizione;
        private Label lblunitadimisura;
        private Label lblprezzo;
        private TextBox txtcodice;
        private TextBox txtdescrizione;
        private TextBox txtprezzo;
        private Button btnaggiungimodicaarticoli;
        private ComboBox cmbunitadimisura;
        private ComboBox cmbViusalizza;
        private Button btnvisualizza;
        private ListBox lstVisualizza;
        private GroupBox grbDettagliarticolo;
        private Label lblArticoli;
    }
}