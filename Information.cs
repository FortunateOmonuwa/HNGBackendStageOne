using System.Text.Json.Serialization;

namespace HNGBackendStageOne
{
    public class Information
    {
        public string Slack_name { get; set; } = "Fortunate_Omonuwa";
        public string Track { get; set; } = "backend";
        public string Current_day { get; set; } = DateTime.UtcNow.DayOfWeek.ToString();
        public string Utc_time { get; set; } = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
        public string Github_file_url { get; set; } = "https://github.com/FortunateOmonuwa/HNGBackendStageOne/blob/main/build/HNGBackendStageOne.exe";
        public string Github_repo_url { get; set; } = "https://github.com/FortunateOmonuwa/HNGBackendStageOne";
        public int Status_code { get; set; } = 200;
    }
}
