
namespace _2001202045_VuNgoDat_SM24_Buoi7.Views
{
    partial class QL_Diem
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
            this.components = new System.ComponentModel.Container();
            this.panelInput = new System.Windows.Forms.Panel();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtSubjectId = new System.Windows.Forms.TextBox();
            this.txtStdId = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.txtScore);
            this.panelInput.Controls.Add(this.txtSubjectId);
            this.panelInput.Controls.Add(this.txtStdId);
            this.panelInput.Location = new System.Drawing.Point(179, 58);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(385, 130);
            this.panelInput.TabIndex = 20;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(11, 87);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(317, 22);
            this.txtScore.TabIndex = 6;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            this.txtScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScore_KeyPress);
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.Location = new System.Drawing.Point(11, 49);
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.Size = new System.Drawing.Size(317, 22);
            this.txtSubjectId.TabIndex = 5;
            // 
            // txtStdId
            // 
            this.txtStdId.Location = new System.Drawing.Point(11, 14);
            this.txtStdId.Name = "txtStdId";
            this.txtStdId.Size = new System.Drawing.Size(317, 22);
            this.txtStdId.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(405, 221);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 46);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(270, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 46);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 46);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã mh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã sv";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // QL_Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(643, 310);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "QL_Diem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_Diem";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtSubjectId;
        private System.Windows.Forms.TextBox txtStdId;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}