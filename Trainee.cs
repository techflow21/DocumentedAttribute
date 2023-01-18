
namespace DocumentedAttribute
{

    [Document("This is a class attribute describing a Trainee")]
    class Trainee
    {

        [Document("This is a constructor attribute describing a Trainee", Input = "Adebola", Output = "The Trainee name is Adebola")]
        public Trainee(string fullname, string cohort)
        {
            Fullname = fullname;
            Cohort = cohort;
        }


        [Document("This is a Cohort property attribute of a Trainee", Input = "Cohort 3", Output = "Cohort 3")]
        public string Cohort { get; private set; }


        [Document("This is a Fullname property attribute of a Trainee", Input = "Adebola Adebisi", Output = "The Trainee fullname is Adebola Adebisi")]
        public string Fullname { get; private set; }


        [Document("This is a Trainee Scream style enum", Input = "enum choice of screams taken", Output = "Output enums Info")]
        enum TraineeScreams
        {
            [Document("This is a Trainee Scream enum", Input = "enum choice of screams taken", Output = "Output enums Info")]
            Omo,

            [Document("This is a Trainee Scream enum", Input = "enum choice of screams taken", Output = "Output enums Info")]
            HeyGod,

            [Document("This is a Trainee Scream enum", Input = "enum choice of screams taken", Output = "Output enums Info")]
            GodAbeg,

            [Document("This is a Trainee Scream enum", Input = "enum choice of screams taken", Output = "Output enums Info")]
            OhShit
        }

        [Document("This is a get Trainee Scream method attribute", Input = "input may be enum", Output = "enum choosen")]
        public static void GetTraineeScreams() => Console.WriteLine(TraineeScreams.GodAbeg);

    }
}
