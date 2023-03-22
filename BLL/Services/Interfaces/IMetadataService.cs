using DAL.Entitites;

namespace BLL.Services.Interfaces
{
    public interface IMetadataService
    {
        List<NodesMetadata> GetActiveNodes();
    }
}
