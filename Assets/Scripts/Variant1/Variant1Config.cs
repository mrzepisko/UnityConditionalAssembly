using System.Text;

public class Variant1Config : IConfig
{
    public void Setup(StringBuilder sb)
    {
        sb.AppendLine(nameof(Variant1Config));
    }
}
