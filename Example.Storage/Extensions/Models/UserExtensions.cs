using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Storage.Models;

namespace Example.Storage.Extensions.Models
{
    public static class UserExtensions
    {
        public static string GetFio(this User user)
        {
            return string.Join(" ", (new string[] {
                user.SurName,
                user.Name,
                user.LastName
            }).Where(x => !string.IsNullOrEmpty(x)));
        }
    }
}
