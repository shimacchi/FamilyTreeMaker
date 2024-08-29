namespace FamilyTreeMaker
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
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.オブジェクトの追加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オブジェクトの削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.婚姻関係を設定MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageSaveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.isSufferedCheck = new System.Windows.Forms.CheckBox();
            this.unknownRadio = new System.Windows.Forms.RadioButton();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.isDeadCheck = new System.Windows.Forms.CheckBox();
            this.isProbandCheck = new System.Windows.Forms.CheckBox();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.mainPictureBox.ContextMenuStrip = this.contextMenu;
            this.mainPictureBox.Location = new System.Drawing.Point(12, 12);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(605, 529);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Click += new System.EventHandler(this.mainPictureBox_Click);
            this.mainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPictureBox_Paint);
            this.mainPictureBox.Resize += new System.EventHandler(this.mainPictureBox_Resize);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.オブジェクトの追加AToolStripMenuItem,
            this.オブジェクトの削除DToolStripMenuItem,
            this.toolStripMenuItem1,
            this.婚姻関係を設定MToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(205, 82);
            // 
            // オブジェクトの追加AToolStripMenuItem
            // 
            this.オブジェクトの追加AToolStripMenuItem.Name = "オブジェクトの追加AToolStripMenuItem";
            this.オブジェクトの追加AToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.オブジェクトの追加AToolStripMenuItem.Text = "オブジェクトの追加(&A)";
            // 
            // オブジェクトの削除DToolStripMenuItem
            // 
            this.オブジェクトの削除DToolStripMenuItem.Name = "オブジェクトの削除DToolStripMenuItem";
            this.オブジェクトの削除DToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.オブジェクトの削除DToolStripMenuItem.Text = "オブジェクトの削除(&D)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // 婚姻関係を設定MToolStripMenuItem
            // 
            this.婚姻関係を設定MToolStripMenuItem.Name = "婚姻関係を設定MToolStripMenuItem";
            this.婚姻関係を設定MToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.婚姻関係を設定MToolStripMenuItem.Text = "婚姻関係を設定(&M)";
            // 
            // ImageSaveButton
            // 
            this.ImageSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSaveButton.Location = new System.Drawing.Point(623, 485);
            this.ImageSaveButton.Name = "ImageSaveButton";
            this.ImageSaveButton.Size = new System.Drawing.Size(147, 56);
            this.ImageSaveButton.TabIndex = 1;
            this.ImageSaveButton.Text = "イメージを保存";
            this.ImageSaveButton.UseVisualStyleBackColor = true;
            this.ImageSaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(623, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 56);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "オブジェクトを追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.isSufferedCheck);
            this.groupBox1.Controls.Add(this.unknownRadio);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.femaleRadio);
            this.groupBox1.Controls.Add(this.maleRadio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.isDeadCheck);
            this.groupBox1.Controls.Add(this.isProbandCheck);
            this.groupBox1.Location = new System.Drawing.Point(623, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 343);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "オブジェクトの情報";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 302);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "近親婚";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // isSufferedCheck
            // 
            this.isSufferedCheck.AutoSize = true;
            this.isSufferedCheck.Location = new System.Drawing.Point(10, 175);
            this.isSufferedCheck.Name = "isSufferedCheck";
            this.isSufferedCheck.Size = new System.Drawing.Size(74, 19);
            this.isSufferedCheck.TabIndex = 9;
            this.isSufferedCheck.Text = "罹患者";
            this.isSufferedCheck.UseVisualStyleBackColor = true;
            // 
            // unknownRadio
            // 
            this.unknownRadio.AutoSize = true;
            this.unknownRadio.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.unknownRadio.Location = new System.Drawing.Point(10, 140);
            this.unknownRadio.Name = "unknownRadio";
            this.unknownRadio.Size = new System.Drawing.Size(88, 19);
            this.unknownRadio.TabIndex = 8;
            this.unknownRadio.TabStop = true;
            this.unknownRadio.Text = "性別不明";
            this.unknownRadio.UseVisualStyleBackColor = true;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(9, 45);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(131, 22);
            this.nameText.TabIndex = 7;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 15);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "氏名";
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(10, 115);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(58, 19);
            this.femaleRadio.TabIndex = 5;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "女性";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(10, 90);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(58, 19);
            this.maleRadio.TabIndex = 4;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "男性";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "死亡時年齢";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(9, 265);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // isDeadCheck
            // 
            this.isDeadCheck.AutoSize = true;
            this.isDeadCheck.Location = new System.Drawing.Point(10, 225);
            this.isDeadCheck.Name = "isDeadCheck";
            this.isDeadCheck.Size = new System.Drawing.Size(59, 19);
            this.isDeadCheck.TabIndex = 1;
            this.isDeadCheck.Text = "死亡";
            this.isDeadCheck.UseVisualStyleBackColor = true;
            // 
            // isProbandCheck
            // 
            this.isProbandCheck.AutoSize = true;
            this.isProbandCheck.Location = new System.Drawing.Point(10, 200);
            this.isProbandCheck.Name = "isProbandCheck";
            this.isProbandCheck.Size = new System.Drawing.Size(74, 19);
            this.isProbandCheck.TabIndex = 0;
            this.isProbandCheck.Text = "発端者";
            this.isProbandCheck.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(623, 74);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 56);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "オブジェクトを削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ImageSaveButton);
            this.Controls.Add(this.mainPictureBox);
            this.Name = "MainForm";
            this.Text = "FamilyTreeMaker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Button ImageSaveButton;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem オブジェクトの追加AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem オブジェクトの削除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolStripMenuItem 婚姻関係を設定MToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox isDeadCheck;
        private System.Windows.Forms.CheckBox isProbandCheck;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton unknownRadio;
        private System.Windows.Forms.CheckBox isSufferedCheck;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

