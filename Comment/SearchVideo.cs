using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Comment
{
    public partial class SearchVideo : Form
    {
        public SearchVideo()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        void TimVideo()
        {
            try
            {


                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--incognito");
                options.AddArguments("--window-size=455,730");
                options.AddArguments("--mute-audio");
                options.AddArguments("--disable-notifications");
                options.AddArguments("--window-position=0,0");
                var driver = new ChromeDriver(driverService, options);

                driver.Navigate().GoToUrl("https://accounts.google.com/o/oauth2/auth/identifier?client_id=717762328687-iludtf96g1hinl76e4lc1b9a82g457nn.apps.googleusercontent.com&scope=profile%20email&redirect_uri=https%3A%2F%2Fstackauth.com%2Fauth%2Foauth2%2Fgoogle&state=%7B%22sid%22%3A1%2C%22st%22%3A%2259%3A3%3Abbc%2C16%3Aa7fce084bdd64e1c%2C10%3A1597995992%2C16%3A9ff0abc0cd4b694b%2Cc99e3825545339da216973e3d5cfdec3025242ef118beeaf07872683f8d3fbac%22%2C%22cdl%22%3Anull%2C%22cid%22%3A%22717762328687-iludtf96g1hinl76e4lc1b9a82g457nn.apps.googleusercontent.com%22%2C%22k%22%3A%22Google%22%2C%22ses%22%3A%22170b4e294a0e40e98167e249c0585783%22%7D&response_type=code&flowName=GeneralOAuthFlow");
                IWebElement query = driver.FindElement(By.CssSelector("input[type='email']"));
                query.SendKeys(txtMail.Text + OpenQA.Selenium.Keys.Enter);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                query = driver.FindElement(By.CssSelector("input[name='password']"));
                query.SendKeys(txtPass.Text + OpenQA.Selenium.Keys.Enter);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                Thread.Sleep(1000);
                try
                {
                    string a = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[1]/div/h1")).Text;
                    if (a.Contains("Verify it's you") || a.Contains("Xác minh đó là bạn") || a.Contains("Xác minh danh tính của bạn"))
                    {
                        driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div/ul/li[2]/div")).Click();
                        //driver.FindElement(By.CssSelector("#view_container > div > div > div.pwWryf.bxPAYd > div > div.WEQkZc > div > form > span > section > div > div > div > ul > li:nth-child(2) > div"));
                        var reemail = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[2]/div[1]/div/div[1]/div/div[1]/input"));
                        reemail.Click();
                        reemail.SendKeys(txtRecovery.Text + OpenQA.Selenium.Keys.Enter);
                    }
                }
                catch (Exception)
                {

                }
                driver.Navigate().GoToUrl("https://www.youtube.com/results?search_query=" + txtKeyword.Text);
                try
                {
                    driver.FindElement(By.CssSelector("a[href*='/watch?v=" + txtLink.Text + "']")).Click();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không tìm thấy link video!");
                }
                int MinTime = (Convert.ToInt32(numMinTime.Value) * 1000);
                int MaxTime = (Convert.ToInt32(numMaxTime.Value) * 1000);
                Random rnd = new Random();
                Thread.Sleep(rnd.Next(MinTime, MaxTime));
                if (CbLike.Checked)
                {
                    try
                    {
                        driver.FindElement(By.XPath("//*[@id='top-level-buttons']/ytd-toggle-button-renderer[1]/a")).Click();
                    }
                    catch
                    {
                        MessageBox.Show("Không ấn được nút like, thử lại!", "Lỗi");
                    }

                }
                Thread.Sleep(2000);
                if (CbSub.Checked)
                {
                    try
                    {
                        string xpath = driver.FindElement(By.XPath("//*[@id='subscribe-button']/ytd-subscribe-button-renderer/paper-button")).Text;
                        if (xpath.Contains("ĐĂNG KÝ") || xpath.Contains("SUBSCRIBE"))
                        {
                            driver.FindElement(By.XPath("//*[@id='subscribe-button']/ytd-subscribe-button-renderer/paper-button")).Click();
                            driver.FindElement(By.CssSelector("#notification-preference-button")).Click();
                            driver.FindElement(By.CssSelector("#items > ytd-menu-service-item-renderer:nth-child(1)")).Click();
                        }
                    }

                    catch (Exception)
                    {
                        string xpath1 = driver.FindElement(By.XPath("//*[@id='subscribe-button']/ytd-subscribe-button-renderer/paper-button")).Text;
                        if (xpath1.Contains("ĐÃ ĐĂNG KÝ") || xpath1.Contains("SUBSCRIBED"))
                        {
                            MessageBox.Show("Đăng kí rồi bạn êi!", "TGT Tool");
                        }
                        else
                        {
                            MessageBox.Show("Lỗi bấm đăng kí!", "Lỗi");
                        }
                    }

                }
                driver.Quit();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi, thử lại");
            }
        }

        private void btnCheckVideo_Click(object sender, EventArgs e)
        {
            //Lay tieu de
            string titleurl = "https://www.googleapis.com/youtube/v3/videos?part=snippet&id=" + txtLink.Text + "&key=AIzaSyBX-OT219m9Nrs-JV3rgWxVIYsNzD8-TP4";
            HttpWebRequest titlerequest = (HttpWebRequest)WebRequest.Create(titleurl);
            HttpWebResponse titleresponse = (HttpWebResponse)titlerequest.GetResponse();
            Stream titlestream = titleresponse.GetResponseStream();
            StreamReader titlereader = new StreamReader(titlestream);
            string titlejson = titlereader.ReadToEnd();
            Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(titlejson);
            string title = (string)jObject["items"][0]["snippet"]["title"];
            string ChannelName = (string)jObject["items"][0]["snippet"]["channelTitle"];

            //Lay so view
            string titleurl1 = "https://www.googleapis.com/youtube/v3/videos?part=statistics&id=" + txtLink.Text + "&key=AIzaSyBX-OT219m9Nrs-JV3rgWxVIYsNzD8-TP4";
            HttpWebRequest titlerequest1 = (HttpWebRequest)WebRequest.Create(titleurl1);
            HttpWebResponse titleresponse1 = (HttpWebResponse)titlerequest1.GetResponse();
            Stream titlestream1 = titleresponse1.GetResponseStream();
            StreamReader titlereader1 = new StreamReader(titlestream1);
            string titlejson1 = titlereader1.ReadToEnd();
            Newtonsoft.Json.Linq.JObject jObject1 = Newtonsoft.Json.Linq.JObject.Parse(titlejson1);
            string ViewCount = (string)jObject1["items"][0]["statistics"]["viewCount"];

            //Lay thoi gian video
            string timeurl = "https://www.googleapis.com/youtube/v3/videos?part=contentDetails&id=" + txtLink.Text + "&key=AIzaSyBX-OT219m9Nrs-JV3rgWxVIYsNzD8-TP4";
            HttpWebRequest timerequest = (HttpWebRequest)WebRequest.Create(timeurl);
            HttpWebResponse timeresponse = (HttpWebResponse)timerequest.GetResponse();
            Stream timestream = timeresponse.GetResponseStream();
            StreamReader timereader = new StreamReader(timestream);
            string timejson = timereader.ReadToEnd();
            Newtonsoft.Json.Linq.JObject videotime = Newtonsoft.Json.Linq.JObject.Parse(timejson);
            string time = (string)videotime["items"][0]["contentDetails"]["duration"];
            TimeSpan ts = XmlConvert.ToTimeSpan(time);
            double seconds = ts.TotalSeconds;

            if (title.Length > 0 && ChannelName.Length > 0 && ViewCount.Length > 0)
            {
                txtTilte.Text = title;
                lblChannelName.Text = ChannelName;
                txtView.Text = ViewCount;
                txtTime.Text = Convert.ToString(seconds);
            }
            else
            {
                MessageBox.Show("Lỗi lấy tên video!", "Lỗi");
            }
            var request = WebRequest.Create("https://img.youtube.com/vi/" + txtLink.Text + "/mqdefault.jpg");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            btnBatDau.Enabled = true;
            txtKeyword.Text = txtTilte.Text;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (numMaxTime.Value > Convert.ToDecimal(txtTime.Text))
            {
                MessageBox.Show("Thời gian view không hợp lệ!", "Lỗi");
            }
            else
            {
                for (int i = 0; i < numThread.Value; i++)
                {
                    ThreadStart search = new ThreadStart(TimVideo);
                    Thread search1 = new Thread(search);
                    search1.IsBackground = true;
                    search1.Start();
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

