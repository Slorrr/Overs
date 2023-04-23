namespace hackathon_21._04._23
{
    /// <summary>
    /// Признак
    /// </summary>
    public class Sign
    {
        public int Id { get; set; }
        public Sign() { }

        public Sign(string name) { }
        public Sign(string name, string description)
        {

        }

        public enum SignType
        {
            Process,
            Resourse,
            Document,

        }
    }
}
