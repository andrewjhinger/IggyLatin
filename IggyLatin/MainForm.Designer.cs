namespace IggyLatin
{
    partial class MainForm
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
            this.iterationsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.stringLabel = new System.Windows.Forms.Label();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.originalLabel = new System.Windows.Forms.Label();
            this.builderLabel = new System.Windows.Forms.Label();
            this.expressionLabel = new System.Windows.Forms.Label();
            this.stringIggyLabel = new System.Windows.Forms.Label();
            this.builderIggyLabel = new System.Windows.Forms.Label();
            this.expressionIggyLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // iterationsNumericUpDown
            // 
            this.iterationsNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.iterationsNumericUpDown.Location = new System.Drawing.Point(163, 32);
            this.iterationsNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.iterationsNumericUpDown.Name = "iterationsNumericUpDown";
            this.iterationsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.iterationsNumericUpDown.TabIndex = 0;
            this.iterationsNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(470, 62);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(90, 23);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "convertButton";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(470, 203);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // originalTextBox
            // 
            this.originalTextBox.Location = new System.Drawing.Point(163, 64);
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.Size = new System.Drawing.Size(301, 20);
            this.originalTextBox.TabIndex = 3;
            // 
            // stringLabel
            // 
            this.stringLabel.AutoSize = true;
            this.stringLabel.Location = new System.Drawing.Point(120, 102);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Size = new System.Drawing.Size(37, 13);
            this.stringLabel.TabIndex = 4;
            this.stringLabel.Text = "String:";
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Location = new System.Drawing.Point(104, 34);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(53, 13);
            this.iterationsLabel.TabIndex = 5;
            this.iterationsLabel.Text = "Iterations:";
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Location = new System.Drawing.Point(112, 67);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(45, 13);
            this.originalLabel.TabIndex = 6;
            this.originalLabel.Text = "Original:";
            // 
            // builderLabel
            // 
            this.builderLabel.AutoSize = true;
            this.builderLabel.Location = new System.Drawing.Point(85, 137);
            this.builderLabel.Name = "builderLabel";
            this.builderLabel.Size = new System.Drawing.Size(72, 13);
            this.builderLabel.TabIndex = 7;
            this.builderLabel.Text = "String Builder:";
            // 
            // expressionLabel
            // 
            this.expressionLabel.AutoSize = true;
            this.expressionLabel.Location = new System.Drawing.Point(56, 167);
            this.expressionLabel.Name = "expressionLabel";
            this.expressionLabel.Size = new System.Drawing.Size(101, 13);
            this.expressionLabel.TabIndex = 8;
            this.expressionLabel.Text = "\tRegular Expression:";
            // 
            // stringIggyLabel
            // 
            this.stringIggyLabel.AutoSize = true;
            this.stringIggyLabel.Location = new System.Drawing.Point(163, 102);
            this.stringIggyLabel.Name = "stringIggyLabel";
            this.stringIggyLabel.Size = new System.Drawing.Size(16, 13);
            this.stringIggyLabel.TabIndex = 9;
            this.stringIggyLabel.Text = "...";
            // 
            // builderIggyLabel
            // 
            this.builderIggyLabel.AutoSize = true;
            this.builderIggyLabel.Location = new System.Drawing.Point(163, 137);
            this.builderIggyLabel.Name = "builderIggyLabel";
            this.builderIggyLabel.Size = new System.Drawing.Size(16, 13);
            this.builderIggyLabel.TabIndex = 10;
            this.builderIggyLabel.Text = "...";
            // 
            // expressionIggyLabel
            // 
            this.expressionIggyLabel.AutoSize = true;
            this.expressionIggyLabel.Location = new System.Drawing.Point(163, 167);
            this.expressionIggyLabel.Name = "expressionIggyLabel";
            this.expressionIggyLabel.Size = new System.Drawing.Size(16, 13);
            this.expressionIggyLabel.TabIndex = 11;
            this.expressionIggyLabel.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 185);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 239);
            this.Controls.Add(this.expressionIggyLabel);
            this.Controls.Add(this.builderIggyLabel);
            this.Controls.Add(this.stringIggyLabel);
            this.Controls.Add(this.expressionLabel);
            this.Controls.Add(this.builderLabel);
            this.Controls.Add(this.originalLabel);
            this.Controls.Add(this.iterationsLabel);
            this.Controls.Add(this.stringLabel);
            this.Controls.Add(this.originalTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.iterationsNumericUpDown);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " IggyLatin - 3 Ways";
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown iterationsNumericUpDown;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox originalTextBox;
        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Label builderLabel;
        private System.Windows.Forms.Label expressionLabel;
        private System.Windows.Forms.Label stringIggyLabel;
        private System.Windows.Forms.Label builderIggyLabel;
        private System.Windows.Forms.Label expressionIggyLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

