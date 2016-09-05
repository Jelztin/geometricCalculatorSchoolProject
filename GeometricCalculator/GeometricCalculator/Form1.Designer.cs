namespace GeometricCalculator
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
            this.FigureTypeSelector = new System.Windows.Forms.ComboBox();
            this.Operation = new System.Windows.Forms.ComboBox();
            this.v1 = new System.Windows.Forms.TextBox();
            this.v2 = new System.Windows.Forms.TextBox();
            this.v3 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FigureTypeSelector
            // 
            this.FigureTypeSelector.AccessibleName = "figureTypeSelector";
            this.FigureTypeSelector.FormattingEnabled = true;
            this.FigureTypeSelector.Items.AddRange(new object[] {
            "Box",
            "Square"});
            this.FigureTypeSelector.Location = new System.Drawing.Point(13, 28);
            this.FigureTypeSelector.Name = "FigureTypeSelector";
            this.FigureTypeSelector.Size = new System.Drawing.Size(121, 21);
            this.FigureTypeSelector.TabIndex = 0;
            // 
            // Operation
            // 
            this.Operation.FormattingEnabled = true;
            this.Operation.Items.AddRange(new object[] {
            "Area",
            "Edge Length",
            "Volume",
            "Surface Area"});
            this.Operation.Location = new System.Drawing.Point(140, 28);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(121, 21);
            this.Operation.TabIndex = 1;
            // 
            // v1
            // 
            this.v1.Location = new System.Drawing.Point(267, 28);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(100, 20);
            this.v1.TabIndex = 2;
            this.v1.Text = "v1";
            // 
            // v2
            // 
            this.v2.Location = new System.Drawing.Point(267, 54);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(100, 20);
            this.v2.TabIndex = 3;
            this.v2.Text = "v2";
            // 
            // v3
            // 
            this.v3.Location = new System.Drawing.Point(266, 80);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(100, 20);
            this.v3.TabIndex = 4;
            this.v3.Text = "v3";
            // 
            // Result
            // 
            this.Result.Enabled = false;
            this.Result.Location = new System.Drawing.Point(33, 181);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(455, 194);
            this.Result.TabIndex = 5;
            this.Result.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calculate_click);
            // 
            // printLog
            // 
            this.printLog.Location = new System.Drawing.Point(413, 66);
            this.printLog.Name = "printLog";
            this.printLog.Size = new System.Drawing.Size(75, 23);
            this.printLog.TabIndex = 7;
            this.printLog.Text = "Print Log";
            this.printLog.UseVisualStyleBackColor = true;
            this.printLog.Click += new System.EventHandler(this.PrintLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 402);
            this.Controls.Add(this.printLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.v3);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.FigureTypeSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FigureTypeSelector;
        private System.Windows.Forms.ComboBox Operation;
        private System.Windows.Forms.TextBox v1;
        private System.Windows.Forms.TextBox v2;
        private System.Windows.Forms.TextBox v3;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button printLog;
    }
}

