using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourKeyMove : MonoBehaviour {

    public float moveDistance;
    public float delay = 0.25f;
    public bool isActive = false;   // Make sure to set this to true for the starting character and false for the second character.

    private float delta;

    // Use this for initialization
    void Start () {
        delta = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            ToggleActive();
        }
        if (Time.time >= delta && isActive)
        {
            Vector3 vec3 = this.transform.position;
            if (Input.GetKey("s"))
            {
                if (vec3.y - moveDistance > -4f)
                {
                    vec3.y -= moveDistance;
                    delta = Time.time + delay;
                }
            }
            if (Input.GetKey("w"))
            {
                if (vec3.y + moveDistance < 4f)
                {
                    vec3.y += moveDistance;
                    delta = Time.time + delay;
                }
            }
            if (Input.GetKey("a"))
            {
                if (vec3.x - moveDistance > -8f)
                {
                    vec3.x -= moveDistance;
                    delta = Time.time + delay;
                }
            }
            if (Input.GetKey("d"))
            {
                if (vec3.x + moveDistance < 8f)
                {
                    vec3.x += moveDistance;
                    delta = Time.time + delay;
                }
            }
            this.transform.position = vec3;
        }
    }

    void ToggleActive()
    {
        isActive = !isActive;
    }
}
