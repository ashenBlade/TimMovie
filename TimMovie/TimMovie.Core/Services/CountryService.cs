﻿using TimMovie.Core.Entities;
using TimMovie.Core.Specifications.InheritedSpecifications;
using TimMovie.SharedKernel.Interfaces;

namespace TimMovie.Core.Services;

public class CountryService
{
    private readonly IRepository<Country> _countryRepository;

    public CountryService(IRepository<Country> countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public Country? FindByName(string name)
    {
        return _countryRepository.Query.FirstOrDefault(new CountryByNameSpec(name));
    }
    
    public IEnumerable<string> GetCountryNames()
    {
        return _countryRepository.Query.Select(country => country.Name).ToList();
    }
}