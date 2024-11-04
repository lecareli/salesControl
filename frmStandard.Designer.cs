namespace salesControl
{
    partial class frmStandard
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
            btnCustomers = new Button();
            SuspendLayout();
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(49, 37);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(140, 89);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "Clientes";
            btnCustomers.Click += btnCustomers_Click;
            // 
            // frmStandard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 628);
            Controls.Add(btnCustomers);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmStandard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Vendas";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCustomers;
    }
}
