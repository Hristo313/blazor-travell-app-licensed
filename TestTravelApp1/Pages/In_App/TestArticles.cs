using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TravelApp1.Pages.In_App;
using TravelApp1.TravelApp;

namespace TestTravelApp1
{
	[Collection("TravelApp1")]
	public class TestArticles
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule));
			ctx.Services.AddScoped<ITravelAppService>(sp => new MockTravelAppService());
			var componentUnderTest = ctx.RenderComponent<Articles>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
