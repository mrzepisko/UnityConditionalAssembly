using System.Text;

public class NotVariant1NotVariant2Config : IConfig
{
    public void Setup(StringBuilder sb)
    {
        sb.AppendLine(nameof(NotVariant1NotVariant2Config));
    }
}
