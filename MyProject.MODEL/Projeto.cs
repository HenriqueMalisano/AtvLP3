using System;
using System.Collections.Generic;

namespace MyProject.MODEL;

public partial class Projeto
{
    public int Id { get; set; }

    public string NomeDoProjeto { get; set; } = null!;

    public string NomeDoGerente { get; set; } = null!;

    public DateTime InicioProjeto { get; set; }

    public DateTime FinalProjeto { get; set; }

    public string ResumoProjeto { get; set; } = null!;

    public string StatusProjeto { get; set; } = null!;
}
