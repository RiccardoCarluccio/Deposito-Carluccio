using UnityEngine;
using UnityEngine.UI;

public class Button_ScaleEnabler : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Slider _slider;

    private void OnEnable()
    {
        _button.onClick.AddListener(EnableOrDisable);
    }

    private void EnableOrDisable()
    {
        if (_slider.interactable)
            _slider.interactable = false;
        else
            _slider.interactable = true;
    }
}
