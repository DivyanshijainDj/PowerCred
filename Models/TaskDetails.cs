using System;
using System.ComponentModel.DataAnnotations;

namespace PowerCred.Models
{
    public class TaskDetails
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public string Priority { get; set; } // e.g., Low, Medium, High

        [Required]
        public DateTime DueDate { get; set; }

        public string AssignedUser { get; set; } // Username of the assigned user

        [Required]
        public string Status { get; set; } // e.g., Pending, Completed
    }
}
