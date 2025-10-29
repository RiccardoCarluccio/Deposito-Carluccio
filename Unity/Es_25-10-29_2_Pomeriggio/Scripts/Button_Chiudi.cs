using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button_Chiudi : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Canvas _canvas;

    void OnEnable()
    {
        _button.onClick.AddListener(ChiudiFinestra);
    }

    void ChiudiFinestra()
    {
        _canvas.gameObject.SetActive(false);
    }
}
