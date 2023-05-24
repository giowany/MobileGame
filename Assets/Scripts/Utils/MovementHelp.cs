using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHelp : MonoBehaviour
{
    public List<Transform> positions;
    public float duration = 1f;
    public float range = 5f;

    private int _index;


    private void Start()
    {
        _index = Random.Range(0, positions.Count);
        transform.position = positions[_index].position;
        duration = Random.Range(1, range);
        StartCoroutine(Movement());
        
    }

    private void ResetIndex()
    {
        _index++;
        if (_index >= positions.Count) _index = 0;
    }

    IEnumerator Movement()
    {
        float time = 0;

        while (true)
        {
            var currantPosition = transform.position;

            while(time < duration)
            {
                transform.position = Vector3.Lerp(currantPosition, positions[_index].transform.position, time / duration);
                time += Time.deltaTime;
                yield return null;

            }

            ResetIndex();
            time = 0;

            yield return null;
        }
    }
}
