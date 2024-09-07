using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Storage.Models
{
	[Index(nameof(IsnCenter))]
	public class User
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public Guid IsnNode { get; set; }

		[ForeignKey(nameof(Center))]
		public Guid IsnCenter { get; set; }

		[Required, MaxLength(255)]
		public string SurName { get; set; }

		[Required, MaxLength(255)]
		public string Name { get; set; }

		[Required, MaxLength(255)]
		public string LastName { get; set; }

		public virtual Center Center { get; set; }
	}
}
