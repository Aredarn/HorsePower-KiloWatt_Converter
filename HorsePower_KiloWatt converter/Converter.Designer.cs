
namespace HorsePower_KiloWatt_converter
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.Convert_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Value_TextBox = new System.Windows.Forms.TextBox();
            this.Upper_Format_Label = new System.Windows.Forms.Label();
            this.Lower_Format_Label = new System.Windows.Forms.Label();
            this.Swap_Format_Click = new System.Windows.Forms.Button();
            this.Final_Value_Label = new System.Windows.Forms.Label();
            this.arrow_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Convert_Click
            // 
            this.Convert_Click.Location = new System.Drawing.Point(242, 34);
            this.Convert_Click.Name = "Convert_Click";
            this.Convert_Click.Size = new System.Drawing.Size(100, 30);
            this.Convert_Click.TabIndex = 0;
            this.Convert_Click.Text = "Convert";
            this.Convert_Click.UseVisualStyleBackColor = true;
            this.Convert_Click.Click += new System.EventHandler(this.Convert_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "HorsePower - Kilowatt converter";
            // 
            // Value_TextBox
            // 
            this.Value_TextBox.Location = new System.Drawing.Point(12, 39);
            this.Value_TextBox.Name = "Value_TextBox";
            this.Value_TextBox.Size = new System.Drawing.Size(144, 23);
            this.Value_TextBox.TabIndex = 2;
            // 
            // Upper_Format_Label
            // 
            this.Upper_Format_Label.AutoSize = true;
            this.Upper_Format_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Upper_Format_Label.Location = new System.Drawing.Point(107, 77);
            this.Upper_Format_Label.Name = "Upper_Format_Label";
            this.Upper_Format_Label.Size = new System.Drawing.Size(26, 17);
            this.Upper_Format_Label.TabIndex = 4;
            this.Upper_Format_Label.Text = "Hp";
            // 
            // Lower_Format_Label
            // 
            this.Lower_Format_Label.AutoSize = true;
            this.Lower_Format_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lower_Format_Label.Location = new System.Drawing.Point(170, 77);
            this.Lower_Format_Label.Name = "Lower_Format_Label";
            this.Lower_Format_Label.Size = new System.Drawing.Size(26, 17);
            this.Lower_Format_Label.TabIndex = 5;
            this.Lower_Format_Label.Text = "Kw";
            // 
            // Swap_Format_Click
            // 
            this.Swap_Format_Click.Location = new System.Drawing.Point(12, 75);
            this.Swap_Format_Click.Name = "Swap_Format_Click";
            this.Swap_Format_Click.Size = new System.Drawing.Size(81, 23);
            this.Swap_Format_Click.TabIndex = 6;
            this.Swap_Format_Click.Text = "Swap values";
            this.Swap_Format_Click.UseVisualStyleBackColor = true;
            this.Swap_Format_Click.Click += new System.EventHandler(this.Swap_Format_Click_Click);
            // 
            // Final_Value_Label
            // 
            this.Final_Value_Label.AutoSize = true;
            this.Final_Value_Label.Location = new System.Drawing.Point(240, 75);
            this.Final_Value_Label.Name = "Final_Value_Label";
            this.Final_Value_Label.Size = new System.Drawing.Size(0, 15);
            this.Final_Value_Label.TabIndex = 7;
            // 
            // arrow_label
            // 
            this.arrow_label.AutoSize = true;
            this.arrow_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arrow_label.Location = new System.Drawing.Point(130, 75);
            this.arrow_label.Name = "arrow_label";
            this.arrow_label.Size = new System.Drawing.Size(44, 20);
            this.arrow_label.TabIndex = 8;
            this.arrow_label.Text = "---->";
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(344, 131);
            this.Controls.Add(this.arrow_label);
            this.Controls.Add(this.Final_Value_Label);
            this.Controls.Add(this.Swap_Format_Click);
            this.Controls.Add(this.Lower_Format_Label);
            this.Controls.Add(this.Upper_Format_Label);
            this.Controls.Add(this.Value_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Convert_Click);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HorsePower&Kilowatt converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convert_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Value_TextBox;
        private System.Windows.Forms.Label Upper_Format_Label;
        private System.Windows.Forms.Label Lower_Format_Label;
        private System.Windows.Forms.Button Swap_Format_Click;
        private System.Windows.Forms.Label Final_Value_Label;
        private System.Windows.Forms.Label arrow_label;
    }
}

