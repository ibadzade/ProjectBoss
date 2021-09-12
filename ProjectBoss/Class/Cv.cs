namespace Boss_Project
{
    public class CV
    {

        public int CVId { get; set; }
        public string Profession { get; set; }
        public string Skills { get; set; }
        public string Language { get; set; }
        public string Language_Level { get; set; }
        public string University { get; set; }
        public string Degree { get; set; }
        public override string ToString()
        {
            return $@"
Profession : {Profession}
Skills : {Skills}
Degree : {Degree}
University : {University}
Language : {Language}
Language's Level : {Language_Level}
ID Of CV : {CVId}";
        }
    }
}
