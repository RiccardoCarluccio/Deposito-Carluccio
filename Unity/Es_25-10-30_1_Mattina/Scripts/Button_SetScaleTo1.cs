using UnityEngine;
using UnityEngine.UI;

public class Button_SetScaleTo1 : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Slider _slider;

    private void OnEnable()
    {
        _button.onClick.AddListener(SetScaleTo1);
    }

    private void SetScaleTo1()
    {

        _slider.value = 1;
    }
}
