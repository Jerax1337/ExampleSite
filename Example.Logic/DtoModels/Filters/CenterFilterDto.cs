using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Logic.DtoModels.Filters
{
    public sealed record CenterFilterDto
    {
        public string Code { get; init; }
    }
}
