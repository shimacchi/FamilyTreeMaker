﻿namespace FamilyTreeMaker
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
            this.親子関係を設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageSaveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.childNumLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isConsanguineousCheck = new System.Windows.Forms.CheckBox();
            this.isSufferedCheck = new System.Windows.Forms.CheckBox();
            this.unknownRadio = new System.Windows.Forms.RadioButton();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ageOfDeathNumeric = new System.Windows.Forms.NumericUpDown();
            this.isDeadCheck = new System.Windows.Forms.CheckBox();
            this.isProbandCheck = new System.Windows.Forms.CheckBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.infoTextFontSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageOfDeathNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTextFontSizeNumeric)).BeginInit();
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
            this.mainPictureBox.Size = new System.Drawing.Size(529, 529);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Click += new System.EventHandler(this.mainPictureBox_Click);
            this.mainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPictureBox_Paint);
            this.mainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseDown);
            this.mainPictureBox.Resize += new System.EventHandler(this.mainPictureBox_Resize);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.オブジェクトの追加AToolStripMenuItem,
            this.オブジェクトの削除DToolStripMenuItem,
            this.toolStripMenuItem1,
            this.婚姻関係を設定MToolStripMenuItem,
            this.親子関係を設定ToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(203, 106);
            // 
            // オブジェクトの追加AToolStripMenuItem
            // 
            this.オブジェクトの追加AToolStripMenuItem.Name = "オブジェクトの追加AToolStripMenuItem";
            this.オブジェクトの追加AToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.オブジェクトの追加AToolStripMenuItem.Text = "人物追加(&A)";
            this.オブジェクトの追加AToolStripMenuItem.Click += new System.EventHandler(this.オブジェクトの追加AToolStripMenuItem_Click);
            // 
            // オブジェクトの削除DToolStripMenuItem
            // 
            this.オブジェクトの削除DToolStripMenuItem.Name = "オブジェクトの削除DToolStripMenuItem";
            this.オブジェクトの削除DToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.オブジェクトの削除DToolStripMenuItem.Text = "人物削除(&D)";
            this.オブジェクトの削除DToolStripMenuItem.Click += new System.EventHandler(this.オブジェクトの削除DToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // 婚姻関係を設定MToolStripMenuItem
            // 
            this.婚姻関係を設定MToolStripMenuItem.Name = "婚姻関係を設定MToolStripMenuItem";
            this.婚姻関係を設定MToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.婚姻関係を設定MToolStripMenuItem.Text = "婚姻関係を設定(&M)";
            // 
            // 親子関係を設定ToolStripMenuItem
            // 
            this.親子関係を設定ToolStripMenuItem.Name = "親子関係を設定ToolStripMenuItem";
            this.親子関係を設定ToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.親子関係を設定ToolStripMenuItem.Text = "親子関係を設定(&F)";
            // 
            // ImageSaveButton
            // 
            this.ImageSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSaveButton.Location = new System.Drawing.Point(562, 485);
            this.ImageSaveButton.Name = "ImageSaveButton";
            this.ImageSaveButton.Size = new System.Drawing.Size(208, 56);
            this.ImageSaveButton.TabIndex = 1;
            this.ImageSaveButton.Text = "イメージを保存";
            this.ImageSaveButton.UseVisualStyleBackColor = true;
            this.ImageSaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(562, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 56);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "人物追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.childNumLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.isConsanguineousCheck);
            this.groupBox1.Controls.Add(this.isSufferedCheck);
            this.groupBox1.Controls.Add(this.unknownRadio);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.femaleRadio);
            this.groupBox1.Controls.Add(this.maleRadio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ageOfDeathNumeric);
            this.groupBox1.Controls.Add(this.isDeadCheck);
            this.groupBox1.Controls.Add(this.isProbandCheck);
            this.groupBox1.Location = new System.Drawing.Point(562, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 272);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人物の情報";
            // 
            // childNumLabel
            // 
            this.childNumLabel.AutoSize = true;
            this.childNumLabel.Location = new System.Drawing.Point(76, 226);
            this.childNumLabel.Name = "childNumLabel";
            this.childNumLabel.Size = new System.Drawing.Size(15, 15);
            this.childNumLabel.TabIndex = 13;
            this.childNumLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "子供の数";
            // 
            // isConsanguineousCheck
            // 
            this.isConsanguineousCheck.AutoSize = true;
            this.isConsanguineousCheck.Location = new System.Drawing.Point(9, 171);
            this.isConsanguineousCheck.Name = "isConsanguineousCheck";
            this.isConsanguineousCheck.Size = new System.Drawing.Size(74, 19);
            this.isConsanguineousCheck.TabIndex = 10;
            this.isConsanguineousCheck.Text = "近親婚";
            this.isConsanguineousCheck.UseVisualStyleBackColor = true;
            // 
            // isSufferedCheck
            // 
            this.isSufferedCheck.AutoSize = true;
            this.isSufferedCheck.Location = new System.Drawing.Point(128, 78);
            this.isSufferedCheck.Name = "isSufferedCheck";
            this.isSufferedCheck.Size = new System.Drawing.Size(74, 19);
            this.isSufferedCheck.TabIndex = 9;
            this.isSufferedCheck.Text = "罹患者";
            this.isSufferedCheck.UseVisualStyleBackColor = true;
            this.isSufferedCheck.CheckedChanged += new System.EventHandler(this.isSufferedCheck_CheckedChanged);
            // 
            // unknownRadio
            // 
            this.unknownRadio.AutoSize = true;
            this.unknownRadio.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.unknownRadio.Location = new System.Drawing.Point(10, 128);
            this.unknownRadio.Name = "unknownRadio";
            this.unknownRadio.Size = new System.Drawing.Size(88, 19);
            this.unknownRadio.TabIndex = 8;
            this.unknownRadio.TabStop = true;
            this.unknownRadio.Tag = "2";
            this.unknownRadio.Text = "性別不明";
            this.unknownRadio.UseVisualStyleBackColor = true;
            this.unknownRadio.CheckedChanged += new System.EventHandler(this.maleRadio_CheckedChanged);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(10, 45);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(89, 22);
            this.nameText.TabIndex = 7;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
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
            this.femaleRadio.Location = new System.Drawing.Point(10, 103);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(58, 19);
            this.femaleRadio.TabIndex = 5;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Tag = "1";
            this.femaleRadio.Text = "女性";
            this.femaleRadio.UseVisualStyleBackColor = true;
            this.femaleRadio.CheckedChanged += new System.EventHandler(this.maleRadio_CheckedChanged);
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(10, 78);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(58, 19);
            this.maleRadio.TabIndex = 4;
            this.maleRadio.TabStop = true;
            this.maleRadio.Tag = "0";
            this.maleRadio.Text = "男性";
            this.maleRadio.UseVisualStyleBackColor = true;
            this.maleRadio.CheckedChanged += new System.EventHandler(this.maleRadio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "死亡時年齢";
            // 
            // ageOfDeathNumeric
            // 
            this.ageOfDeathNumeric.Location = new System.Drawing.Point(127, 168);
            this.ageOfDeathNumeric.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.ageOfDeathNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ageOfDeathNumeric.Name = "ageOfDeathNumeric";
            this.ageOfDeathNumeric.Size = new System.Drawing.Size(82, 22);
            this.ageOfDeathNumeric.TabIndex = 2;
            this.ageOfDeathNumeric.ValueChanged += new System.EventHandler(this.ageOfDeathNumeric_ValueChanged);
            // 
            // isDeadCheck
            // 
            this.isDeadCheck.AutoSize = true;
            this.isDeadCheck.Location = new System.Drawing.Point(128, 128);
            this.isDeadCheck.Name = "isDeadCheck";
            this.isDeadCheck.Size = new System.Drawing.Size(59, 19);
            this.isDeadCheck.TabIndex = 1;
            this.isDeadCheck.Text = "死亡";
            this.isDeadCheck.UseVisualStyleBackColor = true;
            this.isDeadCheck.CheckedChanged += new System.EventHandler(this.isDeadCheck_CheckedChanged);
            // 
            // isProbandCheck
            // 
            this.isProbandCheck.AutoSize = true;
            this.isProbandCheck.Location = new System.Drawing.Point(128, 103);
            this.isProbandCheck.Name = "isProbandCheck";
            this.isProbandCheck.Size = new System.Drawing.Size(74, 19);
            this.isProbandCheck.TabIndex = 0;
            this.isProbandCheck.Text = "発端者";
            this.isProbandCheck.UseVisualStyleBackColor = true;
            this.isProbandCheck.CheckedChanged += new System.EventHandler(this.isProbandCheck_CheckedChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(684, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 56);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "人物削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "表示列数";
            // 
            // colSizeNumeric
            // 
            this.colSizeNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colSizeNumeric.Location = new System.Drawing.Point(562, 98);
            this.colSizeNumeric.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.colSizeNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colSizeNumeric.Name = "colSizeNumeric";
            this.colSizeNumeric.Size = new System.Drawing.Size(85, 22);
            this.colSizeNumeric.TabIndex = 11;
            this.colSizeNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colSizeNumeric.ValueChanged += new System.EventHandler(this.charSizeNumeric_ValueChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bmp";
            // 
            // infoTextFontSizeNumeric
            // 
            this.infoTextFontSizeNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoTextFontSizeNumeric.Location = new System.Drawing.Point(664, 98);
            this.infoTextFontSizeNumeric.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.infoTextFontSizeNumeric.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.infoTextFontSizeNumeric.Name = "infoTextFontSizeNumeric";
            this.infoTextFontSizeNumeric.Size = new System.Drawing.Size(85, 22);
            this.infoTextFontSizeNumeric.TabIndex = 12;
            this.infoTextFontSizeNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.infoTextFontSizeNumeric.ValueChanged += new System.EventHandler(this.infoTextFontSizeNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(661, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "情報文字サイズ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.infoTextFontSizeNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colSizeNumeric);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.ageOfDeathNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTextFontSizeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.NumericUpDown ageOfDeathNumeric;
        private System.Windows.Forms.CheckBox isDeadCheck;
        private System.Windows.Forms.CheckBox isProbandCheck;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton unknownRadio;
        private System.Windows.Forms.CheckBox isSufferedCheck;
        private System.Windows.Forms.CheckBox isConsanguineousCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown colSizeNumeric;
        private System.Windows.Forms.ToolStripMenuItem 親子関係を設定ToolStripMenuItem;
        private System.Windows.Forms.Label childNumLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown infoTextFontSizeNumeric;
        private System.Windows.Forms.Label label4;
    }
}

