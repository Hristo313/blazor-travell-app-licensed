using TravelApp1.Models.TravelApp;

namespace TravelApp1.TravelApp
{
    public interface ITravelAppService
    {
        Task<List<SelectedArticlesType>> GetSelectedArticles();
        Task<List<DestinationsType>> GetDestinations();
        Task<List<ImageSet1Type>> GetImageSet1();
        Task<List<ImageSet2Type>> GetImageSet2();
        Task<List<ArticlesSource1Type>> GetArticlesSource1();
        Task<List<ArticlesSource2Type>> GetArticlesSource2();
        Task<List<ArticlesSource3Type>> GetArticlesSource3();
        Task<List<ArticlesSource4Type>> GetArticlesSource4();
    }
}
