namespace ComicsPOO.Entidades
{
    public class Comic : Producto
    {
        public string Autor { get; set; }
        public TipoComic TipoComic { get; set; }

        public Comic(string descripcion, decimal precio, int stock, string autor, TipoComic tipoComic)
            : base(descripcion, precio, stock)
        {
            Autor = autor ?? throw new ArgumentNullException(nameof(autor));
            TipoComic = tipoComic;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Autor: {Autor} - Tipo: {TipoComic}";
        }

    }
}
