
namespace DocumentedAttribute
{

    [Document("This is a class attribute describing a Trainee", Input = "inputs taken", Output = "output taken")]
    class Trainee
    {

        [Document("This is a constructor attribute describing a Trainee", Input = "two inputs taken", Output = "Sum of two integers")]
        public Trainee(string fullname, string cohort)
        {
            Fullname = fullname;
            Cohort = cohort;
        }


        [Document("This is a Cohort property attribute describing a Trainee", Input = "two inputs taken", Output = "Sum of two integers")]
        public string Cohort { get; private set; }


        [Document("This is a Fullname property attribute describing a Trainee", Input = "two inputs taken", Output = "Sum of two integers")]
        public string Fullname { get; private set; }


        [Document("This is a Trainee Scream enum describing a Trainee", Input = "two inputs taken", Output = "Sum of two integers")]
        enum TraineeScreams
        {
            Omo,
            HeyGod,
            GodAbeg,
            OhShit
        }

        [Document("This is a get Trainee Scream method attribute describing a Trainee Scream style", Input = "two inputs taken", Output = "Sum of two integers")]
        internal void GetTraineeScream()
        {
            Console.WriteLine(TraineeScreams.GodAbeg);

        }

    }
}
