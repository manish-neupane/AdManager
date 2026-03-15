using AdManager.API.Controllers.Shared;
using AdManager.Interface.Application.Inventory;
using AdManager.Model.Application.Inventory;
using AdManager.Model.Shared;
using Microsoft.AspNetCore.Mvc;

namespace AdManager.API.Controllers.Application.Inventory
{
    public class ScreenController(IScreenService ss) : SharedController
    {
        [HttpGet]
        public async Task<IActionResult> GetScreenGrid([FromQuery] MvParamReqOption<MvScreenGridFilter> param)
        {
            try
            {
                var response = await ss.GetScreenGrid(param);
                return Ok(ApiResult.Success(response));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResult.Fail(ex.Message));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetScreenList([FromQuery] MvScreenSearchFilter param)
        {
            try
            {
                var response = await ss.GetScreenList(param);
                return Ok(ApiResult.Success(response));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResult.Fail(ex.Message));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetScreenDropdown()
        {
            try
            {
                var response = await ss.GetScreenDropdown();
                return Ok(ApiResult.Success(response));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResult.Fail(ex.Message));
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostScreen([FromBody] MvPostScreen param)
        {
            try
            {
                var response = await ss.PostScreen(param);
                return Ok(ApiResult.Success(response));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResult.Fail(ex.Message));
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutScreen([FromBody] MvPutScreen param)
        {
            try
            {
                var response = await ss.PutScreen(param);
                return Ok(ApiResult.Success(response));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResult.Fail(ex.Message));
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteScreen([FromBody] MvDeleteScreen param)
        {
            try
            {
                var response = await ss.DeleteScreen(param);
                return Ok(ApiResult.Success(response));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResult.Fail(ex.Message));
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostUpsertScreen([FromBody] MvUpsertScreen param)
        {
            try
            {
                var response = await ss.PostUpsertScreen(param);
                return Ok(ApiResult.Success(response));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResult.Fail(ex.Message));
            }
        }
    }
}
