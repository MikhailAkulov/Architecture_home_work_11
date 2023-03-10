using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using ClinicService.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ClinicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationController : ControllerBase
    {
        private IConsultationRepository _consultationRepository;
        public ConsultationController(IConsultationRepository consultationRepository)
        {
            _consultationRepository = consultationRepository;
        }

        [HttpPost("create")]
        [SwaggerOperation(OperationId = "ConsultationCreate")]
        public ActionResult<int> Create([FromBody] CreateConsultationRequest createConsultationRequest)
        {
            int res = _consultationRepository.Create(new Consultation
            {
                ClientId = createConsultationRequest.ClientId,
                PetId = createConsultationRequest.PetId,
                ConsultationDate = createConsultationRequest.ConsultationDate,
                Description = createConsultationRequest.Description,
            });
            return Ok(res);
        }

        [HttpPut("update")]
        [SwaggerOperation(OperationId = "ConsultationUpdate")]
        public ActionResult<int> Update([FromBody] UpdateConsultationRequest updateConsultationRequest)
        {
            int res = _consultationRepository.Update(new Consultation
            {
                ConsultationId = updateConsultationRequest.ConsultationId,
                ClientId = updateConsultationRequest.ClientId,
                PetId = updateConsultationRequest.PetId,
                ConsultationDate = updateConsultationRequest.ConsultationDate,
                Description = updateConsultationRequest.Description,
            });
            return Ok(res);
        }

        [HttpDelete("delete")]
        [SwaggerOperation(OperationId = "ConsultationDelete")]
        public ActionResult<int> Delete(int consultationId)
        {
            int res = _consultationRepository.Delete(consultationId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        [SwaggerOperation(OperationId = "ConsultationGetAll")]
        public ActionResult<List<Consultation>> GetAll()
        {
            return Ok(_consultationRepository.GetAll());
        }

        [HttpGet("get-by-id")]
        [SwaggerOperation(OperationId = "ConsultationGetById")]
        public ActionResult<Consultation> GetById(int consultationId)
        {
            return Ok(_consultationRepository.GetById(consultationId));
        }
    }
}