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
        public IActionResult GetInfo(string slack_name, string track)
        {
            try
            {
                if (track != _info.Track && slack_name != _info.SlackName)
                {
                    return BadRequest("Invalid track and / or Slack Name");
                }
               
                

                var response = new
                {
                    _info.SlackName,
                    _info.CurrentDay,
                    _info.CurrentUTCTime,
                    _info.Track,
                    _info.GithubFileURL,
                    _info.GithubRepoURL,
                    _info.StatusCode
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
