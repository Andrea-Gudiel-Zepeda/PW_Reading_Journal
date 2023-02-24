using System;
using System.Collections.Generic;

namespace Reading_Journal.Models;

public partial class Calificacion
{
    public int IdCalificacion { get; set; }

    public int LimiteInferior { get; set; }

    public int LimiteSuperior { get; set; }

    public int IdUser { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
