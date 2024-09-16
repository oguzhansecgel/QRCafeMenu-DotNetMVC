using CafeMenum.UI.DTO.FoodImage;

namespace CafeMenum.UI.DTO.Food
{
    public class GetAllFoodResponse
    {
        public int id;

        public string foodName;

        public string foodDescription;
 
        public double foodPrice;

        public int categoryId;

        public string ImageUrl { get; set; }

    }
}
