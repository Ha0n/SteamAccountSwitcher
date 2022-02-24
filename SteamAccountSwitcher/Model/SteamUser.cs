namespace SteamAccountSwitcher
{
    class SteamUser
    {
        public long steamId64 { get; set; }
        public string AccountName { get; set; }
        public string PersonaName { get; set; }
        public bool RememberPassword { get; set; }
        public long Timestamp { get; set; }
    }
}
