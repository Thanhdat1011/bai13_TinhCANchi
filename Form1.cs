using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai13_TinhCANchi
{
    public partial class Form1 : Form
    {
        string[] canArr = { "Canh", "tân", "Nhân", "Quí", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" ,"Giáp"};
        string[] chiArr = { "Thìn", "Tỵ", "Ngọ", "Mùi", "Dậu", "Tất", "Hợi", "Sửu", "Dần", "Mão","Tý","Mạo"};
        string TinhCan(int nam){ return canArr[nam % 10];}
        string TinhChi(int nam) { return chiArr[nam % 12]; }
        string TinhCanChi(string text) {return TinhCan(Convert.ToInt32(text)) + "" + TinhChi(Convert.ToInt32(text));}
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            txtkq.Text = TinhCanChi(txtnam.Text);
            for (int i = 1900; i < 3000; i++) 
            {
                lstNames.Items.Add(i + " - " + TinhCanChi(i.ToString()));
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
