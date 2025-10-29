using UnityEngine;
using UnityEngine.UI;

public class Button_SimpleInteraction : MonoBehaviour
{
    [SerializeField] private Button _button;

    void OnEnable()
    {
        _button.onClick.AddListener(() => Interazione());
    }
    void Interazione()
    {
        print("Pulsante premuto");
    }
}
