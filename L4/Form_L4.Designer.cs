﻿namespace L4
{
    partial class Form_L4
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
            this.SuspendLayout();
            // 
            // Form_L4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 381);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_L4";
            this.Text = "Form_L4";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_L4_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_L4_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_L4_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_L4_MouseUp);
            this.Resize += new System.EventHandler(this.Form_L4_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

