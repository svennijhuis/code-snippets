static List<T> ReadCSV<T>(string path)
    => new CsvReader(new StreamReader(path), CultureInfo.InvariantCulture)
        .GetRecords<T>()
        .ToList();
