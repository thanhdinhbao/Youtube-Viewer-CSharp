using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Data;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms;

namespace Comment
{
    public partial class MyEmail : Form
    {

        public MyEmail()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }


        private void AddMail_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+path+"MailTool.mdb;Persist Security Info=True;Jet OLEDB:Database Password=1";
            string query = "Select * From Mail";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        //Add Mail
        private void btnAddMail_Click(object sender, EventArgs e)
        {
            AddMail f1 = new AddMail();
            f1.ShowDialog();
        }
        //Del Mail
        private void Xoa_Mail()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string ID = row.Cells[0].Value.ToString();
                try
                {
                    OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+path+"MailTool.mdb;Persist Security Info=True;Jet OLEDB:Database Password=1");
                    string query = "DELETE FROM Mail WHERE [ID]= @ID";
                    OleDbCommand cmd = new OleDbCommand();
                    conn.Open();
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa mail thành công!", "Thành công");
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message, "Lỗi");
                }

            }

        }

        private void btnDelMail_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mail này?", "Chắc chắn không?", buttons, MessageBoxIcon.Exclamation);
            switch (result)
            {
                case DialogResult.Yes:
                    Xoa_Mail();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        //Add video
        private void btnLogin_Click(object sender, EventArgs e)
        {
            CommentVideo f1 = new CommentVideo();
            //f1.txtMail1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f1.txtPass1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f1.txtRecovery1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f1.ShowDialog();
        }
        //Check login mail
        void CheckMail()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string mail = row.Cells[1].Value.ToString();
                string pass = row.Cells[2].Value.ToString();
                string recovery = row.Cells[3].Value.ToString();
                try
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
                    query.SendKeys(mail + OpenQA.Selenium.Keys.Enter);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                    query = driver.FindElement(By.CssSelector("input[name='password']"));
                    query.SendKeys(pass + OpenQA.Selenium.Keys.Enter);
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
                            reemail.SendKeys(recovery + OpenQA.Selenium.Keys.Enter);
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
                        if (b.Contains(mail))
                        {
                            MessageBox.Show("Mail login thành công!", "Thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không login được Email!", "Lỗi");
                        }
                    }
                    catch (Exception)
                    {

                    }
                    driver.Quit();

                }
                catch (Exception)
                {

                }
            }
        }
        private void btnCheckMail_Click(object sender, EventArgs e)
        {
            ThreadStart check = new ThreadStart(CheckMail);
            Thread check1 = new Thread(check);
            check1.IsBackground = true;
            check1.Start();
        }
        //Sửa Email
        private void btnEditMail_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Comment\\Comment\\MailTool.mdb;Persist Security Info=True;Jet OLEDB:Database Password=1");
            con.Open();
            string query = "UPDATE Mail SET " +
                "Mail = " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "," +
                "Pass = " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "," +
                "Recovery = " + dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + ", " +
                "WHERE ID = '" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";

            OleDbCommand sCommand = new OleDbCommand(query, con);
            // OleDbDataAdapter sAdapter = new OleDbDataAdapter(sCommand);
            //OleDbCommandBuilder sBuilder = new OleDbCommandBuilder(sAdapter);
            //DataSet sDs = new DataSet();
            //sAdapter.Fill(sDs, "Table");
            //DataTable sTable = sDs.Tables["Table"];

            //dataGridView1.DataSource = sTable;
            //dataGridView1.ReadOnly = true;
            con.Close();
        }
        //Tăng đề xuất hình thu nhỏ
        private void btnDeXuat_Click(object sender, EventArgs e)
        {
            TangDeXuat t2 = new TangDeXuat();
            t2.txtMail.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            t2.txtPass.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            t2.txtRecovery.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            t2.ShowDialog();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 2 || e.ColumnIndex == 10) && e.Value != null)
            {
                dataGridView1.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('\u002a', e.Value.ToString().Length);
            }
        }
        //Tìm kiếm video 
        private void btnSearchVideo_Click(object sender, EventArgs e)
        {
            SearchVideo search = new SearchVideo();
            search.txtMail.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            search.txtPass.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            search.txtRecovery.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            search.ShowDialog();
        }
    }
}
