using System.ComponentModel.DataAnnotations;

namespace gym_membership.Models
{
    public class BloodGroup
    {
        [Key]
        public int BloodGroupId {get; set;}
        public string BloodGroupName {get; set;}
        public virtual ICollection<GymTrainee> GymTrainees {get; set;}
    }
}