using AutoCubes.Application.Commands.Countries.Create;
using AutoCubes.Application.Commands.Countries.Update;
using AutoCubes.Application.Contracts.Masters;
using AutoCubes.Infrastructure.Context;
using AutoCubes.Infrastructure.Models;

namespace AutoCubes.Infrastructure.CommandRepository
{
    public class CountryCommandRepository : ICountriesCommandRepository
    {
        private readonly AutoCubesDbContext _context;

        public CountryCommandRepository(AutoCubesDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(CreateCountryCommand command)
        {
            var model = new ICountry { CountryCode = command.CountryCode, CountryName = command.CountryName, CountryAlias = command.CountryAlias };

            await _context.ICountries.AddAsync(model);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(Guid Id)
        {
            var model = await _context.ICountries.FindAsync(Id);
            if(model != null)
            {
                model.CountryStatus = 0;
                _context.ICountries.Update(model);
                _context.SaveChanges();
            }
        }

        public async Task UpdateAsync(UpdateCountryCommand command)
        {
            var model = await _context.ICountries.FindAsync(command.Id);
            if(model != null)
            {
                model.CountryName = command.CountryName;
                model.CountryCode = command.CountryCode;
                model.CountryAlias = command.CountryAlias;

                _context.ICountries.Update(model);
                _context.SaveChanges();
            }
        }
    }
}
