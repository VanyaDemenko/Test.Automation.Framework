using Automation.Common.Extensions;
using Automation.Common.Interfaces;
using FluentAssertions;
using FluentAssertions.Execution;

namespace Automation.Tests.Extensions
{
    public static class AssertionExtensions
    {
        public static void AllPropertiesShouldHaveEquivalent(this IEntity actualData, IEntity expectedData)
        {
            var fieldsToVerify = ObjectsExtensions.GetNotNullObjectPropertiesDictionary(expectedData);
            actualData.HaveValues(expectedData, fieldsToVerify);
        }

        public static void AllPropertiesShouldNotHaveEquivalent(this IEntity actualData, IEntity expectedData)
        {
            var fieldsToVerify = ObjectsExtensions.GetNotNullObjectPropertiesDictionary(expectedData);
            actualData.NotHaveValues(expectedData, fieldsToVerify);
        }

        private static bool HaveValues<TEntity>(this TEntity actualData, TEntity expectedData, Dictionary<string, string> propertiesToVerify) where TEntity : IEntity
        {
            using var assertionScope = new AssertionScope();

            foreach (var dataSet in propertiesToVerify)
            {
                var actualDatapropValue = actualData.GetType().GetProperty(dataSet.Key).GetValue(actualData, null).ToString().Replace("\t", "/");
                var expectedDatapropValue = expectedData.GetType().GetProperty(dataSet.Key).GetValue(expectedData, null).ToString();
                actualDatapropValue.Should().Be(expectedDatapropValue, $"Column with name {dataSet.Key} has wrong data");
            }
            return true;
        }

        private static bool NotHaveValues<TEntity>(this TEntity actualData, TEntity expectedData, Dictionary<string, string> propertiesToVerify) where TEntity : IEntity
        {
            using var assertionScope = new AssertionScope();

            foreach (var dataSet in propertiesToVerify)
            {
                var actualDatapropValue = actualData.GetType().GetProperty(dataSet.Key).GetValue(actualData, null).ToString().Replace("\t", "/");
                var expectedDatapropValue = expectedData.GetType().GetProperty(dataSet.Key).GetValue(expectedData, null).ToString();
                actualDatapropValue.Should().NotBe(expectedDatapropValue, $"Column with name {dataSet.Key} has wrong data");
            }
            return true;
        }
    }
}
