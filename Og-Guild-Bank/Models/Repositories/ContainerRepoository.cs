using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public class ContainerRepoository : IContainerRepository
    {
        private readonly AppDbContext _appDbContext;

        public ContainerRepoository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Container> GetAllContainers()
        {
            return _appDbContext.Containers;
        }

        public Container GetContainerById(int containerId)
        {
            return _appDbContext.Containers.FirstOrDefault(c => c.ContainerId == containerId);
        }
    }
}
