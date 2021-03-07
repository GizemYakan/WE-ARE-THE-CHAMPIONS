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
    public partial class TeamPlayersForm : Form
    {
        ChampionsDbContext db;
        Team team;
        public TeamPlayersForm(ChampionsDbContext _db, Team _team)
        {
            team = _team;
            db = _db;
            InitializeComponent();
            PlayersListele();
        }

        private void PlayersListele()
        {
            lbPlayers.DataSource = db.Players.Where(x => x.Team.TeamName == team.TeamName).ToList();
            lbAllPlayers.DataSource = db.Players.Where(x => x.Team.TeamName != team.TeamName).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Player player = (Player)lbAllPlayers.SelectedItem;
            player.Team = team;
            db.SaveChanges();
            PlayersListele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Player player = (Player)lbPlayers.SelectedItem;
            player.Team = db.Teams.FirstOrDefault(x => x.TeamName == "Belirtilmemiş");
            db.SaveChanges();
            PlayersListele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text.Trim() == "")
            {
                PlayersListele();
            }
            else
            {
                lbAllPlayers.DataSource = db.Players
                    .Where(x => x.Team.TeamName != team.TeamName && x.PlayerName
                    .Contains(txtAra.Text.Trim()))
                    .ToList();
            }
        }
    }
}
