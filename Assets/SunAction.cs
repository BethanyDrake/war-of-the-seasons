﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunAction : Action
{
    // Start is called before the first frame update
    void Start()
    {

    }


    public SpriteRenderer[] renderers;
    float cooldown = 2;
    bool firing = false;
    float timeSinceFired = 0;

    float fireTime = 0.5f;

    // Update is called once per frame
    void Update()
    {

        if (firing) {
            timeSinceFired += Time.deltaTime;
        }

        if (!firing && Input.GetButtonDown("Fire")) {
            firing = true;
            timeSinceFired = 0;
            foreach (SpriteRenderer sp in renderers){
                sp.enabled = true;
            }

        }

        if (firing && timeSinceFired > fireTime) {
            foreach (SpriteRenderer sp in renderers){
                sp.enabled = false;
            }
        }
        if (firing && timeSinceFired > cooldown) {
            firing = false;
        }

    }

    public override void Stop() {
        //disable aura
    }
}
