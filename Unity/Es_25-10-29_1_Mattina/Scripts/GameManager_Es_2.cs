using TMPro;
using UnityEngine;

public class GameManager_Es_2 : MonoBehaviour
{
    private static GameManager_Es_2 _instance;
    public static GameManager_Es_2 Instance { get { return _instance; } }

    private float _timer = 0;
    private float _lastTime = 0;
    private bool _startTimer = false;
    [SerializeField] private TextMeshProUGUI _timerText;
    [SerializeField] private TextMeshProUGUI _lastTimeText;
    [SerializeField] private TextMeshProUGUI _congratulazioni;
    [SerializeField] private TextMeshProUGUI _newRecord;
    private float _textTimer = 0;
    private bool _isTextTimerActive = false;
    private float _timeAfterTextDisappears = 5f;

    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }

    void Update()
    {
        if (_startTimer)
        {
            _timer += Time.deltaTime;
            _timerText.text = $"{_timer:F2}";
        }
        else
            _timerText.text = "Time";

        if (_isTextTimerActive)
        {
            _textTimer += Time.deltaTime;
        }

        if (_timeAfterTextDisappears < _textTimer)
        {
            _congratulazioni.gameObject.SetActive(false);
            _newRecord.gameObject.SetActive(false);
        }
    }

    public void StartTimer()
    {
        _startTimer = true;
    }

    public void StopTimer()
    {
        _startTimer = false;
        _textTimer = 0;

        _congratulazioni.gameObject.SetActive(true);
        _congratulazioni.text = "Congratulazioni!";
        _isTextTimerActive = true;

        if (_timer < _lastTime || _lastTime == 0)
        {
            _newRecord.text = $"Hai fatto un nuovo record, migliorando il tuo tempo precedente di: {_lastTime - _timer:F2}";
            _newRecord.gameObject.SetActive(true);
            _isTextTimerActive = true;
            _lastTimeText.text = $"{_timer:F2}";
            _lastTime = _timer;
        }
        _timer = 0;
    }

    public void EraseTimer()
    {
        _startTimer = false;
        _timer = 0;
    }

    public bool IsTimeStarted()
    {
        return _startTimer;
    }
}
