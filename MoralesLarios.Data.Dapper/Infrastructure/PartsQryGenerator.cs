using System;
using System.Reflection;
using System.Text;
using System.Linq;
using MoralesLarios.Data.Helper;

namespace MoralesLarios.Data.Dapper.Infrastructure
{
    public class PartsQryGenerator<TEntity> : IPartsQryGenerator<TEntity> where TEntity : class
    {
        private PropertyInfo[] properties;
        private string[]       propertiesNames;
        private string         typeName;

        private string characterParameter;

        public PartsQryGenerator(char characterParameter = '@')
        {
            var type = typeof(TEntity);

            this.characterParameter = characterParameter.ToString();

            properties      = type.GetProperties();
            propertiesNames = properties.Where(a => ! IsComplexType(a)).Select(a => a.Name).ToArray();
            typeName        = type.Name;
        }

        public string GeneratePartInsert(string identityField = null)
        {
            var result = string.Empty;

            var sb = new StringBuilder($"INSERT INTO {typeName} (");

            var propertiesNamesDef = propertiesNames.Where(a => a != identityField).ToArray();

            string camps = string.Join(",", propertiesNamesDef);

            sb.Append($"{camps}) VALUES (");

            string[] parametersCampsCol = propertiesNamesDef.Select(a => $"{characterParameter}{a}").ToArray();

            string campsParameter = string.Join(",", parametersCampsCol);

            sb.Append($"{campsParameter})");

            result = sb.ToString();

            return result;
        }

        public string GenerateSelect()
        {
            var result = string.Empty;

            var sb = new StringBuilder("SELECT ");

            string separator = $",{Environment.NewLine}";

            string selectPart = string.Join(separator, propertiesNames);

            sb.AppendLine(selectPart);

            string fromPart = $"FROM {typeName}";

            sb.Append(fromPart);

            result = sb.ToString();

            return result;
        }

        public string GenerateDelete(object parameters)
        {
            ParameterValidator.ValidateObject(parameters, nameof(parameters));

            var where = GenerateWhere(parameters);

            var result = $"DELETE FROM {typeName} {where} ";

            return result;
        }

        public string GenerateUpdate(object pks)
        {
            ParameterValidator.ValidateObject(pks, nameof(pks));

            var pksFields = pks.GetType().GetProperties().Select(a => a.Name).ToArray();

            var sb = new StringBuilder($"UPDATE {typeName} SET ");

            var propertiesNamesDef = propertiesNames.Where(a => ! pksFields.Contains(a)).ToArray();

            var propertiesSet = propertiesNamesDef.Select(a => $"{a} = {characterParameter}{a}").ToArray();

            var strSet = string.Join(",", propertiesSet);

            var where = GenerateWhere(pks);

            sb.Append($" {strSet} {where} ");

            var result = sb.ToString();

            return result;
        }

        public string GenerateSelect(object fieldsFilter)
        {
            ParameterValidator.ValidateObject(fieldsFilter, nameof(fieldsFilter));

            var initialSelect = GenerateSelect();

            var where = GenerateWhere(fieldsFilter);

            var result = $" {initialSelect} {where}";

            return result;
        }


        private string GenerateWhere(object filtersPKs)
        {
            ParameterValidator.ValidateObject(filtersPKs, nameof(filtersPKs));

            var filtersPksFields = filtersPKs.GetType().GetProperties().Select(a => a.Name).ToArray();

            if (!filtersPksFields?.Any() ?? true) throw new ArgumentException($"El parameter filtersPks isn't valid. This parameter must be a class type", nameof(filtersPKs));

            var propertiesWhere = filtersPksFields.Select(a => $"{a} = {characterParameter}{a}").ToArray();

            var strWhere = string.Join(" AND ", propertiesWhere);

            var result = $" WHERE {strWhere} ";

            return result;
        }

        private bool IsComplexType(PropertyInfo propertyInfo)
        {
            bool result;

            result = (propertyInfo.PropertyType.IsClass && propertyInfo.PropertyType.Name != "String") || propertyInfo.PropertyType.IsInterface;

            return result;
        }



    }
}