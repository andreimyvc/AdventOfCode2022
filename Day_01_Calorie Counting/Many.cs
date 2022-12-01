

public void Test()
{
    List<Item> lista = new List<Item>();

    List<ItemList> listas = new List<ItemList>();
    var x = lista.Select(p => p.Nombre);
    var y = lista.SelectMany(p => p.Nombre);

    var k = listas.Select(p => p.Items);
    var l = listas.SelectMany(p => p.Items);
}

public class ItemList
{
    public int Id { get; set; }
    public List<Item> Items { get; set; }
}
public class Item
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int EquipoId { get; set; }
}