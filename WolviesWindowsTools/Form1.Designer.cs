namespace WolviesWindowsTools
{
    partial class frmMain
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
            this.tabTools = new System.Windows.Forms.TabControl();
            this.tabPDF_Combine = new System.Windows.Forms.TabPage();
            this.lblDrag_pdf = new System.Windows.Forms.Label();
            this.btnCombine = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveDn = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.lv_files_cmb = new System.Windows.Forms.ListView();
            this.tabPDF_Edit = new System.Windows.Forms.TabPage();
            this.lblDrag_doc = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lv_files_doc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabTools.SuspendLayout();
            this.tabPDF_Combine.SuspendLayout();
            this.tabPDF_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTools
            // 
            this.tabTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTools.Controls.Add(this.tabPDF_Combine);
            this.tabTools.Controls.Add(this.tabPDF_Edit);
            this.tabTools.Location = new System.Drawing.Point(24, 16);
            this.tabTools.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabTools.Name = "tabTools";
            this.tabTools.SelectedIndex = 0;
            this.tabTools.Size = new System.Drawing.Size(912, 512);
            this.tabTools.TabIndex = 0;
            // 
            // tabPDF_Combine
            // 
            this.tabPDF_Combine.Controls.Add(this.lblDrag_pdf);
            this.tabPDF_Combine.Controls.Add(this.btnCombine);
            this.tabPDF_Combine.Controls.Add(this.btnClear);
            this.tabPDF_Combine.Controls.Add(this.btnRemove);
            this.tabPDF_Combine.Controls.Add(this.btnMoveDn);
            this.tabPDF_Combine.Controls.Add(this.btnMoveUp);
            this.tabPDF_Combine.Controls.Add(this.lv_files_cmb);
            this.tabPDF_Combine.Location = new System.Drawing.Point(8, 39);
            this.tabPDF_Combine.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPDF_Combine.Name = "tabPDF_Combine";
            this.tabPDF_Combine.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPDF_Combine.Size = new System.Drawing.Size(896, 465);
            this.tabPDF_Combine.TabIndex = 0;
            this.tabPDF_Combine.Text = "Combine PDF\'s";
            this.tabPDF_Combine.UseVisualStyleBackColor = true;
            // 
            // lblDrag_pdf
            // 
            this.lblDrag_pdf.AutoSize = true;
            this.lblDrag_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrag_pdf.Location = new System.Drawing.Point(190, 173);
            this.lblDrag_pdf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDrag_pdf.Name = "lblDrag_pdf";
            this.lblDrag_pdf.Size = new System.Drawing.Size(320, 44);
            this.lblDrag_pdf.TabIndex = 6;
            this.lblDrag_pdf.Text = "Drag PDF\'s Here";
            // 
            // btnCombine
            // 
            this.btnCombine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCombine.Location = new System.Drawing.Point(734, 406);
            this.btnCombine.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(150, 44);
            this.btnCombine.TabIndex = 5;
            this.btnCombine.Text = "Combine";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.Combine);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(734, 179);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 44);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(734, 123);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 44);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.Remove);
            // 
            // btnMoveDn
            // 
            this.btnMoveDn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveDn.Location = new System.Drawing.Point(734, 67);
            this.btnMoveDn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMoveDn.Name = "btnMoveDn";
            this.btnMoveDn.Size = new System.Drawing.Size(150, 44);
            this.btnMoveDn.TabIndex = 2;
            this.btnMoveDn.Text = "Move Down";
            this.btnMoveDn.UseVisualStyleBackColor = true;
            this.btnMoveDn.Click += new System.EventHandler(this.MoveDn);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.Location = new System.Drawing.Point(734, 12);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(150, 44);
            this.btnMoveUp.TabIndex = 1;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.MoveUp);
            // 
            // lv_files_cmb
            // 
            this.lv_files_cmb.AllowDrop = true;
            this.lv_files_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_files_cmb.Location = new System.Drawing.Point(12, 12);
            this.lv_files_cmb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lv_files_cmb.Name = "lv_files_cmb";
            this.lv_files_cmb.Size = new System.Drawing.Size(706, 435);
            this.lv_files_cmb.TabIndex = 0;
            this.lv_files_cmb.UseCompatibleStateImageBehavior = false;
            this.lv_files_cmb.View = System.Windows.Forms.View.List;
            this.lv_files_cmb.DragDrop += new System.Windows.Forms.DragEventHandler(this.onDrop_PDF);
            this.lv_files_cmb.DragEnter += new System.Windows.Forms.DragEventHandler(this.onEnter_PDF);
            this.lv_files_cmb.DragLeave += new System.EventHandler(this.onLeave_PDF);
            // 
            // tabPDF_Edit
            // 
            this.tabPDF_Edit.Controls.Add(this.lblDrag_doc);
            this.tabPDF_Edit.Controls.Add(this.btnConvert);
            this.tabPDF_Edit.Controls.Add(this.lv_files_doc);
            this.tabPDF_Edit.Location = new System.Drawing.Point(8, 39);
            this.tabPDF_Edit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPDF_Edit.Name = "tabPDF_Edit";
            this.tabPDF_Edit.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPDF_Edit.Size = new System.Drawing.Size(896, 465);
            this.tabPDF_Edit.TabIndex = 1;
            this.tabPDF_Edit.Text = "PDF Edit";
            this.tabPDF_Edit.UseVisualStyleBackColor = true;
            // 
            // lblDrag_doc
            // 
            this.lblDrag_doc.AutoSize = true;
            this.lblDrag_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrag_doc.Location = new System.Drawing.Point(198, 192);
            this.lblDrag_doc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDrag_doc.Name = "lblDrag_doc";
            this.lblDrag_doc.Size = new System.Drawing.Size(292, 44);
            this.lblDrag_doc.TabIndex = 7;
            this.lblDrag_doc.Text = "Drag PDF Here";
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(734, 406);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(150, 44);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.Apply_doc);
            // 
            // lv_files_doc
            // 
            this.lv_files_doc.AllowDrop = true;
            this.lv_files_doc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_files_doc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv_files_doc.Location = new System.Drawing.Point(12, 12);
            this.lv_files_doc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lv_files_doc.MultiSelect = false;
            this.lv_files_doc.Name = "lv_files_doc";
            this.lv_files_doc.Size = new System.Drawing.Size(706, 435);
            this.lv_files_doc.TabIndex = 0;
            this.lv_files_doc.UseCompatibleStateImageBehavior = false;
            this.lv_files_doc.DragDrop += new System.Windows.Forms.DragEventHandler(this.onDrop_doc);
            this.lv_files_doc.DragEnter += new System.Windows.Forms.DragEventHandler(this.onEnter_doc);
            this.lv_files_doc.DragLeave += new System.EventHandler(this.onLeave_doc);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Complete);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(24, 540);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(912, 44);
            this.progressBar1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 594);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabTools);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(966, 534);
            this.Name = "frmMain";
            this.Text = "Wolvies Windows Tools";
            this.tabTools.ResumeLayout(false);
            this.tabPDF_Combine.ResumeLayout(false);
            this.tabPDF_Combine.PerformLayout();
            this.tabPDF_Edit.ResumeLayout(false);
            this.tabPDF_Edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTools;
        private System.Windows.Forms.TabPage tabPDF_Combine;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveDn;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.ListView lv_files_cmb;
        private System.Windows.Forms.Label lblDrag_pdf;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabPDF_Edit;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ListView lv_files_doc;
        private System.Windows.Forms.Label lblDrag_doc;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

