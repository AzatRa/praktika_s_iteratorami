using System.Collections;
using UnityEngine;

public class RedefineMoverTime : MonoBehaviour
{
    [Header("Положение объекта")]
    [SerializeField] private Vector3 _startPosition = new Vector3(-2.5f, 0, 0);
    [SerializeField] private Vector3 _endPosition = new Vector3(2.5f, 0, 0);
    [Tooltip("Количество шагов движения")]
    [SerializeField] private int _stepsCount = 10;
    [Tooltip("Длительность движения в секундах")]
    [SerializeField] private float _duration = 1.0f;

    private void Start()
    {
        StartCoroutine(MoveObject());
    }

    private IEnumerator MoveObject()
    {
        Vector3 distance = _endPosition - _startPosition;
        Vector3 stepValue = distance / _stepsCount; // Шаг перемещения

        for (int step = 0; step <= _stepsCount; step++)
        {
            transform.position = _startPosition + stepValue * step; // Обновляем позицию
            yield return new WaitForSecondsRealtime(_duration / _stepsCount); // Задержка между шагами
        }
    }
}
