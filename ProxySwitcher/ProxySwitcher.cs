namespace ProxySwitcher
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Core;

    public partial class ProxySwitcher : Form
    {
        private bool proxyEnabled;
        private string proxyConnectionString;
        private bool userProxyPreference;
        private Timer timer;
        private ProxySwitch proxySwitch;
        private int timerTicks;
        private int policyChanged;

        public ProxySwitcher()
        {
            InitializeComponent();

            this.GetStatus();
            this.SetInitialUserPreference();
            this.InitTimer();
            this.RefreshPolicyNumber();
        }

        public void GetStatus()
        {
            var proxySwitch = new ProxySwitch();

            this.proxyEnabled = proxySwitch.CheckStatus();
            this.proxyConnectionString = proxySwitch.CheckProxyConnectionString();
                        
            this.SetDisplay();          
        }

        private void SetInitialUserPreference()
        {
            this.userProxyPreference = this.proxyEnabled;
        }

        private void InitTimer()
        {
            this.timer = new Timer();
            this.timer.Tick += Timer_Tick;
            this.timer.Interval = 5000;
            this.timer.Start();

            this.timerTicks = 1;
            this.RefreshTimer();            
        }

        private void RefreshTimer()
        {
            this.lblTimerTick.Text = "Timer Ticks: " + this.timerTicks;
        }

        private void RefreshPolicyNumber()
        {
            this.lblPolicyChangeTimes.Text = "Policy Changed: " + this.policyChanged;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.GetStatus();

            if (this.proxyEnabled != this.userProxyPreference)
            {
                if (this.userProxyPreference)
                {
                    this.proxySwitch.SwitchOn();
                }
                else
                {
                    this.proxySwitch.SwitchOff();
                }

                this.policyChanged++;
            }

            this.GetStatus();

            this.timerTicks++;
            this.RefreshTimer();
            this.RefreshPolicyNumber();
        }

        private void SetDisplay()
        {
            if (proxyEnabled == false)
            {
                this.lblStatus.Text = "Proxy Off";
                this.btnSwitch.Text = "Turn On";
                this.lblStatus.ForeColor = Color.Red;
            }
            else
            {
                this.lblStatus.Text = "Proxy On";
                this.btnSwitch.Text = "Turn Off";
                this.lblStatus.ForeColor = Color.Green;                          
            }

            this.lblProxyName.Text = proxyConnectionString;
        }

        private void SwitchProxy()
        {
            if (this.proxySwitch == null)
            {
                this.proxySwitch = new ProxySwitch();
            }

            this.GetStatus();

            if (this.proxyEnabled == true)
            {
                proxySwitch.SwitchOff();
                this.userProxyPreference = false;
            }
            else
            {
                proxySwitch.SwitchOn();
                this.userProxyPreference = true;
            }

            this.GetStatus();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            this.SwitchProxy();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.GetStatus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
