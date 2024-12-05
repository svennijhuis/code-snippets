private static async Task<byte[]> ToByteArray(Stream input)
{
    using var ms = new MemoryStream();
    await input.CopyToAsync(ms);
    return ms.ToArray();
}
