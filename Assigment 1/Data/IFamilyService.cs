using System.Collections.Generic;
using Models;

namespace Assigment_1.Data
{
    public interface IFamilyService
    {
        public IList<Adult> AdultList { get; }

        public void Save();
    }
}