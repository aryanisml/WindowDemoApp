namespace MockWInApp
{
    partial class Form1
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
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lstOutputBox = new System.Windows.Forms.ListBox();
            this.lstInputBox1 = new System.Windows.Forms.ListBox();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.btnDeselect);
            this.SearchPanel.Controls.Add(this.btnSelect);
            this.SearchPanel.Controls.Add(this.lstOutputBox);
            this.SearchPanel.Controls.Add(this.lstInputBox1);
            this.SearchPanel.Location = new System.Drawing.Point(12, 12);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(554, 255);
            this.SearchPanel.TabIndex = 0;
            // 
            // btnDeselect
            // 
            this.btnDeselect.Location = new System.Drawing.Point(250, 115);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(46, 23);
            this.btnDeselect.TabIndex = 3;
            this.btnDeselect.Text = "<";
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(250, 58);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(45, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lstOutputBox
            // 
            this.lstOutputBox.FormattingEnabled = true;
            this.lstOutputBox.Location = new System.Drawing.Point(408, 15);
            this.lstOutputBox.Name = "lstOutputBox";
            this.lstOutputBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstOutputBox.Size = new System.Drawing.Size(120, 212);
            this.lstOutputBox.TabIndex = 1;
            this.lstOutputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstOutputBox_KeyDown);
            // 
            // lstInputBox1
            // 
            this.lstInputBox1.FormattingEnabled = true;
            this.lstInputBox1.Location = new System.Drawing.Point(18, 15);
            this.lstInputBox1.Name = "lstInputBox1";
            this.lstInputBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstInputBox1.Size = new System.Drawing.Size(120, 212);
            this.lstInputBox1.TabIndex = 0;
            this.lstInputBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstInputBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 282);
            this.Controls.Add(this.SearchPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SearchPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.ListBox lstOutputBox;
        private System.Windows.Forms.ListBox lstInputBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDeselect;
    }
}

