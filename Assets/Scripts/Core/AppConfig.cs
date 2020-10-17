using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AppConfig : IConfig
{
    private readonly IConfig[] m_Configs;

    public AppConfig()
    {
        var type = typeof(IConfig);
        var types = System.AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => type.IsAssignableFrom(p))
            .Where(t => t.IsClass)
            .Where(t => !t.IsAbstract)
            .Where(t => t != typeof(AppConfig))
            ;
        List<IConfig> instances = new List<IConfig>();
        foreach (var t in types)
        {
            var instance = Activator.CreateInstance(t) as IConfig;
            instances.Add(instance);
        }
        m_Configs = instances.ToArray();
    }

    public void Setup(StringBuilder sb)
    {
        sb.AppendLine(nameof(AppConfig));
        foreach (var cfg in m_Configs)
        {
            cfg.Setup(sb);
        }
    }
}
