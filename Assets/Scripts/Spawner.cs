using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _character;
    [SerializeField] private int _characterCount;
    private int _minValue = -5;
    private int _maxValue = 5;
    private int _xPosition;
    private int _zPosition;
    private int _yPosition = 0;

    void Start()
    {
        StartCoroutine(Scatter());
    }

    private IEnumerator Scatter()
    {
        while(_characterCount > 0)
        {
            _xPosition = Random.Range(_minValue, _maxValue);
            _zPosition = Random.Range(_minValue, _maxValue);
            Instantiate(_character, new Vector3(_xPosition, _yPosition, _zPosition), Quaternion.identity);
            yield return new WaitForSeconds(2f);
            _characterCount--;
        }
    }
}
