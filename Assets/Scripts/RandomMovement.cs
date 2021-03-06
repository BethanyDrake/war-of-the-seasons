﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour {
    // Start is called before the first frame update

    int GetRandom() {
        return Random.Range(-1, 2);
    }
    void Start () {
        x = GetRandom();
        y = GetRandom();
    }

    int x = 0;
    int y = 0;
    // Update is called once per frame
    float timeSinceLastMoved = 0;
    float timeUntilMove = 1;
    float speed = 5;

    void BounceIfNecessary () {
        Vector3 screenPos = Camera.main.WorldToScreenPoint (this.transform.position);
        if (screenPos.x < 0) x = 1;
        if (screenPos.y < 0) y = 1;
        if (screenPos.x > Screen.width) x = -1;
        if (screenPos.y > Screen.height) y = -1;
    }

    void ChangeDirection() {
        x = GetRandom();
        y = GetRandom();
        if (x == 0 && y == 0) {
            ChangeDirection();
        }
    }
    void Update () {
        var direction = Vector3.Normalize (new Vector3 (x, y, 0));
        transform.position += direction * speed * Time.deltaTime;

        timeSinceLastMoved += Time.deltaTime;
        if (timeSinceLastMoved > timeUntilMove) {
            ChangeDirection();
            timeSinceLastMoved = 0;
        }
        BounceIfNecessary ();
    }
}