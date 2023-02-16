using System.ComponentModel.DataAnnotations;
    
namespace RecopeWebApp.Models
{
    public class Recipes
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public string Ingredients{ get; set; }
        public virtual string Instructions { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public Recipes()
        {

        }
    }
}
