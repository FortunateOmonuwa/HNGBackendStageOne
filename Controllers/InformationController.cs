using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNGBackendStageOne.Controllers
{
    [Route("api")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        private readonly Information _info;

        public InformationController(Information info)
        {
            _info = info;
        }

        [HttpGet]
        public IActionResult GetInfo(string slack_name, string track)
        {
            try
            {
                if (track != _info.Track && slack_name != _info.Slack_name)
                {
                    return BadRequest("Invalid track and / or Slack Name");
                }
               
                

                var response = new
                {
                    _info.Slack_name,
                    _info.Current_day,
                    _info.Utc_time,
                    _info.Track,
                    _info.Github_file_url,
                    _info.Github_repo_url,
                    _info.Status_code
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
