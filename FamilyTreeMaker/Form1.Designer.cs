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
            this.男性を追加FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.女性を追加FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.性別不明を追加UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オブジェクトの削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.婚姻関係を設定MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.婚姻関係を削除IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.親子関係を設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.親子関係を削除EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageSaveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isConsanguineousCheck = new System.Windows.Forms.CheckBox();
            this.isSufferedCheck = new System.Windows.Forms.CheckBox();
            this.unknownRadio = new System.Windows.Forms.RadioButton();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ageNumeric = new System.Windows.Forms.NumericUpDown();
            this.isDeadCheck = new System.Windows.Forms.CheckBox();
            this.isProbandCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.infoTextFontSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).BeginInit();
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
            this.mainPictureBox.Location = new System.Drawing.Point(9, 10);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(542, 542);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Click += new System.EventHandler(this.mainPictureBox_Click);
            this.mainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPictureBox_Paint);
            this.mainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseDown);
            this.mainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseUp);
            this.mainPictureBox.Resize += new System.EventHandler(this.mainPictureBox_Resize);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.オブジェクトの追加AToolStripMenuItem,
            this.オブジェクトの削除DToolStripMenuItem,
            this.toolStripMenuItem2,
            this.婚姻関係を設定MToolStripMenuItem,
            this.婚姻関係を削除IToolStripMenuItem,
            this.toolStripMenuItem1,
            this.親子関係を設定ToolStripMenuItem,
            this.親子関係を削除EToolStripMenuItem,
            this.toolStripMenuItem3,
            this.保存SToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(175, 176);
            // 
            // オブジェクトの追加AToolStripMenuItem
            // 
            this.オブジェクトの追加AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.男性を追加FToolStripMenuItem,
            this.女性を追加FToolStripMenuItem,
            this.性別不明を追加UToolStripMenuItem});
            this.オブジェクトの追加AToolStripMenuItem.Name = "オブジェクトの追加AToolStripMenuItem";
            this.オブジェクトの追加AToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.オブジェクトの追加AToolStripMenuItem.Text = "人物追加(&A)";
            // 
            // 男性を追加FToolStripMenuItem
            // 
            this.男性を追加FToolStripMenuItem.Name = "男性を追加FToolStripMenuItem";
            this.男性を追加FToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.男性を追加FToolStripMenuItem.Text = "男性を追加(&M)";
            this.男性を追加FToolStripMenuItem.Click += new System.EventHandler(this.男性を追加FToolStripMenuItem_Click);
            // 
            // 女性を追加FToolStripMenuItem
            // 
            this.女性を追加FToolStripMenuItem.Name = "女性を追加FToolStripMenuItem";
            this.女性を追加FToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.女性を追加FToolStripMenuItem.Text = "女性を追加(&F)";
            this.女性を追加FToolStripMenuItem.Click += new System.EventHandler(this.女性を追加FToolStripMenuItem_Click);
            // 
            // 性別不明を追加UToolStripMenuItem
            // 
            this.性別不明を追加UToolStripMenuItem.Name = "性別不明を追加UToolStripMenuItem";
            this.性別不明を追加UToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.性別不明を追加UToolStripMenuItem.Text = "性別不明を追加(&U)";
            this.性別不明を追加UToolStripMenuItem.Click += new System.EventHandler(this.性別不明を追加UToolStripMenuItem_Click);
            // 
            // オブジェクトの削除DToolStripMenuItem
            // 
            this.オブジェクトの削除DToolStripMenuItem.Name = "オブジェクトの削除DToolStripMenuItem";
            this.オブジェクトの削除DToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.オブジェクトの削除DToolStripMenuItem.Text = "人物削除(&D)";
            this.オブジェクトの削除DToolStripMenuItem.Click += new System.EventHandler(this.オブジェクトの削除DToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 6);
            // 
            // 婚姻関係を設定MToolStripMenuItem
            // 
            this.婚姻関係を設定MToolStripMenuItem.Name = "婚姻関係を設定MToolStripMenuItem";
            this.婚姻関係を設定MToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.婚姻関係を設定MToolStripMenuItem.Text = "婚姻関係を設定(&M)";
            this.婚姻関係を設定MToolStripMenuItem.Click += new System.EventHandler(this.婚姻関係を設定MToolStripMenuItem_Click);
            // 
            // 婚姻関係を削除IToolStripMenuItem
            // 
            this.婚姻関係を削除IToolStripMenuItem.Name = "婚姻関係を削除IToolStripMenuItem";
            this.婚姻関係を削除IToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.婚姻関係を削除IToolStripMenuItem.Text = "婚姻関係を削除(&I)";
            this.婚姻関係を削除IToolStripMenuItem.Click += new System.EventHandler(this.婚姻関係を削除IToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // 親子関係を設定ToolStripMenuItem
            // 
            this.親子関係を設定ToolStripMenuItem.Name = "親子関係を設定ToolStripMenuItem";
            this.親子関係を設定ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.親子関係を設定ToolStripMenuItem.Text = "親子関係を設定(&F)";
            this.親子関係を設定ToolStripMenuItem.Click += new System.EventHandler(this.親子関係を設定ToolStripMenuItem_Click);
            // 
            // 親子関係を削除EToolStripMenuItem
            // 
            this.親子関係を削除EToolStripMenuItem.Name = "親子関係を削除EToolStripMenuItem";
            this.親子関係を削除EToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.親子関係を削除EToolStripMenuItem.Text = "親子関係を削除(&E)";
            this.親子関係を削除EToolStripMenuItem.Click += new System.EventHandler(this.親子関係を削除EToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(171, 6);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.保存SToolStripMenuItem.Text = "保存(S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // ImageSaveButton
            // 
            this.ImageSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSaveButton.Location = new System.Drawing.Point(568, 231);
            this.ImageSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImageSaveButton.Name = "ImageSaveButton";
            this.ImageSaveButton.Size = new System.Drawing.Size(175, 45);
            this.ImageSaveButton.TabIndex = 1;
            this.ImageSaveButton.Text = "家系図をファイルに保存";
            this.ImageSaveButton.UseVisualStyleBackColor = true;
            this.ImageSaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.isConsanguineousCheck);
            this.groupBox1.Controls.Add(this.isSufferedCheck);
            this.groupBox1.Controls.Add(this.unknownRadio);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.femaleRadio);
            this.groupBox1.Controls.Add(this.maleRadio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ageNumeric);
            this.groupBox1.Controls.Add(this.isDeadCheck);
            this.groupBox1.Controls.Add(this.isProbandCheck);
            this.groupBox1.Location = new System.Drawing.Point(568, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.MinimumSize = new System.Drawing.Size(156, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(175, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人物の情報";
            // 
            // isConsanguineousCheck
            // 
            this.isConsanguineousCheck.AutoSize = true;
            this.isConsanguineousCheck.Location = new System.Drawing.Point(7, 137);
            this.isConsanguineousCheck.Margin = new System.Windows.Forms.Padding(2);
            this.isConsanguineousCheck.Name = "isConsanguineousCheck";
            this.isConsanguineousCheck.Size = new System.Drawing.Size(60, 16);
            this.isConsanguineousCheck.TabIndex = 10;
            this.isConsanguineousCheck.Text = "近親婚";
            this.isConsanguineousCheck.UseVisualStyleBackColor = true;
            this.isConsanguineousCheck.CheckedChanged += new System.EventHandler(this.isConsanguineousCheck_CheckedChanged);
            // 
            // isSufferedCheck
            // 
            this.isSufferedCheck.AutoSize = true;
            this.isSufferedCheck.Location = new System.Drawing.Point(96, 62);
            this.isSufferedCheck.Margin = new System.Windows.Forms.Padding(2);
            this.isSufferedCheck.Name = "isSufferedCheck";
            this.isSufferedCheck.Size = new System.Drawing.Size(60, 16);
            this.isSufferedCheck.TabIndex = 9;
            this.isSufferedCheck.Text = "罹患者";
            this.isSufferedCheck.UseVisualStyleBackColor = true;
            this.isSufferedCheck.CheckedChanged += new System.EventHandler(this.isSufferedCheck_CheckedChanged);
            // 
            // unknownRadio
            // 
            this.unknownRadio.AutoSize = true;
            this.unknownRadio.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.unknownRadio.Location = new System.Drawing.Point(8, 102);
            this.unknownRadio.Margin = new System.Windows.Forms.Padding(2);
            this.unknownRadio.Name = "unknownRadio";
            this.unknownRadio.Size = new System.Drawing.Size(71, 16);
            this.unknownRadio.TabIndex = 8;
            this.unknownRadio.TabStop = true;
            this.unknownRadio.Tag = "2";
            this.unknownRadio.Text = "性別不明";
            this.unknownRadio.UseVisualStyleBackColor = true;
            this.unknownRadio.CheckedChanged += new System.EventHandler(this.maleRadio_CheckedChanged);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(8, 36);
            this.nameText.Margin = new System.Windows.Forms.Padding(2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(68, 19);
            this.nameText.TabIndex = 7;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(5, 22);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 12);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "氏名";
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(8, 82);
            this.femaleRadio.Margin = new System.Windows.Forms.Padding(2);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(47, 16);
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
            this.maleRadio.Location = new System.Drawing.Point(8, 62);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(2);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(47, 16);
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
            this.label1.Location = new System.Drawing.Point(94, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "年齢";
            // 
            // ageNumeric
            // 
            this.ageNumeric.Location = new System.Drawing.Point(95, 36);
            this.ageNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.ageNumeric.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.ageNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ageNumeric.Name = "ageNumeric";
            this.ageNumeric.Size = new System.Drawing.Size(62, 19);
            this.ageNumeric.TabIndex = 2;
            this.ageNumeric.ValueChanged += new System.EventHandler(this.ageOfDeathNumeric_ValueChanged);
            // 
            // isDeadCheck
            // 
            this.isDeadCheck.AutoSize = true;
            this.isDeadCheck.Location = new System.Drawing.Point(96, 102);
            this.isDeadCheck.Margin = new System.Windows.Forms.Padding(2);
            this.isDeadCheck.Name = "isDeadCheck";
            this.isDeadCheck.Size = new System.Drawing.Size(48, 16);
            this.isDeadCheck.TabIndex = 1;
            this.isDeadCheck.Text = "死亡";
            this.isDeadCheck.UseVisualStyleBackColor = true;
            this.isDeadCheck.CheckedChanged += new System.EventHandler(this.isDeadCheck_CheckedChanged);
            // 
            // isProbandCheck
            // 
            this.isProbandCheck.AutoSize = true;
            this.isProbandCheck.Location = new System.Drawing.Point(96, 82);
            this.isProbandCheck.Margin = new System.Windows.Forms.Padding(2);
            this.isProbandCheck.Name = "isProbandCheck";
            this.isProbandCheck.Size = new System.Drawing.Size(60, 16);
            this.isProbandCheck.TabIndex = 0;
            this.isProbandCheck.Text = "発端者";
            this.isProbandCheck.UseVisualStyleBackColor = true;
            this.isProbandCheck.CheckedChanged += new System.EventHandler(this.isProbandCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "表示列数";
            // 
            // colSizeNumeric
            // 
            this.colSizeNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colSizeNumeric.Location = new System.Drawing.Point(568, 25);
            this.colSizeNumeric.Margin = new System.Windows.Forms.Padding(2);
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
            this.colSizeNumeric.Size = new System.Drawing.Size(64, 19);
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
            this.saveFileDialog1.DefaultExt = "png";
            // 
            // infoTextFontSizeNumeric
            // 
            this.infoTextFontSizeNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoTextFontSizeNumeric.Location = new System.Drawing.Point(663, 25);
            this.infoTextFontSizeNumeric.Margin = new System.Windows.Forms.Padding(2);
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
            this.infoTextFontSizeNumeric.Size = new System.Drawing.Size(64, 19);
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
            this.label4.Location = new System.Drawing.Point(661, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "情報文字サイズ";
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(568, 289);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(79, 15);
            this.infoLabel.TabIndex = 14;
            this.infoLabel.Text = "Information";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.infoTextFontSizeNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colSizeNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImageSaveButton);
            this.Controls.Add(this.mainPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "家系図作成支援ソフトウェア";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem 婚姻関係を設定MToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ageNumeric;
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown infoTextFontSizeNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 婚姻関係を削除IToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ToolStripMenuItem 親子関係を削除EToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 男性を追加FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 女性を追加FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 性別不明を追加UToolStripMenuItem;
    }
}

