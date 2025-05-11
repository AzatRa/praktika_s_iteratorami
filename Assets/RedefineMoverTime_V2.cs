using System.Collections;
using UnityEngine;

public class RedefineMoverTime : MonoBehaviour
{
    [Header("Положение объекта")]
    [SerializeField] private Vector3 _startPosition = new Vector3(-2.5f, 0, 0);
    [SerializeField] private Vector3 _endPosition = new Vector3(2.5f, 0, 0);
    [Tooltip("Длительность движения в секундах")]
    [SerializeField] private float _duration = 1.0f;

    private void Start()
    {
        StartCoroutine(MoveObject());
    }

    private IEnumerator MoveObject()
    {
        float elapsedTime = 0f;

        while (elapsedTime < _duration)
        {
            float t = elapsedTime / _duration; // Нормализованное время от 0 до 1
            transform.position = Vector3.Lerp(_startPosition, _endPosition, t); // Линейная интерполяция
            elapsedTime += Time.deltaTime; // Увеличиваем прошедшее время
            yield return null; // Ждем следующего кадра
        }
    }
}
