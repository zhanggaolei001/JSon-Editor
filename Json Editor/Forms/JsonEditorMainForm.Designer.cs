using ZTn.Json.JsonTreeView.Controls;

namespace ZTn.Json.Editor.Forms
{
    partial class JsonEditorMainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonEditorMainForm));
            this.jsonTreeViewSplitContainer = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.findNextButton = new System.Windows.Forms.ToolStripButton();
            this.jTokenTree = new ZTn.Json.JsonTreeView.Controls.JTokenTreeUserControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.jsonValueTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jsonTypeComboBox = new System.Windows.Forms.ComboBox();
            this.jsonValueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newtonsoftJsonTypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.formMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJsonObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJsonArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutJsonEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiStatusStrip = new System.Windows.Forms.StatusStrip();
            this.actionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.jsonStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.findPreviousButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.jsonTreeViewSplitContainer)).BeginInit();
            this.jsonTreeViewSplitContainer.Panel1.SuspendLayout();
            this.jsonTreeViewSplitContainer.Panel2.SuspendLayout();
            this.jsonTreeViewSplitContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.formMenuStrip.SuspendLayout();
            this.guiStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // jsonTreeViewSplitContainer
            // 
            this.jsonTreeViewSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonTreeViewSplitContainer.Location = new System.Drawing.Point(0, 22);
            this.jsonTreeViewSplitContainer.Name = "jsonTreeViewSplitContainer";
            // 
            // jsonTreeViewSplitContainer.Panel1
            // 
            this.jsonTreeViewSplitContainer.Panel1.Controls.Add(this.toolStrip1);
            this.jsonTreeViewSplitContainer.Panel1.Controls.Add(this.jTokenTree);
            this.jsonTreeViewSplitContainer.Panel1MinSize = 200;
            // 
            // jsonTreeViewSplitContainer.Panel2
            // 
            this.jsonTreeViewSplitContainer.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.panel2);
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.panel1);
            this.jsonTreeViewSplitContainer.Panel2MinSize = 320;
            this.jsonTreeViewSplitContainer.Size = new System.Drawing.Size(1008, 510);
            this.jsonTreeViewSplitContainer.SplitterDistance = 672;
            this.jsonTreeViewSplitContainer.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBox,
            this.findNextButton,
            this.findPreviousButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // searchBox
            // 
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 25);
            // 
            // findNextButton
            // 
            this.findNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findNextButton.Image = ((System.Drawing.Image)(resources.GetObject("findNextButton.Image")));
            this.findNextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(67, 22);
            this.findNextButton.Text = "Find Next";
            this.findNextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.findNextButton.Click += new System.EventHandler(this.FindNextButton_Click);
            // 
            // jTokenTree
            // 
            this.jTokenTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jTokenTree.CollapsedFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTokenTree.ExpandedFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.jTokenTree.Location = new System.Drawing.Point(3, 31);
            this.jTokenTree.Margin = new System.Windows.Forms.Padding(6);
            this.jTokenTree.Name = "jTokenTree";
            this.jTokenTree.Size = new System.Drawing.Size(666, 476);
            this.jTokenTree.TabIndex = 2;
            this.jTokenTree.AfterSelect += new System.EventHandler<ZTn.Json.JsonTreeView.AfterSelectEventArgs>(this.jTokenTree_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.jsonValueTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 418);
            this.panel2.TabIndex = 1;
            // 
            // jsonValueTextBox
            // 
            this.jsonValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonValueTextBox.Location = new System.Drawing.Point(0, 0);
            this.jsonValueTextBox.Name = "jsonValueTextBox";
            this.jsonValueTextBox.Size = new System.Drawing.Size(332, 418);
            this.jsonValueTextBox.TabIndex = 15;
            this.jsonValueTextBox.Text = "";
            this.jsonValueTextBox.TextChanged += new System.EventHandler(this.jsonValueTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.jsonTypeComboBox);
            this.panel1.Controls.Add(this.jsonValueLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.newtonsoftJsonTypeTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 92);
            this.panel1.TabIndex = 0;
            // 
            // jsonTypeComboBox
            // 
            this.jsonTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jsonTypeComboBox.Enabled = false;
            this.jsonTypeComboBox.FormattingEnabled = true;
            this.jsonTypeComboBox.Location = new System.Drawing.Point(3, 54);
            this.jsonTypeComboBox.Name = "jsonTypeComboBox";
            this.jsonTypeComboBox.Size = new System.Drawing.Size(154, 20);
            this.jsonTypeComboBox.TabIndex = 18;
            // 
            // jsonValueLabel
            // 
            this.jsonValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.jsonValueLabel.AutoSize = true;
            this.jsonValueLabel.Location = new System.Drawing.Point(3, 75);
            this.jsonValueLabel.Name = "jsonValueLabel";
            this.jsonValueLabel.Size = new System.Drawing.Size(65, 12);
            this.jsonValueLabel.TabIndex = 17;
            this.jsonValueLabel.Text = "JSON Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "NewtonSoft.Json Type";
            // 
            // newtonsoftJsonTypeTextBox
            // 
            this.newtonsoftJsonTypeTextBox.Location = new System.Drawing.Point(3, 18);
            this.newtonsoftJsonTypeTextBox.Name = "newtonsoftJsonTypeTextBox";
            this.newtonsoftJsonTypeTextBox.ReadOnly = true;
            this.newtonsoftJsonTypeTextBox.Size = new System.Drawing.Size(154, 21);
            this.newtonsoftJsonTypeTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "JSON Type";
            // 
            // formMenuStrip
            // 
            this.formMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.formMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.formMenuStrip.Name = "formMenuStrip";
            this.formMenuStrip.Size = new System.Drawing.Size(1008, 25);
            this.formMenuStrip.TabIndex = 0;
            this.formMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newJsonObjectToolStripMenuItem,
            this.newJsonArrayToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShowShortcutKeys = false;
            this.newToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // newJsonObjectToolStripMenuItem
            // 
            this.newJsonObjectToolStripMenuItem.Name = "newJsonObjectToolStripMenuItem";
            this.newJsonObjectToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newJsonObjectToolStripMenuItem.Text = "New Json &Object";
            this.newJsonObjectToolStripMenuItem.Click += new System.EventHandler(this.newJsonObjectToolStripMenuItem_Click);
            // 
            // newJsonArrayToolStripMenuItem
            // 
            this.newJsonArrayToolStripMenuItem.Name = "newJsonArrayToolStripMenuItem";
            this.newJsonArrayToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newJsonArrayToolStripMenuItem.Text = "New Json &Array";
            this.newJsonArrayToolStripMenuItem.Click += new System.EventHandler(this.newJsonArrayToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutJsonEditorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(26, 21);
            this.aboutToolStripMenuItem.Text = "?";
            // 
            // aboutJsonEditorToolStripMenuItem
            // 
            this.aboutJsonEditorToolStripMenuItem.Name = "aboutJsonEditorToolStripMenuItem";
            this.aboutJsonEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutJsonEditorToolStripMenuItem.Text = "About Json Editor";
            this.aboutJsonEditorToolStripMenuItem.Click += new System.EventHandler(this.aboutJsonEditorToolStripMenuItem_Click);
            // 
            // guiStatusStrip
            // 
            this.guiStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionStatusLabel,
            this.toolStripStatusLabel1,
            this.jsonStatusLabel});
            this.guiStatusStrip.Location = new System.Drawing.Point(0, 533);
            this.guiStatusStrip.Name = "guiStatusStrip";
            this.guiStatusStrip.Size = new System.Drawing.Size(1008, 22);
            this.guiStatusStrip.TabIndex = 9;
            this.guiStatusStrip.Text = "statusStrip";
            // 
            // actionStatusLabel
            // 
            this.actionStatusLabel.Name = "actionStatusLabel";
            this.actionStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.actionStatusLabel.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(881, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // jsonStatusLabel
            // 
            this.jsonStatusLabel.Name = "jsonStatusLabel";
            this.jsonStatusLabel.Size = new System.Drawing.Size(69, 17);
            this.jsonStatusLabel.Text = "JsonStatus";
            // 
            // findPreviousButton
            // 
            this.findPreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findPreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("findPreviousButton.Image")));
            this.findPreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findPreviousButton.Name = "findPreviousButton";
            this.findPreviousButton.Size = new System.Drawing.Size(89, 22);
            this.findPreviousButton.Text = "Find Previous";
            this.findPreviousButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.findPreviousButton.ToolTipText = "Find Previous";
            this.findPreviousButton.Click += new System.EventHandler(this.findPreviousButton_Click);
            // 
            // JsonEditorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 555);
            this.Controls.Add(this.guiStatusStrip);
            this.Controls.Add(this.jsonTreeViewSplitContainer);
            this.Controls.Add(this.formMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.formMenuStrip;
            this.Name = "JsonEditorMainForm";
            this.Text = "ZTn Json Editor";
            this.jsonTreeViewSplitContainer.Panel1.ResumeLayout(false);
            this.jsonTreeViewSplitContainer.Panel1.PerformLayout();
            this.jsonTreeViewSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jsonTreeViewSplitContainer)).EndInit();
            this.jsonTreeViewSplitContainer.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.formMenuStrip.ResumeLayout(false);
            this.formMenuStrip.PerformLayout();
            this.guiStatusStrip.ResumeLayout(false);
            this.guiStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip formMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SplitContainer jsonTreeViewSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newJsonObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newJsonArrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutJsonEditorToolStripMenuItem;
        private JTokenTreeUserControl jTokenTree;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip guiStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel actionStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel jsonStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox jsonValueTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox jsonTypeComboBox;
        public System.Windows.Forms.Label jsonValueLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newtonsoftJsonTypeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.ToolStripButton findNextButton;
        private System.Windows.Forms.ToolStripButton findPreviousButton;
    }
}

