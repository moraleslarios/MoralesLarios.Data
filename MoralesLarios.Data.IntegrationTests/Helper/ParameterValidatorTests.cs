using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoralesLarios.Data.Helper;
using Xunit;
using System.Collections;
using MoralesLarios.Tests.CustomAttributes;

namespace MoralesLarios.Data.IntegrationTests.Helper
{
    public class ParameterValidatorTests
    {

        [Fact]
        [Category("uno")]
        public void ValidateObject_ParameterNull_ThrowException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                ParameterValidator.ValidateObject(null, "data");
            });
        }

        [Fact]
        public void ValidateObject_ParameterNotNull_OK()
        {
            ParameterValidator.ValidateObject("d", "data");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ValidateString_ParameterNullEmptyWhite_ThrowException(string parameter)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                ParameterValidator.ValidateString(parameter, "argument");
            });
        }


        [Fact]
        public void ValidateString_GoodParameter_OK()
        {
            ParameterValidator.ValidateString("algo", "nameOfParameter");
        }


        [Fact]
        public void ValidateEnumerable_GoodParameter_OK()
        {
            IEnumerable enumerable = new List<object>() { new object(), new object() };

            ParameterValidator.ValidateEnumerable(enumerable, nameof(enumerable));
        }

        [Fact]
        public void ValidateEnumerable_ListInts_OK()
        {
            IEnumerable enumerable = new List<int>() {17, 18 };

            ParameterValidator.ValidateEnumerable(enumerable, nameof(enumerable));
        }

        [Fact]
        public void ValidateEnumerable_ListIntsNullablesWhithNullValue_ThrowException()
        {
            IEnumerable enumerable = new List<int?>() { 17, null };

            Assert.Throws<ArgumentNullException>(() =>
            {
                ParameterValidator.ValidateEnumerable(enumerable, nameof(enumerable));
            });
        }

        [Fact]
        public void ValidateEnumerableString_ListString_OK()
        {
            IEnumerable<string> enumerable = new List<string>() { "Hello", "GoodBye" };

            ParameterValidator.ValidateEnumerableString(enumerable, nameof(enumerable));
        }

        [Fact]
        public void ValidateEnumerableString_ListStringsWhithNullValue_ThrowException()
        {
            IEnumerable<string> enumerable = new List<string>() { "Hello", null };

            Assert.Throws<ArgumentNullException>(() =>
            {
                ParameterValidator.ValidateEnumerableString(enumerable, nameof(enumerable));
            });
        }



    }
}
