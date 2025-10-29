using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Button_Teleporter : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private Button _button;
    private int _randomHorizontalPosition;
    private int _randomVerticalPosition;

    public void OnPointerEnter(PointerEventData eventData)
    {
        _randomHorizontalPosition = Random.Range(-850, 850);
        _randomVerticalPosition = Random.Range(-480, 480);
        print($"X: {_randomHorizontalPosition}, Y: {_randomVerticalPosition}");
        _button.transform.localPosition = new Vector3(_randomHorizontalPosition, _randomVerticalPosition);
        print($"Position: {_button.transform.position}");
    }
}
