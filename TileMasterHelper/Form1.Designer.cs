namespace TileMasterHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.areaCheckBox = new System.Windows.Forms.RadioButton();
            this.volumeCheckBox = new System.Windows.Forms.RadioButton();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Enabled = false;
            this.heightLabel.Location = new System.Drawing.Point(280, 264);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(43, 15);
            this.heightLabel.TabIndex = 15;
            this.heightLabel.Text = "Height";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Enabled = false;
            this.heightTextBox.HideSelection = false;
            this.heightTextBox.Location = new System.Drawing.Point(343, 261);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(161, 23);
            this.heightTextBox.TabIndex = 14;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(280, 210);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(39, 15);
            this.widthLabel.TabIndex = 13;
            this.widthLabel.Text = "Width";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(280, 158);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(44, 15);
            this.lengthLabel.TabIndex = 12;
            this.lengthLabel.Text = "Length";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(343, 207);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(161, 23);
            this.widthTextBox.TabIndex = 11;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(343, 155);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lengthTextBox.Size = new System.Drawing.Size(161, 23);
            this.lengthTextBox.TabIndex = 10;
            this.lengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lengthTextBox.UseWaitCursor = true;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.lengthTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Please choose the area or volume, and enter the values you want to calculate";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(325, 330);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(144, 56);
            this.calculateButton.TabIndex = 17;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // areaCheckBox
            // 
            this.areaCheckBox.AutoSize = true;
            this.areaCheckBox.Location = new System.Drawing.Point(366, 56);
            this.areaCheckBox.Name = "areaCheckBox";
            this.areaCheckBox.Size = new System.Drawing.Size(49, 19);
            this.areaCheckBox.TabIndex = 18;
            this.areaCheckBox.TabStop = true;
            this.areaCheckBox.Text = "Area";
            this.areaCheckBox.UseVisualStyleBackColor = true;
            // 
            // volumeCheckBox
            // 
            this.volumeCheckBox.AutoSize = true;
            this.volumeCheckBox.Location = new System.Drawing.Point(366, 94);
            this.volumeCheckBox.Name = "volumeCheckBox";
            this.volumeCheckBox.Size = new System.Drawing.Size(65, 19);
            this.volumeCheckBox.TabIndex = 19;
            this.volumeCheckBox.TabStop = true;
            this.volumeCheckBox.Text = "Volume";
            this.volumeCheckBox.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultTextBox.Location = new System.Drawing.Point(617, 210);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(146, 33);
            this.resultTextBox.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.volumeCheckBox);
            this.Controls.Add(this.areaCheckBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label heightLabel;
        private TextBox heightTextBox;
        private Label widthLabel;
        private Label lengthLabel;
        private TextBox widthTextBox;
        private TextBox lengthTextBox;
        private Label label1;
        private Button calculateButton;
        private RadioButton areaCheckBox;
        private RadioButton volumeCheckBox;
        private TextBox result;
        private TextBox resultTextBox;
        private ErrorProvider errorProvider1;
    }
}