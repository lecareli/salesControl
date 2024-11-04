namespace salesControl.br.com.views.customers
{
    partial class frmCustomers
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
            pnlSearch = new Panel();
            btnSearch = new Button();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem = new ToolStripMenuItem();
            pnlData = new Panel();
            dataGridView1 = new DataGridView();
            pnlSearch.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlSearch
            // 
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(textBox1);
            pnlSearch.Controls.Add(menuStrip1);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1030, 121);
            pnlSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(605, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 45);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Pesquisar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(421, 23);
            textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1028, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // incluirToolStripMenuItem
            // 
            incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            incluirToolStripMenuItem.Size = new Size(180, 22);
            incluirToolStripMenuItem.Text = "Incluir";
            incluirToolStripMenuItem.Click += incluirToolStripMenuItem_Click;
            // 
            // pnlData
            // 
            pnlData.BorderStyle = BorderStyle.FixedSingle;
            pnlData.Controls.Add(dataGridView1);
            pnlData.Location = new Point(0, 127);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(1030, 479);
            pnlData.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1028, 477);
            dataGridView1.TabIndex = 0;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 607);
            Controls.Add(pnlData);
            Controls.Add(pnlSearch);
            MainMenuStrip = menuStrip1;
            Name = "frmCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomers";
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSearch;
        private Button btnSearch;
        private TextBox textBox1;
        private Panel pnlData;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem incluirToolStripMenuItem;
    }
}