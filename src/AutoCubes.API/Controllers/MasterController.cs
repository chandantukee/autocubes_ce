using AutoCubes.Application.Commands.Countries.Create;
using AutoCubes.Application.Commands.Countries.Delete;
using AutoCubes.Application.Commands.Countries.Update;
using AutoCubes.Application.DTOs;
using AutoCubes.Application.Queries.GetCountries;
using AutoCubes.Shared.Api;
using AutoCubes.Shared.Commands;
using AutoCubes.Shared.Queries;
using Microsoft.AspNetCore.Mvc;

namespace AutoCubes.API.Controllers
{
    [Route("api/master")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly ICommandDispatcher _commandDispatcher;

        public MasterController(IQueryDispatcher queryDispatcher,ICommandDispatcher commandDispatcher)
        {
            _queryDispatcher = queryDispatcher;
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet]
        [Route("country/get/all")]
        public async Task<IActionResult> GetCountries()
        {
            ApiResponse apiResponse = new ApiResponse();
            var query = new GetCountriesQuery();
            var result = await _queryDispatcher.DispatchAsync<GetCountriesQuery, IEnumerable<GetCountriesQueryResult>>(query);
            apiResponse.IsSuccess = query.IsSuccess;
            if (apiResponse.IsSuccess)
                apiResponse.AddData(result);
            return new ApiResponseWrapper<ApiResponse>(apiResponse, System.Net.HttpStatusCode.OK);
        }

        [HttpPost]
        [Route("country/create")]
        public async Task<IActionResult> CreateCountry(CreateCountryDto request)
        {
            ApiResponse apiResponse = new ApiResponse();
            var command = new CreateCountryCommand { CountryName = request.CountryName, CountryAlias = request.CountryAlias, CountryCode = request.CountryCode};
            await _commandDispatcher.DispatchAsync<CreateCountryCommand>(command);
            apiResponse.IsSuccess = command.IsSuccess;
            if (apiResponse.IsSuccess)
                apiResponse.AddSuccessMessage("created successfully");
            return new ApiResponseWrapper<ApiResponse>(apiResponse, System.Net.HttpStatusCode.OK);
        }

        [HttpPost]
        [Route("country/update")]
        public async Task<IActionResult> UpdateCountry(UpdateCountryDto request)
        {
            ApiResponse apiResponse = new ApiResponse();
            var command = new UpdateCountryCommand { Id = request.Id, CountryName = request.CountryName, CountryAlias = request.CountryAlias, CountryCode = request.CountryCode };
            await _commandDispatcher.DispatchAsync<UpdateCountryCommand>(command);
            apiResponse.IsSuccess = command.IsSuccess;
            if (apiResponse.IsSuccess)
                apiResponse.AddSuccessMessage("updated successfully");
            return new ApiResponseWrapper<ApiResponse>(apiResponse, System.Net.HttpStatusCode.OK);
        }

        [HttpPost]
        [Route("country/disable/{id}")]
        public async Task<IActionResult> DeleteCountry([FromRoute] Guid id)
        {
            ApiResponse apiResponse = new ApiResponse();
            var command = new DeleteCountryCommand { Id = id };
            await _commandDispatcher.DispatchAsync<DeleteCountryCommand>(command);
            apiResponse.IsSuccess = command.IsSuccess;
            if (apiResponse.IsSuccess)
                apiResponse.AddSuccessMessage("disabled successfully");
            return new ApiResponseWrapper<ApiResponse>(apiResponse, System.Net.HttpStatusCode.OK);
        }
    }
}
