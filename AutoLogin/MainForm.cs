using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace AutoLogin
{
    public partial class MainForm : Form
    {
        bool buttonStatus = false;

        public MainForm()
        {
            InitializeComponent();
            loginWebBrowser.ScriptErrorsSuppressed = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loginButton_Click(null, null);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            buttonStatus = false;
            loginButton.Enabled = buttonStatus;

            if (!testConnection())
                loginWebBrowser.Url = new Uri("http://login.gwifi.com.cn/cmps/admin.php/api/login/");
            else
                writeConnectionSuccessHtmlFile();
        }

        private void loginWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            buttonStatus = true;
            loginButton.Enabled = buttonStatus;

            if (!testConnection())
            {
                try
                {
                    //HtmlElement username = webBrowser1.Document.All["kw"];
                    HtmlElement username = loginWebBrowser.Document.GetElementById("first_name");
                    username.SetAttribute("value", Properties.Settings.Default.user);
                    HtmlElement password = loginWebBrowser.Document.GetElementById("first_password");
                    password.SetAttribute("value", Properties.Settings.Default.password);

                    HtmlElement login = loginWebBrowser.Document.GetElementById("first_button");
                    login.InvokeMember("click");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
                Debug.WriteLine(loginWebBrowser.Url);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete(Application.StartupPath + "/ConnectionSuccess.html");
        }

        private void setLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new setDialogForm().ShowDialog();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        #region 获取内/外网ip函数模块 
        public static String GetLocalIp()
        {
            String[] allInternalIP = getAllInternalIP();

            foreach (String ip in allInternalIP) if (ip.StartsWith("10.")) return ip;
            foreach (String ip in allInternalIP) if (ip.Contains("169.")) return ip;
            foreach (String ip in allInternalIP) if (ip.Contains("172.")) return ip;
            foreach (String ip in allInternalIP) if (ip.Contains("192.")) return ip;
            foreach (String ip in allInternalIP) if (ip.Contains(".")) return ip;

            return "127.0.0.1";
        }

        public static string[] getAllInternalIP()
        {
            string hostName = Dns.GetHostName();                    //获取主机名称    
            IPAddress[] addresses = Dns.GetHostAddresses(hostName); //解析主机IP地址    

            string[] IP = new string[addresses.Length];             //转换为字符串形式    
            for (int i = 0; i < addresses.Length; i++)
                IP[i] = addresses[i].ToString();

            return IP;
        }

        public static JObject getExtenalIPInfo()
        {
            // http://ip.taobao.com/service/getIpInfo.php?ip=myip
            //{"code":0,"data":{"ip":"119.167.102.186","country":"中国","area":"","region":"山东","city":"青岛","county":"XX","isp":"联通","country_id":"CN","area_id":"","region_id":"370000","city_id":"370200","county_id":"xx","isp_id":"100026"}} 

            //从网址中获取本机ip数据    
            System.Net.WebClient client = new System.Net.WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string str = client.DownloadString("http://ip.taobao.com/service/getIpInfo.php?ip=myip");
            client.Dispose();

            return JObject.Parse(str);
        }

        public static string getExtenalIP()
        {
            return getExtenalIPInfo()["data"]["ip"].ToString();
        }

        public static string getExtenalIP(JObject json)
        {
            return json["data"]["ip"].ToString();
        }

        public bool testConnection()
        {
            try { getExtenalIP(); }
            catch
            {
                connectionStatusLabel.Text = "需要登录GIWIFI";
                internalIPLabel.Text = "内网ip:" + GetLocalIp();
                externalIPLabel.Text = "外网ip:无";
                return false;
            }
            connectionStatusLabel.Text = "成功连接网络";
            internalIPLabel.Text = "内网ip:" + GetLocalIp();
            externalIPLabel.Text = "外网ip:" + getExtenalIP();
            return true;
        }

        public void writeConnectionSuccessHtmlFile()
        {
            string[] allInternalIP = getAllInternalIP();
            string allInternalIPHtml = "";
            foreach (string ip in allInternalIP)
            {
                allInternalIPHtml = allInternalIPHtml + ip + "<br>";
            }

            File.WriteAllText(Application.StartupPath + "/ConnectionSuccess.html",
                @"<html>"
                + @"<body>"
                + @"<h2>网络连接成功</h2>"
                + @"<h3>内网ip:</h3>"
                + allInternalIPHtml
                + @"<h3>外网ip:</h3>"
                + getExtenalIP()
                + @"</body>"
                + @"</html>",
                Encoding.UTF8);

            loginWebBrowser.Url = new Uri("file://" + Application.StartupPath + "/ConnectionSuccess.html");
        }
        #endregion


    }
}
