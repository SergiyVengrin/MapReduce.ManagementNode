using AutoMapper;
using BLL.Models;
using ManagementNode.Models;

namespace ManagementNode
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<FileDto, FileModel>().ReverseMap();
            CreateMap<FileInfoModel, FileInfoDto>().ReverseMap();
        }
    }
}
