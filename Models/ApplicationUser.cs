using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace KanbanApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<BoardMember> BoardMembers { get; set; } = new List<BoardMember>();
    }
}
