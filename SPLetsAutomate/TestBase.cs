using Atata;
using NUnit.Framework;

namespace SPLetsAutomate
{
    public class TestBase
    {
        [SetUp]
        public void TestIniitialize()
        {
            AtataContext.Configure().
                UseChrome().
                WithOptions(options =>
                {
                    options.AddArgument("--start-maximized");
                }).
                UseBaseUrl("https://demoqa.com/text-box").
                UseAllNUnitFeatures().
                AddLogConsumer(new ExtentLogConsumer()).
                AddScreenshotConsumer(new ExtentScreenshotConsumer()).
                Build();
        }

        [TearDown]
        public void TestCleanUp()
        {
            ExtentContext.Reports.Flush();
            AtataContext.Current?.CleanUp();
        }
    }
}