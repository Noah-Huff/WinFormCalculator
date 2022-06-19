namespace Calculator
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.boxOperation = new System.Windows.Forms.ComboBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblFirstOperand = new System.Windows.Forms.Label();
            this.lblSecondOperand = new System.Windows.Forms.Label();
            this.lblShowOperation = new System.Windows.Forms.Label();
            this.boxFirstOperand = new System.Windows.Forms.TextBox();
            this.boxSecondOperand = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(466, 246);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(223, 97);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // boxOperation
            // 
            this.boxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOperation.FormattingEnabled = true;
            this.boxOperation.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Multiply",
            "Divide",
            "Factorial"});
            this.boxOperation.Location = new System.Drawing.Point(38, 276);
            this.boxOperation.Name = "boxOperation";
            this.boxOperation.Size = new System.Drawing.Size(208, 39);
            this.boxOperation.TabIndex = 4;
            this.boxOperation.SelectedIndexChanged += new System.EventHandler(this.boxOperation_SelectedIndexChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(32, 370);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(123, 32);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "Answer: ";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(32, 218);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(140, 32);
            this.lblOperation.TabIndex = 6;
            this.lblOperation.Text = "Operation";
            // 
            // lblFirstOperand
            // 
            this.lblFirstOperand.AutoSize = true;
            this.lblFirstOperand.Location = new System.Drawing.Point(38, 54);
            this.lblFirstOperand.Name = "lblFirstOperand";
            this.lblFirstOperand.Size = new System.Drawing.Size(187, 32);
            this.lblFirstOperand.TabIndex = 7;
            this.lblFirstOperand.Text = "First Operand";
            // 
            // lblSecondOperand
            // 
            this.lblSecondOperand.AutoSize = true;
            this.lblSecondOperand.Location = new System.Drawing.Point(451, 54);
            this.lblSecondOperand.Name = "lblSecondOperand";
            this.lblSecondOperand.Size = new System.Drawing.Size(229, 32);
            this.lblSecondOperand.TabIndex = 8;
            this.lblSecondOperand.Text = "Second Operand";
            // 
            // lblShowOperation
            // 
            this.lblShowOperation.AutoSize = true;
            this.lblShowOperation.Location = new System.Drawing.Point(349, 133);
            this.lblShowOperation.Name = "lblShowOperation";
            this.lblShowOperation.Size = new System.Drawing.Size(0, 32);
            this.lblShowOperation.TabIndex = 9;
            // 
            // boxFirstOperand
            // 
            this.boxFirstOperand.Location = new System.Drawing.Point(38, 133);
            this.boxFirstOperand.MaxLength = 9;
            this.boxFirstOperand.Name = "boxFirstOperand";
            this.boxFirstOperand.Size = new System.Drawing.Size(187, 38);
            this.boxFirstOperand.TabIndex = 10;
            // 
            // boxSecondOperand
            // 
            this.boxSecondOperand.Location = new System.Drawing.Point(457, 133);
            this.boxSecondOperand.MaxLength = 9;
            this.boxSecondOperand.Name = "boxSecondOperand";
            this.boxSecondOperand.Size = new System.Drawing.Size(223, 38);
            this.boxSecondOperand.TabIndex = 11;
            this.boxSecondOperand.TextChanged += new System.EventHandler(this.boxSecondOperand_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(162, 370);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(92, 32);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.boxSecondOperand);
            this.Controls.Add(this.boxFirstOperand);
            this.Controls.Add(this.lblShowOperation);
            this.Controls.Add(this.lblSecondOperand);
            this.Controls.Add(this.lblFirstOperand);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.boxOperation);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox boxOperation;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblFirstOperand;
        private System.Windows.Forms.Label lblSecondOperand;
        private System.Windows.Forms.Label lblShowOperation;
        private System.Windows.Forms.TextBox boxFirstOperand;
        private System.Windows.Forms.TextBox boxSecondOperand;
        private System.Windows.Forms.Label lblResult;
    }
}

