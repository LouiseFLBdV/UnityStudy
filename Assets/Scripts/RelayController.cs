using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RelayController : MonoBehaviour
{
    public List<GameObject> runners = new List<GameObject>();
    public float speed;
    private float passDistance;
    private int _runnerId;

    private void Start()
    {
        if (passDistance == 0)
        {
            passDistance = 1.5f;
        }

        if (speed == 0)
        {
            speed = 1;
        }
    }

    private void Update()
    {
        if (_runnerId + 1 < runners.Count)
        {
            if (Vector3.Distance(runners[_runnerId].transform.position, runners[_runnerId + 1].transform.position) >
                passDistance)
            {
                runners[_runnerId].transform.position = Vector3.MoveTowards(runners[_runnerId].transform.position,
                    runners[_runnerId + 1].transform.position,
                    speed / 10);
            }
            else
            {
                _runnerId++;
            }
        }
        else
        {
            if (Vector3.Distance(runners[_runnerId].transform.position, runners[0].transform.position) >
                passDistance)
            {
                runners[_runnerId].transform.position = Vector3.MoveTowards(runners[_runnerId].transform.position,
                    runners[0].transform.position, speed / 10);
            }
            else
            {
                _runnerId = 0;
            }
        }
    }
}