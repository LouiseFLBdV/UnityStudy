using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed;
    public bool isMoving;
    public List<GameObject> wayPoints;
    
    private int _wayPoint;
    
    
    void Start()
    {
        if (speed ==0)
        {
            speed = 1;
        }

        isMoving = true;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (!isMoving) return;
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[_wayPoint].transform.position, speed/100);
        transform.Rotate(1,0.5f,0.3f);
        
        if (transform.position == wayPoints[_wayPoint].transform.position)
        {
            _wayPoint++;
            if (_wayPoint > wayPoints.Count - 1)
            {
                _wayPoint = 0;
            }
        }
    }
}
