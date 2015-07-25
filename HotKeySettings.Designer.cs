namespace ReachPlus.SDK.Samples.ReachPlusHotKey
{
    partial class HotKeySettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotKeySettings));
            this.comboKey = new System.Windows.Forms.ComboBox();
            this.comboModifier1 = new System.Windows.Forms.ComboBox();
            this.comboModifier2 = new System.Windows.Forms.ComboBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboKey
            // 
            this.comboKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKey.FormattingEnabled = true;
            this.comboKey.Location = new System.Drawing.Point(494, 102);
            this.comboKey.Name = "comboKey";
            this.comboKey.Size = new System.Drawing.Size(194, 33);
            this.comboKey.TabIndex = 0;
            // 
            // comboModifier1
            // 
            this.comboModifier1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModifier1.FormattingEnabled = true;
            this.comboModifier1.Location = new System.Drawing.Point(91, 102);
            this.comboModifier1.Name = "comboModifier1";
            this.comboModifier1.Size = new System.Drawing.Size(194, 33);
            this.comboModifier1.TabIndex = 1;
            // 
            // comboModifier2
            // 
            this.comboModifier2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModifier2.FormattingEnabled = true;
            this.comboModifier2.Location = new System.Drawing.Point(291, 102);
            this.comboModifier2.Name = "comboModifier2";
            this.comboModifier2.Size = new System.Drawing.Size(194, 33);
            this.comboModifier2.TabIndex = 2;
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(463, 152);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(225, 63);
            this.buttonSet.TabIndex = 3;
            this.buttonSet.Text = "&Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // HotKeySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 299);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.comboModifier2);
            this.Controls.Add(this.comboModifier1);
            this.Controls.Add(this.comboKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HotKeySettings";
            this.Text = "Virtual panic button";
            this.Load += new System.EventHandler(this.HotKeyManager_Load);
            this.Resize += new System.EventHandler(this.HotKeySettings_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboKey;
        private System.Windows.Forms.ComboBox comboModifier1;
        private System.Windows.Forms.ComboBox comboModifier2;
        private System.Windows.Forms.Button buttonSet;
    }
}

