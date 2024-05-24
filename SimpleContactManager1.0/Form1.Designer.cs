namespace SimpleContactManager
{
    // Część klasy Form1 zawiera definicję interfejsu użytkownika w aplikacji okienkowej.
    partial class Form1
    {
        // Deklaracja zmiennych dla komponentów interfejsu użytkownika.
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;

        // Metoda InitializeComponent jest generowana automatycznie i inicjalizuje komponenty interfejsu użytkownika.
        private void InitializeComponent()
        {
            // Inicjalizacja listy kontaktów.
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxContacts
            // 
            // Konfiguracja listy kontaktów.
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.ItemHeight = 16;
            this.listBoxContacts.Location = new System.Drawing.Point(12, 12);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(200, 228);
            this.listBoxContacts.TabIndex = 0;
            // 
            // btnAdd
            // 
            // Konfiguracja przycisku Dodaj.
            this.btnAdd.Location = new System.Drawing.Point(230, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            // Konfiguracja przycisku Usuń.
            this.btnRemove.Location = new System.Drawing.Point(230, 210);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtName
            // 
            // Konfiguracja pola tekstowego dla nazwy.
            this.txtName.Location = new System.Drawing.Point(230, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            // Konfiguracja pola tekstowego dla adresu e-mail.
            this.txtEmail.Location = new System.Drawing.Point(230, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            // Konfiguracja pola tekstowego dla numeru telefonu.
            this.txtPhoneNumber.Location = new System.Drawing.Point(230, 130);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // lblName
            // 
            // Konfiguracja etykiety dla nazwy.
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(230, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            // Konfiguracja etykiety dla adresu e-mail.
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(230, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            // Konfiguracja etykiety dla numeru telefonu.
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(230, 110);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // Form1
            // 
            // Konfiguracja głównego okna aplikacji.
            this.ClientSize = new System.Drawing.Size(344, 253);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxContacts);
            this.Name = "Form1";
            this.Text = "Contact Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
