using Microsoft.EntityFrameworkCore;
using Models;
using Repositories;
using Repositories.Contracts;

namespace Question1.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly RepositoryContext _context;

    public ProjectRepository(RepositoryContext context)
    {
        _context = context;
    }

    public Project? GetOneProject(int id)
    {
        return _context
            .Projects
            .AsNoTracking()
            .SingleOrDefault(p => p.ProjectId.Equals(id));
    }

    public Project? UpdateOneProject(int id, Project project)
    {
      var prj= _context.Projects.Where(p => p.ProjectId.Equals(id));
    }
}