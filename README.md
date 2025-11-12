## Відповіді на запитання із завдання
1) Десеріалізація: класи `Book`, `PublishingHouse`; `JsonSerializer.DeserializeAsync<List<Book>>` (див. Program.cs).  
2) Не серіалізувати `PublishingHouseId`: додати `[JsonIgnore] public int PublishingHouseId { get; set; }`.  
3) `Title` під ключем "Name": `[JsonPropertyName("Name")] public string Title { get; set; } = string.Empty;`