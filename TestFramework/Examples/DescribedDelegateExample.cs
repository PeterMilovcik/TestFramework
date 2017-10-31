using NUnit.Framework;

namespace TestFramework.Examples
{
    internal class DescribedDelegateExample
    {
        /// <summary>
        /// Console Output:
        /// Given: Two numbers x=2 and y = 3. -> Passed
        ///  When: Sum of those numbers is performed. -> Passed
        ///  Then: Result value of sum operation is 5. -> Passed
        /// </summary>
        [Test]
        public void Sum()
        {
            int x = 0;
            int y = 0;
            int sum = 0;

            Scenario.Create()
                .Given("Two numbers x=2 and y=3.", () =>
                {
                    x = 2;
                    y = 3;
                })
                .When("Sum of those numbers is performed.", () =>
                    sum = x + y)
                .Then("Result value of sum operation is 5.", () =>
                    Assert.That(sum, Is.EqualTo(5)))
                .Execute();
        }
    }
}