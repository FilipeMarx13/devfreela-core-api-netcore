using System;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Api.Controllers
{
    [ApiController]
    [Route("/projects")]
    public class ProjectsController : ControllerBase
    {
        public ProjectsController()
        {
        }

        // api/projects?query=net core
        [HttpGet]
        public IActionResult Get(string query)
        {
            //var projects = _projectService.GetAll(query);

            //return Ok(projects);
            return Ok();
        }
    }
}
