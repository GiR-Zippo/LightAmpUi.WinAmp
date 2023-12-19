/*
 * Copyright(c) 2023 GiR-Zippo
 * Licensed under the GPL v3 license. See https://github.com/GiR-Zippo/LightAmp/blob/main/LICENSE for full license information.
 */

using System;
using System.Windows;
using Skin.Ui.Globals.SkinContainer;

namespace Skin.Ui
{
    /// <summary>
    /// does nothing, but looks fancy
    /// </summary>
    public partial class Skin_MainView_Ex : Window
    {
        public Skin_MainView_Ex()
        {
            InitializeComponent();
            SkinContainer.OnNewSkinLoaded += SkinContainer_OnNewSkinLoaded;
            SkinContainer_OnNewSkinLoaded(null, null);
        }

        private void SkinContainer_OnNewSkinLoaded(object sender, EventArgs e)
        {
            this.Background = SkinContainer.EQUALIZER[0]; //Temp
        }
    }
}
