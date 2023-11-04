namespace IndivTask1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddPolygon = new System.Windows.Forms.Button();
            this.United = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(242, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 567);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MD);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MU);
            // 
            // AddPolygon
            // 
            this.AddPolygon.Location = new System.Drawing.Point(14, 16);
            this.AddPolygon.Name = "AddPolygon";
            this.AddPolygon.Size = new System.Drawing.Size(169, 81);
            this.AddPolygon.TabIndex = 1;
            this.AddPolygon.Text = "Добавить полигон";
            this.AddPolygon.UseVisualStyleBackColor = true;
            this.AddPolygon.Click += new System.EventHandler(this.AddPolygon_Click);
            // 
            // United
            // 
            this.United.Location = new System.Drawing.Point(14, 114);
            this.United.Name = "United";
            this.United.Size = new System.Drawing.Size(169, 81);
            this.United.TabIndex = 2;
            this.United.Text = "Объединить";
            this.United.UseVisualStyleBackColor = true;
            this.United.Click += new System.EventHandler(this.United_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(14, 490);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(169, 81);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 583);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.United);
            this.Controls.Add(this.AddPolygon);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddPolygon;
        private System.Windows.Forms.Button United;
        private System.Windows.Forms.Button Clear;
    }
}

