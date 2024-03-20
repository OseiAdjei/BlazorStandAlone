

using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //One to Many Relationship
        [JsonIgnore]
        public List<Employee> Employees { get; set; }


    }
}
