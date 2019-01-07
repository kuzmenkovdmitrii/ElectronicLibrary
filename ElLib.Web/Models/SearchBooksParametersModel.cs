namespace ElLib.Web.Models
{
    public class SearchBooksParametersModel
    {
        public string Name { get; set; }
        public int[] Categories { get; set; }
        public int[] Authors { get; set; }
        public int Language { get; set; }
        public int[] Publishings { get; set; }
    }
}