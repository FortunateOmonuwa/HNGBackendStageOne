namespace HNGBackendStageOne
{
    public class Information
    {
        public string Slack_Name { get; set; } = "Fortunate Omonuwa";
        public string Track { get; set; } = "Backend";
        public DayOfWeek Current_Day { get; set; } = DateTime.UtcNow.DayOfWeek;
        public DateTime CurrentUTCTime { get; set; } = DateTime.UtcNow;
        public string Github_File_URL { get; set; } = "";
        public string Github_Repo_URL { get; set; } = "";
        public int Status_Code { get; set; } = 200;
    }
}
