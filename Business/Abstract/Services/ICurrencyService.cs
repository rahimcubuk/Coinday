﻿using Business.Abstract.Repository;
using Entities.Concrete.Models;

namespace Business.Abstract.Services
{
    public interface ICurrencyService : IServiceRepository<Currency>
    {
    }
}
