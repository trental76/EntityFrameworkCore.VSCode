using System;
using System.Collections.Generic;

namespace EntityFrameworkVSCode.Data.ScaffoldModels;

public partial class Coach
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
