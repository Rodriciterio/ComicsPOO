namespace ComicsPOO.Entidades
{
    public class Figurita: Producto
    {
        public int Altura { get; set; }

        public Figurita(string descripcion, decimal precio, int stock, int altura)
            : base(descripcion, precio, stock)
        {
            Altura = altura;
        }

        public Figurita(decimal precio, int stock, int altura)
            : this($"Figura de {altura} cm", precio, stock, altura) { }

        public override string ToString()
        {
            return base.ToString() + $" - Altura: {Altura} cm";
        }

    }
}
