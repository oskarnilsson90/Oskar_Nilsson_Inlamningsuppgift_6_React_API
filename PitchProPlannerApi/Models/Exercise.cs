using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PitchProPlannerApi.Models
{
    // Enum för olika övningstyper
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExerciseCategory
    {
        Matches,
        Attacking,
        Defending,
        Possession,
        Technique,
        Passing,
        Shooting,
        Goalkeeper,
        Conditioning
    }
    public class Exercise
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public required string Title { get; set; }

        [EnumDataType(typeof(ExerciseCategory), ErrorMessage = "The value must be 0 = Matches, 1 = Attacking, 2 = Defending, 3 = Possession, 4 = Technique, 5 = Passing, 6 = Shooting, 7 = Goalkeeper, 8 = Conditioning")]
        public ExerciseCategory Category { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public required string Description { get; set; }

        [Required(ErrorMessage = "Number of players for Team 1 is required.")]
        [Range(0, 50, ErrorMessage = "Number of players must be between 0 and 50.")]
        public int PlayersTeam1 { get; set; }

        [Required(ErrorMessage = "Number of players for Team 2 is required.")]
        [Range(0, 50, ErrorMessage = "Number of players must be between 0 and 50.")]
        public int PlayersTeam2 { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "Number of goalkeepers must be between 0 and 10.")]
        public int GoalKeepers { get; set; }

        [Required]
        [Range(0, 200, ErrorMessage = "TouchLine must be between 0 and 200 meters.")]
        public int TouchLine { get; set; }

        [Required]
        [Range(0, 150, ErrorMessage = "GoalLine must be between 0 and 150.")]
        public int GoalLine { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "Number of goals must be between 0 and 10.")]
        public int Goals { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Number of cones must be between 0 and 100.")]
        public int Cones { get; set; }
    }
}
