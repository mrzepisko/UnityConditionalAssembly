using System.Text;

public class Variant1NotVariant2Config : IConfig
{
    public void Setup(StringBuilder sb)
    {
        sb.AppendLine(nameof(Variant1NotVariant2Config));
    }
}
