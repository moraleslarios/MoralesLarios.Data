using MoralesLarios.Data.EntityFramework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MoralesLarios.Data.IntegrationTests.EntityFramework.Infrastructure
{
    public class PKExtractorTests
    {

        private IPKExtractor instance;


        public PKExtractorTests()
        {
            instance = new PKExtractor();
        }


        [Fact]
        public void ExtractPKInObjectEnumerable_GoodParameters_OK()
        {
            int    partOne = 1;
            string partTwo = "two";

            object pk = new { partOne, partTwo };

            IEnumerable<object> result = instance.ExtractPKInObjectEnumerable(pk);

            Assert.Equal(2, result.Count());
            Assert.Equal(result.First(), partOne);
            Assert.Equal(result.ElementAt(1), partTwo);
        }


    }
}
