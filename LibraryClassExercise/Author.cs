namespace LibraryClassExercise
{
    internal class Author
    {
        public string name;
        public string dateOfBirth;
        public string gender;

        public Author(string Name, int dayOfBirth, string monthOfBirth, int yearOfBirth, string Gender)
        {
            name = Name;
            dateOfBirth = dayOfBirth + " " + monthOfBirth + " " + yearOfBirth;
            gender = Gender;
        }
    }
}
