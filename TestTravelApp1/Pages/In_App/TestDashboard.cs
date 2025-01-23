using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TravelApp1.Pages.In_App;
using TravelApp1.TravelApp;

namespace TestTravelApp1
{
	[Collection("TravelApp1")]
	public class TestDashboard
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbListModule));
			ctx.Services.AddScoped<ITravelAppService>(sp => new MockTravelAppService());
			var componentUnderTest = ctx.RenderComponent<Dashboard>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
