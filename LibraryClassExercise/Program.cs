namespace LibraryClassExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author bookauthor = new Author("JRR Tolkien",20,"March",1998,"Male");
            Book hobbit = new Book("The Hobbit",350,"1939",true, false, bookauthor);

            //Console.WriteLine($"{hobbit.title} by JRR Tolkien. Released in {hobbit.releaseDate} with {hobbit.pages} pages. The genre is {hobbit.ficOrNofic} and the cover is a {hobbit.cover}");
            Console.WriteLine($"{hobbit.author.name}, author of {hobbit.title}, born {hobbit.author.dateOfBirth}, Gender: {hobbit.author.gender}");
        }
    }
}
