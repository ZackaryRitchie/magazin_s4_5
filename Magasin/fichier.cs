using Magasin;
using Magasin.model;
using System.Text.Json;

string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
string fichier = Path.Combine(basePath, "data", "livres.json");

string? dossier= Path.GetDirectoryName(fichier);

if (dossier is not null && !Directory.Exists(dossier))
{
    Directory.CreateDirectory(dossier);

}

CreerLivre(fichier);

List<Item>ListItem = LireJson(fichier);

foreach (Item items in ListItem)
{
    Console.WriteLine(items.ToString());
}


static void CreerLivre(string fichier)
{
    //deférnir liste
    List<Item> list = new List<Item>
    {
        new Item("1",25533,"blabla",26.99,"grounded",251),
        new Item("2",25534,"blabla",27.99,"grounded",200),
        new Item("3",25535,"blabla",25.99,"grounded",301)
    };
    //sérialiser 
    JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true};
    string  LivresJson = JsonSerializer.Serialize(list);


    //écrire dans le fichier
    File.WriteAllTextAsync(fichier, LivresJson );

}



static List<Item> LireJson(string fichier)
{
    //lire le fichier avec file.ReadAll
    string LivresJson = File.ReadAllText(fichier);

    //Désérialiser l'objet du fichier
    List<Item>? list = JsonSerializer.Deserialize<List<Item>>(LivresJson);

    //retourner la liste des object

    if (list is null)
    {
        throw new InvalidOperationException("Erreur dans désérialiser");
    }
    return list;
}