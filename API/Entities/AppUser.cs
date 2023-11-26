using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
using Microsoft.AspNetCore.Routing.Tree;

namespace API.Entities
{

    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}

