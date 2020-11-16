namespace InClassAssignment8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFatInput = new System.Windows.Forms.TextBox();
            this.txtCarbInput = new System.Windows.Forms.TextBox();
            this.lblcalCarb = new System.Windows.Forms.Label();
            this.lblCalFat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calories from Fat/Carbs Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calories from fat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calories from carbs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Input Fat grams:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Input Carbs grams:";
            // 
            // txtFatInput
            // 
            this.txtFatInput.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatInput.Location = new System.Drawing.Point(256, 127);
            this.txtFatInput.Name = "txtFatInput";
            this.txtFatInput.Size = new System.Drawing.Size(100, 31);
            this.txtFatInput.TabIndex = 5;
            // 
            // txtCarbInput
            // 
            this.txtCarbInput.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarbInput.Location = new System.Drawing.Point(612, 127);
            this.txtCarbInput.Name = "txtCarbInput";
            this.txtCarbInput.Size = new System.Drawing.Size(100, 31);
            this.txtCarbInput.TabIndex = 6;
            // 
            // lblcalCarb
            // 
            this.lblcalCarb.AutoSize = true;
            this.lblcalCarb.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalCarb.Location = new System.Drawing.Point(145, 385);
            this.lblcalCarb.Name = "lblcalCarb";
            this.lblcalCarb.Size = new System.Drawing.Size(0, 32);
            this.lblcalCarb.TabIndex = 7;
            // 
            // lblCalFat
            // 
            this.lblCalFat.AutoSize = true;
            this.lblCalFat.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalFat.Location = new System.Drawing.Point(482, 385);
            this.lblCalFat.Name = "lblCalFat";
            this.lblCalFat.Size = new System.Drawing.Size(0, 32);
            this.lblCalFat.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCalFat);
            this.Controls.Add(this.lblcalCarb);
            this.Controls.Add(this.txtCarbInput);
            this.Controls.Add(this.txtFatInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFatInput;
        private System.Windows.Forms.TextBox txtCarbInput;
        private System.Windows.Forms.Label lblcalCarb;
        private System.Windows.Forms.Label lblCalFat;
        private System.Windows.Forms.Button button1;
    }
}

