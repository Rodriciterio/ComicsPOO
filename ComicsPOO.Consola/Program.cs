using ComicsPOO.Entidades;

namespace ComicsPOO.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var comic = new Comic("Batman", 1500, 10, "John Clarke", TipoComic.Occidental);
            Console.WriteLine(comic.ToString());
        }
    }
}
