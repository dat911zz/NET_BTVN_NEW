using _2001202045_VuNgoDat_SM24_Buoi7.Models;
using BTNET.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Visual Studio 2019
/// </summary>
namespace _2001202045_VuNgoDat_SM24_Buoi7.Views
{
    public partial class QL_SinhVien : Form
    {
        DAL db;
        public QL_SinhVien()
        {
            db = new DAL();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool flag = true;
            errProvider.Clear();
            panelInput.Controls.OfType<TextBox>().ToList().ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.Text))
                {
                    errProvider.SetError(x, "Vui lòng nhập dữ liệu!");
                    flag = false;
                }
            });
            if (!txtDate.MaskCompleted)
            {
                errProvider.SetError(txtDate, "Vui lòng nhập đúng dữ liệu!");
                flag = false;
            }
            if (flag)
            {
                try
                {
                    db.Commit($"SET DATEFORMAT DMY; INSERT INTO SINHVIEN VALUES('{txtId.Text}','{txtName.Text}','{txtDate.Text.Trim()}','{txtClassId.Text}')");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            MessageBox.Show($"Thêm thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool flag = true;
            errProvider.Clear();
            panelInput.Controls.OfType<TextBox>().ToList().ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.Text) && !x.Name.Equals("txtClassId"))
                {
                    errProvider.SetError(x, "Vui lòng nhập dữ liệu!");
                    flag = false;
                }
            });
            if (flag)
            {
                try
                {
                    var rowsAffected = db.Commit($"DELETE FROM SINHVIEN WHERE MASV = '{txtId.Text}'");
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
            errProvider.Clear();
            panelInput.Controls.OfType<TextBox>().ToList().ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.Text))
                {
                    errProvider.SetError(x, "Vui lòng nhập dữ liệu!");
                    flag = false;
                    count++;
                }
                
            });
            if (count >= 2)
            {
                MessageBox.Show($"Lỗi: Bắt buộc nhập 1 trong các trường còn lại ngoài id", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            if (flag)
            {
                try
                {
                    string SQLStatement = "";
                    if (!string.IsNullOrEmpty(txtClassId.Text))
                    {
                        SQLStatement += "MALOP = '" + txtClassId.Text + "',";
                    }
                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        SQLStatement += "TENSV = '" + txtName.Text + "',";
                    }
                    if (!string.IsNullOrEmpty(txtDate.Text))
                    {
                        SQLStatement += "NGSINH = '" + txtDate.Text + "'";
                    }
                    var rowsAffected = db.Commit($"UPDATE SINHVIEN SET {SQLStatement} WHERE MASV = '{txtId.Text}'");
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
    }
}
