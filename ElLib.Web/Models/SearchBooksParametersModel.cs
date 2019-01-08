namespace ElLib.Web.Models
{
    public class SearchBooksParametersModel
    {
        public string Query { get; set; }
        public int[] Categories { get; set; }
        public int[] Authors { get; set; }
        public int[] Languages { get; set; }
        public int[] Publishings { get; set; }
    }
}