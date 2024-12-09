using ComicsPOO.Entidades;

namespace ComicsPOO.Datos
{
    public class Comiqueria
    {
        private SerializadorXml? serializadorXml;
        private Dictionary<Guid, Producto> productos;

        public Comiqueria()
        {
            productos = new Dictionary<Guid, Producto>();
            serializadorXml = new SerializadorXml();

        }

        public bool ExisteProducto(string descripcion)
        {
            return productos.Values.Any(p => p.Descripcion == descripcion);
        }

        public void AgregarProducto(Producto producto)
        {
            if (productos.ContainsKey(producto.Codigo))
                throw new InvalidOperationException("El producto ya existe.");
            productos[producto.Codigo] = producto;
        }

        public bool EditarProducto(Guid codigo, int stock, decimal? precio = null)
        {
            if (productos.TryGetValue(codigo, out var producto))
            {
                producto.Stock = stock;
                if (precio.HasValue)
                    producto.Precio = precio.Value;
                return true;
            }
            return false;
        }

        public Producto GetProducto(Guid codigo)
        {
            productos.TryGetValue(codigo, out var producto);
            return producto;
        }

        public Producto BuscarProductoPorDescripcion(string descripcion)
        {
            return productos.Values.FirstOrDefault(p => p.Descripcion == descripcion);
        }

        public bool QuitarProducto(Guid codigo)
        {
            return productos.Remove(codigo);
        }

        public List<Producto> GetProductos()
        {
            return productos.Values.ToList();
        }

        public int GetCantidad() => productos.Count;

        public void GuardarDatos()
        {
            serializadorXml!.GuardarDatos(productos.Values.ToList());

        }



    }
}
