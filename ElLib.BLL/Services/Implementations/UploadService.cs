using System.Net;
using System.Text;
using System.Web;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Exception;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ElLib.BLL.Services.Implementations
{
    public class UploadService : IUploadService
    {
        static int appId = 6807116;
        static int groupId = 176184947;
        static int userId = 524693788;
        static string token = "6b9fdc78b282f1c39df932ec7d38576f2360741d643a8ade098e36098d48d90d66274436339e09467f64d";

        public string UploadPicture(string path)
        {
            var client = new WebClient();

            var urlForServer = "https://api.vk.com/method/photos.getWallUploadServer?access_token=" + token + "&v=5.52";
            var reqForServer = client.DownloadString(urlForServer);
            var jsonForServer = JsonConvert.DeserializeObject(reqForServer) as JObject;

            var urlUploadServer = jsonForServer["response"]["upload_url"].ToString();
            var reqUploadServer = Encoding.UTF8.GetString(client.UploadFile(urlUploadServer, "POST", path));
            var jsonUploadServer = JsonConvert.DeserializeObject(reqUploadServer) as JObject;

            var urlSavePhoto = "https://api.vk.com/method/photos.saveWallPhoto?access_token=" + token
                                                                                              + "&server=" +
                                                                                              jsonUploadServer["server"]
                                                                                              + "&photo=" +
                                                                                              jsonUploadServer["photo"]
                                                                                              + "&hash=" +
                                                                                              jsonUploadServer["hash"]
                                                                                              + "&v=5.52";
            var reqSavePhoto = client.DownloadString(urlSavePhoto);
            var jsonSavePhoto = JsonConvert.DeserializeObject(reqSavePhoto) as JObject;

            var pictureUrl = jsonSavePhoto["response"][0]["photo_807"].ToString();

            return pictureUrl;
        }

        public string UploadDocument(string path)
        {
            var client = new WebClient();

            var urlForServer = "https://api.vk.com/method/docs.getWallUploadServer?access_token=" + token + "&v=5.52";
            var reqForServer = client.DownloadString(urlForServer);
            var jsonForServer = JsonConvert.DeserializeObject(reqForServer) as JObject;

            var urlUploadServer = jsonForServer["response"]["upload_url"].ToString();
            var reqUploadServer = Encoding.UTF8.GetString(client.UploadFile(urlUploadServer, "POST", path));
            var jsonUploadServer = JsonConvert.DeserializeObject(reqUploadServer) as JObject;

            var urlSaveDoc = "https://api.vk.com/method/docs.save?access_token=" + token
                                                                                 + "&server=" +
                                                                                 jsonUploadServer["server"]
                                                                                 + "&file=" +
                                                                                 jsonUploadServer["file"]
                                                                                 + "&hash=" +
                                                                                 jsonUploadServer["hash"]
                                                                                 + "&v=5.52";
            var reqSaveDoc = client.DownloadString(urlSaveDoc);
            var jsonSaveDoc = JsonConvert.DeserializeObject(reqSaveDoc) as JObject;

            var docUrl = jsonSaveDoc["response"][0]["url"].ToString();

            return docUrl;
        }
    }
}