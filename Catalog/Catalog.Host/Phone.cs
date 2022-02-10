namespace Catalog.Host
{
    public class Phone
    {
        public string Brand { get; set; } = default!;
        public string Model { get; set; } = default!;
        public double ScreenSize { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
