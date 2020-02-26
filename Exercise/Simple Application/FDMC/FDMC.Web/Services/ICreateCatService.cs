namespace FDMC.Web.Services
{
    public interface ICreateCatService
    {
        int CreateCat(string name, int age, string breed, string image);
    }
}
