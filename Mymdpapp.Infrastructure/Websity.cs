using System;
using System.Collections.Generic;

namespace Mymdpapp.Infrastructure;

public partial class Websity
{
    public int Id { get; set; }

    public string Website { get; set; } = null!;

    public string? Password { get; set; }
}
