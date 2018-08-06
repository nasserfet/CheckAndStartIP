using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        enum program_status
        {
            started,
            stoped
        }
        Bussiness _Bussiness = new Bussiness();
        static System.Timers.Timer t;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        TimeSpan _startTimeSpan;
        TimeSpan _periodTimeSpan;
        System.Threading.Timer _timer;

        public Form1()
        {
            InitializeComponent();

            openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog.DefaultExt = "1";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                label_selectedFile.Text = openFileDialog.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeProgram();
        }
        public void InitializeProgram()
        {
            try
            {
                label_status.Text = program_status.stoped.ToString();
                _Bussiness.ReadSetting(out SettingModel settingModel);
                textBox_IP.Text = settingModel.ip;
                textBox_proxy.Text = settingModel.proxy;
                label_selectedFile.Text = settingModel.file_path;
                textBox_argument.Text = settingModel.start_argument;
                textBox_interval.Text = settingModel.interval.ToString();
                checkBox_proxy.Checked = settingModel.proxy_enable;
                checkBox_network_connection_toggle.Checked = settingModel.network_toggle_enabled;
                textBox_network_connection_toggle_interval.Text = settingModel.network_interval;
                textBox_network_connection_toggle_name.Text = settingModel.network_name;
                txt_closeFile.Text = settingModel.file_closing_path;
                ToggleNetowrkStatus(textBox_network_connection_toggle_name.Text);
            }
            catch (Exception ex)
            {
                InsertIntoTextBox("exception : " + ex.StackTrace + "////////////////" + ex.Message);
            }
        }
        public void ToggleNetowrkStatus(string networkName)
        {
            try
            {
                _startTimeSpan = TimeSpan.Zero;
                _periodTimeSpan = TimeSpan.FromSeconds(double.Parse(textBox_network_connection_toggle_interval.Text));

                _timer = new System.Threading.Timer((e) =>
                {
                    if ((checkBox_network_connection_toggle.Checked) && (label_status.Text == program_status.started.ToString()))
                    {
                        bool status = _Bussiness.ToggleNetworkStatus(networkName, Bussiness.Status.Disable);
                        if (status)
                        {
                            InsertIntoTextBox("successfully : "+networkName + " network disabled at " + DateTime.Now);
                        }
                        else {
                            InsertIntoTextBox("failed : " + networkName + " network disabling at " + DateTime.Now);
                        }
                        System.Threading.Thread.Sleep(1500);
                        status = _Bussiness.ToggleNetworkStatus(networkName, Bussiness.Status.Enable);
                        if (status)
                        {
                            InsertIntoTextBox("successfully : " + networkName + " network enabled at " + DateTime.Now);
                        }
                        else
                        {
                            InsertIntoTextBox("failed : " + networkName + " network enabling at " + DateTime.Now);
                        }
                    }
                }, null, _startTimeSpan, _periodTimeSpan);
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                SettingModel settingModel = new SettingModel();
                settingModel.file_path = label_selectedFile.Text;
                settingModel.ip = textBox_IP.Text;
                settingModel.proxy = textBox_proxy.Text;
                settingModel.start_argument = textBox_argument.Text;
                settingModel.interval = double.Parse(textBox_interval.Text);
                settingModel.proxy_enable = checkBox_proxy.Checked;
                settingModel.network_interval = textBox_network_connection_toggle_interval.Text;
                settingModel.network_name = textBox_network_connection_toggle_name.Text;
                settingModel.network_toggle_enabled = checkBox_network_connection_toggle.Checked;
                settingModel.file_closing_path = txt_closeFile.Text;
                // Pass "SettingModel" object for conversion object to JSON string
                string json = new JavaScriptSerializer().Serialize(settingModel);

                // Write that JSON to txt file
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Assets\\setting.txt", json);
                MessageBox.Show("setting saved !");
            }
            catch (Exception ex)
            {
                InsertIntoTextBox("exception : " + ex.StackTrace + "////////////////" + ex.Message);
                MessageBox.Show("setting not saved ! ", ex.Message);
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            t_Elapsed(sender, null);
            if (label_status.Text == program_status.started.ToString())
            {
                label_status.Text = program_status.stoped.ToString();
                t.Stop();
            }
            else
            {
                label_status.Text = program_status.started.ToString();

                t = new System.Timers.Timer(double.Parse(textBox_interval.Text));
                t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);
                t.Start();
            }
        }

        void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                string proxy = checkBox_proxy.Checked ? textBox_proxy.Text : null;
                bool IsIpOk = _Bussiness.IsIpOk(textBox_IP.Text, proxy);
                InsertIntoTextBox("program status : " + IsIpOk);

                if (!IsIpOk)
                {
                    //kill program
                    TerminateProcess(Path.GetFileNameWithoutExtension(label_selectedFile.Text));
                    TerminateProcess(Path.GetFileNameWithoutExtension(txt_closeFile.Text));

                    //start program
                    string fullPath = '"' + label_selectedFile.Text + '"';
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = fullPath;
                    startInfo.WorkingDirectory = fullPath;
                    startInfo.Arguments = textBox_argument.Text;
                    Process.Start(startInfo);
                    InsertIntoTextBox("process " + startInfo.FileName + " started ");
                }
            }
            catch (Exception ex)
            {
                InsertIntoTextBox("exception : " + ex.StackTrace + "////////////////" + ex.Message);
            }
        }
        void TerminateProcess(string pathName) {
            //kill program
            Process[] _proceses = null;
            _proceses = Process.GetProcessesByName(pathName);
            foreach (Process proces in _proceses)
            {
                proces.Kill();
                InsertIntoTextBox("process " + proces.ProcessName + " id " + proces.Id + " killed ");
            }
        }
        void InsertIntoTextBox(string message)
        {
            if (richTextBox_status.InvokeRequired == true)
            {
                richTextBox_status.Invoke((MethodInvoker)delegate
                {
                    richTextBox_status.Text = richTextBox_status.Text.Insert(0, DateTime.Now.ToString() + "  :   " + Environment.NewLine + message + Environment.NewLine);
                });
            }

            else
            {
                richTextBox_status.Text = richTextBox_status.Text.Insert(0, DateTime.Now.ToString() + "  :   " + Environment.NewLine + message + Environment.NewLine);
            }
        }
    
        private void button_clean_Click(object sender, EventArgs e)
        {
            richTextBox_status.Clear();
        }

        private void button_browse_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txt_closeFile.Text = openFileDialog.FileName;
            }
        }
    }

    class Bussiness
    {
        public enum Status
        {
            Enable
                , Disable
        }
        public void ReadSetting(out SettingModel settingModel)
        {
            try
            {
                settingModel = new SettingModel();
                string settingPath = AppDomain.CurrentDomain.BaseDirectory + "\\Assets\\setting.txt";
                string json_setting = File.ReadAllText(settingPath);
                JavaScriptSerializer oJS = new JavaScriptSerializer();
                SettingModel oRootObject = new SettingModel();
                oRootObject = oJS.Deserialize<SettingModel>(json_setting);

                settingModel.ip = oRootObject.ip;
                settingModel.proxy = oRootObject.proxy;
                settingModel.file_path = oRootObject.file_path;
                settingModel.start_argument = oRootObject.start_argument;
                settingModel.interval = oRootObject.interval;
                settingModel.proxy_enable = oRootObject.proxy_enable;
                settingModel.network_interval = oRootObject.network_interval;
                settingModel.network_name = oRootObject.network_name;
                settingModel.network_toggle_enabled = oRootObject.network_toggle_enabled;
                settingModel.file_closing_path = oRootObject.file_closing_path;
            }
            catch (Exception ex) { throw ex; }
        }
        private string GetIp(string proxyUri, string url = "https://api.ipify.org")
        {
            try
            {
                HttpClient httpClient;
                if (!string.IsNullOrEmpty(proxyUri))
                {
                    WebProxy proxy = new WebProxy(proxyUri, false)
                    {
                        UseDefaultCredentials = true,
                    };

                    HttpClientHandler httpClientHandler = new HttpClientHandler()
                    {
                        Proxy = proxy,
                        PreAuthenticate = false,
                        UseDefaultCredentials = true,
                    };
                    httpClient = new HttpClient(httpClientHandler);
                }
                else
                {
                    httpClient = new HttpClient();
                }
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
                return responseBody;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool IsIpOk(string ip, string proxy)
        {
            try
            {
                string returnedIp = GetIp(proxy);
                if (returnedIp == ip)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public bool ToggleNetworkStatus(string interfaceName, Status status)
        {
            bool result = false;
            if (Status.Enable == status)
            {
                System.Diagnostics.ProcessStartInfo psi =
                       new System.Diagnostics.ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" enable");
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo = psi;
                result = p.Start();
            }

            else
            {
                System.Diagnostics.ProcessStartInfo psi =
                    new System.Diagnostics.ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" disable");
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo = psi;
                result = p.Start();
            }
            return result;
        }
    }
    class SettingModel
    {
        public string ip { get; set; }
        public string proxy { get; set; }
        public string file_path { get; set; }
        public string start_argument { get; set; }
        public double interval { set; get; }
        public bool proxy_enable { set; get; }
        public string network_name { set; get; }
        public string network_interval { set; get; }
        public bool network_toggle_enabled { set; get; }
        public string file_closing_path { get; set; }
    }
}
