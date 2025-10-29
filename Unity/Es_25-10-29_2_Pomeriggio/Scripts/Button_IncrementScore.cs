using UnityEngine;
using UnityEngine.UI;

public class Button_IncrementScore : MonoBehaviour
{
    [SerializeField] private Button _button;

    void OnEnable()
    {
        _button.onClick.AddListener(() => CallIncrementScore());
    }

    void CallIncrementScore()
    {
        GameManager_Es_3.Instance.IncrementScore();
    }
}
