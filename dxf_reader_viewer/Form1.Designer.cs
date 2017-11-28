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
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_load,
            this.ts_save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(566, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_load
            // 
            this.ts_load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_load.Image = ((System.Drawing.Image)(resources.GetObject("ts_load.Image")));
            this.ts_load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_load.Name = "ts_load";
            this.ts_load.Size = new System.Drawing.Size(37, 22);
            this.ts_load.Text = "Load";
            this.ts_load.Click += new System.EventHandler(this.ts_load_Click);
            // 
            // ts_save
            // 
            this.ts_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_save.Image = ((System.Drawing.Image)(resources.GetObject("ts_save.Image")));
            this.ts_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_save.Name = "ts_save";
            this.ts_save.Size = new System.Drawing.Size(35, 22);
            this.ts_save.Text = "Save";
            this.ts_save.Click += new System.EventHandler(this.ts_save_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 467);
            this.Controls.Add(this.toolStrip1);
            this.Name = "main_form";
            this.Text = "DXF reader viewer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_load;
        private System.Windows.Forms.ToolStripButton ts_save;
    }
}

