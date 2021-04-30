using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor6.Client
{
public class ComponenteJSON
{
    public string Componente { get; set; }
    public IDictionary<string, object> Parametros { get; set; }
}

public class JSONComponent
{
    public string Component { get; set; }
    public IDictionary<string, object> Parameters { get; set; }
}
}
