namespace Mission11_ReedStewart_0108.Models.ViewModels
{
    public class PaginationInfo
    {
        public int TotalItems { get; set; }
        public int PageItems { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int) (Math.Ceiling((decimal) TotalItems / PageItems));
    }
}
