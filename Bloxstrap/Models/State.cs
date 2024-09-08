namespace Bloxstrap.Models
{
    public class State
    {
        public bool ShowFFlagEditorWarning { get; set; } = true;
        
        public bool PromptWebView2Install { get; set; } = true;

        public AppState Player { get; set; } = new();
        
        public AppState Studio { get; set; } = new();

        [Obsolete("Use PlayerModManifest/StudioModManifest instead", true)]
        public List<string> ModManifest { set { PlayerModManifest = value; } }
        public List<string> PlayerModManifest { get; set; } = new();
        public List<string> StudioModManifest { get; set; } = new();
    }
}
