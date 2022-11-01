namespace MoviesRepository.Data.Models
{
    public class MoviesReportItem
    {
        /// <summary>
        /// Gets or sets the actor names (concatenated names of movie actors, with default comma separator).
        /// </summary>
        /// <value>
        /// The actor names.
        /// </value>
        public string ActorNames { get; set; }
        public string CategoryName { get; set; }
        public int NumberOfActors { get; set; }
        public string Title { get; set; }
        public int YearOfProduction { get; set; }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
            {
                return true;
            }

            var item = obj as MoviesReportItem;
            return item != null
                && ActorNames.Equals(item.ActorNames)
                && CategoryName.Equals(item.CategoryName)
                && NumberOfActors.Equals(item.NumberOfActors)
                && Title.Equals(item.Title)
                && YearOfProduction.Equals(item.YearOfProduction);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}