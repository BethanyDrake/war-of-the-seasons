using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var y = Input.GetAxis("Vertical");
        var x = Input.GetAxis("Horizontal");
        var direction = Vector3.Normalize(new Vector3(x, y, 0));
        transform.position += direction * speed * Time.deltaTime;
    }
}
