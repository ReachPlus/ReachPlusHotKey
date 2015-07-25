/*
Copyright 2015 ReachPlus Alerts

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ReachPlus.SDK.Samples.ReachPlusHotKey
{
    public partial class HotKeySettings : Form
    {
        int registeredId = 0;
       private NotifyIcon notifyIcon = new NotifyIcon();
        public HotKeySettings()
        {
            InitializeComponent();
            for (int counter = 65 ; counter < 65 + 26; counter++)
                comboKey.Items.Add((char)counter);
            List<string> modifiers = new List<string>();
            modifiers.Add("Alt");
            modifiers.Add("Control");
            modifiers.Add("Shift");
            modifiers.Add("Windows");
            comboKey.SelectedIndex = 0;
            comboModifier1.Items.AddRange(modifiers.ToArray());
            comboModifier1.SelectedIndex = 0;
            comboModifier2.Items.AddRange(modifiers.ToArray());
            comboModifier2.SelectedIndex = 2;
            notifyIcon.Text = "RPAS";
            notifyIcon.Icon = new System.Drawing.Icon("logo.ico");
            notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
         
        }

        private void notifyIcon_Click(object sender, System.EventArgs e)
        {
            this.Show();
        }

        private void HotKeyManager_Load(object sender, EventArgs e)
        {
            
        }

         void HotKeyHelper_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            Boolean result = SDKHelper.sendAlert();
            if(result)
                this.notifyIcon.BalloonTipText = "Alert sent";
            else
                this.notifyIcon.BalloonTipText = "Error occured while sending alert";

            this.notifyIcon.ShowBalloonTip(2000);
         
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (registeredId != 0)
                HotKeyHelper.UnregisterHotKey(registeredId);
            KeyModifiers combo1 = (KeyModifiers)Enum.Parse(typeof(KeyModifiers), comboModifier1.Text, true);
            KeyModifiers combo2 = (KeyModifiers)Enum.Parse(typeof(KeyModifiers), comboModifier2.Text, true);
            Keys key = (Keys)Enum.Parse(typeof(Keys), comboKey.Text, true);

            registeredId = HotKeyHelper.RegisterHotKey(key, combo1 | combo2 | KeyModifiers.NoRepeat);
            HotKeyHelper.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyHelper_HotKeyPressed);
            Console.ReadLine();
        }

        private void HotKeySettings_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            }
            
        }
    }
}
