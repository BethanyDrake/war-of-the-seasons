using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomAction : Action {
    // Start is called before the first frame update
    void Start () {

    }

    public SpriteRenderer[] renderers;

    float cooldown = 1;
    bool firing = false;
    float timeSinceFired = 0;

    // Update is called once per frame
    void Update () {

        if (firing) {
            timeSinceFired += Time.deltaTime;
        }
        if (!firing && Input.GetButtonDown ("Fire")) {
            firing = true;
            timeSinceFired = 0;
            foreach (SpriteRenderer sp in renderers) {
                sp.enabled = false;
            }

        }
        if (firing && timeSinceFired > cooldown) {
            firing = false;
            Appear ();
        }

    }

    void Appear () {
        foreach (SpriteRenderer sp in renderers) {
            sp.enabled = true;
        }
    }

    public override void Stop () {
        Appear ();
    }
}