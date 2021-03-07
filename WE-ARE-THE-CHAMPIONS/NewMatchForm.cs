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
    public partial class NewMatchForm : Form
    {
        ChampionsDbContext db;
        public NewMatchForm(ChampionsDbContext _db)
        {
            db = _db;
            InitializeComponent();

            cboTeam1.SelectedIndex = -1;
            cboTeam2.SelectedIndex = -1;
            cboTeam1.DataSource = db.Teams.Where(x => x.TeamName != "Belirtilmemiş").ToList();
            cboTeam2.DataSource = db.Teams.Where(x => x.TeamName != "Belirtilmemiş").ToList();
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            if (cboTeam1.SelectedIndex == -1 || cboTeam2.SelectedIndex == -1 || cboTeam2.SelectedItem == cboTeam1.SelectedItem)
            {
                MessageBox.Show("Lütfen doğru seçim yapın");
            }
            else
            {
                DateTime date = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value, (int)nudHour.Value, (int)nudMinute.Value, 0);
                if (date < DateTime.Now)
                {
                    MessageBox.Show("Geçersiz Tarih!");
                    return;
                }
                db.Matches.Add(new Match()
                {
                    MatchTime = date,
                    Team1 = (Team)cboTeam1.SelectedItem,
                    Team2 = (Team)cboTeam2.SelectedItem,
                });
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
