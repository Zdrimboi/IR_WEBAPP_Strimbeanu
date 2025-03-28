namespace IR_WEBAPP_Strimbeanu.Models
{
    public class CategoryFilter
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Whether user has picked it
        public bool IsSelected { get; set; }

        // Whether it’s feasible given other filters
        public bool IsEnabled { get; set; } = true;

        // How many items remain if user picks this category
        public int ItemCount { get; set; }
    }

}
