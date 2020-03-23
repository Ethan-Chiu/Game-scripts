using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

   
    public Transform cam;
    public float speed = 5f;
 
    public float jump = 10f;
    public Rigidbody player;
    public float maxspeed = 15f;
    public float rate = 2f;
    Vector3 rot;
  
	// Use this for initialization

	// Update is called once per frame
	void FixedUpdate () {
        //offset.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //offset.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        if (Input.GetKeyDown("space") )
        {
            
            player.AddForce(0,jump*Time.deltaTime,0);

        }
       
		//transform.position = transform.position + offset;

        //speed up
        if(Input.GetMouseButton(1)&&speed<maxspeed)
        {
            speed += Time.deltaTime * rate;
        }
        else if (speed > 5)
        {
            speed -= Time.deltaTime * rate;
        }
        if (speed < 5)
            speed = 5;


        rot.x = 0;
        rot.y = cam.eulerAngles.y;
        rot.z = 0;
        transform.eulerAngles = rot;


       
	}        
}
