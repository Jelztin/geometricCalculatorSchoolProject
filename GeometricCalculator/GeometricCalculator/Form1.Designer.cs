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
            this.FigureTypeSelector.SelectedIndexChanged += new System.EventHandler(this.FigureTypeSelector_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 402);
            this.Controls.Add(this.FigureTypeSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FigureTypeSelector;
    }
}

