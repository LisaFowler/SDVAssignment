namespace SandwichWinForm
{
    partial class frmChef
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.lstSandwich = new System.Windows.Forms.ListBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(171, 185);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 32);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(94, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 32);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 32);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(11, 66);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 16);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Sandwich";
            // 
            // lstSandwich
            // 
            this.lstSandwich.Location = new System.Drawing.Point(11, 85);
            this.lstSandwich.Name = "lstSandwich";
            this.lstSandwich.Size = new System.Drawing.Size(224, 82);
            this.lstSandwich.TabIndex = 20;
            // 
            // txtSpeciality
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(75, 33);
            this.txtSpecialty.Name = "txtSpeciality";
            this.txtSpecialty.Size = new System.Drawing.Size(160, 20);
            this.txtSpecialty.TabIndex = 17;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(11, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Speciality";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(11, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Name";
            // 
            // frmChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 232);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lstSandwich);
            this.Controls.Add(this.txtSpecialty);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label1);
            this.Name = "frmChef";
            this.Text = "Chef Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ListBox lstSandwich;
        internal System.Windows.Forms.TextBox txtSpecialty;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label1;
    }
}