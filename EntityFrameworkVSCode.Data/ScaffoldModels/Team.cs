using System;
using System.Collections.Generic;

namespace EntityFrameworkVSCode.Data.ScaffoldModels;

public partial class Team
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime CreatedDate { get; set; }
}
