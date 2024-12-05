using var memoryStream = new MemoryStream();
using var streamWriter = new StreamWriter(memoryStream);
using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
csvWriter.WriteRecords(mostFavoritedCars);
streamWriter.Flush();

return memoryStream.ToArray();
