﻿namespace WinformBubble
{
    partial class Item
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            //

            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblContent);
            this.panel1.Location = new System.Drawing.Point(20, 10);
            this.panel1.MaximumSize = new System.Drawing.Size(370, 400);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.panel1.Size = new System.Drawing.Size(26, 36);
            this.panel1.TabIndex = 0;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblContent.ForeColor = System.Drawing.Color.White;
            this.lblContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;

            this.lblContent.Location = new System.Drawing.Point(5, 10);
            this.lblContent.Margin = new System.Windows.Forms.Padding(0);
            this.lblContent.MaximumSize = new System.Drawing.Size(280, 1000);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(16, 16);
            this.lblContent.TabIndex = 5;
            this.lblContent.Text = " ";
            this.lblContent.Visible = false;

            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "Item";

            this.Padding = new System.Windows.Forms.Padding(20, 10, 10, 5);
            this.Size = new System.Drawing.Size(59, 54);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContent;
    }
}