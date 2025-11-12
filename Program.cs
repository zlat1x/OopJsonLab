using System.Text.Json;
using OopJsonLab.Models;

var path = Path.Combine(AppContext.BaseDirectory, "Data", "books.json");

if (!File.Exists(path))
{
    Console.WriteLine($"Файл не знайдено: {path}");
    Console.WriteLine("Переконайтесь, що Data/books.json існує в корені проєкту і .csproj має CopyToOutputDirectory.");
    return;
}

var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true,
    WriteIndented = true
};

List<Book>? books;
await using (var fs = File.OpenRead(path))
{
    books = await JsonSerializer.DeserializeAsync<List<Book>>(fs, options);
}

if (books is null)
{
    Console.WriteLine("Не вдалося прочитати дані.");
    return;
}

foreach (var b in books)
{
    Console.WriteLine($"[{b.PublishingHouseId}] \"{b.Title}\" / {b.PublishingHouse?.Name} ({b.PublishingHouse?.Address})");
}

var outPath = Path.Combine(AppContext.BaseDirectory, "out_base.json");
await File.WriteAllTextAsync(outPath, JsonSerializer.Serialize(books, options));
Console.WriteLine($"\nБазову сереалізацію збережено у: {outPath}");