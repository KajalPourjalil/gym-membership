using System.ComponentModel.DataAnnotations;

namespace gym_membership.Models
{
    public class TrainingLevel
    {
        [Key]
        public int TrainingLevelId { get; set; }
        public string TrainingLevelName { get; set; }
        public virtual ICollection<GymTrainee> GymTrainees { get; set; }
    }
}