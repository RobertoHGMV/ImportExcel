namespace ImportExcel
{
    partial class ImporterForm
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
            this.gridImporter = new System.Windows.Forms.DataGridView();
            this.cmdOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbQtdLines = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.cbSheet = new System.Windows.Forms.ComboBox();
            this.btnImporter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridImporter)).BeginInit();
            this.SuspendLayout();
            // 
            // gridImporter
            // 
            this.gridImporter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridImporter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImporter.Location = new System.Drawing.Point(16, 47);
            this.gridImporter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridImporter.Name = "gridImporter";
            this.gridImporter.Size = new System.Drawing.Size(933, 358);
            this.gridImporter.TabIndex = 0;
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdOk.Location = new System.Drawing.Point(16, 457);
            this.cmdOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(100, 28);
            this.cmdOk.TabIndex = 2;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 409);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Linhas:";
            // 
            // lbQtdLines
            // 
            this.lbQtdLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQtdLines.AutoSize = true;
            this.lbQtdLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdLines.Location = new System.Drawing.Point(104, 409);
            this.lbQtdLines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQtdLines.Name = "lbQtdLines";
            this.lbQtdLines.Size = new System.Drawing.Size(18, 20);
            this.lbQtdLines.TabIndex = 5;
            this.lbQtdLines.Text = "#";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(16, 15);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(412, 22);
            this.txtFileName.TabIndex = 8;
            // 
            // cbSheet
            // 
            this.cbSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSheet.FormattingEnabled = true;
            this.cbSheet.Location = new System.Drawing.Point(740, 11);
            this.cbSheet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSheet.Name = "cbSheet";
            this.cbSheet.Size = new System.Drawing.Size(208, 24);
            this.cbSheet.TabIndex = 10;
            // 
            // btnImporter
            // 
            this.btnImporter.Location = new System.Drawing.Point(437, 12);
            this.btnImporter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImporter.Name = "btnImporter";
            this.btnImporter.Size = new System.Drawing.Size(112, 28);
            this.btnImporter.TabIndex = 3;
            this.btnImporter.Text = "Importar";
            this.btnImporter.UseVisualStyleBackColor = true;
            this.btnImporter.Click += new System.EventHandler(this.btnImporter_Click);
            // 
            // ImporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 498);
            this.Controls.Add(this.cbSheet);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lbQtdLines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImporter);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.gridImporter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImporterForm";
            this.Text = "Importador";
            ((System.ComponentModel.ISupportInitialize)(this.gridImporter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridImporter;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbQtdLines;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.ComboBox cbSheet;
        private System.Windows.Forms.Button btnImporter;
    }
}

