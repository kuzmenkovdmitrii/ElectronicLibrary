using System.Net;
using System.Text;
using ElLib.BLL.Services.Interfaces;
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
            WebClient client = new WebClient();

            string urlForServer = "https://api.vk.com/method/photos.getWallUploadServer?access_token=" + token + "&v=5.52";
            string reqForServer = client.DownloadString(urlForServer);
            JObject jsonForServer = JsonConvert.DeserializeObject(reqForServer) as JObject;

            string urlUploadServer = jsonForServer["response"]["upload_url"].ToString();
            string reqUploadServer = Encoding.UTF8.GetString(client.UploadFile(urlUploadServer, "POST", path));
            JObject jsonUploadServer = JsonConvert.DeserializeObject(reqUploadServer) as JObject;

            string urlSavePhoto = "https://api.vk.com/method/photos.saveWallPhoto?access_token=" + token
                                                                                              + "&server=" +
                                                                                              jsonUploadServer["server"]
                                                                                              + "&photo=" +
                                                                                              jsonUploadServer["photo"]
                                                                                              + "&hash=" +
                                                                                              jsonUploadServer["hash"]
                                                                                              + "&v=5.52";
            string reqSavePhoto = client.DownloadString(urlSavePhoto);
            JObject jsonSavePhoto = JsonConvert.DeserializeObject(reqSavePhoto) as JObject;

            string pictureUrl = jsonSavePhoto["response"][0]["photo_807"].ToString();

            return pictureUrl;
        }

        public string UploadDocument(string path)
        {
            WebClient client = new WebClient();

            string urlForServer = "https://api.vk.com/method/docs.getWallUploadServer?access_token=" + token + "&v=5.52";
            string reqForServer = client.DownloadString(urlForServer);
            JObject jsonForServer = JsonConvert.DeserializeObject(reqForServer) as JObject;

            string urlUploadServer = jsonForServer["response"]["upload_url"].ToString();
            string reqUploadServer = Encoding.UTF8.GetString(client.UploadFile(urlUploadServer, "POST", path));
            JObject jsonUploadServer = JsonConvert.DeserializeObject(reqUploadServer) as JObject;

            string urlSaveDoc = "https://api.vk.com/method/docs.save?access_token=" + token
                                                                                 + "&server=" +
                                                                                 jsonUploadServer["server"]
                                                                                 + "&file=" +
                                                                                 jsonUploadServer["file"]
                                                                                 + "&hash=" +
                                                                                 jsonUploadServer["hash"]
                                                                                 + "&v=5.52";
            string reqSaveDoc = client.DownloadString(urlSaveDoc);
            JObject jsonSaveDoc = JsonConvert.DeserializeObject(reqSaveDoc) as JObject;

            string docUrl = jsonSaveDoc["response"][0]["url"].ToString();

            return docUrl;
        }
    }
}