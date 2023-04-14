using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemExhaust : MonoBehaviour
{
    ParticleSystem particleSystem;
    ParticleSystem.MainModule particleMain;
    ParticleSystem.EmissionModule particleEmission;
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleMain = particleSystem.main;
        particleEmission = particleSystem.emission;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {                     
            particleEmission.rateOverTime = 200;      
            particleMain.startSize = 0.2f;
        }
        else
        {            
            particleEmission.rateOverTime = 100;
            particleMain.startSize = 0.1f;
        }
    }
}
