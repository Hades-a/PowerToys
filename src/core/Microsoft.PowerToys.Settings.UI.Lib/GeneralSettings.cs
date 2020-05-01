﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Lib
{
    public class GeneralSettings
    {
        // Gets or sets a value indicating whether packaged.
        [JsonPropertyName("packaged")]
        public bool Packaged { get; set; }

        // Gets or sets a value indicating whether run powertoys on start-up.
        [JsonPropertyName("startup")]
        public bool Startup { get; set; }

        // Gets or sets a value indicating whether the powertoy elevated.
        [JsonPropertyName("is_elevated")]
        public bool IsElevated { get; set; }

        // Gets or sets a value indicating whether powertoys should run elevated.
        [JsonPropertyName("run_elevated")]
        public bool RunElevated { get; set; }

        // Gets or sets a value indicating whether is admin.
        [JsonPropertyName("is_admin")]
        public bool IsAdmin { get; set; }

        // Gets or sets theme Name.
        [JsonPropertyName("theme")]
        public string Theme { get; set; }

        // Gets or sets system theme name.
        [JsonPropertyName("system_theme")]
        public string SystemTheme { get; set; }

        // Gets or sets powertoys version number.
        [JsonPropertyName("powertoys_version")]
        public string PowertoysVersion { get; set; }

        [JsonPropertyName("enabled")]
        public EnabledModules Enabled { get; set; }

        public GeneralSettings()
        {
            this.Packaged = false;
            this.Startup = false;
            this.IsAdmin = false;
            this.IsElevated = false;
            this.Theme = "system";
            this.SystemTheme = "light";
            this.PowertoysVersion = interop.CommonManaged.GetProductVersion();
            this.Enabled = new EnabledModules();
        }

        // converts the current to a json string.
        public string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
