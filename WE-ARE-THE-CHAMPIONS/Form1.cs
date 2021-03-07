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
    public partial class Form1 : Form
    {
        ChampionsDbContext db = new ChampionsDbContext();
        public Form1()
        {
            InitializeComponent();
            dgvMatches.AutoGenerateColumns = false; //otomatik seçim
            MaclariListele();
            SonuclariKontrolEt();
            TakimlariKontrolEt();
        }

        private void TakimlariKontrolEt()
        {
            if (db.Teams.Any(x => x.TeamName == "Belirtilmemiş"))
            {
                return;
            }
            else
            {
                db.Teams.Add(new Team()
                {
                    TeamName = "Belirtilmemiş"
                });
                db.SaveChanges();
            }
        }

        private void SonuclariKontrolEt()
        {
            var matches = db.Matches.ToList();
            foreach (Match match in matches)
            {
                if (match.Score1 > match.Score2)
                {
                    match.Result = ChampionsData.Models.Result.team1;
                }
                else if (match.Score2 > match.Score1)
                {
                    match.Result = ChampionsData.Models.Result.team2;
                }
                else if (match.Score2 == match.Score1)
                {
                    match.Result = ChampionsData.Models.Result.tie;
                }
                else
                {
                    match.Result = null;
                }
                db.SaveChanges();
            }
        }

        private void MaclariListele()
        {
            var matches = db.Matches.ToList().Select(
                x => new
                {
                    MatchId = x.Id,
                    Team1 = x.Team1,
                    Team2 = x.Team2,
                    Date = x.MatchTime?.ToShortDateString(),
                    Time = x.MatchTime?.ToShortTimeString(),
                    Score = x.Score1 + " - " + x.Score2,
                    MatchResult = x.Result
                });
            dgvMatches.DataSource = matches.ToList();
        }

        private void tsmiTeams_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm(db);
            teamsForm.ShowDialog();
        }

        private void tsmiColors_Click(object sender, EventArgs e)
        {
            ColorsForm colorsForm = new ColorsForm(db);
            colorsForm.ShowDialog();
        }

        private void tsmiPlayers_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm(db);
            playersForm.ShowDialog();
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            NewMatchForm newMatchForm = new NewMatchForm(db);
            newMatchForm.ShowDialog();
            MaclariListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count == 0)
            {
                return;
            }
            int matchId = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.ToList().FirstOrDefault(x => x.Id == matchId);

            db.Matches.Remove(match);
            db.SaveChanges();
            MaclariListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count == 0)
            {
                return;
            }
            int matchId2 = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match match2 = db.Matches.ToList().FirstOrDefault(x => x.Id == matchId2);

            EditMatchForm editMatchForm = new EditMatchForm(db, match2);
            editMatchForm.ShowDialog();
            MaclariListele();
        }
    }
}
