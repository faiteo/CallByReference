namespace CallByReference
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
            this.txtEnterNum = new System.Windows.Forms.TextBox();
            this.btnUpdateNumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblB4Call = new System.Windows.Forms.Label();
            this.lblAfterCall = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Number";
            // 
            // txtEnterNum
            // 
            this.txtEnterNum.Location = new System.Drawing.Point(99, 17);
            this.txtEnterNum.Name = "txtEnterNum";
            this.txtEnterNum.Size = new System.Drawing.Size(112, 20);
            this.txtEnterNum.TabIndex = 1;
            // 
            // btnUpdateNumber
            // 
            this.btnUpdateNumber.Location = new System.Drawing.Point(99, 43);
            this.btnUpdateNumber.Name = "btnUpdateNumber";
            this.btnUpdateNumber.Size = new System.Drawing.Size(129, 23);
            this.btnUpdateNumber.TabIndex = 2;
            this.btnUpdateNumber.Text = "Update Number to 100";
            this.btnUpdateNumber.UseVisualStyleBackColor = true;
            this.btnUpdateNumber.Click += new System.EventHandler(this.UpdateNumberTo100);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result = ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(261, 24);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "label3";
            this.lblResult.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number Before Call =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number After Call =";
            // 
            // lblB4Call
            // 
            this.lblB4Call.AutoSize = true;
            this.lblB4Call.Location = new System.Drawing.Point(116, 129);
            this.lblB4Call.Name = "lblB4Call";
            this.lblB4Call.Size = new System.Drawing.Size(35, 13);
            this.lblB4Call.TabIndex = 7;
            this.lblB4Call.Text = "label5";
            this.lblB4Call.Visible = false;
            // 
            // lblAfterCall
            // 
            this.lblAfterCall.AutoSize = true;
            this.lblAfterCall.Location = new System.Drawing.Point(116, 153);
            this.lblAfterCall.Name = "lblAfterCall";
            this.lblAfterCall.Size = new System.Drawing.Size(35, 13);
            this.lblAfterCall.TabIndex = 8;
            this.lblAfterCall.Text = "label6";
            this.lblAfterCall.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Reset_Form);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAfterCall);
            this.Controls.Add(this.lblB4Call);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdateNumber);
            this.Controls.Add(this.txtEnterNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterNum;
        private System.Windows.Forms.Button btnUpdateNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblB4Call;
        private System.Windows.Forms.Label lblAfterCall;
        private System.Windows.Forms.Button button1;
    }
}

