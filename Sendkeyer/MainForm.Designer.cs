namespace Sendkeyer
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._appsCombo = new System.Windows.Forms.ComboBox();
            this._linesList = new System.Windows.Forms.ListBox();
            this._sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._lineBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this._resetLink = new System.Windows.Forms.LinkLabel();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._appendNewLineCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _appsCombo
            // 
            this._appsCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._appsCombo.FormattingEnabled = true;
            this._appsCombo.Location = new System.Drawing.Point(26, 49);
            this._appsCombo.Name = "_appsCombo";
            this._appsCombo.Size = new System.Drawing.Size(248, 20);
            this._appsCombo.TabIndex = 1;
            // 
            // _linesList
            // 
            this._linesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._linesList.FormattingEnabled = true;
            this._linesList.IntegralHeight = false;
            this._linesList.ItemHeight = 12;
            this._linesList.Location = new System.Drawing.Point(26, 147);
            this._linesList.Name = "_linesList";
            this._linesList.Size = new System.Drawing.Size(248, 103);
            this._linesList.TabIndex = 4;
            this._linesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._linesList_MouseDoubleClick);
            // 
            // _sendButton
            // 
            this._sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._sendButton.Location = new System.Drawing.Point(213, 265);
            this._sendButton.Name = "_sendButton";
            this._sendButton.Size = new System.Drawing.Size(75, 23);
            this._sendButton.TabIndex = 5;
            this._sendButton.Text = "Send";
            this._sendButton.UseVisualStyleBackColor = true;
            this._sendButton.Click += new System.EventHandler(this._sendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "App Name (&A):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value (&V):";
            // 
            // _lineBox
            // 
            this._lineBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lineBox.Location = new System.Drawing.Point(26, 100);
            this._lineBox.Name = "_lineBox";
            this._lineBox.Size = new System.Drawing.Size(248, 19);
            this._lineBox.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::Sendkeyer.Properties.Settings.Default.MainForm_TopMost;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Sendkeyer.Properties.Settings.Default, "MainForm_TopMost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(225, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Top Most";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // _resetLink
            // 
            this._resetLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._resetLink.AutoSize = true;
            this._resetLink.Location = new System.Drawing.Point(26, 276);
            this._resetLink.Name = "_resetLink";
            this._resetLink.Size = new System.Drawing.Size(82, 12);
            this._resetLink.TabIndex = 7;
            this._resetLink.TabStop = true;
            this._resetLink.Text = "Clear Histories";
            this._resetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._resetLink_LinkClicked);
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // _appendNewLineCheck
            // 
            this._appendNewLineCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._appendNewLineCheck.AutoSize = true;
            this._appendNewLineCheck.Checked = global::Sendkeyer.Properties.Settings.Default.AppendNewLine;
            this._appendNewLineCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Sendkeyer.Properties.Settings.Default, "AppendNewLine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._appendNewLineCheck.Location = new System.Drawing.Point(154, 125);
            this._appendNewLineCheck.Name = "_appendNewLineCheck";
            this._appendNewLineCheck.Size = new System.Drawing.Size(120, 16);
            this._appendNewLineCheck.TabIndex = 8;
            this._appendNewLineCheck.Text = "Append ENTER (~)";
            this._appendNewLineCheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this._sendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this._appendNewLineCheck);
            this.Controls.Add(this._resetLink);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this._lineBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._sendButton);
            this.Controls.Add(this._linesList);
            this.Controls.Add(this._appsCombo);
            this.DataBindings.Add(new System.Windows.Forms.Binding("TopMost", global::Sendkeyer.Properties.Settings.Default, "MainForm_TopMost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::Sendkeyer.Properties.Settings.Default.MainForm_Location;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SENDKEYer";
            this.TopMost = global::Sendkeyer.Properties.Settings.Default.MainForm_TopMost;
            this.WindowState = global::Sendkeyer.Properties.Settings.Default.MainForm_WindowState;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._FormClosing);
            this.ClientSizeChanged += new System.EventHandler(this._ClientSizeChanged);
            this.LocationChanged += new System.EventHandler(this._LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _appsCombo;
        private System.Windows.Forms.ListBox _linesList;
        private System.Windows.Forms.Button _sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _lineBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel _resetLink;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.CheckBox _appendNewLineCheck;
    }
}

