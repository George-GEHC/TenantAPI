// ----------------------------------------------------------------------------------
// <copyright company="Exesoft Inc.">
//	This code was generated by Instant Web API code automation software (https://www.InstantWebAPI.com)
//	Copyright Exesoft Inc. © 2019.  All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------------

using InstantHelper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using TenantAPI.Models;
using TenantAPI.Services;

namespace TenantAPI.Controllers {
    
    
    // TODO: Uncomment the following line to use an API Key; change the value of the key in appSetting (X-API-Key)
    // [ApiKey()]
    [Route("AddressType")]
    public class AddressTypeController : ControllerBase {
        
        private IAddressTypeBuilder _builder;
        
        public AddressTypeController(IAddressTypeBuilder builder) {
            _builder = builder;
        }
        
        [HttpGet("")]
        public async Task<ActionResult> GetAddressTypes() {

            return Ok(await _builder.GetAddressTypes());
        }
        
        [HttpGet("Display")]
        public async Task<ActionResult> GetDisplayModels() {
            //List all model properties that should be displayed
            //Here only a couple have been added as an example
            var propNames = new List<string>();
            propNames.Add(nameof(AddressTypeModel.Id));
            propNames.Add(nameof(AddressTypeModel.Type));

            return Ok(await Task.FromResult(_builder.GetDisplayModels(propNames)));
        }
        
        [HttpGet("Paged")]
        public async Task<ActionResult> Paged(int pageIndex, int pageSize) {

            var models = await _builder.GetAddressTypes();

            return Ok(models.ToPagedList(pageIndex, pageSize, 0, models.Count()));
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAddressType_ById(int id) {

             var response = await _builder.GetAddressType_ById(id);
            if (response.ValidationMessage != null) {
                return BadRequest(response.ValidationMessage);
            }

            return Ok(response.Model);
        }
        
        [HttpPost("")]
        [ModelStateValidation()]
        public async Task<ActionResult> AddAddressType([FromBody]AddressTypeModel model) {

            var response = await _builder.AddAddressType(model);

            if (response.ValidationMessage != null) {
                return BadRequest(response.ValidationMessage);
            }

            return CreatedAtAction("GetAddressType_ById", new {id = ((AddressTypeModel)response.Model).Id}, response.Model);
        }
        
        [HttpPut("")]
        [ModelStateValidation()]
        public async Task<ActionResult> UpdateAddressType([FromBody]AddressTypeModel model) {
            var response = await _builder.UpdateAddressType(model);

            if (response.ValidationMessage != null) {
                return BadRequest(response.ValidationMessage);
            }

            return AcceptedAtAction("GetAddressType_ById", new {id = model.Id}, model);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAddressType(int id) {

            var response = await _builder.DeleteAddressType(id);

            if (response.ValidationMessage != null) {
                return BadRequest(response.ValidationMessage);
            }

            return StatusCode(response.StatusCode);
        }
    }
}

