namespace Sandwich
{
    partial class frmAddSandwich
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
            this.txtSandwichName = new System.Windows.Forms.TextBox();
            this.txtSandwichPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilling1 = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSandwichName
            // 
            this.txtSandwichName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSandwichName.Location = new System.Drawing.Point(56, 55);
            this.txtSandwichName.Name = "txtSandwichName";
            this.txtSandwichName.Size = new System.Drawing.Size(121, 20);
            this.txtSandwichName.TabIndex = 1;
            // 
            // txtSandwichPrice
            // 
            this.txtSandwichPrice.Location = new System.Drawing.Point(232, 55);
            this.txtSandwichPrice.Name = "txtSandwichPrice";
            this.txtSandwichPrice.Size = new System.Drawing.Size(115, 20);
            this.txtSandwichPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price: $";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Filling1:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtFilling1
            // 
            this.txtFilling1.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilling1.Location = new System.Drawing.Point(56, 82);
            this.txtFilling1.Name = "txtFilling1";
            this.txtFilling1.ReadOnly = true;
            this.txtFilling1.Size = new System.Drawing.Size(121, 20);
            this.txtFilling1.TabIndex = 11;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(232, 82);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(115, 20);
            this.txtAmount.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Date Last Modified";
            // 
            // frmAddSandwich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 165);
            this.Controls.Add(this.txtSandwichPrice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFilling1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSandwichName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddSandwich";
            this.Text = "Add Sandwich";
            this.Load += new System.EventHandler(this.AddNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSandwichName;
        private System.Windows.Forms.TextBox txtSandwichPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilling1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}