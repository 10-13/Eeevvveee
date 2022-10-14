namespace EveEchoesOverlays
{
    partial class HealthBarElement
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundPulseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.onToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgpulse_timer = new System.Windows.Forms.Timer(this.components);
            this.update_timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundPulseToolStripMenuItem,
            this.autoUpdateToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // backgroundPulseToolStripMenuItem
            // 
            this.backgroundPulseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.backgroundPulseToolStripMenuItem.Name = "backgroundPulseToolStripMenuItem";
            this.backgroundPulseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backgroundPulseToolStripMenuItem.Text = "BackgroundPulse";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.onToolStripMenuItem.Text = "On";
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.offToolStripMenuItem.Text = "Off";
            // 
            // autoUpdateToolStripMenuItem
            // 
            this.autoUpdateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.onToolStripMenuItem1,
            this.offToolStripMenuItem1});
            this.autoUpdateToolStripMenuItem.Name = "autoUpdateToolStripMenuItem";
            this.autoUpdateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoUpdateToolStripMenuItem.Text = "AutoUpdate";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "100";
            this.toolStripTextBox1.Leave += new System.EventHandler(this.toolStripTextBox1_Leave);
            // 
            // onToolStripMenuItem1
            // 
            this.onToolStripMenuItem1.Name = "onToolStripMenuItem1";
            this.onToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.onToolStripMenuItem1.Text = "On";
            // 
            // offToolStripMenuItem1
            // 
            this.offToolStripMenuItem1.Name = "offToolStripMenuItem1";
            this.offToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.offToolStripMenuItem1.Text = "Off";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // HealthBarElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "HealthBarElement";
            this.Size = new System.Drawing.Size(463, 79);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem backgroundPulseToolStripMenuItem;
        private ToolStripMenuItem onToolStripMenuItem;
        private ToolStripMenuItem offToolStripMenuItem;
        private ToolStripMenuItem autoUpdateToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Timer bgpulse_timer;
        private System.Windows.Forms.Timer update_timer;
        private ToolStripMenuItem onToolStripMenuItem1;
        private ToolStripMenuItem offToolStripMenuItem1;
    }
}
