using DuAn1_CuaHangTienLoiCircleK.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace DuAn1_CuaHangTienLoiCircleK
{
    public partial class QuanLySanPham : Form
    {
        CuaHangTienLoiCircleKContext db = new CuaHangTienLoiCircleKContext();
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void loadSP()
        {
            dgvSP.DataSource = db.SanPhams
                                    .Include(sp => sp.IdKhuyenMaiNavigation)
                                    .ToList()
                                    .Select(x => new
                                    {
                                        x.IdSanPham,
                                        x.TenSanPham,
                                        x.GiaBan,
                                        TenKhuyenMai = x.IdKhuyenMaiNavigation != null ? x.IdKhuyenMaiNavigation.TenKhuyenMai : "",
                                    }).ToList();
        }

        private void loadCBBKM()
        {
            comboBoxKMSP.DataSource = db.KhuyenMais.ToList();
            comboBoxKMSP.DisplayMember = "TenKhuyenMai";
            comboBoxKMSP.ValueMember = "IdKhuyenMai";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSP();
            loadCBBKM();
            
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSP.DataSource == null)
            {
                loadSP();
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSP.Rows[e.RowIndex];
                textBoxIDSP.Text = row.Cells["IdSanPham"].Value?.ToString();
                textBoxTenSP.Text = row.Cells["TenSanPham"].Value?.ToString();
                textBoxGiaSP.Text = row.Cells["GiaBan"].Value?.ToString();

                var tenKM = row.Cells["TenKhuyenMai"].Value?.ToString();
                if (!string.IsNullOrEmpty(tenKM))
                {
                    for (int i = 0; i < comboBoxKMSP.Items.Count; i++)
                    {
                        var item = comboBoxKMSP.Items[i] as dynamic;
                        if (item != null && item.TenKhuyenMai == tenKM)
                        {
                            comboBoxKMSP.SelectedIndex = i;
                            break;
                        }
                    }
                }
                else
                {
                    comboBoxKMSP.SelectedIndex = 0;
                }


                if (int.TryParse(row.Cells["IdSanPham"].Value?.ToString(), out int idSP))
                {
                    loadCTSP(idSP);
                }
            }

        }

        private void textBoxTK_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxTK.Text.Trim().ToLower();

            var filtered = db.SanPhams
                .Include(sp => sp.IdKhuyenMaiNavigation)
                .ToList()
                .Where(sp =>
                    string.IsNullOrEmpty(keyword) ||
                    (sp.TenSanPham != null &&
                     sp.TenSanPham.Length >= keyword.Length &&
                       sp.TenSanPham.Substring(0, keyword.Length).ToLower() == keyword)
                )
                .Select(sp => new
                {
                    sp.IdSanPham,
                    sp.TenSanPham,
                    sp.GiaBan,
                    TenKhuyenMai = sp.IdKhuyenMaiNavigation != null ? sp.IdKhuyenMaiNavigation.TenKhuyenMai : "",
                })
                .ToList();

            dgvSP.DataSource = filtered;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Thêm sản phẩm mới
                var sp = new SanPham
                {
                    TenSanPham = textBoxTenSP.Text.Trim(),
                    GiaBan = decimal.TryParse(textBoxGiaSP.Text, out var gia) ? gia : 0,
                    IdKhuyenMai = comboBoxKMSP.SelectedValue as int? ?? 0
                };
                db.SanPhams.Add(sp);
                db.SaveChanges();

                // 2. Lấy IdSanPham vừa thêm
                int idSP = sp.IdSanPham;

                // 3. Thêm chi tiết sản phẩm mới
                DateOnly? hanSuDung = null;
                if (DateOnly.TryParse(textBoxHSD.Text, out var hsd))
                {
                    hanSuDung = hsd;
                }
                var ctsp = new SanPhamChiTiet
                {
                    IdSanPham = idSP,
                    HanSuDung = hanSuDung,
                    SoLuong = int.TryParse(textBoxSL.Text, out var sl) ? sl : 0,
                    DonViTinh = textBoxDVT.Text.Trim(),
                    MoTa = textBoxMT.Text.Trim()
                };
                db.SanPhamChiTiets.Add(ctsp);
                db.SaveChanges();

                // 4. Refresh lại hai DataGridView
                loadSP();
                loadCTSP(idSP);

                MessageBox.Show("Thêm sản phẩm và chi tiết thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxIDSP.Text, out int idSP))
                {
                    // Sửa sản phẩm
                    var sp = db.SanPhams.FirstOrDefault(x => x.IdSanPham == idSP);
                    if (sp != null)
                    {
                        sp.TenSanPham = textBoxTenSP.Text.Trim();
                        sp.GiaBan = decimal.TryParse(textBoxGiaSP.Text, out var gia) ? gia : 0;
                        sp.IdKhuyenMai = comboBoxKMSP.SelectedValue as int? ?? 0;
                    }

                    // Sửa chi tiết sản phẩm (giả sử chỉ sửa chi tiết đầu tiên của sản phẩm)
                    var ctsp = db.SanPhamChiTiets.FirstOrDefault(x => x.IdSanPham == idSP);
                    if (ctsp != null)
                    {
                        ctsp.HanSuDung = DateOnly.TryParse(textBoxHSD.Text, out var hsd) ? hsd : null;
                        ctsp.SoLuong = int.TryParse(textBoxSL.Text, out var sl) ? sl : 0;
                        ctsp.DonViTinh = textBoxDVT.Text.Trim();
                        ctsp.MoTa = textBoxMT.Text.Trim();
                    }

                    db.SaveChanges();
                    loadSP();
                    loadCTSP(idSP);
                    MessageBox.Show("Sửa sản phẩm và chi tiết thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxIDSP.Text, out int idSP))
                {
                    // Xóa chi tiết sản phẩm trước (nếu có)
                    var ctspList = db.SanPhamChiTiets.Where(x => x.IdSanPham == idSP).ToList();
                    if (ctspList.Any())
                    {
                        db.SanPhamChiTiets.RemoveRange(ctspList);
                    }

                    // Xóa sản phẩm
                    var sp = db.SanPhams.FirstOrDefault(x => x.IdSanPham == idSP);
                    if (sp != null)
                    {
                        db.SanPhams.Remove(sp);
                    }

                    db.SaveChanges();
                    loadSP();
                    dgvCTSP.DataSource = null;
                    MessageBox.Show("Xóa sản phẩm và chi tiết thành công!");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonLM_Click(object sender, EventArgs e)
        {
            textBoxIDSP.Clear();
            textBoxTenSP.Clear();
            textBoxGiaSP.Clear();
            if (comboBoxKMSP.Items.Count > 0)
                comboBoxKMSP.SelectedIndex = 0;
            textBoxTK.Clear();
            textBoxTenSPCT.Clear();
            textBoxHSD.Clear();
            textBoxSL.Clear();  
            textBoxDVT.Clear();
            textBoxMT.Clear();
            loadSP();
            dgvCTSP.DataSource = null;
        }









        private void loadCTSP(int? idSanPham = null)
        {
            var query = db.SanPhamChiTiets
            .Include(ct => ct.IdSanPhamNavigation)
            .AsQueryable();

            if (idSanPham.HasValue)
                query = query.Where(ct => ct.IdSanPham == idSanPham.Value);

            var list = query
                .ToList()
                .Select(ct => new
                {
                    ct.IdSanPhamChiTiet,
                    TenSanPham = ct.IdSanPhamNavigation != null ? ct.IdSanPhamNavigation.TenSanPham : "",
                    ct.HanSuDung,
                    ct.SoLuong,
                    ct.DonViTinh,
                    ct.MoTa
                })
                .ToList();

            dgvCTSP.DataSource = list;

            
            if (list.Count > 0)
            {
                dgvCTSP.ClearSelection();
                dgvCTSP.Rows[0].Selected = true;
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);
                dgvCTSP_CellClick(dgvCTSP, args);
            }
            else
            {
                textBoxTenSPCT.Clear();
                textBoxHSD.Clear();
                textBoxSL.Clear();
                textBoxDVT.Clear();
                textBoxMT.Clear();
            }
        }

        private void dgvCTSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCTSP.Rows[e.RowIndex];
                
                textBoxTenSPCT.Text = row.Cells["TenSanPham"].Value?.ToString();
                textBoxHSD.Text = row.Cells["HanSuDung"].Value?.ToString();
                textBoxSL.Text = row.Cells["SoLuong"].Value?.ToString();
                textBoxDVT.Text = row.Cells["DonViTinh"].Value?.ToString();
                textBoxMT.Text = row.Cells["MoTa"].Value?.ToString();
            }

        }  
    }
}