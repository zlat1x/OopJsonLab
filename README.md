## Відповіді на запитання із завдання:
1) Десеріалізація: класи `Book`, `PublishingHouse`; `JsonSerializer.DeserializeAsync<List<Book>>`.
2) Не серіалізувати PublishingHouseId: `[JsonIgnore] public int PublishingHouseId { get; set; }`.
3) Title під ключем "Name": `[JsonPropertyName("Name")] public string Title { get; set; } = string.Empty`.
