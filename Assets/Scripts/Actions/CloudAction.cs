using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudAction : Action
{

    public ParticleSystem particalSystem;
    // Start is called before the first frame update
    void Start()
    {
         particalSystem.gameObject.active = true;
        particalSystem.Stop();
    }

    public override void Stop() {
        particalSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire")) {
            particalSystem.Play();

        }

         if (Input.GetButtonUp("Fire")) {
            particalSystem.Stop();

        }


    }
}
