using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;
using static Comment.CommentVideo;

namespace Comment
{
    public partial class CommentVideo : Form
    {
        int n;
        string ProfileFolderPath = "Profile";
        public CommentVideo()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        #region Class
        //Class Title
        public class RootTitle
        {
            public List<ItemTitle> items { get; set; }
        }

        public class ItemTitle
        {
            public string id { get; set; }
            public SnippetTitle snippet { get; set; }

        }

        public class SnippetTitle
        {
            public string channelId { get; set; }
            public string channelTitle { get; set; }

        }
        //Class View Count
        public class ItemViewCount
        {
            public StatisticsViewCount statistics { get; set; }
        }


        public class RootViewCount
        {
            public List<ItemViewCount> items { get; set; }
        }

        public class StatisticsViewCount
        {
            public string viewCount { get; set; }
            public string likeCount { get; set; }
            public string favoriteCount { get; set; }
            public string commentCount { get; set; }
        }
        //Class Sub Count

        public class ItemSubCount
        {
            public StatisticsSubCount statistics { get; set; }
        }

        public class RootSubCount
        {
            public List<ItemSubCount> items { get; set; }
        }

        public class StatisticsSubCount
        {
            public string subscriberCount { get; set; }

        }
        //Class 

        public class ContentDetailsDuration
        {
            public string duration { get; set; }

        }

        public class ItemDuration
        {
            public ContentDetailsDuration contentDetails { get; set; }
        }



        public class RootDuration
        {
            public List<ItemDuration> items { get; set; }
        }



        #endregion


        public string ApiProxy()
        {
            string proxyurl = "https://api.getproxylist.com/proxy?&protocol[]=socks5&country[]=US";
            HttpWebRequest proxyrequest = (HttpWebRequest)WebRequest.Create(proxyurl);
            HttpWebResponse proxyresponse = (HttpWebResponse)proxyrequest.GetResponse();
            Stream proxystream = proxyresponse.GetResponseStream();
            StreamReader proxyreader = new StreamReader(proxystream);
            string proxyjson = proxyreader.ReadToEnd();
            var SteamDetails = JsonConvert.DeserializeObject<dynamic>(proxyjson);
            string ip = SteamDetails.ip;
            string port = SteamDetails.port;
            return ip + port;
        }
        public void Api()
        {
            var client = new RestClient("https://proxy-orbit1.p.rapidapi.com/v1/");
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("x-rapidapi-host", "proxy-orbit1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "d346afd0d5mshafb495a22ac67ecp1cd187jsn33c84737bc62");
            RestResponse response = client.Execute(request);
        }
        private string UserAgent()
        {
            return "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.162 Safari/537.36|Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36|Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36|Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Ubuntu/16.04.3 Chrome/64.0.3282.140 Safari/537.36|Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.100 Safari/537.36 OPR/48.0.2685.52|Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36 Edge/16.16299|Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko|Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/68.4.154 Chrome/62.4.3202.154 Safari/537.36|Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.119 Safari/537.36 Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:58.0) Gecko/20100101 Firefox/58.0|Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36|Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.167 Safari/537.36|Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36|Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36|Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36|Mozilla/5.0 (Windows NT 10.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36|Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.167 Safari/537.36|Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36|Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.167 Safari/537.36|Mozilla/5.0 (X11; CrOS x86_64 10176.68.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.144 Safari/537.36|Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.168 Safari/537.36|Mozilla/5.0 (Windows NT 6.3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.167 Safari/537.36|Mozilla/5.0 (Windows NT 6.3; WOW64; rv:54.0) Gecko/20100101 Firefox/54.0|Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko|Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3288.0 Safari/537.36|Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) HeadlessChrome/65.0.3292.0 Safari/537.36|Mozilla/5.0 (X11; CrOS x86_64 10214.0.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3294.0 Safari/537.36|Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3291.0 Safari/537.36,gzip(gfe)|Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko|Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko|Mozilla/5.0 (Windows NT 6.3; ARM; Trident/7.0; Touch; rv:11.0) like Gecko|Mozilla/5.0 (Windows NT 6.2; WOW64; Trident/7.0; rv:11.0) like Gecko|Mozilla/5.0 (IE 11.0; Windows NT 6.2; WOW64; Trident/7.0; rv:11.0) like Gecko";
        }
        private string GetUA()
        {
            string result = "";
            try
            {
                string text = this.UserAgent();
                char[] separator = new char[]
                {
                '|'
                };
                string[] array = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                Random random = new Random();
                result = array[random.Next(0, array.Length)];
            }
            catch
            {
            }
            return result;
        }
        public void StartCmtChrome()
        {
            try
            {
                string UA = GetUA();
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                ChromeOptions options = new ChromeOptions();
                if (!Directory.Exists(ProfileFolderPath))
                {
                    Directory.CreateDirectory(ProfileFolderPath);
                }
                if (Directory.Exists(ProfileFolderPath))
                {
                    int nameCount = 0;

                    options.AddArguments("user-data-dir=" + ProfileFolderPath + "\\" + nameCount);
                }
                if (CbMute.Checked)
                {
                    options.AddArguments("--mute-audio");
                }
                //var proxy = new Proxy();
                //proxy.Kind = ProxyKind.Manual;
                //proxy.IsAutoDetect = true;
                //proxy.HttpProxy = this.ApiProxy();
                //proxy.SslProxy = this.ApiProxy();
                //proxy.SocksProxy = this.ApiProxy();
                //options.Proxy = proxy;
                //options.AddExtension("C:\\Users\\PC\\Downloads\\npeicpdbkakmehahjeeohfdhnlpdklia.crx");
                options.PageLoadStrategy = PageLoadStrategy.Normal;
                options.AddExcludedArgument("enable-automation");
                //options.AddAdditionalCapability("useAutomationExtension", false);
                options.AddArgument("--user-agent=" + UA);
                options.AddArguments("ignore-certificate-errors");
                options.AddArguments("--incognito");
                options.AddArguments("--window-size=455,768");
                options.AddArguments("--disable-notifications");
                options.AddArguments("--window-position=0,0");
                options.AddUserProfilePreference("media.peerconnection.enabled", false);

                var driver = new ChromeDriver(driverService, options);
                //driver.Navigate().GoToUrl("chrome-extension://npeicpdbkakmehahjeeohfdhnlpdklia/options.html");
                //driver.FindElementById("disable_non_proxied_udp").Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Navigate().GoToUrl("https://accounts.google.com/o/oauth2/auth?client_id=717762328687-iludtf96g1hinl76e4lc1b9a82g457nn.apps.googleusercontent.com&scope=profile+email&redirect_uri=https%3a%2f%2fstackauth.com%2fauth%2foauth2%2fgoogle&state=%7b%22sid%22%3a1%2c%22st%22%3a%2259%3a3%3aBBC%2c16%3a76f381a5db260ab5%2c10%3a1597585850%2c16%3a0de8c2b94c0a8704%2c37d8ad8e3a517a80798df4b0a8a831482af29d563ee953ffe7bb75a40e5394b0%22%2c%22cdl%22%3anull%2c%22cid%22%3a%22717762328687-iludtf96g1hinl76e4lc1b9a82g457nn.apps.googleusercontent.com%22%2c%22k%22%3a%22Google%22%2c%22ses%22%3a%2205707ef6697b439795eb788e54653265%22%7d&response_type=code");
                IWebElement query = driver.FindElement(By.CssSelector("input[type='email']"));
                lblStatus.Text = "Đang nhập mail";
                query.SendKeys("dinhthanh.ytb1@gmail.com" + OpenQA.Selenium.Keys.Enter);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                query = driver.FindElement(By.CssSelector("input[name='password']"));
                lblStatus.Text = "Đang nhập mật khẩu";
                query.SendKeys(txtPass1.Text.Trim() + OpenQA.Selenium.Keys.Enter);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                Thread.Sleep(1000);
                //Kiểm tra đăng nhập
                try
                {
                    string a = driver.FindElement(By.CssSelector("#headingText")).Text;
                    if (a.Contains("Verify it's you") || a.Contains("Xác minh đó là bạn") || a.Contains("Xác minh danh tính của bạn"))
                    {
                        driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div/ul/li[2]/div")).Click();
                        //driver.FindElement(By.CssSelector("#view_container > div > div > div.pwWryf.bxPAYd > div > div.WEQkZc > div > form > span > section > div > div > div > ul > li:nth-child(2) > div"));
                        var reemail = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[2]/div[1]/div/div[1]/div/div[1]/input"));
                        reemail.Click();
                        reemail.SendKeys(txtRecovery1.Text.Trim() + OpenQA.Selenium.Keys.Enter);
                    }
                }
                catch (Exception)
                {

                }
                //Chuyển hướng đến YT
                lblStatus.Text = "Đang chuyển hướng đến Youtube";
                driver.Navigate().GoToUrl("https://www.youtube.com/watch?v=" + txtLink.Text.Trim());
                int MinTime = (Convert.ToInt32(numMinTime.Value) * 1000);
                int MaxTime = (Convert.ToInt32(numMaxTime.Value) * 1000);
                Random rnd = new Random();
                var randomtime = rnd.Next(MinTime, MaxTime);
                n = randomtime;
                pbRun.Value = 0;
                pbRun.Maximum = randomtime;
                tmRun.Enabled = true;
                tmRun.Start();
                lblStatus.Text = "Đang view";
                Thread.Sleep(randomtime);
                lblStatus.Text = "Đã view";

                //Like
                if (CbLike.Checked)
                {
                    try
                    {
                        lblStatus.Text = "Đang ấn nút like";
                        driver.FindElement(By.XPath("//*[@id='top-level-buttons']/ytd-toggle-button-renderer[1]/a")).Click();
                    }
                    catch
                    {
                        lblStatus.Text = "Không tìm thấy nút like";
                        MessageBox.Show("Không ấn được nút like, thử lại!", "Lỗi");
                    }

                }
                Thread.Sleep(2000);
                //Sub
                if (CbSub.Checked)
                {
                    try
                    {
                        string xpath = driver.FindElement(By.XPath("//*[@id='subscribe-button']/ytd-subscribe-button-renderer/paper-button")).Text;
                        if (xpath.Contains("ĐĂNG KÝ") || xpath.Contains("SUBSCRIBE"))
                        {
                            lblStatus.Text = "Đang ấn Đăng kí";
                            driver.FindElement(By.XPath("//*[@id='subscribe-button']/ytd-subscribe-button-renderer/paper-button")).Click();
                            lblStatus.Text = "Đã ấn Đăng kí";
                            driver.FindElement(By.CssSelector("#notification-preference-button")).Click();
                            lblStatus.Text = "Đang chọn tất cả chuông";
                            driver.FindElement(By.CssSelector("#items > ytd-menu-service-item-renderer:nth-child(1)")).Click();
                            lblStatus.Text = "Đã chọn tất cả chuông";
                        }
                    }

                    catch (Exception)
                    {
                        string xpath1 = driver.FindElement(By.XPath("//*[@id='subscribe-button']/ytd-subscribe-button-renderer/paper-button")).Text;
                        if (xpath1.Contains("ĐÃ ĐĂNG KÝ") || xpath1.Contains("SUBSCRIBED"))
                        {
                            lblStatus.Text = "Mail đã đăng kí kênh";
                            MessageBox.Show("Đăng kí rồi bạn êi!", "TGT Tool");
                        }
                        else
                        {
                            lblStatus.Text = "Lỗi khi nhấn đăng kí";
                            MessageBox.Show("Lỗi bấm đăng kí!", "Lỗi");
                        }
                    }

                }
                //Comment
                IWebElement body = driver.FindElement(By.XPath("/html/body"));
                body.SendKeys(OpenQA.Selenium.Keys.End);
                Thread.Sleep(2000);
                body.SendKeys(OpenQA.Selenium.Keys.PageDown);
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-watch-flexy/div[4]/div[1]/div/ytd-comments/ytd-item-section-renderer/div[3]/ytd-comment-thread-renderer[1]/ytd-comment-renderer/div[1]/div[2]/ytd-comment-action-buttons-renderer/div[1]/ytd-toggle-button-renderer[1]/a/yt-icon-button/button")).Click();
                driver.FindElement(By.Id("placeholder-area")).Click();
                Thread.Sleep(2000);
                lblStatus.Text = "Đang Comment";
                driver.FindElement(By.Id("contenteditable-root")).SendKeys(txtCmt.Text.Trim());
                Thread.Sleep(2000);
                driver.FindElement(By.Id("submit-button")).Click();
                lblStatus.Text = "Đã comment";
                lblStatus.Text = "Đang thoát Chrome!";
                Thread.Sleep(5000);
                driver.Close();
                driver.Quit();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi, vui lòng thử lại!", "Lỗi");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCmt.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập Comment!", "Lỗi");
                }
                if (numMaxTime.Value > Convert.ToDecimal(txtTime.Text))
                {
                    MessageBox.Show("Thời gian view lớn hơn thời gian video!", "Lỗi");
                }
                if (Convert.ToInt32(numMaxTime.Value) - Convert.ToInt32(numMinTime.Value) < 50)
                {
                    MessageBox.Show("Thời gian view phải chênh lệch 50s!", "Lỗi");
                }
            }
            catch (Exception)
            {
                for (int i = 0; i < numThread.Value; i++)
                {
                    ThreadStart comment = new ThreadStart(StartCmtChrome);
                    Thread cmt = new Thread(comment);
                    cmt.IsBackground = true;
                    cmt.Start();
                }
            }

        }

        async void GetTitleVideo(string id, string key)
        {
            try
            {
                var options = new RestClientOptions()
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("https://www.googleapis.com/youtube/v3/videos?part=snippet%2CcontentDetails&id="+id+"&key="+ key);
                request.Method = Method.Get;
                RestResponse response = await client.ExecuteAsync(request);
                RootTitle parsed_json = JsonConvert.DeserializeObject<RootTitle>(response.Content);
                string ChannelName = parsed_json.items[0].snippet.channelTitle;
                string ChannelID = parsed_json.items[0].snippet.channelId;

                if(ChannelName.Length > 0)
                {
                    lblChannelName.Text = ChannelName;
                }
                else
                {
                    MessageBox.Show("Lỗi API!");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lấy tiêu đề video!");
            }
        }

        async void GetViewCount(string id, string key)
        {
            try
            {
                var options = new RestClientOptions()
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("https://www.googleapis.com/youtube/v3/videos?part=statistics&id="+id+"&key="+key);
                request.Method = Method.Get;
                RestResponse response = await client.ExecuteAsync(request);
                RootViewCount parsed_json = JsonConvert.DeserializeObject<RootViewCount>(response.Content);
                string ViewCount = parsed_json.items[0].statistics.viewCount;

                if (ViewCount.Length > 0)
                {
                    txtView.Text = ViewCount;
                }
                else
                {
                    MessageBox.Show("Lỗi API!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lấy số view!");
            }
        }

        async void GetSubCount(string id, string key)
        {
            try
            {
                var options = new RestClientOptions()
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("https://www.googleapis.com/youtube/v3/videos?part=snippet%2CcontentDetails&id=" + id + "&key=" + key);
                request.Method = Method.Get;
                RestResponse response = await client.ExecuteAsync(request);
                RootTitle parsed_json = JsonConvert.DeserializeObject<RootTitle>(response.Content);
                
                string ChannelID = parsed_json.items[0].snippet.channelId;


                var options1 = new RestClientOptions()
                {
                    MaxTimeout = -1,
                };
                var client1 = new RestClient(options);
                var request1 = new RestRequest("https://www.googleapis.com/youtube/v3/channels?part=statistics&id="+ ChannelID +"&key="+key);
                request1.Method = Method.Get;
                RestResponse response1 = await client.ExecuteAsync(request1);
                RootSubCount parsed_json1 = JsonConvert.DeserializeObject<RootSubCount>(response1.Content);
                string sub_count = parsed_json1.items[0].statistics.subscriberCount;

                if(sub_count.Length >0)
                {
                    txtTotalSub.Text = sub_count;
                }
                else
                {
                    MessageBox.Show("Lỗi API!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lấy số sub!");
            }
        }

        async void GetVideoDuration(string id, string key)
        {
            try
            {
                var options = new RestClientOptions()
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("https://www.googleapis.com/youtube/v3/videos?part=contentDetails&id="+id+"&key="+key);
                request.Method = Method.Get;
                RestResponse response = await client.ExecuteAsync(request);
                RootDuration parsed_json = JsonConvert.DeserializeObject<RootDuration>(response.Content);
                string time = parsed_json.items[0].contentDetails.duration;
                TimeSpan ts = XmlConvert.ToTimeSpan(time);
                double seconds = ts.TotalSeconds;

                if(seconds > 0)
                {
                    txtTime.Text = seconds.ToString();
                }
                else
                {
                    MessageBox.Show("Lỗi API!");
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Không thể lấy thời lượng video");
            }
        }

        void GetThumbnail(string id)
        {
            try
            {
                var request = WebRequest.Create("https://img.youtube.com/vi/" +id + "/mqdefault.jpg");
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox1.Image = Bitmap.FromStream(stream);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                btnBatDau.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lấy thumbnail video!");
            }
        }
        

        private void btnCheckVideo_Click(object sender, EventArgs e)
        {
            string id = txtLink.Text;
            string key = "AIzaSyDInVCVdX1AH5T_J8zprDTCfSdrnu_bSUo";

            GetTitleVideo(id,key);
            GetViewCount(id, key);
            GetSubCount(id, key);
            GetVideoDuration(id, key);
            GetThumbnail(id);
        }

        private void AddVideo_Load(object sender, EventArgs e)
        {
            //btnBatDau.Enabled = false;
            btnCheckVideo.Enabled = true;
        }

        private void tmRun_Tick(object sender, EventArgs e)
        {
            n--;

            pbRun.PerformStep();

            if (n == 0)
            {
                tmRun.Stop();
            }
        }
    }
}
