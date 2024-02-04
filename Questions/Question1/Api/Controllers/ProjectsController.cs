using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace Controllers;

[ApiController]
[Route("api/projects")]
public class ProjectsController : ControllerBase
{
    public ProjectRepository _projectRepository;
    public ProjectsController()
    {
        _projectRepository = new ProjectRepository();
    }

    // Tüm projelerin listesini döner.
    [HttpGet("/")]
    public IActionResult GetAllProjects()
    {
        
        return Ok(_projectRepository.Projects);
    }

    // Sadece bu ACTION cevap kağına geçirilmelidir. 
    [HttpGet("/{budget}")]
    public IActionResult GetFilteredProject(decimal budget)
    {
        if (budget<=0)
        {
            return BadRequest();
        }
        var filteredProjects = _projectRepository.Projects.Where(x => x.Budget < budget);

        return Ok(filteredProjects);
    }
}




