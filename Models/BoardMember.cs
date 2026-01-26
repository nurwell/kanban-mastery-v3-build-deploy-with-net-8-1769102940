namespace KanbanApi.Models
{
    public class BoardMember
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public string UserId { get; set; }
        public string Role { get; set; }
        public Board Board { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
