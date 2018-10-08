using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace UNLOCODE.Tests
{
    public class RepositoryTest
    {        
        [Fact]
        public void UNLOCODE_Contain()
        {
            var query = UNLOCODE.Repositories.Repository.UNLOCODEs.Where(x => x.Name.Contains("South"));
            Assert.NotNull(query);
            Assert.NotEmpty(query);
        }
    }
}
