using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button_StampaEChiudi : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Canvas _canvas;
    [SerializeField] private TextMeshProUGUI _text;

    void OnEnable()
    {
        _button.onClick.AddListener(StampaEChiudiFinestra);
    }

    void StampaEChiudiFinestra()
    {
        Stampa();
        ChiudiFinestra();
    }

    void Stampa()
    {
        _text.gameObject.SetActive(true);
        _text.text = "Adios";
    }

    void ChiudiFinestra()
    {
        _canvas.gameObject.SetActive(false);
    }
}
