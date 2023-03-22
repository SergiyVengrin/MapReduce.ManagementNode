using DAL.Entitites;

namespace DAL.Repositories.Interfaces
{
    public interface IMetadataRepository
    {
        List<NodesMetadata> GetActiveNodes();
    }
}
