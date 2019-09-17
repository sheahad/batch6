namespace MyWindowsFormsApp
{
    partial class ArrayUi
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
            this.showButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.elementTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.sizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(184, 101);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(184, 58);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Element";
            // 
            // elementTextBox
            // 
            this.elementTextBox.Location = new System.Drawing.Point(78, 58);
            this.elementTextBox.Name = "elementTextBox";
            this.elementTextBox.Size = new System.Drawing.Size(100, 20);
            this.elementTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(78, 19);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 3;
            // 
            // sizeButton
            // 
            this.sizeButton.Location = new System.Drawing.Point(184, 19);
            this.sizeButton.Name = "sizeButton";
            this.sizeButton.Size = new System.Drawing.Size(75, 23);
            this.sizeButton.TabIndex = 1;
            this.sizeButton.Text = "Size";
            this.sizeButton.UseVisualStyleBackColor = true;
            this.sizeButton.Click += new System.EventHandler(this.sizeButton_Click);
            // 
            // ArrayUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 139);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elementTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.showButton);
            this.Name = "ArrayUi";
            this.Text = "Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox elementTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Button sizeButton;
    }
}