using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button_ApriFinestra : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Canvas _canvas;
    [SerializeField] private TextMeshProUGUI _text;

    void OnEnable()
    {
        _button.onClick.AddListener(ApriFinestra);
    }

    void ApriFinestra()
    {
        _text.gameObject.SetActive(false);
        _canvas.gameObject.SetActive(true);
    }
}
