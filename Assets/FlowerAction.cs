using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerAction : Action
{
    public ParticleSystem particalSystem;
    // Start is called before the first frame update
    void Start()
    {
        particalSystem.gameObject.active = true;
        particalSystem.Stop();
    }

    // Update is called once per frame

    float cooldown = 1;
    bool firing = false;
    float timeSinceFired = 0;
    public override void  Stop() {
        particalSystem.Stop();
    }
    void Update()
    {

        if (firing) {
            timeSinceFired += Time.deltaTime;
        }
        if (!firing && Input.GetButtonDown("Fire")) {
            firing = true;
            timeSinceFired = 0;
            particalSystem.Play();
        }
        if (firing && timeSinceFired > cooldown) {
            firing = false;
            particalSystem.Stop();
        }
    }
}
