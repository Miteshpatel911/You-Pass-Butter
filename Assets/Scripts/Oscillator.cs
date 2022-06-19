using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startingPosition;
    float movementFactor;

    [SerializeField] Vector3 movementVector;
    [SerializeField] float period = 2f;

    void Start()
    {
        startingPosition = transform.position;
    }

  
    void Update()
    {
        if(period <= Mathf.Epsilon) { return;  }
        float cycles = Time.time / period; // continually growing with time
        const float tau = Mathf.PI * 2; //Constant Value of 2pi
        float sineWave = Mathf.Sin(cycles * tau); //Going from -1 to 1

        movementFactor = (sineWave + 1) / 2f; //Recalculating value to 0 to 1

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
    }
}
