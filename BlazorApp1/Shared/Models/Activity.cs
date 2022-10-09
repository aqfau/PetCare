using BlazorApp1.Shared.Enums;

namespace BlazorApp1.Shared.Models
{
    public class Activity
    {
        /// <summary>
        /// Gets or Sets the Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or Sets the Name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets the Description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or Sets the ActivityType
        /// </summary>
        public ActivityType Type { get; set; }

        /// <summary>
        /// Gets or Sets the Activities that are allowed to be added onto a job
        /// Example, a drop in visit could have a walk added on, but a boarding visit can't have a drop in added on
        /// </summary>
        public ActivityType[]? AllowedAddOns { get; set; }
    }
}