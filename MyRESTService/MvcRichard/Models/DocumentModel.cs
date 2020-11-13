namespace MvcRichard.Models
{
    public class DocumentModel
    {
        public string FullName;
        public string ShortName;
        public string PathName;

        public DocumentModel(string fullName, string shortName,string pathName)
        {
            FullName = fullName;
            ShortName = shortName;
            PathName = pathName;
        }
    }
}