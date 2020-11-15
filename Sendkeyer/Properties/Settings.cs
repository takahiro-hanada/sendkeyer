using System;
using System.Collections.Generic;
using System.Configuration;

namespace Sendkeyer.Properties
{
    sealed partial class Settings
    {
        public Settings()
        {
            Apps = Apps ?? new string[0];

            Lines = Lines ?? new string[0];

            SettingsLoaded += (sender, e) =>
            {
                if (!Upgraded)
                {
                    Upgrade();
                    Upgraded = true;
                }
            };
        }

        [UserScopedSetting()]
        public string[] Apps
        {
            get { return ((string[])(this["Apps"])); }
            set { this["Apps"] = value; }
        }

        [UserScopedSetting()]
        public string[] Lines
        {
            get { return ((string[])(this["Lines"])); }
            set { this["Lines"] = value; }
        }
    }
}
