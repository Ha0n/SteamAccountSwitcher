using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Gameloop.Vdf;
using System.Diagnostics;

namespace SteamAccountSwitcher
{
    class Utils
    {
        /// <summary>
        /// 单例实现
        /// </summary>
        private static Utils utils = new Utils();
        private Utils() { }
        public static Utils getInstance()
        {
            return utils;
        }


        private const string vdfFilePath = @"config/loginusers.vdf";
        public string steamPath;
        public string steamEXEPath;
        public bool steamExist = false;

        /// <summary>
        /// 将时间戳转换为DateTime
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public DateTime Timestamp2DateTime(long timestamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(timestamp).ToLocalTime();
            return dateTime;
        }


        public RegistryKey getSteamRegistryKey(bool edit)
        {
            return Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Valve\Steam", edit);
        }

        public void loadSteamData()
        {
            try
            {
                var steamKey = getSteamRegistryKey(false);
                if (steamKey != null)
                {
                    steamPath = steamKey.GetValue("SteamPath").ToString();
                    Debug.WriteLine("获取Steam路径:" + steamPath);

                    steamEXEPath = steamKey.GetValue("SteamExe").ToString();
                    Debug.WriteLine("获取SteamExe路径" + steamEXEPath);

                    steamExist = true;
                }
                else
                    steamExist = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("加载Steam数据失败:" + ex.Message);
                MessageBox.Show(ex.Message);

                steamExist = false;
            }
        }

        public List<SteamUser> loadUsers()
        {
            Debug.WriteLine("开始解析用户信息");

            string vdfPath = Path.Combine(steamPath, vdfFilePath);
            List<SteamUser> users = new List<SteamUser>();

            var rootToken = VdfConvert.Deserialize(File.ReadAllText(vdfPath));
            foreach (var userToken in rootToken.Value)
            {
                dynamic i = VdfConvert.Deserialize(userToken.ToString());

                SteamUser user = new SteamUser()
                {
                    steamId64 = Convert.ToInt64(i.Key.ToString()),
                    AccountName = i.Value.AccountName?.ToString(),
                    PersonaName = i.Value.PersonaName?.ToString(),
                    RememberPassword = Convert.ToBoolean(Convert.ToInt64(i.Value.RememberPassword?.ToString())),
                    Timestamp = Convert.ToInt64(i.Value.Timestamp?.ToString())
                };

                users.Add(user);
            }

            Debug.WriteLine("解析用户信息完成");

            return users;
        }

        public string AutoLoginUser
        {
            get
            {
                string result = getSteamRegistryKey(false).GetValue("AutoLoginUser").ToString();
                if (string.IsNullOrEmpty(result))
                    return string.Empty;
                else
                    return result;
            }
            set
            {
                var steamKey = getSteamRegistryKey(true);
                if(!value.Equals(AutoLoginUser))
                    steamKey.SetValue("AutoLoginUser", value);
            }
        }

        public bool TryKillSteamProcess()
        {
            Debug.WriteLine("尝试结束Steam进程");

            try
            {
                KillSteamProcess();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("结束Steam进程失败:" + ex.Message);
                return false;
            }
        }

        public void StartSteam(string param = "")
        {
            Debug.WriteLine("启动Steam");

            if (!string.IsNullOrEmpty(steamEXEPath))
            {
                Process.Start(steamEXEPath, param);
            }
        }

        private void KillSteamProcess()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.ProcessName.Equals("steam", StringComparison.OrdinalIgnoreCase) || process.ProcessName.Equals("steamwebhelper", StringComparison.OrdinalIgnoreCase))
                {
                    process.Kill();
                }
            }
        }
    }
}
