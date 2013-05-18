using Microsoft.VisualStudio.Shell;
using System;
using System.ComponentModel;

namespace LigerShark.Farticus
{
    class FartOptions : DialogPage
    {
        private bool _enabled = true;
        private Farts _errorFart = Farts.HighPressure;
        private bool _hasLoaded = false;

        [LocDisplayName("On build error")]
        [Description("Select which fart to play when the build has errors")]
        [Category("Farticus")]
        public Farts SelectedErrorFart
        {
            get { return _errorFart; }
            set
            {
                _errorFart = value;

                if (_hasLoaded)
                    FartPlayer.PlayFart(value);
            }
        }

        [LocDisplayName("Enable auto-farts")]
        [Description("When enabled, farts are played when the build fails or has warnings")]
        [Category("Farticus")]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        public override void LoadSettingsFromStorage()
        {
            try
            {
                base.LoadSettingsFromStorage();
            }
            catch (FormatException)
            {
                // If the enum changes, the settings will display an error unless we fix the enum values.
                SelectedErrorFart = _errorFart;
            }

            _hasLoaded = true;
        }
    }
}