using System.Text;

public class Variant2Config : IConfig
{
    public void Setup(StringBuilder sb)
    {
        sb.AppendLine(nameof(Variant2Config));
    }
}
