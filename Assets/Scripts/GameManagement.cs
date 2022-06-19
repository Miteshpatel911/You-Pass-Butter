using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    [SerializeField] GameObject plate;
    void Start()
    {
        plate.SetActive(false);
    }

    
    void Update()
    {
      
    }
    public void ActivePlate()
    {
        plate.SetActive(true);
    }
}
