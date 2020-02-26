namespace FDMC.Web.Services
{ 
    using FDMC.Web.Models.Cats;
    public interface ICatDetailsServices
    {
        CatDetailsViewModel CatInfo(string catId);
    }
}
