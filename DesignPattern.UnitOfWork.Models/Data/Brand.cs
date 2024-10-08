﻿using System;
using System.Collections.Generic;

namespace DesignPattern.UnitOfWork.Models.Data;

public partial class Brand
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Beer> Beers { get; set; } = new List<Beer>();
}
