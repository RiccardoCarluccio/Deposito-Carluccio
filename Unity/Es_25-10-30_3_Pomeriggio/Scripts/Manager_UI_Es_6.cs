using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Manager_UI_Es_6 : MonoBehaviour
{
    private static Manager_UI_Es_6 _instance;
    public static Manager_UI_Es_6 Instance { get { return _instance; } }

    [Header("Cambio Colori")]
    [SerializeField] private TMP_Dropdown _dropdownColori;
    [SerializeField] private Image _backgroundColor;

    [Header("Cambio Difficoltà")]
    [SerializeField] private TMP_Dropdown _dropdownDifficolta;
    [SerializeField] private TextMeshProUGUI _textDifficolta;

    [Header("Opzioni Dinamiche")]
    [SerializeField] private TMP_Dropdown _dropdownDinamico;
    [SerializeField] private Image _characterBackground;
    [SerializeField] private Sprite _charDefault;
    [SerializeField] private Sprite _char1;
    [SerializeField] private Sprite _char2;
    [SerializeField] private Sprite _char3;

    private List<string> _options = new() { "Nessuno", "Sora", "Donald", "Goofy" };
    private List<Sprite> _characterSprites;

    private void Awake()
    {
        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }

    private void OnEnable()
    {
        _dropdownColori.onValueChanged.AddListener(ChangeColor);
        _dropdownDifficolta.onValueChanged.AddListener(ChangeDifficulty);

        _dropdownDinamico.ClearOptions();
        _dropdownDinamico.AddOptions(_options);
        _dropdownDinamico.onValueChanged.AddListener(ChangeCharacter);

        _characterSprites = new() { _charDefault, _char1, _char2, _char3 };
    }

    private void ChangeColor(int index)
    {
        switch (index)
        {
            case 0:
                _backgroundColor.color = Color.grey;
                break;

            case 1:
                _backgroundColor.color = new Color32(157, 0, 0, 255);
                break;

            case 2:
                _backgroundColor.color = new Color32(17, 165, 0, 255);
                break;

            case 3:
                _backgroundColor.color = new Color32(0, 36, 153, 255);
                break;
        }
    }

    private void ChangeDifficulty(int index)
    {
        switch (index)
        {
            case 0:
                _textDifficolta.text = "Difficoltà:";
                break;

            case 1:
                _textDifficolta.text = "Difficoltà: Facile";
                break;

            case 2:
                _textDifficolta.text = "Difficoltà: Medio";
                break;

            case 3:
                _textDifficolta.text = "Difficoltà: Difficile";
                break;
        }
    }

    private void ChangeCharacter(int index)
    {
        _characterBackground.sprite = _characterSprites[index];
    }
}
