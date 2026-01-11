using System.ComponentModel.DataAnnotations;

namespace DependencyInjectionDemo.Components.Demos.BuiltInComponents.Sampledata
{
   
    public class Superhero
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string SpecialAbility { get; set; } = string.Empty;

        [Range(0, 100)]
        public int? Score { get; set; }

        public DateTime? CreationDate { get; set; }

    }

}
