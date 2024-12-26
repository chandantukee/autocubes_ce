using AutoCubes.Application.Commands.Organization.Create;
using AutoCubes.Application.DTOs;
using AutoCubes.Shared.Commands;
using AutoCubes.UI.Models;
using AutoCubes.UI.Models.Organization;
using Microsoft.AspNetCore.Mvc;

namespace AutoCubes.UI.Controllers
{
  public class OrganizationController : Controller
  {
    private readonly ICommandDispatcher _commandDispatcher;

    public OrganizationController(ICommandDispatcher commandDispatcher)
    {
      _commandDispatcher = commandDispatcher;
    }
    public IActionResult Index() => View();
    public IActionResult Create()
    {
      var model = InitializeViewModel();

      return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateOrganizationViewModel model)
    {
      if (!ModelState.IsValid)
      {
        var data = InitializeViewModel();
        return View(data);
      }
      CreateOrganizationCommand command = new()
      {
        OrganizationName = model.OrganizationName,
        OrganizationAlias = model.OrganizationAlias,
        OrganizationCode = model.OrganizationCode,
        OrganizationTypeId = model.OrganizationTypeId,
        Cin = model.Cin,
        Gstin = model.Gstin,
        Iec = model.Iec,
        Pan = model.Pan,
        OrganizationContactPerson = model.OrganizationContactPerson,
        OrganizationCountryId = model.OrganizationCountryId,
        OrganizationStateId = model.OrganizationStateId,
        OrganizationCityId = model.OrganizationCityId,
        OrganizationEmail = model.OrganizationEmail,
        OrganizationMobile = model.OrganizationMobile,
        OrganizationAddress = model.OrganizationAddress,
        OrganizationPincode = model.OrganizationPincode,
      };
      await _commandDispatcher.DispatchAsync<CreateOrganizationCommand>(command);
      return RedirectToAction("Index");
    }
    public IActionResult Update() => View();
    public IActionResult Delete() => View();

    private CreateOrganizationViewModel InitializeViewModel(CreateOrganizationViewModel model = null)
    {
      var orgTypes = new List<SelectModel>
    {
        new SelectModel { Id = new Guid("45cff94b-b582-11ef-8023-0a4c6350ffc9"), Name = "OEM" },
        new SelectModel { Id = new Guid("45d46059-b582-11ef-8023-0a4c6350ffc9"), Name = "Supplier" }
    };

      var countries = new List<SelectModel>
    {
        new SelectModel { Id = new Guid("08dd1212-3607-4e99-8a68-5d1c75fa889d"), Name = "India" },
        new SelectModel { Id = new Guid("08dd1213-b11a-4c4f-8d1d-2644eb39e2e7"), Name = "America" }
    };

      var states = new List<SelectModel>
    {
        new SelectModel { Id = new Guid("f82300e6-b590-11ef-8023-0a4c6350ffc9"), Name = "Karnataka" },
        new SelectModel { Id = new Guid("f825d059-b590-11ef-8023-0a4c6350ffc9"), Name = "Tamil Nadu" },
        new SelectModel { Id = new Guid("f825d592-b590-11ef-8023-0a4c6350ffc9"), Name = "Kerala" }
    };

      var cities = new List<SelectModel>
    {
        new SelectModel { Id = new Guid("221bfb86-b591-11ef-8023-0a4c6350ffc9"), Name = "Bengaluru" },
        new SelectModel { Id = new Guid("221c0133-b591-11ef-8023-0a4c6350ffc9"), Name = "Chennai" },
        new SelectModel { Id = new Guid("221c0237-b591-11ef-8023-0a4c6350ffc9"), Name = "Kochi" }
    };

      if (model == null)
      {
        model = new CreateOrganizationViewModel();
      }

      model.OrganizationTypes = orgTypes;
      model.Countries = countries;
      model.States = states;
      model.Cities = cities;

      return model;
    }
  }
}
