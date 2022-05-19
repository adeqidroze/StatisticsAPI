namespace Statistics.Core.Entities
{
    public class CountryEntity : BaseEntity

    {
        public CountryEntity()
        {
            this.TeamsCountries = new List<TeamsEntity>();
        }
        public string CountryName { get; set; }

        public ICollection<TeamsEntity>? TeamsCountries { get; set; }
    }
}
