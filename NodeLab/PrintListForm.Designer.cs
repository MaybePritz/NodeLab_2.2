﻿namespace NodeLab
{
    partial class PrintListForm
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
            components = new System.ComponentModel.Container();
            singleLinkedListBindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)singleLinkedListBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 0);
            listBox1.Margin = new Padding(6, 6, 6, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(713, 343);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // PrintListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 343);
            Controls.Add(listBox1);
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PrintListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Текущий список";
            Load += PrintListForm_Load;
            ((System.ComponentModel.ISupportInitialize)singleLinkedListBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource singleLinkedListBindingSource;
        private ListBox listBox1;
    }
}