namespace projectapitest.Models
{
    public class Cars
    {
        private int idcar;
        private string name;

        public Cars(int idcar, string name)
        {
            this.idcar = idcar;
            this.name = name;
        }

        public int Idcar { get => idcar; set => idcar = value; }
        public string Name { get => name; set => name = value; }
    }
}
