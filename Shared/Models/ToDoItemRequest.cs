using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorPlanner.Shared.Models
{
    public class ToDoItemRequest
    {
        public string Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        public string PlanId { get; set; }
    }
}
