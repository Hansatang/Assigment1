using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Assigment_1.Data
{
    public interface ICloudAdultInterface
    {
        Task<IList<Adult>> GetAdultAsync();
        Task   AddAdultAsync(Adult todo);
        Task   RemoveAdultAsync(int todoId);
        Task   UpdateAsync(Adult adult);
    }
}