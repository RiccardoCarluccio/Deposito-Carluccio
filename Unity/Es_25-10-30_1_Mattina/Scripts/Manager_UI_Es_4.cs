using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Manager_UI_Es_4 : MonoBehaviour
{
    private static Manager_UI_Es_4 _instance;
    public static Manager_UI_Es_4 Instance { get { return _instance; } }

    [SerializeField] private Slider _sliderText;
    [SerializeField] private TextMeshProUGUI _textSliderValue;

    [SerializeField] private Slider _sliderLight;
    [SerializeField] private Light _light;
    [SerializeField] private TextMeshProUGUI _textLightIntensity;

    [SerializeField] private Slider _sliderScale;
    [SerializeField] private GameObject _cube;
    [SerializeField] private TextMeshProUGUI _textSliderScale;

    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }

    private void Update()
    {
        _textSliderValue.text = $"Valore: {_sliderText.value}";

        _light.intensity = _sliderLight.value;
        _textLightIntensity.text = $"Intensità: {_sliderLight.value:F2}";

        _cube.transform.localScale = Vector3.one * _sliderScale.value;
        _textSliderScale.text = $"Scala: {_sliderScale.value:F2}";
    }    
}
