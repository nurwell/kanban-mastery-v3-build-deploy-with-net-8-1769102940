using System;
using System.Collections.Generic;

namespace KanbanApi.Models
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }
        public ICollection<Column> Columns { get; set; } = new List<Column>();
        public ICollection<BoardMember> BoardMembers { get; set; } = new List<BoardMember>();
    }
}
