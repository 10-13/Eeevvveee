namespace Eve_bot
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.SheildHP = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ArmorHP = new System.Windows.Forms.ProgressBar();
            this.UpdateTicker = new System.Windows.Forms.Timer(this.components);
            this.Repair = new System.Windows.Forms.CheckBox();
            this.AlgorithmWorking = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SheildHP
            // 
            this.SheildHP.Location = new System.Drawing.Point(12, 32);
            this.SheildHP.Name = "SheildHP";
            this.SheildHP.Size = new System.Drawing.Size(776, 15);
            this.SheildHP.TabIndex = 0;
            this.SheildHP.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sheild:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Armor:";
            // 
            // ArmorHP
            // 
            this.ArmorHP.Location = new System.Drawing.Point(12, 79);
            this.ArmorHP.Name = "ArmorHP";
            this.ArmorHP.Size = new System.Drawing.Size(776, 15);
            this.ArmorHP.TabIndex = 2;
            this.ArmorHP.Value = 100;
            // 
            // UpdateTicker
            // 
            this.UpdateTicker.Interval = 400;
            this.UpdateTicker.Tick += new System.EventHandler(this.UpdateTicker_Tick);
            // 
            // Repair
            // 
            this.Repair.AutoSize = true;
            this.Repair.Location = new System.Drawing.Point(12, 419);
            this.Repair.Name = "Repair";
            this.Repair.Size = new System.Drawing.Size(59, 19);
            this.Repair.TabIndex = 4;
            this.Repair.Text = "Repair";
            this.Repair.UseVisualStyleBackColor = true;
            // 
            // AlgorithmWorking
            // 
            this.AlgorithmWorking.AutoSize = true;
            this.AlgorithmWorking.Location = new System.Drawing.Point(12, 394);
            this.AlgorithmWorking.Name = "AlgorithmWorking";
            this.AlgorithmWorking.Size = new System.Drawing.Size(54, 19);
            this.AlgorithmWorking.TabIndex = 5;
            this.AlgorithmWorking.Text = "Work";
            this.AlgorithmWorking.UseVisualStyleBackColor = true;
            this.AlgorithmWorking.CheckedChanged += new System.EventHandler(this.AlgorithmWorking_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "AddTextMarks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AlgorithmWorking);
            this.Controls.Add(this.Repair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArmorHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SheildHP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Eeevvveee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar SheildHP;
        private Label label1;
        private Label label2;
        private ProgressBar ArmorHP;
        private System.Windows.Forms.Timer UpdateTicker;
        private CheckBox Repair;
        private CheckBox AlgorithmWorking;
        private Button button1;
    }
}