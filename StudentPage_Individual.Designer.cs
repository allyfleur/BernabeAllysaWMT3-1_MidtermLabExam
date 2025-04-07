using System.Windows.Forms;

namespace StudentManagementApp.Forms
{
    partial class StudentPage_Individual
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Location = new System.Drawing.Point(12, 15);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(58, 13);
            this.labelStudentId.TabIndex = 0;
            this.labelStudentId.Text = "Student ID:";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(12, 50);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(57, 13);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Full Name:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 85);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Location = new System.Drawing.Point(76, 12);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.ReadOnly = true;
            this.textBoxStudentId.Size = new System.Drawing.Size(200, 20);
            this.textBoxStudentId.TabIndex = 3;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(76, 47);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.ReadOnly = true;
            this.textBoxFullName.Size = new System.Drawing.Size(200, 20);
            this.textBoxFullName.TabIndex = 4;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(76, 82);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(200, 60);
            this.textBoxAddress.TabIndex = 5;
            // 
            // StudentPage_Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 160);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelStudentId);
            this.Name = "StudentPage_Individual";
            this.Text = "Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxAddress;
    }
}