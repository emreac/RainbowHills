using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    private Vector3 positionDisplacement;
    private Vector3 positionOrigin;
    private float _timePassed;
    private void Start()
    {
        float randomDistance = Random.Range(-6f, 6f);
        positionDisplacement = new Vector3(0F, 0f, randomDistance);
        positionOrigin = transform.position;
    }

    private void Update()
    {
        _timePassed += Time.deltaTime;
        transform.position = Vector3.Lerp(positionOrigin ,positionOrigin + positionDisplacement ,
           Mathf.PingPong(_timePassed, 1));
    }
}
//y value
//positionOrigin + positionDisplacement