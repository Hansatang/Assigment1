using System.Collections.Generic;
using Models;

namespace Assigment_1.Data
{
    public interface IAdultService
    {
        public IList<Adult> AdultsList { get; }

        public void Save();
        void Remove(int adultId);
    }
}