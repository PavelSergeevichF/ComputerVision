namespace OpenCV_ImageProcessingBasic
{
    partial class ImageProcessing
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictOriginal = new System.Windows.Forms.PictureBox();
            this.pictResult = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.ApplyFilter = new System.Windows.Forms.Button();
            this.FilterName = new System.Windows.Forms.Label();
            this.GraphicsPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCorrection = new System.Windows.Forms.ComboBox();
            this.ApplyCorrection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictOriginal
            // 
            this.pictOriginal.Location = new System.Drawing.Point(12, 12);
            this.pictOriginal.Name = "pictOriginal";
            this.pictOriginal.Size = new System.Drawing.Size(503, 452);
            this.pictOriginal.TabIndex = 0;
            this.pictOriginal.TabStop = false;
            // 
            // pictResult
            // 
            this.pictResult.Location = new System.Drawing.Point(521, 13);
            this.pictResult.Name = "pictResult";
            this.pictResult.Size = new System.Drawing.Size(473, 451);
            this.pictResult.TabIndex = 1;
            this.pictResult.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(694, 670);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(145, 47);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(866, 601);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(58, 46);
            this.btnGray.TabIndex = 3;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(930, 601);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(64, 46);
            this.btnNegative.TabIndex = 4;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(845, 671);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(632, 483);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(207, 21);
            this.comboBoxFilter.TabIndex = 6;
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.Location = new System.Drawing.Point(845, 483);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(151, 50);
            this.ApplyFilter.TabIndex = 7;
            this.ApplyFilter.Text = "Apply";
            this.ApplyFilter.UseVisualStyleBackColor = true;
            // 
            // FilterName
            // 
            this.FilterName.AutoSize = true;
            this.FilterName.Location = new System.Drawing.Point(629, 467);
            this.FilterName.Name = "FilterName";
            this.FilterName.Size = new System.Drawing.Size(60, 13);
            this.FilterName.TabIndex = 8;
            this.FilterName.Text = "Filter Name";
            // 
            // GraphicsPicture
            // 
            this.GraphicsPicture.Location = new System.Drawing.Point(26, 483);
            this.GraphicsPicture.Name = "GraphicsPicture";
            this.GraphicsPicture.Size = new System.Drawing.Size(530, 196);
            this.GraphicsPicture.TabIndex = 9;
            this.GraphicsPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 687);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 687);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "255";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Correction Name";
            // 
            // comboBoxCorrection
            // 
            this.comboBoxCorrection.FormattingEnabled = true;
            this.comboBoxCorrection.Items.AddRange(new object[] {
            "Линейное растяжение",
            "Гамма-коррекция",
            "Логарифмическая"});
            this.comboBoxCorrection.Location = new System.Drawing.Point(632, 552);
            this.comboBoxCorrection.Name = "comboBoxCorrection";
            this.comboBoxCorrection.Size = new System.Drawing.Size(207, 21);
            this.comboBoxCorrection.TabIndex = 14;
            this.comboBoxCorrection.SelectedIndexChanged += new System.EventHandler(this.comboBoxCorrection_SelectedIndexChanged);
            // 
            // ApplyCorrection
            // 
            this.ApplyCorrection.Location = new System.Drawing.Point(845, 545);
            this.ApplyCorrection.Name = "ApplyCorrection";
            this.ApplyCorrection.Size = new System.Drawing.Size(151, 50);
            this.ApplyCorrection.TabIndex = 15;
            this.ApplyCorrection.Text = "Apply";
            this.ApplyCorrection.UseVisualStyleBackColor = true;
            // 
            // ImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.ApplyCorrection);
            this.Controls.Add(this.comboBoxCorrection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraphicsPicture);
            this.Controls.Add(this.FilterName);
            this.Controls.Add(this.ApplyFilter);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictResult);
            this.Controls.Add(this.pictOriginal);
            this.Name = "ImageProcessing";
            this.Text = "ImageProcessing";
            this.Load += new System.EventHandler(this.ImageProcessing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicsPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictOriginal;
        private System.Windows.Forms.PictureBox pictResult;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button ApplyFilter;
        private System.Windows.Forms.Label FilterName;
        private System.Windows.Forms.PictureBox GraphicsPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCorrection;
        private System.Windows.Forms.Button ApplyCorrection;
    }
}

