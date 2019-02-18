namespace WindowsFormsApplication1
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
            this.PositionLabel = new System.Windows.Forms.Label();
            this.ColorDialog = new System.Windows.Forms.Button();
            this.CellCountLabel = new System.Windows.Forms.Label();
            this.DrawingArea = new System.Windows.Forms.PictureBox();
            this.CellXUpDown = new System.Windows.Forms.NumericUpDown();
            this.CellYUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CurrentColorPictBox = new System.Windows.Forms.PictureBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.FillModeButton = new System.Windows.Forms.Button();
            this.FillCellModeButton = new System.Windows.Forms.Button();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.LineModeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColorPictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(99, 9);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(44, 18);
            this.PositionLabel.TabIndex = 0;
            this.PositionLabel.Text = "label1";
            // 
            // ColorDialog
            // 
            this.ColorDialog.Location = new System.Drawing.Point(12, 36);
            this.ColorDialog.Name = "ColorDialog";
            this.ColorDialog.Size = new System.Drawing.Size(79, 31);
            this.ColorDialog.TabIndex = 2;
            this.ColorDialog.Text = "Цвет    ";
            this.ColorDialog.UseVisualStyleBackColor = true;
            this.ColorDialog.Click += new System.EventHandler(this.ColorDialog_Click);
            // 
            // CellCountLabel
            // 
            this.CellCountLabel.AutoSize = true;
            this.CellCountLabel.Location = new System.Drawing.Point(526, 8);
            this.CellCountLabel.Name = "CellCountLabel";
            this.CellCountLabel.Size = new System.Drawing.Size(100, 18);
            this.CellCountLabel.TabIndex = 3;
            this.CellCountLabel.Text = "Число клеток";
            // 
            // DrawingArea
            // 
            this.DrawingArea.BackColor = System.Drawing.SystemColors.Control;
            this.DrawingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingArea.Location = new System.Drawing.Point(102, 31);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(400, 200);
            this.DrawingArea.TabIndex = 4;
            this.DrawingArea.TabStop = false;
            this.DrawingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.DrawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseDown);
            this.DrawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.DrawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseUp);
            // 
            // CellXUpDown
            // 
            this.CellXUpDown.Location = new System.Drawing.Point(551, 34);
            this.CellXUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CellXUpDown.Name = "CellXUpDown";
            this.CellXUpDown.Size = new System.Drawing.Size(60, 26);
            this.CellXUpDown.TabIndex = 8;
            this.CellXUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CellXUpDown.ValueChanged += new System.EventHandler(this.CellXUpDown_ValueChanged);
            // 
            // CellYUpDown
            // 
            this.CellYUpDown.Location = new System.Drawing.Point(551, 76);
            this.CellYUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CellYUpDown.Name = "CellYUpDown";
            this.CellYUpDown.Size = new System.Drawing.Size(60, 26);
            this.CellYUpDown.TabIndex = 10;
            this.CellYUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CellYUpDown.ValueChanged += new System.EventHandler(this.CellYUpDown_ValueChanged);
            // 
            // CurrentColorPictBox
            // 
            this.CurrentColorPictBox.Location = new System.Drawing.Point(72, 39);
            this.CurrentColorPictBox.Name = "CurrentColorPictBox";
            this.CurrentColorPictBox.Size = new System.Drawing.Size(15, 14);
            this.CurrentColorPictBox.TabIndex = 11;
            this.CurrentColorPictBox.TabStop = false;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(508, 36);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(43, 18);
            this.XLabel.TabIndex = 12;
            this.XLabel.Text = "по X:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(508, 79);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(44, 18);
            this.YLabel.TabIndex = 13;
            this.YLabel.Text = "по Y:";
            // 
            // FillModeButton
            // 
            this.FillModeButton.Location = new System.Drawing.Point(17, 78);
            this.FillModeButton.Name = "FillModeButton";
            this.FillModeButton.Size = new System.Drawing.Size(75, 23);
            this.FillModeButton.TabIndex = 14;
            this.FillModeButton.Text = "Заливка";
            this.FillModeButton.UseVisualStyleBackColor = true;
            this.FillModeButton.Click += new System.EventHandler(this.FillModeButton_Click);
            // 
            // FillCellModeButton
            // 
            this.FillCellModeButton.Location = new System.Drawing.Point(17, 108);
            this.FillCellModeButton.Name = "FillCellModeButton";
            this.FillCellModeButton.Size = new System.Drawing.Size(75, 23);
            this.FillCellModeButton.TabIndex = 15;
            this.FillCellModeButton.Text = "Краска";
            this.FillCellModeButton.UseVisualStyleBackColor = true;
            this.FillCellModeButton.Click += new System.EventHandler(this.FillCellModeButton_Click);
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(102, 238);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(44, 18);
            this.ModeLabel.TabIndex = 16;
            this.ModeLabel.Text = "label5";
            this.ModeLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // LineModeButton
            // 
            this.LineModeButton.Location = new System.Drawing.Point(17, 137);
            this.LineModeButton.Name = "LineModeButton";
            this.LineModeButton.Size = new System.Drawing.Size(75, 23);
            this.LineModeButton.TabIndex = 17;
            this.LineModeButton.Text = "Линия";
            this.LineModeButton.UseVisualStyleBackColor = true;
            this.LineModeButton.Click += new System.EventHandler(this.LineModeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 271);
            this.Controls.Add(this.LineModeButton);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.FillCellModeButton);
            this.Controls.Add(this.FillModeButton);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.CurrentColorPictBox);
            this.Controls.Add(this.CellYUpDown);
            this.Controls.Add(this.CellXUpDown);
            this.Controls.Add(this.DrawingArea);
            this.Controls.Add(this.CellCountLabel);
            this.Controls.Add(this.ColorDialog);
            this.Controls.Add(this.PositionLabel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColorPictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Button ColorDialog;
        private System.Windows.Forms.Label CellCountLabel;
        private System.Windows.Forms.PictureBox DrawingArea;
        private System.Windows.Forms.NumericUpDown CellXUpDown;
        private System.Windows.Forms.NumericUpDown CellYUpDown;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox CurrentColorPictBox;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Button FillModeButton;
        private System.Windows.Forms.Button FillCellModeButton;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Button LineModeButton;
    }
}

