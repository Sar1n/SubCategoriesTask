namespace SubCategoriesTask
{
	public class Category
	{
		public Category(
			int CategoryId,
			string CategoryName,
			int? ParentCategoryId)
		{
			this.CategoryId = CategoryId;
			this.CategoryName = CategoryName;
			this.ParentCategoryId = ParentCategoryId;
		}
		public int CategoryId { get; set; }

		public string CategoryName { get; set; }

		public int? ParentCategoryId { get; set; }
	}
}
