namespace apiForLMSAPI.Model
{
    public class Post
    {
        public string MainSubject { get; set; }
        public string SubjectName { get; set; }
        public List<Dictionary<string, string>> SubjectData { get; set; }
        public List<string> Subjects { get; set; }
        public string HeadSubject { get; set; }
        public int Id { get; set; }
    }
}
