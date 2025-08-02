using DuAn1_CuaHangTienLoiCircleK.Models;
using Microsoft.EntityFrameworkCore;
namespace DuAn1_CuaHangTienLoiCircleK
{
    public partial class Form1 : Form
    {
        CuaHangTienLoiCircleKContext db = new CuaHangTienLoiCircleKContext();
        public Form1()
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
            loadCTSP();
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                var sp = new SanPham
                {
                    TenSanPham = textBoxTenSP.Text.Trim(),
                    GiaBan = decimal.TryParse(textBoxGiaSP.Text, out var gia) ? gia : 0,
                    IdKhuyenMai = comboBoxKMSP.SelectedValue as int? ?? 0
                };
                db.SanPhams.Add(sp);
                db.SaveChanges();
                loadSP();
                MessageBox.Show("Thêm sản phẩm thành công!");
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
                if (int.TryParse(textBoxIDSP.Text, out int id))
                {
                    var sp = db.SanPhams.FirstOrDefault(x => x.IdSanPham == id);
                    if (sp != null)
                    {
                        sp.TenSanPham = textBoxTenSP.Text.Trim();
                        sp.GiaBan = decimal.TryParse(textBoxGiaSP.Text, out var gia) ? gia : 0;
                        sp.IdKhuyenMai = comboBoxKMSP.SelectedValue as int? ?? 0;
                        db.SaveChanges();
                        loadSP();
                        MessageBox.Show("Sửa sản phẩm thành công!");
                    }
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
                if (int.TryParse(textBoxIDSP.Text, out int id))
                {
                    var sp = db.SanPhams.FirstOrDefault(x => x.IdSanPham == id);
                    if (sp != null)
                    {
                        db.SanPhams.Remove(sp);
                        db.SaveChanges();
                        loadSP();
                        MessageBox.Show("Xóa sản phẩm thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            loadCTSP();
        }









        private void loadCTSP(int? idSanPham = null)
        {
            var query = db.SanPhamChiTiets
        .Include(ct => ct.IdSanPhamNavigation)
        .AsQueryable();

            if (idSanPham.HasValue)
                query = query.Where(ct => ct.IdSanPham == idSanPham.Value);

            dgvCTSP.DataSource = query
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