using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_ORG_SQLite_RGR_2022.Services.Interfaces
{
    public interface IEncryptionService : IDisposable
    {
        string ComputeSha256Hash(string s);
    }
}
