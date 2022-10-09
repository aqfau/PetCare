using BlazorApp1.Shared.Models;

namespace BlazorApp1.Server.Services
{
    public interface IActivityService
    {
        /// <summary>
        /// Returns all activities
        /// </summary>
        /// <returns>All activities in an Enumerable</returns>
        IEnumerable<Activity> Get();
    }
}
