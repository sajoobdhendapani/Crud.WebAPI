using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccessLayer
{
    public interface ITestDetailsRepostory
    {
        public TestDetail InsertSP(TestDetail details);
        public IEnumerable<TestDetail> ReadSP();
        public TestDetail DeleteSP(long Id);
        public TestDetail UpdateSP(long Id, TestDetail UptdDetails);
    }
}
