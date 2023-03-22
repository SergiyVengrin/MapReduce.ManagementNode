using BLL.Services.Interfaces;
using DAL.Entitites;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementation
{
    public sealed class MetadataService : IMetadataService
    {
        private readonly IMetadataRepository _metadataRepository;

        public MetadataService(IMetadataRepository metadataRepository)
        {
            _metadataRepository = metadataRepository;
        }

        public List<NodesMetadata> GetActiveNodes()
        {
            return _metadataRepository.GetActiveNodes();
        }
    }
}
