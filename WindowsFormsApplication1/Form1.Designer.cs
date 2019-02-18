using System;

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
            this.ColorDialogButton = new System.Windows.Forms.Button();
            this.CellCountLabel = new System.Windows.Forms.Label();
            this.DrawingArea = new System.Windows.Forms.PictureBox();
            this.XUpDown = new System.Windows.Forms.NumericUpDown();
            this.YUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FillModeButton = new System.Windows.Forms.Button();
            this.FillOneModeButton = new System.Windows.Forms.Button();
            this.FillLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(99, 9);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(38, 14);
            this.PositionLabel.TabIndex = 0;
            this.PositionLabel.Text = "label1";
            // 
            // ColorDialogButton
            // 
            this.ColorDialogButton.Location = new System.Drawing.Point(17, 31);
            this.ColorDialogButton.Name = "ColorDialogButton";
            this.ColorDialogButton.Size = new System.Drawing.Size(79, 31);
            this.ColorDialogButton.TabIndex = 2;
            this.ColorDialogButton.Text = "Цвет    ";
            this.ColorDialogButton.UseVisualStyleBackColor = true;
            this.ColorDialogButton.Click += new System.EventHandler(this.ColorDialog_Click);
            // 
            // CellCountLabel
            // 
            this.CellCountLabel.AutoSize = true;
            this.CellCountLabel.Location = new System.Drawing.Point(526, 8);
            this.CellCountLabel.Name = "CellCountLabel";
            this.CellCountLabel.Size = new System.Drawing.Size(85, 14);
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
            this.DrawingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            this.DrawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // XUpDown
            // 
            this.XUpDown.Location = new System.Drawing.Point(551, 34);
            this.XUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.XUpDown.Name = "XUpDown";
            this.XUpDown.Size = new System.Drawing.Size(60, 22);
            this.XUpDown.TabIndex = 8;
            this.XUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.XUpDown.ValueChanged += new System.EventHandler(this.CellCountX_ValueChanged);
            // 
            // YUpDown
            // 
            this.YUpDown.Location = new System.Drawing.Point(551, 76);
            this.YUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.YUpDown.Name = "YUpDown";
            this.YUpDown.Size = new System.Drawing.Size(60, 22);
            this.YUpDown.TabIndex = 10;
            this.YUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.YUpDown.ValueChanged += new System.EventHandler(this.CellCountY_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(72, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 14);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "по X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "по Y:";
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
            // FillOneModeButton
            // 
            this.FillOneModeButton.Location = new System.Drawing.Point(17, 108);
            this.FillOneModeButton.Name = "FillOneModeButton";
            this.FillOneModeButton.Size = new System.Drawing.Size(75, 23);
            this.FillOneModeButton.TabIndex = 15;
            this.FillOneModeButton.Text = "Краска";
            this.FillOneModeButton.UseVisualStyleBackColor = true;
            this.FillOneModeButton.Click += new System.EventHandler(this.FillOneModeButton_Click);
            // 
            // FillLabel
            // 
            this.FillLabel.AutoSize = true;
            this.FillLabel.Location = new System.Drawing.Point(102, 238);
            this.FillLabel.Name = "FillLabel";
            this.FillLabel.Size = new System.Drawing.Size(38, 14);
            this.FillLabel.TabIndex = 16;
            this.FillLabel.Text = "label5";
            this.FillLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 271);
            this.Controls.Add(this.FillLabel);
            this.Controls.Add(this.FillOneModeButton);
            this.Controls.Add(this.FillModeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.YUpDown);
            this.Controls.Add(this.XUpDown);
            this.Controls.Add(this.DrawingArea);
            this.Controls.Add(this.CellCountLabel);
            this.Controls.Add(this.ColorDialogButton);
            this.Controls.Add(this.PositionLabel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Button ColorDialogButton;
        private System.Windows.Forms.Label CellCountLabel;
        private System.Windows.Forms.PictureBox DrawingArea;
        private System.Windows.Forms.NumericUpDown XUpDown;
        private System.Windows.Forms.NumericUpDown YUpDown;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FillModeButton;
        private System.Windows.Forms.Button FillOneModeButton;
        private System.Windows.Forms.Label FillLabel;
    }
}

