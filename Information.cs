using System.Text.Json.Serialization;

namespace HNGBackendStageOne
{
    public class Information
    {
        [JsonPropertyName("slack_name")]
        public string SlackName { get; set; } = "Fortunate_Omonuwa";
        public string Track { get; set; } = "Backend";
        [JsonPropertyName("current_day")]
        public string CurrentDay { get; set; } = DateTime.UtcNow.DayOfWeek.ToString();
        [JsonPropertyName("utc_time")]
        public DateTime CurrentUTCTime { get; set; } = DateTime.UtcNow;
        [JsonPropertyName("github_file_url")]
        public string GithubFileURL { get; set; } = "https://github.com/FortunateOmonuwa/HNGBackendStageOne/blob/main/build/HNGBackendStageOne.exe";
        [JsonPropertyName("github_repo_url")]
        public string GithubRepoURL { get; set; } = "https://github.com/FortunateOmonuwa/HNGBackendStageOne";
        [JsonPropertyName("status_code")]
        public int StatusCode { get; set; } = 200;
    }
}
