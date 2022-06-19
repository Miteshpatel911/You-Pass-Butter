using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem vortex;
    
    public void PortalVortex()
    {
        vortex.Play();
    }
}
