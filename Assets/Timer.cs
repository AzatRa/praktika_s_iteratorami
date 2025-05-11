using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private float _repeatRate = 0.5f;

    private void Start()
    {
        _text.text = "0";
        InvokeRepeating(nameof(SetCurrentTime), _delay, _repeatRate);
    }

    private void SetCurrentTime()
    {
        _text.text = Time.time.ToString("");
    }
}
