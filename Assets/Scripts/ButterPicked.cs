using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterPicked : MonoBehaviour
{
    GameManagement gameManagement;
    void Start()
    {
        gameManagement = GetComponent<GameManagement>();
    }

    
    void Update()
    {
        
    }
    /*void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.transform)
        {
            Debug.Log("PICKED");
            gameManagement.ActivePlate();
        }
    }*/
}
