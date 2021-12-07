namespace CSVeMail
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.DomainLabel = new System.Windows.Forms.Label();
            this.EmailDomainInput = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ConfigTabControl = new System.Windows.Forms.TabControl();
            this.GenerationSettingsTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RandomNumbersCountInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RandomNumbersEnd = new System.Windows.Forms.RadioButton();
            this.RandomNumbersStart = new System.Windows.Forms.RadioButton();
            this.RandomNumbersToggle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.ConfigTabControl.SuspendLayout();
            this.GenerationSettingsTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RandomNumbersCountInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DomainLabel
            // 
            this.DomainLabel.AutoSize = true;
            this.DomainLabel.Location = new System.Drawing.Point(14, 16);
            this.DomainLabel.Name = "DomainLabel";
            this.DomainLabel.Size = new System.Drawing.Size(84, 15);
            this.DomainLabel.TabIndex = 0;
            this.DomainLabel.Text = "Email Domain:";
            this.DomainLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmailDomainInput
            // 
            this.EmailDomainInput.Location = new System.Drawing.Point(173, 13);
            this.EmailDomainInput.Name = "EmailDomainInput";
            this.EmailDomainInput.Size = new System.Drawing.Size(318, 23);
            this.EmailDomainInput.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ConfigTabControl
            // 
            this.ConfigTabControl.Controls.Add(this.GenerationSettingsTab);
            this.ConfigTabControl.Location = new System.Drawing.Point(0, 0);
            this.ConfigTabControl.Name = "ConfigTabControl";
            this.ConfigTabControl.SelectedIndex = 0;
            this.ConfigTabControl.Size = new System.Drawing.Size(512, 135);
            this.ConfigTabControl.TabIndex = 2;
            // 
            // GenerationSettingsTab
            // 
            this.GenerationSettingsTab.BackColor = System.Drawing.SystemColors.Menu;
            this.GenerationSettingsTab.Controls.Add(this.groupBox2);
            this.GenerationSettingsTab.Controls.Add(this.groupBox1);
            this.GenerationSettingsTab.Controls.Add(this.RandomNumbersToggle);
            this.GenerationSettingsTab.Controls.Add(this.label1);
            this.GenerationSettingsTab.Controls.Add(this.DomainLabel);
            this.GenerationSettingsTab.Controls.Add(this.EmailDomainInput);
            this.GenerationSettingsTab.Location = new System.Drawing.Point(4, 24);
            this.GenerationSettingsTab.Name = "GenerationSettingsTab";
            this.GenerationSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.GenerationSettingsTab.Size = new System.Drawing.Size(504, 107);
            this.GenerationSettingsTab.TabIndex = 0;
            this.GenerationSettingsTab.Text = "Generation";
            this.GenerationSettingsTab.Click += new System.EventHandler(this.GenerationSettingsTab_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RandomNumbersCountInput);
            this.groupBox2.Location = new System.Drawing.Point(390, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 54);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Count";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // RandomNumbersCountInput
            // 
            this.RandomNumbersCountInput.Location = new System.Drawing.Point(6, 21);
            this.RandomNumbersCountInput.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.RandomNumbersCountInput.Name = "RandomNumbersCountInput";
            this.RandomNumbersCountInput.Size = new System.Drawing.Size(95, 23);
            this.RandomNumbersCountInput.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RandomNumbersEnd);
            this.groupBox1.Controls.Add(this.RandomNumbersStart);
            this.groupBox1.Location = new System.Drawing.Point(253, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RandomNumbersEnd
            // 
            this.RandomNumbersEnd.AutoSize = true;
            this.RandomNumbersEnd.Location = new System.Drawing.Point(74, 22);
            this.RandomNumbersEnd.Name = "RandomNumbersEnd";
            this.RandomNumbersEnd.Size = new System.Drawing.Size(45, 19);
            this.RandomNumbersEnd.TabIndex = 6;
            this.RandomNumbersEnd.TabStop = true;
            this.RandomNumbersEnd.Text = "End";
            this.RandomNumbersEnd.UseVisualStyleBackColor = true;
            // 
            // RandomNumbersStart
            // 
            this.RandomNumbersStart.AutoSize = true;
            this.RandomNumbersStart.Location = new System.Drawing.Point(19, 22);
            this.RandomNumbersStart.Name = "RandomNumbersStart";
            this.RandomNumbersStart.Size = new System.Drawing.Size(49, 19);
            this.RandomNumbersStart.TabIndex = 5;
            this.RandomNumbersStart.TabStop = true;
            this.RandomNumbersStart.Text = "Start";
            this.RandomNumbersStart.UseVisualStyleBackColor = true;
            // 
            // RandomNumbersToggle
            // 
            this.RandomNumbersToggle.AutoSize = true;
            this.RandomNumbersToggle.Location = new System.Drawing.Point(179, 65);
            this.RandomNumbersToggle.Name = "RandomNumbersToggle";
            this.RandomNumbersToggle.Size = new System.Drawing.Size(68, 19);
            this.RandomNumbersToggle.TabIndex = 3;
            this.RandomNumbersToggle.Text = "Enabled";
            this.RandomNumbersToggle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Random Numbers:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 134);
            this.Controls.Add(this.ConfigTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.Text = "Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ConfigTabControl.ResumeLayout(false);
            this.GenerationSettingsTab.ResumeLayout(false);
            this.GenerationSettingsTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RandomNumbersCountInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label DomainLabel;
        private TextBox EmailDomainInput;
        private FileSystemWatcher fileSystemWatcher1;
        private TabControl ConfigTabControl;
        private TabPage GenerationSettingsTab;
        private Label label1;
        private RadioButton RandomNumbersStart;
        private CheckBox RandomNumbersToggle;
        private RadioButton RandomNumbersEnd;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown RandomNumbersCountInput;
    }
}