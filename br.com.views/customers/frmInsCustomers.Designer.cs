namespace salesControl.br.com.views.customers
{
    partial class frmInsCustomers
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
            txtId = new TextBox();
            lblId = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblRG = new Label();
            lblCPF = new Label();
            txtRG = new TextBox();
            mTxtCPF = new MaskedTextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            mTxtPhone = new MaskedTextBox();
            lblPhone = new Label();
            mTxtPostalCode = new MaskedTextBox();
            lblPostalCode = new Label();
            lblStreet = new Label();
            txtStreet = new TextBox();
            lblHouseNumber = new Label();
            txtHouseNumber = new TextBox();
            lblNeighborhood = new Label();
            txtNeighborhood = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblUF = new Label();
            btnInsert = new Button();
            cbxUF = new ComboBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(55, 76);
            txtId.Name = "txtId";
            txtId.Size = new Size(119, 23);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(55, 49);
            lblId.Name = "lblId";
            lblId.Size = new Size(48, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Código:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(55, 133);
            lblName.Name = "lblName";
            lblName.Size = new Size(97, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Nome completo:";
            // 
            // txtName
            // 
            txtName.Location = new Point(55, 160);
            txtName.Name = "txtName";
            txtName.Size = new Size(443, 23);
            txtName.TabIndex = 2;
            // 
            // lblRG
            // 
            lblRG.AutoSize = true;
            lblRG.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRG.Location = new Point(522, 133);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(25, 15);
            lblRG.TabIndex = 5;
            lblRG.Text = "RG:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCPF.Location = new Point(750, 133);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(30, 15);
            lblCPF.TabIndex = 7;
            lblCPF.Text = "CPF:";
            // 
            // txtRG
            // 
            txtRG.Location = new Point(522, 160);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(206, 23);
            txtRG.TabIndex = 4;
            // 
            // mTxtCPF
            // 
            mTxtCPF.Location = new Point(750, 160);
            mTxtCPF.Name = "mTxtCPF";
            mTxtCPF.Size = new Size(157, 23);
            mTxtCPF.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(55, 231);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(55, 258);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(443, 23);
            txtEmail.TabIndex = 9;
            // 
            // mTxtPhone
            // 
            mTxtPhone.Location = new Point(522, 258);
            mTxtPhone.Name = "mTxtPhone";
            mTxtPhone.Size = new Size(206, 23);
            mTxtPhone.TabIndex = 12;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(522, 231);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(52, 15);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "Contato:";
            // 
            // mTxtPostalCode
            // 
            mTxtPostalCode.Location = new Point(55, 345);
            mTxtPostalCode.Name = "mTxtPostalCode";
            mTxtPostalCode.Size = new Size(206, 23);
            mTxtPostalCode.TabIndex = 14;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostalCode.Location = new Point(55, 318);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(30, 15);
            lblPostalCode.TabIndex = 13;
            lblPostalCode.Text = "CEP:";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStreet.Location = new Point(285, 318);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(72, 15);
            lblStreet.TabIndex = 16;
            lblStreet.Text = "Logradouro:";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(285, 345);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(443, 23);
            txtStreet.TabIndex = 15;
            // 
            // lblHouseNumber
            // 
            lblHouseNumber.AutoSize = true;
            lblHouseNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHouseNumber.Location = new Point(750, 318);
            lblHouseNumber.Name = "lblHouseNumber";
            lblHouseNumber.Size = new Size(54, 15);
            lblHouseNumber.TabIndex = 18;
            lblHouseNumber.Text = "Número:";
            // 
            // txtHouseNumber
            // 
            txtHouseNumber.Location = new Point(750, 345);
            txtHouseNumber.Name = "txtHouseNumber";
            txtHouseNumber.Size = new Size(157, 23);
            txtHouseNumber.TabIndex = 17;
            // 
            // lblNeighborhood
            // 
            lblNeighborhood.AutoSize = true;
            lblNeighborhood.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNeighborhood.Location = new Point(55, 401);
            lblNeighborhood.Name = "lblNeighborhood";
            lblNeighborhood.Size = new Size(41, 15);
            lblNeighborhood.TabIndex = 20;
            lblNeighborhood.Text = "Bairro:";
            // 
            // txtNeighborhood
            // 
            txtNeighborhood.Location = new Point(55, 428);
            txtNeighborhood.Name = "txtNeighborhood";
            txtNeighborhood.Size = new Size(333, 23);
            txtNeighborhood.TabIndex = 19;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCity.Location = new Point(414, 401);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(43, 15);
            lblCity.TabIndex = 22;
            lblCity.Text = "Cidade";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(414, 428);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(314, 23);
            txtCity.TabIndex = 21;
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUF.Location = new Point(750, 401);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(45, 15);
            lblUF.TabIndex = 24;
            lblUF.Text = "Estado:";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(750, 508);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(157, 59);
            btnInsert.TabIndex = 25;
            btnInsert.Text = "Gravar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // cbxUF
            // 
            cbxUF.FormattingEnabled = true;
            cbxUF.Items.AddRange(new object[] { "SP", "RJ", "AP", "MA" });
            cbxUF.Location = new Point(750, 428);
            cbxUF.Name = "cbxUF";
            cbxUF.Size = new Size(108, 23);
            cbxUF.TabIndex = 26;
            // 
            // frmInsCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 604);
            Controls.Add(cbxUF);
            Controls.Add(btnInsert);
            Controls.Add(lblUF);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Controls.Add(lblNeighborhood);
            Controls.Add(txtNeighborhood);
            Controls.Add(lblHouseNumber);
            Controls.Add(txtHouseNumber);
            Controls.Add(lblStreet);
            Controls.Add(txtStreet);
            Controls.Add(mTxtPostalCode);
            Controls.Add(lblPostalCode);
            Controls.Add(mTxtPhone);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(mTxtCPF);
            Controls.Add(lblCPF);
            Controls.Add(lblRG);
            Controls.Add(txtRG);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Name = "frmInsCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInsCustomers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private Label lblName;
        private TextBox txtName;
        private Label lblRG;
        private Label lblCPF;
        private TextBox txtRG;
        private MaskedTextBox mTxtCPF;
        private Label lblEmail;
        private TextBox txtEmail;
        private MaskedTextBox mTxtPhone;
        private Label lblPhone;
        private MaskedTextBox mTxtPostalCode;
        private Label lblPostalCode;
        private Label lblStreet;
        private TextBox txtStreet;
        private Label lblHouseNumber;
        private TextBox txtHouseNumber;
        private Label lblNeighborhood;
        private TextBox txtNeighborhood;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblUF;
        private Button btnInsert;
        private ComboBox cbxUF;
    }
}