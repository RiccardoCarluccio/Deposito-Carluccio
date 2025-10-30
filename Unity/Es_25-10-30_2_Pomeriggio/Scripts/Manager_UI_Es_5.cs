using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Manager_UI_Es_5 : MonoBehaviour
{
    private static Manager_UI_Es_5 _instance;
    public static Manager_UI_Es_5 Instance { get { return _instance; } }

    [Header("Info Panel")]
    [SerializeField] private Toggle _toggle;
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _text;

    [Header("Active Elements")]
    [SerializeField] private Image _toggableImage;
    [SerializeField] private TextMeshProUGUI _toggableText;
    [SerializeField] private Button _toggableButton;
    [SerializeField] private TextMeshProUGUI _activeText;

    private void Awake()
    {
        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }

    private void OnEnable()
    {
        //print($"Tipo: {_toggableImage.GetType()}");
    }

    private void Update()
    {
        _text.text = $"Attivo: {_toggle.isOn}";

        if (_toggableImage.IsActive())
            _activeText.text = "Attivo: Immagine";
        else if (_toggableText.IsActive())
            _activeText.text = "Attivo: Testo";
        else if (_toggableButton.IsActive())
            _activeText.text = "Attivo: Pulsante";
        else
            _activeText.text = "Attivo: Niente";
    }
}
