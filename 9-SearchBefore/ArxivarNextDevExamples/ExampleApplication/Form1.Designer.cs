namespace ExampleApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.errorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tokenValue = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonGetAooAsync = new System.Windows.Forms.Button();
            this.buttonGetDocTypes = new System.Windows.Forms.Button();
            this.buttonGetAoo = new System.Windows.Forms.Button();
            this.aooTable = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.datagridComplex = new System.Windows.Forms.DataGridView();
            this.getMaskById = new System.Windows.Forms.Button();
            this.buttonPredefinedProfile = new System.Windows.Forms.Button();
            this.buttonPredProfById = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aooTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridComplex)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1087, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1087, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tokenValue);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.tokenLabel);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.passwordTxt);
            this.splitContainer1.Panel1.Controls.Add(this.userTxt);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1087, 638);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 2;
            // 
            // tokenValue
            // 
            this.tokenValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenValue.Location = new System.Drawing.Point(389, 3);
            this.tokenValue.Multiline = true;
            this.tokenValue.Name = "tokenValue";
            this.tokenValue.ReadOnly = true;
            this.tokenValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tokenValue.Size = new System.Drawing.Size(686, 94);
            this.tokenValue.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.refreshToken);
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.ForeColor = System.Drawing.Color.Red;
            this.tokenLabel.Location = new System.Drawing.Point(280, 36);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(103, 13);
            this.tokenLabel.TabIndex = 5;
            this.tokenLabel.Text = "Token non presente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoginClick);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(67, 49);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(126, 20);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.Text = "123..";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(67, 27);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(126, 20);
            this.userTxt.TabIndex = 2;
            this.userTxt.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utente";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 534);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1079, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aoo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonGetAooAsync);
            this.splitContainer2.Panel1.Controls.Add(this.buttonGetDocTypes);
            this.splitContainer2.Panel1.Controls.Add(this.buttonGetAoo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.aooTable);
            this.splitContainer2.Size = new System.Drawing.Size(1073, 502);
            this.splitContainer2.SplitterDistance = 201;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonGetAooAsync
            // 
            this.buttonGetAooAsync.Location = new System.Drawing.Point(6, 71);
            this.buttonGetAooAsync.Name = "buttonGetAooAsync";
            this.buttonGetAooAsync.Size = new System.Drawing.Size(192, 23);
            this.buttonGetAooAsync.TabIndex = 2;
            this.buttonGetAooAsync.Text = "get AOO Async";
            this.buttonGetAooAsync.UseVisualStyleBackColor = true;
            this.buttonGetAooAsync.Click += new System.EventHandler(this.buttonGetAooAsync_Click);
            // 
            // buttonGetDocTypes
            // 
            this.buttonGetDocTypes.Location = new System.Drawing.Point(6, 42);
            this.buttonGetDocTypes.Name = "buttonGetDocTypes";
            this.buttonGetDocTypes.Size = new System.Drawing.Size(192, 23);
            this.buttonGetDocTypes.TabIndex = 1;
            this.buttonGetDocTypes.Text = "get DocumentTypes";
            this.buttonGetDocTypes.UseVisualStyleBackColor = true;
            this.buttonGetDocTypes.Click += new System.EventHandler(this.buttonGetDocTypes_Click);
            // 
            // buttonGetAoo
            // 
            this.buttonGetAoo.Location = new System.Drawing.Point(6, 13);
            this.buttonGetAoo.Name = "buttonGetAoo";
            this.buttonGetAoo.Size = new System.Drawing.Size(192, 23);
            this.buttonGetAoo.TabIndex = 0;
            this.buttonGetAoo.Text = "get AOO";
            this.buttonGetAoo.UseVisualStyleBackColor = true;
            this.buttonGetAoo.Click += new System.EventHandler(this.buttonGetAoo_Click);
            // 
            // aooTable
            // 
            this.aooTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aooTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aooTable.Location = new System.Drawing.Point(0, 0);
            this.aooTable.Name = "aooTable";
            this.aooTable.Size = new System.Drawing.Size(868, 502);
            this.aooTable.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1079, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ComplexList";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.buttonPredProfById);
            this.splitContainer3.Panel1.Controls.Add(this.buttonPredefinedProfile);
            this.splitContainer3.Panel1.Controls.Add(this.getMaskById);
            this.splitContainer3.Panel1.Controls.Add(this.button3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.datagridComplex);
            this.splitContainer3.Size = new System.Drawing.Size(1073, 502);
            this.splitContainer3.SplitterDistance = 175;
            this.splitContainer3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "get Mask";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.maskGetData);
            // 
            // datagridComplex
            // 
            this.datagridComplex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridComplex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridComplex.Location = new System.Drawing.Point(0, 0);
            this.datagridComplex.Name = "datagridComplex";
            this.datagridComplex.Size = new System.Drawing.Size(894, 502);
            this.datagridComplex.TabIndex = 0;
            // 
            // getMaskById
            // 
            this.getMaskById.Location = new System.Drawing.Point(7, 32);
            this.getMaskById.Name = "getMaskById";
            this.getMaskById.Size = new System.Drawing.Size(166, 23);
            this.getMaskById.TabIndex = 1;
            this.getMaskById.Text = "get Mask By Id";
            this.getMaskById.UseVisualStyleBackColor = true;
            this.getMaskById.Click += new System.EventHandler(this.getMaskByIdHandler);
            // 
            // buttonPredefinedProfile
            // 
            this.buttonPredefinedProfile.Location = new System.Drawing.Point(7, 61);
            this.buttonPredefinedProfile.Name = "buttonPredefinedProfile";
            this.buttonPredefinedProfile.Size = new System.Drawing.Size(165, 23);
            this.buttonPredefinedProfile.TabIndex = 2;
            this.buttonPredefinedProfile.Text = "get PredefinedProfile";
            this.buttonPredefinedProfile.UseVisualStyleBackColor = true;
            this.buttonPredefinedProfile.Click += new System.EventHandler(this.buttonPredefinedProfile_Click);
            // 
            // buttonPredProfById
            // 
            this.buttonPredProfById.Location = new System.Drawing.Point(8, 90);
            this.buttonPredProfById.Name = "buttonPredProfById";
            this.buttonPredProfById.Size = new System.Drawing.Size(165, 23);
            this.buttonPredProfById.TabIndex = 3;
            this.buttonPredProfById.Text = "get PredProf by Id";
            this.buttonPredProfById.UseVisualStyleBackColor = true;
            this.buttonPredProfById.Click += new System.EventHandler(this.buttonPredProfById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 685);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Example WebApi Application";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aooTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridComplex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tokenValue;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonGetAoo;
        private System.Windows.Forms.DataGridView aooTable;
        private System.Windows.Forms.ToolStripStatusLabel errorLabel;
        private System.Windows.Forms.Button buttonGetDocTypes;
        private System.Windows.Forms.Button buttonGetAooAsync;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView datagridComplex;
        private System.Windows.Forms.Button getMaskById;
        private System.Windows.Forms.Button buttonPredefinedProfile;
        private System.Windows.Forms.Button buttonPredProfById;
    }
}

