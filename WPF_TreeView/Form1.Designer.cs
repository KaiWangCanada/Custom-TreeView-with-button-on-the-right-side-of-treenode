﻿namespace WPF_TreeView
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.wpfTreeView1 = new WPF_TreeView.WpfTreeView();
            this.SuspendLayout();
            // 
            // wpfTreeView1
            // 
            this.wpfTreeView1.BackColor = System.Drawing.SystemColors.Control;
            this.wpfTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpfTreeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.wpfTreeView1.FullRowSelect = true;
            this.wpfTreeView1.ItemHeight = 30;
            this.wpfTreeView1.Location = new System.Drawing.Point(0, 0);
            this.wpfTreeView1.Name = "wpfTreeView1";
            this.wpfTreeView1.ShowLines = false;
            this.wpfTreeView1.Size = new System.Drawing.Size(256, 437);
            this.wpfTreeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 437);
            this.Controls.Add(this.wpfTreeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WpfTreeView wpfTreeView1;
    }
}

