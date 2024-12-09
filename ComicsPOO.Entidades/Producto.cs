using System.Drawing;
using System.Xml.Serialization;

namespace ComicsPOO.Entidades
{
    [XmlInclude(typeof(Comic))]
    [XmlInclude(typeof(Figurita))]
    public class Producto
    {
        private Guid codigo;
        private string descripcion;
        private decimal precio;
        private int stock;

        protected Producto(string descripcion, decimal precio, int stock)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripción no puede ser nula o vacía.");

            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a cero.");

            if (stock < 0)
                throw new ArgumentException("El stock no puede ser menor a cero.");

            codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }

        public Producto()
        {
            
        }

        public Guid Codigo => codigo;

        public string Descripcion
        {
            get => descripcion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La descripción no puede ser nula o vacía.");
                descripcion = value;
            }
        }

        public decimal Precio
        {
            get => precio;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio debe ser mayor a cero.");
                precio = value;
            }
        }

        public int Stock
        {
            get => stock;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El stock no puede ser menor a cero.");
                stock = value;
            }
        }

        public override string ToString()
        {
            return $"{Codigo} - {Descripcion} - {Precio:C} - Stock: {Stock}";
        }

        public override bool Equals(object obj)
        {
            return obj is Producto producto && Descripcion == producto.Descripcion;
        }

        public static explicit operator Guid(Producto producto) => producto.Codigo;

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
