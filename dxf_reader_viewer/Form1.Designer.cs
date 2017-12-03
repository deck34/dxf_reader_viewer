namespace dxf_reader_viewer
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_load = new System.Windows.Forms.ToolStripButton();
            this.ts_save = new System.Windows.Forms.ToolStripButton();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.numPenWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbColors = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_load,
            this.ts_save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(662, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_load
            // 
            this.ts_load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_load.Image = ((System.Drawing.Image)(resources.GetObject("ts_load.Image")));
            this.ts_load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_load.Name = "ts_load";
            this.ts_load.Size = new System.Drawing.Size(59, 22);
            this.ts_load.Text = "Load .dxf";
            this.ts_load.Click += new System.EventHandler(this.ts_load_Click);
            // 
            // ts_save
            // 
            this.ts_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_save.Image = ((System.Drawing.Image)(resources.GetObject("ts_save.Image")));
            this.ts_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_save.Name = "ts_save";
            this.ts_save.Size = new System.Drawing.Size(71, 22);
            this.ts_save.Text = "Save image";
            this.ts_save.Click += new System.EventHandler(this.ts_save_Click);
            // 
            // pb_image
            // 
            this.pb_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_image.BackColor = System.Drawing.SystemColors.Window;
            this.pb_image.Location = new System.Drawing.Point(13, 29);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(544, 426);
            this.pb_image.TabIndex = 1;
            this.pb_image.TabStop = false;
            // 
            // numPenWidth
            // 
            this.numPenWidth.DecimalPlaces = 2;
            this.numPenWidth.Location = new System.Drawing.Point(567, 45);
            this.numPenWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPenWidth.Name = "numPenWidth";
            this.numPenWidth.Size = new System.Drawing.Size(83, 20);
            this.numPenWidth.TabIndex = 2;
            this.numPenWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Толщина линий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цвет линий";
            // 
            // lbColors
            // 
            this.lbColors.FormattingEnabled = true;
            this.lbColors.Location = new System.Drawing.Point(566, 150);
            this.lbColors.Name = "lbColors";
            this.lbColors.Size = new System.Drawing.Size(83, 95);
            this.lbColors.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Маштаб";
            // 
            // numScale
            // 
            this.numScale.DecimalPlaces = 1;
            this.numScale.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numScale.Location = new System.Drawing.Point(566, 93);
            this.numScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(83, 20);
            this.numScale.TabIndex = 6;
            this.numScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(662, 467);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numScale);
            this.Controls.Add(this.lbColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPenWidth);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.toolStrip1);
            this.Name = "main_form";
            this.Text = "DXF reader viewer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_load;
        private System.Windows.Forms.ToolStripButton ts_save;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.NumericUpDown numPenWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbColors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numScale;
    }
}

