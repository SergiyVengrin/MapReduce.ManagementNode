using DAL.Entitites;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementation
{
    public sealed class MetadataRepository : IMetadataRepository
    {
        private readonly MapReduceDBContext _dbContext;
        private const string SpGetActiveNodes = "sp_getActiveNodes";

        public MetadataRepository(MapReduceDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<NodesMetadata> GetActiveNodes()
        {
            var nodes = _dbContext.NodesMetadata.FromSqlRaw($"EXEC {SpGetActiveNodes}").ToList();

            return nodes;
        }
    }
}
