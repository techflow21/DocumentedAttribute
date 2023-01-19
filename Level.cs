
namespace DocumentedAttribute
{
    internal class Level
    {
        [Document("This is a level enum with a custom attribute.")]
        internal enum LevelEnum
        {
            [Document("This is the Level1 of LevelEnum")]
            Level1,
            [Document("This is the Level2 of LevelEnum")]
            Level2,
            [Document("This is the Level3 of LevelEnum")]
            Level3
        }
    }
}
