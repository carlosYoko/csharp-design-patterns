using System;
using System.Collections.Generic;

namespace DesignPattern.UnitOfWork.Models.Data;

public partial class Beer
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Style { get; set; } = null!;

    public Guid BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
