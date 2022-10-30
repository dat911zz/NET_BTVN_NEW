using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001202045_VuNgoDat_SM24_Buoi7.Views
{
    public partial class QL_Diem : Form
    {
        BTNET.Core.DAL db;
        public QL_Diem()
        {
            db = new BTNET.Core.DAL();
            InitializeComponent();
        }
        private bool isValidScore()
        {
            if (float.Parse(txtScore.Text) < 0 || float.Parse(txtScore.Text) > 10)
            {
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool flag = true;
            errorProvider.Clear();
            panelInput.Controls.OfType<TextBox>().ToList().ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.Text))
                {
                    errorProvider.SetError(x, "Vui lòng nhập dữ liệu!");
                    flag = false;
                }
            });
            if (flag && isValidScore())
            {
                try
                {
                    db.Commit($"INSERT INTO KETQUA VALUES('{txtStdId.Text}','{txtSubjectId.Text}',{float.Parse(txtScore.Text.Trim())})");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                MessageBox.Show($"Cập nhật thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show($"Cập nhật thất bại!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool flag = true;
            errorProvider.Clear();
            panelInput.Controls.OfType<TextBox>().ToList().ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.Text) && !x.Name.Equals("txtScore"))
                {
                    errorProvider.SetError(x, "Vui lòng nhập dữ liệu!");
                    flag = false;
                }
            });
            if (flag)
            {
                try
                {
                    var rowsAffected = db.Commit($"DELETE FROM KETQUA WHERE MASV = '{txtStdId.Text}' AND MAMH = '{txtSubjectId.Text}'");
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show($"Lỗi: Không tìm thấy id", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            MessageBox.Show($"Xóa thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool flag = true;
            int count = 0;
            errorProvider.Clear();
            panelInput.Controls.OfType<TextBox>().ToList().ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.Text))
                {
                    errorProvider.SetError(x, "Vui lòng nhập dữ liệu!");
                    flag = false;
                    count++;
                }

            });
            if (flag)
            {
                try
                {
                    string SQLStatement = "";
                    if (!string.IsNullOrEmpty(txtScore.Text))
                    {
                        SQLStatement += "DIEM = '" + txtScore.Text.Trim() + "'";
                    }
                    var rowsAffected = db.Commit($"UPDATE KETQUA SET {SQLStatement} WHERE MASV = '{txtStdId.Text}' AND MAMH = '{txtSubjectId.Text}'");
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show($"Lỗi: Không tìm thấy id", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show($"Cập nhật thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void txtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider.SetError(ctr, "Vui lòng nhập đúng định dạng!");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (!string.IsNullOrEmpty(ctr.Text))
            {
                if (float.Parse(ctr.Text) < 0 || float.Parse(ctr.Text) > 10)
                {
                    ctr.Focus();
                    errorProvider.SetError(ctr, "Số chỉ được nhập phải nằm trong khoảng [0:10]");
                }
                else
                {
                    errorProvider.Clear();
                }
            }
            
        }
    }
}
