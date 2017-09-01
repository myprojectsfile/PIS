using khodamooz.data.Entities;

namespace khodamooz.data
{
    public interface IKhodamoozRepository
    {
        User GetUser(string userName);
    }
}