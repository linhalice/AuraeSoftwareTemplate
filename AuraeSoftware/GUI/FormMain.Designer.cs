namespace AuraeSoftware.GUI
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitChromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tinhNang1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhNang2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1387, 592);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dataGridView1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1387, 592);
            this.panelMain.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.button1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 592);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1387, 79);
            this.panelBottom.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1234, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitChromeToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // quitChromeToolStripMenuItem
            // 
            this.quitChromeToolStripMenuItem.Name = "quitChromeToolStripMenuItem";
            this.quitChromeToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.quitChromeToolStripMenuItem.Text = "Quit Chrome";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolSettingsToolStripMenuItem
            // 
            this.toolSettingsToolStripMenuItem.Name = "toolSettingsToolStripMenuItem";
            this.toolSettingsToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.toolSettingsToolStripMenuItem.Text = "Tool Settings";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1387, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tinhNang1ToolStripMenuItem,
            this.tinhNang2ToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(178, 68);
            // 
            // tinhNang1ToolStripMenuItem
            // 
            this.tinhNang1ToolStripMenuItem.Name = "tinhNang1ToolStripMenuItem";
            this.tinhNang1ToolStripMenuItem.Size = new System.Drawing.Size(177, 32);
            this.tinhNang1ToolStripMenuItem.Text = "Tinh nang 1";
            this.tinhNang1ToolStripMenuItem.Click += new System.EventHandler(this.tinhNang1ToolStripMenuItem_Click);
            // 
            // tinhNang2ToolStripMenuItem
            // 
            this.tinhNang2ToolStripMenuItem.Name = "tinhNang2ToolStripMenuItem";
            this.tinhNang2ToolStripMenuItem.Size = new System.Drawing.Size(177, 32);
            this.tinhNang2ToolStripMenuItem.Text = "tinh Nang 2";
            this.tinhNang2ToolStripMenuItem.Click += new System.EventHandler(this.tinhNang2ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 671);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panelMain;
        private Panel panelBottom;
        private Button button1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem quitChromeToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem toolSettingsToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStripMain;
        private ToolStripMenuItem tinhNang1ToolStripMenuItem;
        private ToolStripMenuItem tinhNang2ToolStripMenuItem;
    }
}