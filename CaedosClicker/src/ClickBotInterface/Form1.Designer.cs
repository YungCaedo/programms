namespace ClickBotInterface
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lableDelay = new System.Windows.Forms.Label();
            this.dropMode = new System.Windows.Forms.ComboBox();
            this.dropMaustaste = new System.Windows.Forms.ComboBox();
            this.labelMaustaste = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.inputDelay = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // lableDelay
            // 
            this.lableDelay.BackColor = System.Drawing.Color.Black;
            this.lableDelay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lableDelay.ForeColor = System.Drawing.SystemColors.Info;
            this.lableDelay.Location = new System.Drawing.Point(14, 132);
            this.lableDelay.Margin = new System.Windows.Forms.Padding(5);
            this.lableDelay.Name = "lableDelay";
            this.lableDelay.Size = new System.Drawing.Size(276, 23);
            this.lableDelay.TabIndex = 1;
            this.lableDelay.Text = "Delay (ms):";
            this.lableDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dropMode
            // 
            this.dropMode.FormattingEnabled = true;
            this.dropMode.Items.AddRange(new object[] {
            "Klicken",
            "Halten"});
            this.dropMode.Location = new System.Drawing.Point(14, 99);
            this.dropMode.Margin = new System.Windows.Forms.Padding(5);
            this.dropMode.Name = "dropMode";
            this.dropMode.Size = new System.Drawing.Size(276, 23);
            this.dropMode.TabIndex = 2;
            this.dropMode.SelectedIndexChanged += new System.EventHandler(this.dropMode_SelectedIndexChanged);
            // 
            // dropMaustaste
            // 
            this.dropMaustaste.FormattingEnabled = true;
            this.dropMaustaste.Items.AddRange(new object[] {
            "Links",
            "Rechts",
            "Mitte"});
            this.dropMaustaste.Location = new System.Drawing.Point(14, 40);
            this.dropMaustaste.Margin = new System.Windows.Forms.Padding(5);
            this.dropMaustaste.Name = "dropMaustaste";
            this.dropMaustaste.Size = new System.Drawing.Size(276, 23);
            this.dropMaustaste.TabIndex = 2;
            this.dropMaustaste.SelectedIndexChanged += new System.EventHandler(this.dropMaustaste_SelectedIndexChanged);
            // 
            // labelMaustaste
            // 
            this.labelMaustaste.BackColor = System.Drawing.Color.Black;
            this.labelMaustaste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaustaste.ForeColor = System.Drawing.SystemColors.Info;
            this.labelMaustaste.Location = new System.Drawing.Point(14, 14);
            this.labelMaustaste.Margin = new System.Windows.Forms.Padding(5);
            this.labelMaustaste.Name = "labelMaustaste";
            this.labelMaustaste.Size = new System.Drawing.Size(276, 23);
            this.labelMaustaste.TabIndex = 1;
            this.labelMaustaste.Text = "Maustaste:";
            this.labelMaustaste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMode
            // 
            this.labelMode.BackColor = System.Drawing.Color.Black;
            this.labelMode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMode.ForeColor = System.Drawing.SystemColors.Info;
            this.labelMode.Location = new System.Drawing.Point(14, 73);
            this.labelMode.Margin = new System.Windows.Forms.Padding(5);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(276, 23);
            this.labelMode.TabIndex = 1;
            this.labelMode.Text = "Modus:";
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.Color.Black;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStart.Location = new System.Drawing.Point(12, 206);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(280, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start (F1)";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.BackColor = System.Drawing.Color.Black;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStop.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStop.Location = new System.Drawing.Point(12, 235);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(280, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop (F2)";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // inputDelay
            // 
            this.inputDelay.BackColor = System.Drawing.SystemColors.Window;
            this.inputDelay.Location = new System.Drawing.Point(14, 158);
            this.inputDelay.Margin = new System.Windows.Forms.Padding(5);
            this.inputDelay.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.inputDelay.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.inputDelay.Name = "inputDelay";
            this.inputDelay.Size = new System.Drawing.Size(276, 23);
            this.inputDelay.TabIndex = 6;
            this.inputDelay.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.inputDelay.ValueChanged += new System.EventHandler(this.inputDelay_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.inputDelay);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelMaustaste);
            this.Controls.Add(this.dropMaustaste);
            this.Controls.Add(this.dropMode);
            this.Controls.Add(this.lableDelay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ceados Klicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lableDelay;
        public System.Windows.Forms.ComboBox dropMode;
        public System.Windows.Forms.ComboBox dropMaustaste;
        public System.Windows.Forms.Label labelMaustaste;
        public System.Windows.Forms.Label labelMode;
        public System.Windows.Forms.Button buttonStart;
        public System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.NumericUpDown inputDelay;
        private System.Windows.Forms.Timer timer1;
    }
}

