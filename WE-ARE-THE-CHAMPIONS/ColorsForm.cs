using ChampionsData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WE_ARE_THE_CHAMPIONS
{
    public partial class ColorsForm : Form
    {
        ChampionsDbContext db;
        ChampionsData.Models.Color color;
        public ColorsForm(ChampionsDbContext _db)
        {
            db = _db;
            InitializeComponent();
            ColorsListele();
        }

        private void ColorsListele()
        {
            lbColors.DataSource = null;
            lbColors.DataSource = db.Colors.ToList();
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            if (txtColorName.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen renk adı giriniz");
                return;
            }
            if (btnAddColor.Text == "Add Color")
            {
                if (db.Colors.Any(x => x.ColorName == txtColorName.Text.Trim()))
                {
                    MessageBox.Show("Renk mevcut");
                    return;
                }
                db.Colors.Add(new ChampionsData.Models.Color()
                {
                    ColorName = txtColorName.Text.Trim(),
                    ColorRed = (int)nudRed.Value,
                    ColorGreen = (int)nudGreen.Value,
                    ColorBlue = (int)nudBlue.Value
                });
            }
            else if (btnEditColor.Text == "Edit Color")
            {
                color.ColorName = txtColorName.Text;
                color.ColorBlue = (int)nudBlue.Value;
                color.ColorRed = (int)nudRed.Value;
                color.ColorGreen = (int)nudGreen.Value;
            }
            db.SaveChanges();
            ClearForm();
            ColorsListele();
        }

        private void ClearForm()
        {
            btnAddColor.Text = "Add Color";
            nudGreen.Value = 0;
            nudBlue.Value = 0;
            nudRed.Value = 0;
            txtColorName.Clear();
        }

        private void btnEditColor_Click(object sender, EventArgs e)
        {

            btnAddColor.Text = "Edit Color";
            color = (ChampionsData.Models.Color)lbColors.SelectedItem;
            txtColorName.Text = color.ColorName;
            nudRed.Value = (decimal)color.ColorRed;
            nudGreen.Value = (decimal)color.ColorGreen;
            nudBlue.Value = (decimal)color.ColorBlue;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var delete = (ChampionsData.Models.Color)lbColors.SelectedItem;
            db.Colors.Remove(delete);
            db.SaveChanges();
            ClearForm();
            ColorsListele();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown degerDegisti = (NumericUpDown)sender;
            pbPreview.BackColor = System.Drawing.Color.FromArgb((int)nudBlue.Value, (int)nudRed.Value, (int)nudGreen.Value);
        }
    }
}
