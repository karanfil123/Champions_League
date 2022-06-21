namespace Champions_League
{
    public partial class Form1 : Form
    {
        List<Team> teams;
        List<ListBox> pots = new List<ListBox>();
        List<ListBox> groups = new List<ListBox>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Team newTeam = null;
            teams = new List<Team>();
            newTeam = new Team("Bayern Munich", "Germany");
            teams.Add(newTeam);
            newTeam = new Team("Sevilla", "Spain");
            teams.Add(newTeam);
            newTeam = new Team("Real Madrid", "Spain");
            teams.Add(newTeam);
            newTeam = new Team("Liverpool", "England");
            teams.Add(newTeam);
            newTeam = new Team("Paris Saint-Germain", "France");
            teams.Add(newTeam);
            newTeam = new Team("Zenit", "Russia");
            teams.Add(newTeam);
            newTeam = new Team("Barcelona", "Spain");
            teams.Add(newTeam);
            newTeam = new Team("Atlético Madrid", "Spain");
            teams.Add(newTeam);
            newTeam = new Team("Manchester City", "England");
            teams.Add(newTeam);
            newTeam = new Team("Manchester United", "England");
            teams.Add(newTeam);
            newTeam = new Team("Chelsea", "England");
            teams.Add(newTeam);
            newTeam = new Team("Borussia Dortmund", "Germany");
            teams.Add(newTeam);
            newTeam = new Team("Shakhtar Donetsk", "Ukrania");
            teams.Add(newTeam);
            newTeam = new Team("Ajax", "Netherlands");
            teams.Add(newTeam);
            newTeam = new Team("Dinamo Kyiv", "Ukrania");
            teams.Add(newTeam);
            newTeam = new Team("Red Bull Salzburg", "Austria");
            teams.Add(newTeam);
            newTeam = new Team("Red Bull Leipzig", "Germany");
            teams.Add(newTeam);
            newTeam = new Team("Internazionale", "Italy");
            teams.Add(newTeam);
            newTeam = new Team("Olympiacos", "Greece");
            teams.Add(newTeam);
            newTeam = new Team("Lazio", "Italy");
            teams.Add(newTeam);
            newTeam = new Team("Krasnodar", "Russia");
            teams.Add(newTeam);
            newTeam = new Team("Atalanta", "Italy");
            teams.Add(newTeam);
            newTeam = new Team("Lokomotiv Moscow", "Russia");
            teams.Add(newTeam);
            newTeam = new Team("Marseille", "France");
            teams.Add(newTeam);
            newTeam = new Team("Club Brugge", "Belgium");
            teams.Add(newTeam);
            newTeam = new Team("Borussia Mönchengladbach", "Germany");
            teams.Add(newTeam);
            newTeam = new Team("Galatasaray", "Turkey");
            teams.Add(newTeam);
            newTeam = new Team("Villareal", "Spain");
            teams.Add(newTeam);
            newTeam = new Team("Juventus", "Italy");
            teams.Add(newTeam);
            newTeam = new Team("Napoli", "Italy");
            teams.Add(newTeam);
            newTeam = new Team("Benfica", "Portugal");
            teams.Add(newTeam);
            newTeam = new Team("Dinamo Zagreb", "Crotia");
            teams.Add(newTeam);
        }

        private void txtGrupOlustur_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            List<int> chooseTeams = new List<int>();
            for (int j = 0; j < 4; j++)
            {
                chooseTeams.Clear();
                for (int i = 0; i < 8; i++)
                {
                    int chooseTeam = rand.Next(0, teams.Count / 4);
                    if (chooseTeams.Contains(chooseTeam))
                    {
                        i--;
                    }
                    else
                    {
                        chooseTeams.Add(chooseTeam);
                    }

                }
                bool IsCountryTeam = false;
                for (int x = 0; x < 8; x++)
                {
                    IsCountryTeam = IsCountrTeammm(groups[x], pots[j].Items[chooseTeams[x]] as Team);
                    if (IsCountryTeam)
                    {
                        break;
                    }
                    if (!IsCountryTeam)
                    {
                        lbxA.Items.Add(pots[j].Items[chooseTeams[0]] as Team);
                        lbxB.Items.Add(pots[j].Items[chooseTeams[1]] as Team);
                        lbxC.Items.Add(pots[j].Items[chooseTeams[2]] as Team);
                        lbxD.Items.Add(pots[j].Items[chooseTeams[3]] as Team);
                        lbxE.Items.Add(pots[j].Items[chooseTeams[4]] as Team);
                        lbxF.Items.Add(pots[j].Items[chooseTeams[5]] as Team);
                        lbxG.Items.Add(pots[j].Items[chooseTeams[6]] as Team);
                        lbxH.Items.Add(pots[j].Items[chooseTeams[7]] as Team);
                    }
                    else
                    {
                        j--;
                    }
                }
            }

        }
        private bool IsCountrTeammm(ListBox group, Team team)
        {
            bool status = false;
            for (int i = 0; i < group.Items.Count; i++)
            {
                Team groupTeam = group.Items[i] as Team;
                if (groupTeam._teamCountry == team._teamCountry)
                {
                    status = true;
                    break;
                }
            }
            return status;
        }

        private void btnPotsCreate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<int> choseTeams = new List<int>();
            for (int i = 0; i < teams.Count; i++)
            {
                int choseTeam = random.Next(0, teams.Count);
                if (choseTeams.Contains(choseTeam))
                {
                    i--;
                }
                else
                {
                    choseTeams.Add(choseTeam);
                }
            }
            for (int i = 0; i < choseTeams.Count; i++)
            {
                if (i < 8)
                {
                    lbxTorba1.Items.Add(teams[choseTeams[i]]);
                }
                else if (i < 16)
                {
                    lbxTorba2.Items.Add(teams[choseTeams[i]]);
                }
                else if (i < 24)
                {
                    lbxTorba3.Items.Add(teams[choseTeams[i]]);
                }
                else
                {
                    lbxTorba4.Items.Add(teams[choseTeams[i]]);

                }
            }
            pots.Add(lbxTorba1);
            pots.Add(lbxTorba2);
            pots.Add(lbxTorba3);
            pots.Add(lbxTorba4);
            groups.Add(lbxA);
            groups.Add(lbxB);
            groups.Add(lbxC);
            groups.Add(lbxD);
            groups.Add(lbxE);
            groups.Add(lbxF);
            groups.Add(lbxG);
            groups.Add(lbxH);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<int> choseTeams = new List<int>();
            int team1Skor = 0;
            int team2Skor = 0;
            int team1Puan = 0;
            int team2Puan = 0;
            for (int i = 0; i < 6; i++)
            {
               
            }
        }
    }
}