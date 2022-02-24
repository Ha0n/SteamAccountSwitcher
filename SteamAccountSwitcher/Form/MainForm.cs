using Gameloop.Vdf;
using Gameloop.Vdf.Linq;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;

namespace SteamAccountSwitcher
{
    public partial class MainForm : Form
    {
        private Utils utils = Utils.getInstance();
        private List<SteamUser> users = new List<SteamUser>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            steamINIT();
        }

        private void account_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
           setInfo2Detail(users.Find(user => user.AccountName.Equals(account_CB.SelectedItem.ToString())));
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            string loginAcc = account_CB.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(loginAcc))
            {
                utils.AutoLoginUser = loginAcc;
                if (utils.TryKillSteamProcess())
                    utils.StartSteam();
            }

            Debug.WriteLine("当前自动登录用户:" + utils.AutoLoginUser);
        }

        private void copy64id_Btn_Click(object sender, EventArgs e)
        {
            if(steam64id_lb.Text.Length != 0)
            {
                Clipboard.SetText(steam64id_lb.Text);
                MessageBox.Show("已复制Steam64位ID:" + steam64id_lb.Text);
            }
        }

        private void saccrefresh_Btn_Click(object sender, EventArgs e)
        {
            steamINIT();
        }

        private void steamINIT()
        {
            if (!utils.steamExist)
                utils.loadSteamData();
            users = utils.loadUsers();

            setInfo2CB(users);

            // 查找存在自动登录过的账号
            if (!string.IsNullOrEmpty(utils.AutoLoginUser))
            {
                int lastLoginUserIndex = users.FindIndex(user => user.AccountName == utils.AutoLoginUser);
                setInfo2Detail(users[lastLoginUserIndex]);
                account_CB.SelectedIndex = lastLoginUserIndex;
            }
        }

        private void setInfo2CB(List<SteamUser> users)
        {
            account_CB.Items.Clear();

            foreach (var item in users)
            {
                account_CB.Items.Add(item.AccountName);
            }
        }

        private void setInfo2Detail(SteamUser user)
        {
            steam64id_lb.Text = user.steamId64.ToString();
            accname_lb.Text = user.AccountName;
            pername_lb.Text = user.PersonaName;
            lastlogintime_lb.Text = utils.Timestamp2DateTime(user.Timestamp).ToString("g");
            rememberPwd_checkbox.Checked = user.RememberPassword;
        }
    }
}