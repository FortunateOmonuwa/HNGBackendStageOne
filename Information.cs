using System.Text.Json.Serialization;

namespace HNGBackendStageOne
{
    public class Information
    {
        public string Slack_Name { get; set; } = "Fortunate_Omonuwa";
        public string Track { get; set; } = "Backend";
        public string Current_Day { get; set; } = DateTime.UtcNow.DayOfWeek.ToString();
        public DateTime Current_UTC_Time { get; set; } = DateTime.UtcNow;
        public string Github_File_URL { get; set; } = "https://github.com/FortunateOmonuwa/HNGBackendStageOne/blob/main/build/HNGBackendStageOne.exe";
        public string Github_Repo_URL { get; set; } = "https://github.com/FortunateOmonuwa/HNGBackendStageOne";
        public int Status_Code { get; set; } = 200;
    }
}
