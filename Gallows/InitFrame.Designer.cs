﻿namespace Gallows
{
    partial class InitFrame
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonEasile = new System.Windows.Forms.RadioButton();
            this.radioButtonFine = new System.Windows.Forms.RadioButton();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.Red;
            this.buttonStart.Location = new System.Drawing.Point(89, 159);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(102, 38);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "СТРАТ!";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сложность";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // radioButtonEasile
            // 
            this.radioButtonEasile.AutoSize = true;
            this.radioButtonEasile.Checked = true;
            this.radioButtonEasile.Location = new System.Drawing.Point(89, 65);
            this.radioButtonEasile.Name = "radioButtonEasile";
            this.radioButtonEasile.Size = new System.Drawing.Size(56, 17);
            this.radioButtonEasile.TabIndex = 4;
            this.radioButtonEasile.TabStop = true;
            this.radioButtonEasile.Text = "Легко";
            this.radioButtonEasile.UseVisualStyleBackColor = true;
            // 
            // radioButtonFine
            // 
            this.radioButtonFine.AutoSize = true;
            this.radioButtonFine.Location = new System.Drawing.Point(89, 88);
            this.radioButtonFine.Name = "radioButtonFine";
            this.radioButtonFine.Size = new System.Drawing.Size(83, 17);
            this.radioButtonFine.TabIndex = 4;
            this.radioButtonFine.Text = "Нормально";
            this.radioButtonFine.UseVisualStyleBackColor = true;
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Location = new System.Drawing.Point(89, 111);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(67, 17);
            this.radioButtonHard.TabIndex = 4;
            this.radioButtonHard.Text = "Сложно!";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // InitFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.radioButtonHard);
            this.Controls.Add(this.radioButtonFine);
            this.Controls.Add(this.radioButtonEasile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitFrame";
            this.Text = "Начать игру!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonEasile;
        private System.Windows.Forms.RadioButton radioButtonFine;
        private System.Windows.Forms.RadioButton radioButtonHard;
    }
}