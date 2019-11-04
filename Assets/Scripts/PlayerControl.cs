using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private GameObject veh_Ute_Red_Z;
    public Vector3 offset = new Vector3(0, 5, -7);
    public float speed = 5.0f;
    private float turnspeed = 5.0f;
    public float horizontallinput;
    public float forwardInput;

    public float Turnspeed { get => turnspeed; set => turnspeed = value; }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontallinput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontallinput);

    }
}
