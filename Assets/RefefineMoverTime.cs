using System.Collections;
using UnityEngine;

public class RedefineMoverTime : MonoBehaviour
{
    [Header("��������� �������")]
    [SerializeField] private Vector3 _startPosition = new Vector3(-2.5f, 0, 0);
    [SerializeField] private Vector3 _endPosition = new Vector3(2.5f, 0, 0);
    [Tooltip("���������� ����� ��������")]
    [SerializeField] private int _stepsCount = 10;
    [Tooltip("������������ �������� � ��������")]
    [SerializeField] private float _duration = 1.0f;

    private IEnumerator _enumerator;

    private void Start()
    {
        StartCoroutine(MoveObject());
    }

    private IEnumerator MoveObject()
    {
        Vector3 distance = _endPosition - _startPosition;
        Vector3 stepValue = distance / _stepsCount; // ��� �����������

        for (int step = 0; step <= _stepsCount; step++)
        {
            transform.position = _startPosition + stepValue * step; // ��������� �������
            yield return new WaitForSeconds(_duration / _stepsCount); // �������� ����� ������
        }
    }
}