using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms;

namespace Comment
{
    public partial class AddMail : Form
    {
        public AddMail()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        //Add mail to Sql
        private void ConnectSQL()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Comment\Comment\MailTool.mdb;Persist Security Info=True;Jet OLEDB:Database Password=1");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Insert into Mail(Mail,Pass,Recovery) Values ('" + txtMail1.Text + "','" + txtPass1.Text + "','" + txtRecovery1.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm mail thành công!", "Thông báo");
            con.Close();

        }
        //Check login mail
        void CheckLogin()
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            options.AddArguments("--window-size=455,730");
            options.AddArguments("--disable-notifications");
            options.AddArguments("--window-position=0,0");
            var driver = new ChromeDriver(driverService, options);

            driver.Navigate().GoToUrl("https://accounts.google.com/o/oauth2/auth/identifier?client_id=717762328687-iludtf96g1hinl76e4lc1b9a82g457nn.apps.googleusercontent.com&scope=profile%20email&redirect_uri=https%3A%2F%2Fstackauth.com%2Fauth%2Foauth2%2Fgoogle&state=%7B%22sid%22%3A1%2C%22st%22%3A%2259%3A3%3Abbc%2C16%3Aa7fce084bdd64e1c%2C10%3A1597995992%2C16%3A9ff0abc0cd4b694b%2Cc99e3825545339da216973e3d5cfdec3025242ef118beeaf07872683f8d3fbac%22%2C%22cdl%22%3Anull%2C%22cid%22%3A%22717762328687-iludtf96g1hinl76e4lc1b9a82g457nn.apps.googleusercontent.com%22%2C%22k%22%3A%22Google%22%2C%22ses%22%3A%22170b4e294a0e40e98167e249c0585783%22%7D&response_type=code&flowName=GeneralOAuthFlow");
            IWebElement query = driver.FindElement(By.CssSelector("input[type='email']"));
            query.SendKeys(txtMail1.Text + OpenQA.Selenium.Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            query = driver.FindElement(By.CssSelector("input[name='password']"));
            query.SendKeys(txtPass1.Text + OpenQA.Selenium.Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
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
                    reemail.SendKeys(txtRecovery1.Text + OpenQA.Selenium.Keys.Enter);
                }
            }
            catch (Exception)
            {

            }
            driver.Navigate().GoToUrl("https://myaccount.google.com/");
            driver.FindElement(By.XPath("//*[@id='gb']/div[2]/div[3]/div[1]/div/div/a")).Click();
            try
            {
                string b = driver.FindElement(By.XPath("/html/body/div[2]/header/div[2]/div[4]/div[1]/div[2]/div[2]")).Text;
                if (b.Contains(txtMail1.Text))
                {
                    btnMail1.Enabled = true;
                    btnCheck1.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Không thêm được Email!");
                    btnMail1.Enabled = false;
                    btnCheck1.Enabled = true;

                }
            }
            catch (Exception)
            {

            }
            driver.Quit();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectSQL();
            MyEmail t1 = new MyEmail();
            t1.dataGridView1.Refresh();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            if (txtMail1.Text == "" || txtPass1.Text == "")
            {
                MessageBox.Show("Chưa nhập Gmail hoặc mật khẩu", "Lỗi");
            }
            else
            {
                ThreadStart check = new ThreadStart(CheckLogin);
                Thread check1 = new Thread(check);
                check1.IsBackground = true;
                check1.Start();
            }
        }

        private void AddMail_Load(object sender, EventArgs e)
        {
            btnMail1.Enabled = false;
        }
    }
}
