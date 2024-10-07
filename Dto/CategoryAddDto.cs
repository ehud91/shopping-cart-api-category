namespace ShoppingCartApi.Dto
{
    public class CategoryAddDto
    {
        public CategoryAddDto(string title, string description)
        {            
            this.title = title;
            this.description = description;

        }

        public string title { get; set; }
        public string description { get; set; }
    }
}
