using System;
using Xunit.Sdk;

namespace MoralesLarios.Tests.CustomAttributes
{
    [TraitDiscoverer("CategoryDiscoverer", "TraitExtensibility")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class CategoryAttribute : Attribute, ITraitAttribute
    {
        public CategoryAttribute(string category) { }
    }
}