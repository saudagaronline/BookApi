namespace BookApi.Models;

public class Book
{
    public long Id { get; set; }
    public string? Title { get; set; }
    public string? Pengarang { get; set; }
    public string? Penerbit { get; set; }
    public int TahunTerbit {get; set; }
}