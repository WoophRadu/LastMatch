using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastMatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLoadMatch_Click(object sender, EventArgs e)
        {
            buttonLoadMatch.Text = "Loading...";
            labelStatus.Text = "Contacting Steam API ... ";

            JObject dataWooph = null;
            JObject dataDavid = null;
            JObject dataAdi = null;
            JObject dataRola = null;
            JObject dataNihtmer = null;
            JObject dataLoopie = null;
            JObject dataDusky = null;

            BackgroundWorker bw = new BackgroundWorker();
            
            bw.WorkerReportsProgress = true;
            
            bw.DoWork += new DoWorkEventHandler(
            delegate (object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;
                labelStatus.Text = "Contacting Steam API ... ";

                WebClient client = new WebClient();
                var rawdata = client.DownloadString("http://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v0002/?appid=730&key=7DBEF9DC04174391BE2C306B62507157&steamid=" + "76561198047147260");
                dataWooph = JObject.Parse(rawdata);
                b.ReportProgress(14);
                rawdata = client.DownloadString("http://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v0002/?appid=730&key=7DBEF9DC04174391BE2C306B62507157&steamid=" + "76561198292504915");
                dataDavid = JObject.Parse(rawdata);
                b.ReportProgress(29);
                rawdata = client.DownloadString("http://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v0002/?appid=730&key=7DBEF9DC04174391BE2C306B62507157&steamid=" + "76561198131077689");
                dataAdi = JObject.Parse(rawdata);
                b.ReportProgress(43);
                rawdata = client.DownloadString("http://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v0002/?appid=730&key=7DBEF9DC04174391BE2C306B62507157&steamid=" + "76561198104342062");
                dataRola = JObject.Parse(rawdata);
                b.ReportProgress(57);
                rawdata = client.DownloadString("http://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v0002/?appid=730&key=7DBEF9DC04174391BE2C306B62507157&steamid=" + "76561198182490079");
                dataNihtmer = JObject.Parse(rawdata);
                b.ReportProgress(71);
                rawdata = client.DownloadString("http://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v0002/?appid=730&key=7DBEF9DC04174391BE2C306B62507157&steamid=" + "76561198064646048");
                dataLoopie = JObject.Parse(rawdata);
                b.ReportProgress(86);
                rawdata = client.DownloadString("http://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v0002/?appid=730&key=7DBEF9DC04174391BE2C306B62507157&steamid=" + "76561198070115844");
                dataDusky = JObject.Parse(rawdata);
                b.ReportProgress(99);
            });
            
            bw.ProgressChanged += new ProgressChangedEventHandler(
            delegate (object o, ProgressChangedEventArgs args)
            {
                labelStatus.Text = string.Format("Fetching data from Steam API ... {0}% ", args.ProgressPercentage);
            });
            
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate (object o, RunWorkerCompletedEventArgs args)
            {
                labelStatus.Text = "Successfully fetched data from Steam API!";

                buttonLoadMatch.Text = "Succes!";

                timerButtonLoadMatch.Enabled = true;
                timerButtonLoadMatch.Start();
                timerButtonLoadMatch.Tick += new EventHandler(resetButtonLoadMatch);
                dataGridView1.RowCount = 1;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[1].Value = "Wooph";
                int kills = (int)dataWooph["playerstats"]["stats"][91]["value"];
                int deaths = (int)dataWooph["playerstats"]["stats"][92]["value"];
                int mvps = (int)dataWooph["playerstats"]["stats"][93]["value"];
                row.Cells[2].Value = kills;
                row.Cells[4].Value = deaths;
                row.Cells[5].Value = mvps;
                dataGridView1.Rows.Add(row);

                row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[1].Value = "David";
                kills = (int)dataDavid["playerstats"]["stats"][81]["value"];
                deaths = (int)dataDavid["playerstats"]["stats"][82]["value"];
                mvps = (int)dataDavid["playerstats"]["stats"][83]["value"];
                row.Cells[2].Value = kills;
                row.Cells[4].Value = deaths;
                row.Cells[5].Value = mvps;
                dataGridView1.Rows.Add(row);

                row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[1].Value = "Adi";
                kills = (int)dataAdi["playerstats"]["stats"][91]["value"];
                deaths = (int)dataAdi["playerstats"]["stats"][92]["value"];
                mvps = (int)dataAdi["playerstats"]["stats"][93]["value"];
                row.Cells[2].Value = kills;
                row.Cells[4].Value = deaths;
                row.Cells[5].Value = mvps;
                dataGridView1.Rows.Add(row);

                row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[1].Value = "Rola";
                kills = (int)dataRola["playerstats"]["stats"][91]["value"];
                deaths = (int)dataRola["playerstats"]["stats"][92]["value"];
                mvps = (int)dataRola["playerstats"]["stats"][93]["value"];
                row.Cells[2].Value = kills;
                row.Cells[4].Value = deaths;
                row.Cells[5].Value = mvps;
                dataGridView1.Rows.Add(row);

                row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[1].Value = "Nihtmer";
                kills = (int)dataNihtmer["playerstats"]["stats"][91]["value"];
                deaths = (int)dataNihtmer["playerstats"]["stats"][92]["value"];
                mvps = (int)dataNihtmer["playerstats"]["stats"][93]["value"];
                row.Cells[2].Value = kills;
                row.Cells[4].Value = deaths;
                row.Cells[5].Value = mvps;
                dataGridView1.Rows.Add(row);

                row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[1].Value = "Loopie";
                kills = (int)dataLoopie["playerstats"]["stats"][90]["value"];
                deaths = (int)dataLoopie["playerstats"]["stats"][91]["value"];
                mvps = (int)dataLoopie["playerstats"]["stats"][92]["value"];
                row.Cells[2].Value = kills;
                row.Cells[4].Value = deaths;
                row.Cells[5].Value = mvps;
                dataGridView1.Rows.Add(row);

                row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[1].Value = "Dusky";
                kills = (int)dataDusky["playerstats"]["stats"][92]["value"];
                deaths = (int)dataDusky["playerstats"]["stats"][93]["value"];
                mvps = (int)dataDusky["playerstats"]["stats"][94]["value"];
                row.Cells[2].Value = kills;
                row.Cells[4].Value = deaths;
                row.Cells[5].Value = mvps;
                dataGridView1.Rows.Add(row);

                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            });

            bw.RunWorkerAsync();

        }
        void resetButtonLoadMatch(object sender, EventArgs e)
        {
            buttonLoadMatch.Text = "Load Match";
            labelStatus.Text = "Idle";
            timerButtonLoadMatch.Stop();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
