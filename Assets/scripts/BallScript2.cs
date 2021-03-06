﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BallScript2 : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    private Camera camera;

    private Vector3 movement;
    private Vector3 cameraForward;

    public int count;

    public Text countText;
    public Text finish;

    public float Jump;
    // Start is called before the first frame update
    void Start()
    {
        finish.text = "";
         rb = GetComponent<Rigidbody>();
         camera = Camera.main;
        count = 0;
        countText.text = "Keys: " + count.ToString();
    }
  void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump")){
rb.velocity = new Vector3(0,Jump,0);
        }
        cameraForward = camera.transform.forward;
        cameraForward.y = 0;

        Quaternion cameraRelativeRotation = Quaternion.FromToRotation(Vector3.forward, cameraForward);
        Vector3 lookToward = cameraRelativeRotation * movement;

        

        if(movement.sqrMagnitude > 0){
            Ray lookRay = new Ray(transform.position, lookToward);
            transform.LookAt(lookRay.GetPoint(1));
        }
            
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        movement = new Vector3(x, 0, z);
        
        rb.AddForce(transform.forward * speed * movement.sqrMagnitude);
    }

       private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        count++;
        countText.text = "Keys: " + count.ToString();

        if (count == 82)
        {
            finish.text = "FIN";
        }
       
    }


    
}
