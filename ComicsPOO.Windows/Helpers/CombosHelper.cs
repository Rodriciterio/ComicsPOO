using ComicsPOO.Entidades;

namespace ComicsPOO.Windows.Helpers
{
    public static class CombosHelper
    {
        public static void CargarComboTipoComic(ref ComboBox cbo)
        {
            cbo.DataSource=Enum.GetValues(typeof(TipoComic)).Cast<TipoComic>().ToList();
            cbo.DropDownStyle=ComboBoxStyle.DropDownList;
            cbo.SelectedIndex=0;
        }
        public static void CargarComboTipoProducto(ref ComboBox cbo)
        {
            var lista = Enum.GetValues(typeof(TipoProducto)).Cast<TipoProducto>().ToList();
            foreach (var item in lista)
            {
                cbo.Items.Add(item);
            }
            cbo.DropDownStyle= ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = 0;
        }

      
    }
}
