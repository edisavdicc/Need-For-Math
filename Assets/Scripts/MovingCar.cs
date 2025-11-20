using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
    public float speed;
    private Rigidbody raceCar;

    void Start()
    {
        raceCar = GetComponent<Rigidbody>();
    }

    void Update()
    {
        raceCar.velocity = new Vector3(speed, 0, 0);
    }
}
