using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ClinicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private IPetRepository _petRepository;
        public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpPost("create")]
        [SwaggerOperation(OperationId = "PetCreate")]
        public ActionResult<int> Create([FromBody] CreatePetRequest createPetRequest)
        {
            int res = _petRepository.Create(new Pet
            {
                ClientId = createPetRequest.ClientId,
                Name = createPetRequest.Name,
                Birthday = createPetRequest.Birthday,
            });
            return Ok(res);
        }

        [HttpPut("update")]
        [SwaggerOperation(OperationId = "PetUpdate")]
        public ActionResult<int> Update([FromBody] UpdatePetRequest updatePetRequest)
        {
            int res = _petRepository.Update(new Pet
            {
                PetId = updatePetRequest.PetId,
                ClientId = updatePetRequest.ClientId,
                Name = updatePetRequest.Name,
                Birthday = updatePetRequest.Birthday,
            });
            return Ok(res);
        }

        [HttpDelete("delete")]
        [SwaggerOperation(OperationId = "PetDelete")]
        public ActionResult<int> Delete(int petId)
        {
            int res = _petRepository.Delete(petId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        [SwaggerOperation(OperationId = "PetGetAll")]
        public ActionResult<List<Pet>> GetAll()
        {
            return Ok(_petRepository.GetAll());
        }

        [HttpGet("get-by-id")]
        [SwaggerOperation(OperationId = "PetGetById")]
        public ActionResult<Pet> GetById(int petId)
        {
            return Ok(_petRepository.GetById(petId));
        }
    }
}