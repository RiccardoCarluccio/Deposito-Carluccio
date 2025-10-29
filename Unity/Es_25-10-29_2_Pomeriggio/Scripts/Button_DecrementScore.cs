using UnityEngine;
using UnityEngine.UI;

public class Button_DecrementScore : MonoBehaviour
{
    [SerializeField] private Button _button;

    void OnEnable()
    {
        _button.onClick.AddListener(() => CallDecrementScore());
    }

    void CallDecrementScore()
    {
        GameManager_Es_3.Instance.DecrementScore();
    }
}
