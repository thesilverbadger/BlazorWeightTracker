using System.Threading.Tasks;
using BlazorWeightTracker.Server.Controllers;
using NUnit.Framework;

namespace BlazorWeightTrackerTests
{
    public class WeightControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetWeights()
        {
            var controller = new WeightController();
            var weights = controller.Get();

            Assert.IsTrue(weights.Count > 0);
        }
    }
}