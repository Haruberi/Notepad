
namespace Notepad
{
    partial class notepad
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjalpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyttFonsterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klippUtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopieraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klistraInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomaInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomaUtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omAnteckningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaHjalpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(535, 250);
            this.textBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.redigeraToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.visaToolStripMenuItem,
            this.hjalpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyToolStripMenuItem,
            this.nyttFonsterToolStripMenuItem,
            this.oppnaToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.sparaSomToolStripMenuItem,
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // redigeraToolStripMenuItem
            // 
            this.redigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klippUtToolStripMenuItem,
            this.kopieraToolStripMenuItem,
            this.klistraInToolStripMenuItem,
            this.taBortToolStripMenuItem});
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.redigeraToolStripMenuItem.Text = "Redigera";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // visaToolStripMenuItem
            // 
            this.visaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomaToolStripMenuItem});
            this.visaToolStripMenuItem.Name = "visaToolStripMenuItem";
            this.visaToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.visaToolStripMenuItem.Text = "Visa";
            // 
            // hjalpToolStripMenuItem
            // 
            this.hjalpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omAnteckningarToolStripMenuItem,
            this.visaHjalpToolStripMenuItem});
            this.hjalpToolStripMenuItem.Name = "hjalpToolStripMenuItem";
            this.hjalpToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.hjalpToolStripMenuItem.Text = "Hjälp";
            // 
            // nyToolStripMenuItem
            // 
            this.nyToolStripMenuItem.Name = "nyToolStripMenuItem";
            this.nyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nyToolStripMenuItem.Text = "Ny";
            // 
            // nyttFonsterToolStripMenuItem
            // 
            this.nyttFonsterToolStripMenuItem.Name = "nyttFonsterToolStripMenuItem";
            this.nyttFonsterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nyttFonsterToolStripMenuItem.Text = "Nytt fönster";
            // 
            // oppnaToolStripMenuItem
            // 
            this.oppnaToolStripMenuItem.Name = "oppnaToolStripMenuItem";
            this.oppnaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.oppnaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.oppnaToolStripMenuItem.Text = "Öppna...";
            this.oppnaToolStripMenuItem.Click += new System.EventHandler(this.oppnaToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sparaToolStripMenuItem.Text = "Spara";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sparaSomToolStripMenuItem.Text = "Spara som...";
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            // 
            // klippUtToolStripMenuItem
            // 
            this.klippUtToolStripMenuItem.Name = "klippUtToolStripMenuItem";
            this.klippUtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.klippUtToolStripMenuItem.Text = "Klipp ut";
            // 
            // kopieraToolStripMenuItem
            // 
            this.kopieraToolStripMenuItem.Name = "kopieraToolStripMenuItem";
            this.kopieraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopieraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kopieraToolStripMenuItem.Text = "Kopiera";
            // 
            // klistraInToolStripMenuItem
            // 
            this.klistraInToolStripMenuItem.Name = "klistraInToolStripMenuItem";
            this.klistraInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.klistraInToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.klistraInToolStripMenuItem.Text = "Klistra in";
            // 
            // taBortToolStripMenuItem
            // 
            this.taBortToolStripMenuItem.Name = "taBortToolStripMenuItem";
            this.taBortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.taBortToolStripMenuItem.Text = "Ta bort";
            // 
            // zoomaToolStripMenuItem
            // 
            this.zoomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomaInToolStripMenuItem,
            this.zoomaUtToolStripMenuItem});
            this.zoomaToolStripMenuItem.Name = "zoomaToolStripMenuItem";
            this.zoomaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zoomaToolStripMenuItem.Text = "Zooma";
            // 
            // zoomaInToolStripMenuItem
            // 
            this.zoomaInToolStripMenuItem.Name = "zoomaInToolStripMenuItem";
            this.zoomaInToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zoomaInToolStripMenuItem.Text = "Zooma in";
            // 
            // zoomaUtToolStripMenuItem
            // 
            this.zoomaUtToolStripMenuItem.Name = "zoomaUtToolStripMenuItem";
            this.zoomaUtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zoomaUtToolStripMenuItem.Text = "Zooma ut";
            // 
            // omAnteckningarToolStripMenuItem
            // 
            this.omAnteckningarToolStripMenuItem.Name = "omAnteckningarToolStripMenuItem";
            this.omAnteckningarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.omAnteckningarToolStripMenuItem.Text = "Om anteckningar";
            // 
            // visaHjalpToolStripMenuItem
            // 
            this.visaHjalpToolStripMenuItem.Name = "visaHjalpToolStripMenuItem";
            this.visaHjalpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.visaHjalpToolStripMenuItem.Text = "Visa Hjälp...";
            // 
            // notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 333);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "notepad";
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyttFonsterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klippUtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopieraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klistraInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomaInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomaUtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjalpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omAnteckningarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaHjalpToolStripMenuItem;
    }
}

