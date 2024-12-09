using ComicsPOO.Entidades;
using System.Xml.Serialization;

namespace ComicsPOO.Datos
{
    public class SerializadorXml : IArchivo<List<Producto>>
    {
        private string nombreArchivo = "Productos.Xml";
        private string rutaPrograma = Environment.CurrentDirectory;
        private string? rutaCompletaArchivo;

        public SerializadorXml()
        {
            rutaCompletaArchivo = Path.Combine(rutaPrograma, nombreArchivo);
        }
        public void GuardarDatos(List<Producto> obj)
        {
            using (var escritor = new StreamWriter(rutaCompletaArchivo!))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Producto>));
                xmlSerializer.Serialize(escritor, obj);
            }
        }

        public List<Producto> LeerDatos()
        {
            if (!File.Exists(rutaCompletaArchivo))
            {
                return new List<Producto>();
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Producto>));
            using (var lector = new StreamReader(rutaCompletaArchivo))
            {
                return (List<Producto>)xmlSerializer.Deserialize(lector)!;
            }
        }

    }
}
