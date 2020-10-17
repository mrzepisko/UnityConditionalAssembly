using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class StartApp : MonoBehaviour
{
    [SerializeField] private Text m_Label;

    private void Awake()
    {
        IConfig config = new AppConfig();
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("StartApp.Awake");
        config.Setup(sb);
        sb.AppendLine("/StartApp.Awake");

        m_Label.text = sb.ToString();
    }
}
