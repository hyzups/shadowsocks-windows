using System;

namespace Shadowsocks.Model
{
    /*
     * Format:
     *  <modifiers-combination>+<key>
     *
     */

    [Serializable]
    public class HotkeyConfig
    {
        public Boolean RegisterOnStartup;
        public string SwitchSystemProxy;
        public string SwitchSystemProxyMode;
        public string SwitchAllowLan;
        public string ShowLogs;
        public string ServerMoveUp;
        public string ServerMoveDown;

        public HotkeyConfig()
        {
            RegisterOnStartup = false;
            SwitchSystemProxy = "";
            SwitchSystemProxyMode = "";
            SwitchAllowLan = "";
            ShowLogs = "";
            ServerMoveUp = "";
            ServerMoveDown = "";
        }
    }
}