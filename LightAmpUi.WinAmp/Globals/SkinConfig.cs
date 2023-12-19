/*
 * Copyright(c) 2023 GiR-Zippo
 * Licensed under the GPL v3 license. See https://github.com/GiR-Zippo/LightAmp/blob/main/LICENSE for full license information.
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using BardMusicPlayer.Pigeonhole;

namespace Skin.Ui.Globals
{
    public static class SkinConfig
    {
        public static Dictionary<string, string> ConfigValues = new Dictionary<string, string>();

        public static string GetValue(string var)
        {
            if (ConfigValues.ContainsKey(var))
                return ConfigValues[var];
            return "";
        }

        public static bool GetBoolValue(string var)
        {
            if (ConfigValues.ContainsKey(var))
                return Convert.ToBoolean(ConfigValues[var]);
            return false;
        }

        public static string SkinPath = Path.GetDirectoryName(BmpPigeonhole.Instance.LastSkin);

        public static void SetValue(string var, string value)
        {
            if (ConfigValues.ContainsKey(var))
                ConfigValues[var] = value;
            else
                ConfigValues.Add(var, value);
            SaveConfig();
        }

        public static void ReadConfig()
        {
            if (!File.Exists(SkinPath+"\\Config.json"))
                return;
            string json = File.ReadAllText(SkinPath + "\\Config.json");
            ConfigValues = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        public static void SaveConfig()
        {
            String json = JsonConvert.SerializeObject(ConfigValues, Formatting.Indented);
            File.WriteAllText(SkinPath + "\\Config.json", json);
        }


    }
}
