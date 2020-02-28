namespace C_Sharp_rich_text_editor
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBold = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeFont = new System.Windows.Forms.ToolStripMenuItem();
            this.textAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLeftAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCenterAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRightAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddImage = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewFile = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderlined = new System.Windows.Forms.ToolStripButton();
            this.btnChangeFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLeftAlign = new System.Windows.Forms.ToolStripButton();
            this.btnCenterAlign = new System.Windows.Forms.ToolStripButton();
            this.btnRightAlign = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddImage = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.MainText = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewFile,
            this.mnuLoadFile,
            this.mnuSaveFile,
            this.toolStripSeparator3,
            this.mnuClose});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(40, 21);
            this.mnuFile.Text = "&File";
            // 
            // mnuNewFile
            // 
            this.mnuNewFile.Image = global::C_Sharp_rich_text_editor.Properties.Resources.files_new_file_icon;
            this.mnuNewFile.Name = "mnuNewFile";
            this.mnuNewFile.Size = new System.Drawing.Size(130, 22);
            this.mnuNewFile.Text = "&New file";
            this.mnuNewFile.Click += new System.EventHandler(this.mnuNewFile_Click);
            // 
            // mnuLoadFile
            // 
            this.mnuLoadFile.Image = global::C_Sharp_rich_text_editor.Properties.Resources.open_file_icon;
            this.mnuLoadFile.Name = "mnuLoadFile";
            this.mnuLoadFile.Size = new System.Drawing.Size(130, 22);
            this.mnuLoadFile.Text = "&Open file";
            this.mnuLoadFile.Click += new System.EventHandler(this.mnuLoadFile_Click);
            // 
            // mnuSaveFile
            // 
            this.mnuSaveFile.Image = global::C_Sharp_rich_text_editor.Properties.Resources.file_save_icon;
            this.mnuSaveFile.Name = "mnuSaveFile";
            this.mnuSaveFile.Size = new System.Drawing.Size(130, 22);
            this.mnuSaveFile.Text = "&Save file";
            this.mnuSaveFile.Click += new System.EventHandler(this.mnuSaveFile_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(127, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Image = global::C_Sharp_rich_text_editor.Properties.Resources.exit_icon;
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(130, 22);
            this.mnuClose.Text = "&Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBold,
            this.mnuItalic,
            this.mnuUnderline,
            this.mnuChangeFont,
            this.textAlignToolStripMenuItem,
            this.mnuAddImage});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // mnuBold
            // 
            this.mnuBold.Image = global::C_Sharp_rich_text_editor.Properties.Resources.bold_467935;
            this.mnuBold.Name = "mnuBold";
            this.mnuBold.Size = new System.Drawing.Size(151, 22);
            this.mnuBold.Text = "&Bold";
            this.mnuBold.Click += new System.EventHandler(this.mnuBold_Click);
            // 
            // mnuItalic
            // 
            this.mnuItalic.Image = global::C_Sharp_rich_text_editor.Properties.Resources.italic_icon;
            this.mnuItalic.Name = "mnuItalic";
            this.mnuItalic.Size = new System.Drawing.Size(151, 22);
            this.mnuItalic.Text = "&Italic";
            this.mnuItalic.Click += new System.EventHandler(this.mnuItalic_Click);
            // 
            // mnuUnderline
            // 
            this.mnuUnderline.Image = global::C_Sharp_rich_text_editor.Properties.Resources.underline_icon;
            this.mnuUnderline.Name = "mnuUnderline";
            this.mnuUnderline.Size = new System.Drawing.Size(151, 22);
            this.mnuUnderline.Text = "&Underline";
            this.mnuUnderline.Click += new System.EventHandler(this.mnuUnderline_Click);
            // 
            // mnuChangeFont
            // 
            this.mnuChangeFont.Image = global::C_Sharp_rich_text_editor.Properties.Resources.font_icon;
            this.mnuChangeFont.Name = "mnuChangeFont";
            this.mnuChangeFont.Size = new System.Drawing.Size(151, 22);
            this.mnuChangeFont.Text = "Change &font";
            this.mnuChangeFont.Click += new System.EventHandler(this.mnuChangeFont_Click);
            // 
            // textAlignToolStripMenuItem
            // 
            this.textAlignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLeftAlign,
            this.mnuCenterAlign,
            this.mnuRightAlign});
            this.textAlignToolStripMenuItem.Name = "textAlignToolStripMenuItem";
            this.textAlignToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.textAlignToolStripMenuItem.Text = "Text align";
            // 
            // mnuLeftAlign
            // 
            this.mnuLeftAlign.Image = global::C_Sharp_rich_text_editor.Properties.Resources.text_alignment_align_left_icon;
            this.mnuLeftAlign.Name = "mnuLeftAlign";
            this.mnuLeftAlign.Size = new System.Drawing.Size(117, 22);
            this.mnuLeftAlign.Text = "&Left";
            this.mnuLeftAlign.Click += new System.EventHandler(this.mnuLeftAlign_Click);
            // 
            // mnuCenterAlign
            // 
            this.mnuCenterAlign.Image = global::C_Sharp_rich_text_editor.Properties.Resources.alignment_center_align_text_icon;
            this.mnuCenterAlign.Name = "mnuCenterAlign";
            this.mnuCenterAlign.Size = new System.Drawing.Size(117, 22);
            this.mnuCenterAlign.Text = "&Center";
            this.mnuCenterAlign.Click += new System.EventHandler(this.mnuCenterAlign_Click);
            // 
            // mnuRightAlign
            // 
            this.mnuRightAlign.Image = global::C_Sharp_rich_text_editor.Properties.Resources.align_alignment_text_right_icon;
            this.mnuRightAlign.Name = "mnuRightAlign";
            this.mnuRightAlign.Size = new System.Drawing.Size(117, 22);
            this.mnuRightAlign.Text = "&Right";
            this.mnuRightAlign.Click += new System.EventHandler(this.mnuRightAlign_Click);
            // 
            // mnuAddImage
            // 
            this.mnuAddImage.Image = global::C_Sharp_rich_text_editor.Properties.Resources.insert_image_pic_icon;
            this.mnuAddImage.Name = "mnuAddImage";
            this.mnuAddImage.Size = new System.Drawing.Size(151, 22);
            this.mnuAddImage.Text = "Add image";
            this.mnuAddImage.Click += new System.EventHandler(this.mnuAddImage_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewFile,
            this.btnOpenFile,
            this.btnSaveFile,
            this.toolStripSeparator1,
            this.btnBold,
            this.btnItalic,
            this.btnUnderlined,
            this.btnChangeFont,
            this.toolStripSeparator2,
            this.btnLeftAlign,
            this.btnCenterAlign,
            this.btnRightAlign,
            this.toolStripSeparator4,
            this.btnAddImage,
            this.btnPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewFile
            // 
            this.btnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewFile.Image = global::C_Sharp_rich_text_editor.Properties.Resources.files_new_file_icon;
            this.btnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(23, 22);
            this.btnNewFile.Text = "New File";
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFile.Image = global::C_Sharp_rich_text_editor.Properties.Resources.open_file_icon;
            this.btnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(23, 22);
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveFile.Image = global::C_Sharp_rich_text_editor.Properties.Resources.file_save_icon;
            this.btnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(23, 22);
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = global::C_Sharp_rich_text_editor.Properties.Resources.bold_467935;
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Image = global::C_Sharp_rich_text_editor.Properties.Resources.italic_icon;
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(23, 22);
            this.btnItalic.Text = "Italic";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderlined
            // 
            this.btnUnderlined.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderlined.Image = global::C_Sharp_rich_text_editor.Properties.Resources.underline_icon;
            this.btnUnderlined.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderlined.Name = "btnUnderlined";
            this.btnUnderlined.Size = new System.Drawing.Size(23, 22);
            this.btnUnderlined.Text = "Underline";
            this.btnUnderlined.Click += new System.EventHandler(this.btnUnderlined_Click);
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChangeFont.Image = global::C_Sharp_rich_text_editor.Properties.Resources.font_icon;
            this.btnChangeFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(23, 22);
            this.btnChangeFont.Text = "Change font";
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLeftAlign
            // 
            this.btnLeftAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLeftAlign.Image = global::C_Sharp_rich_text_editor.Properties.Resources.text_alignment_align_left_icon;
            this.btnLeftAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLeftAlign.Name = "btnLeftAlign";
            this.btnLeftAlign.Size = new System.Drawing.Size(23, 22);
            this.btnLeftAlign.Text = "Align left";
            this.btnLeftAlign.Click += new System.EventHandler(this.btnLeftAlign_Click);
            // 
            // btnCenterAlign
            // 
            this.btnCenterAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCenterAlign.Image = global::C_Sharp_rich_text_editor.Properties.Resources.alignment_center_align_text_icon;
            this.btnCenterAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCenterAlign.Name = "btnCenterAlign";
            this.btnCenterAlign.Size = new System.Drawing.Size(23, 22);
            this.btnCenterAlign.Text = "Align center";
            this.btnCenterAlign.Click += new System.EventHandler(this.btnCenterAlign_Click);
            // 
            // btnRightAlign
            // 
            this.btnRightAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRightAlign.Image = global::C_Sharp_rich_text_editor.Properties.Resources.align_alignment_text_right_icon;
            this.btnRightAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRightAlign.Name = "btnRightAlign";
            this.btnRightAlign.Size = new System.Drawing.Size(23, 22);
            this.btnRightAlign.Text = "Align right";
            this.btnRightAlign.Click += new System.EventHandler(this.btnRightAlign_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddImage
            // 
            this.btnAddImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddImage.Image = global::C_Sharp_rich_text_editor.Properties.Resources.insert_image_pic_icon;
            this.btnAddImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(23, 22);
            this.btnAddImage.Text = "toolStripButton1";
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = global::C_Sharp_rich_text_editor.Properties.Resources.printer_print_printing_icon;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 22);
            this.btnPrint.Text = "toolStripButton1";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // MainText
            // 
            this.MainText.AutoWordSelection = true;
            this.MainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainText.Location = new System.Drawing.Point(0, 52);
            this.MainText.Margin = new System.Windows.Forms.Padding(4);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(1067, 490);
            this.MainText.TabIndex = 5;
            this.MainText.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 542);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "My notes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox MainText;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderlined;
        private System.Windows.Forms.ToolStripButton btnChangeFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.ToolStripButton btnSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnLeftAlign;
        private System.Windows.Forms.ToolStripButton btnCenterAlign;
        private System.Windows.Forms.ToolStripButton btnRightAlign;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNewFile;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBold;
        private System.Windows.Forms.ToolStripMenuItem mnuItalic;
        private System.Windows.Forms.ToolStripMenuItem mnuUnderline;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeFont;
        private System.Windows.Forms.ToolStripMenuItem textAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLeftAlign;
        private System.Windows.Forms.ToolStripMenuItem mnuCenterAlign;
        private System.Windows.Forms.ToolStripMenuItem mnuRightAlign;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnNewFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuAddImage;
        private System.Windows.Forms.ToolStripButton btnAddImage;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}