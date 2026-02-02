using System;
using System.Collections.Generic;

namespace KanbanApi.Models
{
    public class Column
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Position { get; set; }
        public int BoardId { get; set; }
        public Board Board { get; set; }
        public ICollection<Card> Cards { get; set; } = new List<Card>();
    }
}
