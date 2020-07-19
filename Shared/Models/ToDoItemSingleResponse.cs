using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPlanner.Shared.Models
{
    public class ToDoItemSingleResponse : BaseAPIResponse
    {
        public ToDoItem Record { get; set; }
    }
}
