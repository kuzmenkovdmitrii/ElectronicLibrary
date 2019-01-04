using System.Web;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IUploadService
    {
        string UploadPicture(string path);
        string UploadDocument(string path);
    }
}
