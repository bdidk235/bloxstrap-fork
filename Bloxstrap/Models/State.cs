namespace Bloxstrap.Models
{
    public class State
    {
        public string LastEnrolledChannel { get; set; } = "";

        [Obsolete("Use PlayerVersionGuid instead", true)]
        public string VersionGuid { set { PlayerVersionGuid = value; } }
        public string PlayerVersionGuid { get; set; } = "";
        public string StudioVersionGuid { get; set; } = "";

        public int PlayerSize { get; set; } = 0;
        public int StudioSize { get; set; } = 0;

        [Obsolete("Use PlayerModManifest/StudioModManifest instead", true)]
        public List<string> ModManifest { set { PlayerModManifest = value; } }
        public List<string> PlayerModManifest { get; set; } = new();
        public List<string> StudioModManifest { get; set; } = new();
    }
}
