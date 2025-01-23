using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TravelApp1.Pages.In_App;

namespace TestTravelApp1
{
	[Collection("TravelApp1")]
	public class TestFAQ
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<FAQ>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
