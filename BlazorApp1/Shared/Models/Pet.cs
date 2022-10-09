using BlazorApp1.Shared.Enums;

namespace BlazorApp1.Shared.Models
{
    public class Pet
    {
        /// <summary>
        /// Gets or Sets the Id of the pet
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or Sets the Name of the pet
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets the Species of the pet
        /// </summary>
        public AnimalType Type { get; set; }

        /// <summary>
        /// Gets or Sets the Breed of the pet if applicable
        /// </summary>
        public string? Breed { get; set; }
    }
}
