using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNGBackendStageOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        private readonly Information _info;

        public InformationController(Information info)
        {
            _info = info;
        }

        [HttpGet]
        public IActionResult GetInfo(string slackName, string track)
        {
            try
            {
                if (track != _info.Track && slackName != _info.Slack_Name)
                {
                    return BadRequest("Invalid track and / or Slack Name");
                }
               
                

                var response = new
                {
                    _info.Slack_Name,
                    _info.Current_Day,
                    _info.CurrentUTCTime,
                    _info.Track,
                    _info.Github_File_URL,
                    _info.Github_Repo_URL,
                    _info.Status_Code
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
