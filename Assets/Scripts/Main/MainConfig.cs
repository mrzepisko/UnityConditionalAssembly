using System.Collections;
using System.Text;

public class MainConfig : IConfig
{
    public void Setup(StringBuilder sb)
    {
        sb.AppendLine(nameof(MainConfig));
    }
}
