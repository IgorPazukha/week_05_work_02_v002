using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    [SerializeField] private int _objectCount;
    private int _minValue = -5;
    private int _maxValue = 5;
    private int _xPosition;
    private int _zPosition;

    void Start()
    {
        StartCoroutine(Scatter());
    }

    private IEnumerator Scatter()
    {
        while (_objectCount > 0)
        {
            _xPosition = Random.Range(_minValue, _maxValue);
            _zPosition = Random.Range(_minValue, _maxValue);
            Instantiate(_object, new Vector2(_xPosition, _zPosition), Quaternion.identity);
            yield return new WaitForSeconds(2f);
            _objectCount--;
        }
    }
}
