using AutoMapper;
using BLL.Models;
using BLL.Services.Interfaces;
using DAL.Entitites;
using ManagementNode.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManagementNode.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NodesController : ControllerBase
    {
        private readonly IMetadataService _metadataService;
        private readonly IManagementService _managementService;
        private readonly IMapper _mapper;

        public NodesController(IMetadataService metadataService, IManagementService managementService, IMapper mapper)
        {
            _metadataService = metadataService;
            _managementService = managementService;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<IActionResult> SaveFile(FileDto file)
        {
            try
            {
                await _managementService.SendFileToNodes(_mapper.Map<FileModel>(file));
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public List<NodesMetadata> GetActiveNodes()
        {
            return _metadataService.GetActiveNodes();
        }

    }
}
