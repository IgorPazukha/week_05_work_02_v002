using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int _objectCount;
    [SerializeField] private Enemy _enemy;

    private int _minValue = -5;
    private int _maxValue = 5;
    private int _xPosition;
    private int _zPosition;

    private void Start()
    {
        StartCoroutine(Scatter());
    }

    private IEnumerator Scatter()
    {
        int waitSecond = 2;
        var waitTime = new WaitForSeconds(waitSecond);

        while (_objectCount > 0)
        {
            _xPosition = Random.Range(_minValue, _maxValue);
            _zPosition = Random.Range(_minValue, _maxValue);
            Instantiate(_enemy, new Vector2(_xPosition, _zPosition), Quaternion.identity);

            _objectCount--;

            yield return waitTime;
        }
    }
}
