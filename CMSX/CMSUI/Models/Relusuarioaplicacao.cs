using System;
using System.Collections.Generic;

namespace CMSUI.Models;

public partial class Relusuarioaplicacao
{
    public Guid Relacaoid { get; set; }

    public Guid? Aplicacaoid { get; set; }

    public Guid? Usuarioid { get; set; }
}
