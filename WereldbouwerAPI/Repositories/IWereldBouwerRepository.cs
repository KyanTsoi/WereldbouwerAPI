﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WereldbouwerAPI
{
    public interface IWereldBouwerRepository
    {
        Task<IEnumerable<WereldBouwer>> GetAllAsync();
        Task<WereldBouwer> GetByIdAsync(Guid id);
        Task<WereldBouwer> AddAsync(WereldBouwer wereldBouwer); // Updated to return Task<WereldBouwer>
        Task UpdateAsync(WereldBouwer wereldBouwer);
        Task DeleteAsync(Guid id);
    }
}

