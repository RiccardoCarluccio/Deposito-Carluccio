using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button_ChiudiFinestra : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Canvas _canvas;
    [SerializeField] private TextMeshProUGUI _text;

    void OnEnable()
    {
        _button.onClick.AddListener(ChiudiFinestra);
    }

    void ChiudiFinestra()
    {
        _text.gameObject.SetActive(false);
        _canvas.gameObject.SetActive(false);
    }
}
