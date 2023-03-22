namespace DAL.Entitites
{
    public partial class NodesMetadata
    {
        public int NodeId { get; set; }
        public string NodeUrl { get; set; } = null!;
        public string NodeFolder { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
