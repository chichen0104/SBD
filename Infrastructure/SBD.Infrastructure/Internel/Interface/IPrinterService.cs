﻿using SBD.Domain.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBD.Infrastructure.Internel.Interface
{
    public interface IPrinterService : IDevice
    {
        Task<bool?> PrintListString(List<string> InputTex);
    }
}
