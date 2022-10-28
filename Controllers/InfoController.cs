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
    [Route("Info")]
    public class InfoController : ControllerBase {
        
        private IInfoBuilder _builder;
        
        public InfoController(IInfoBuilder builder) {
            _builder = builder;
        }
        
        [HttpGet("")]
        public async Task<ActionResult> GetInfoes() {

            return Ok(await _builder.GetInfoes());
        }
        
        [HttpGet("Display")]
        public async Task<ActionResult> GetDisplayModels() {
            //List all model properties that should be displayed
            //Here only a couple have been added as an example
            var propNames = new List<string>();
            propNames.Add(nameof(InfoModel.Id));
            propNames.Add(nameof(InfoModel.Type));

            return Ok(await Task.FromResult(_builder.GetDisplayModels(propNames)));
        }
        
        [HttpGet("Paged")]
        public async Task<ActionResult> Paged(int pageIndex, int pageSize) {

            var models = await _builder.GetInfoes();

            return Ok(models.ToPagedList(pageIndex, pageSize, 0, models.Count()));
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult> GetInfo_ById(int id) {

             var response = await _builder.GetInfo_ById(id);
            if (response.ValidationMessage != null) {
                return BadRequest(response.ValidationMessage);
            }

            return Ok(response.Model);
        }
        
        [HttpPost("")]
        [ModelStateValidation()]
        public async Task<ActionResult> AddInfo([FromBody]InfoModel model) {

            var response = await _builder.AddInfo(model);

            if (response.ValidationMessage != null) {
                return BadRequest(response.ValidationMessage);
            }

            return CreatedAtAction("GetInfo_ById", new {id = ((InfoModel)response.Model).Id}, response.Model);
        }
        
        [HttpPut("")]
        [ModelStateValidation()]
        public async Task<ActionResult> UpdateInfo([FromBody]InfoModel model) {
            var response = await _builder.UpdateInfo(model);

            if (response.ValidationMessage != null) {
                return BadRequest(response.ValidationMessage);
            }

            return AcceptedAtAction("GetInfo_ById", new {id = model.Id}, model);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteInfo(int id) {

            var response = await _builder.DeleteInfo(id);

            if (response.ValidationMessage != null) {
                return BadRequest(response.ValidationMessage);
            }

            return StatusCode(response.StatusCode);
        }
    }
}

