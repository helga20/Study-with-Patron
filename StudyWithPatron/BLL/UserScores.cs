namespace StudyWithPatron.BLL
{
    public class UserScores
    {
        //CREATE TABLE IF NOT EXISTS UserScore (Id INTEGER PRIMARY KEY NOT NULL, name TEXT NOT NULL, result INTEGER NOT NULL);
        public int? Id { get; set; }
        public string name { get; set; }
        public int result { get; set; }

        public UserScores(string name, int result)
        {
            this.name = name;
            this.result = result;
        }
    }
}
