namespace Bloxstrap.Models.Persistable
{
    public class State
    {
        public bool ShowFFlagEditorWarning { get; set; } = true;

        public bool PromptWebView2Install { get; set; } = true;

        public bool ForceReinstall { get; set; } = false;

        public WindowState SettingsWindow { get; set; } = new();

        #region Deprecated properties
        /// <summary>
        /// Deprecated, use App.RobloxState.Player
        /// </summary>
        public AppState? Player { private get; set; }
        public AppState? GetDeprecatedPlayer() => Player;

        /// <summary>
        /// Deprecated, use App.RobloxState.Studio
        /// </summary>
        public AppState? Studio { private get; set; }
        public AppState? GetDeprecatedStudio() => Studio;

        /// <summary>
        /// Deprecated, use App.RobloxState.PlayerModManifest
        /// </summary>
        public List<string>? PlayerModManifest { private get; set; }
        public List<string>? GetDeprecatedPlayerModManifest() => PlayerModManifest;

        /// <summary>
        /// Deprecated, use App.RobloxState.StudioModManifest
        /// </summary>
        public List<string>? StudioModManifest { private get; set; }
        public List<string>? GetDeprecatedStudioModManifest() => StudioModManifest;
        #endregion
    }
}
