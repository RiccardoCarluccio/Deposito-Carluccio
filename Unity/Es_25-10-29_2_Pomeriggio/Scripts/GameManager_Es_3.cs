using TMPro;
using UnityEngine;

public class GameManager_Es_3 : MonoBehaviour
{
    private static GameManager_Es_3 _instance;
    public static GameManager_Es_3 Instance { get { return _instance; } }

    [SerializeField] private TextMeshProUGUI _scoreDisplay;
    private int _score = 0;

    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }

    void Update()
    {
        _scoreDisplay.text = _score.ToString();
    }

    public void IncrementScore()
    {
        _score++;
    }

    public void DecrementScore()
    {
        _score--;
    }
}
