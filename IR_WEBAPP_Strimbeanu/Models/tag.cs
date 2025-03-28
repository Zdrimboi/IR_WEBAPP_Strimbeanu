namespace IR_WEBAPP_Strimbeanu.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<ProductTag> ProductTags { get; set; } = new();
    }
}
