using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Assigment_1.Data
{
    public interface ICloudAdultInterface
    {
        Task<IList<Adult>> GetAdultAsync();
        Task AddAdultAsync(Adult adult);
        Task RemoveAdultAsync(int adultId);
        Task UpdateAsync(Adult adult);
    }
}