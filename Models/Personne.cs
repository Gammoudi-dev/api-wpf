namespace projectapitest.Models
{
    public class Personne
    {
        private string name;
        private string surname;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
// hello
        public Personne(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
