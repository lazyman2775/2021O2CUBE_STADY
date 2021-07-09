using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float turnSpeed = 10;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);

    }
}
