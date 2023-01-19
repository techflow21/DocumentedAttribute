
namespace DocumentedAttribute
{
    [Document("This is a Trainee class")]
    class Trainee
    {
        [Document("This is a name property of Trainee class")]
        public string Name { get; set; }

        [Document("This is a method of Trainee class", Input = "Bello", Output = "")]
        public void SetName(string name)
        {
            Name = name;
        }

        [Document("This is another method of Trainee class", Input = "", Output = "Bello")]
        public string GetName()
        {
            return Name;
        }
    }
}
