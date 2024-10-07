namespace ShoppingCartApi.Dto
{
    public class CategoryDto
    {
        public CategoryDto(string catId, string title, string description)
        {
            if (catId == null || catId == "")
            {
                Guid uuid = Guid.NewGuid();
                CatId = uuid.ToString();
            }
            else
            {
                CatId = catId;
            }
            
            Title = title;
            Description = description;

        }

        public string CatId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

    }
}
