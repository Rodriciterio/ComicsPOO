namespace ComicsPOO.Datos
{
    public interface IArchivo<T> where T : class
    {
        T LeerDatos();
        void GuardarDatos(T obj);
    }
}
