using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public float _speed = 3;
	
    // Start is called before the first frame update
    void Start()
    {

	transform.position = Vector3.zero;
        
    }

    // Update is called once per frame
    void Update()
    {

	Move();
        
    }

	void Move(){

	float horizontal = Input.GetAxis("Horizontal");
	float vertical = Input.GetAxis("Vertical");
	
	transform.Translate(Vector3.right * horizontal * _speed * Time.deltaTime);
	transform.Translate(Vector3.up * vertical * _speed * Time.deltaTime);
	

	if(transform.position.x > 8.9f){
		transform.position = new Vector3(-8.9f ,transform.position.y , 0);
	}
	else if (transform.position.x < -8.9f){
 		transform.position = new Vector3(8.9f ,transform.position.y , 0);
	}

	if(transform.position.y > 0 ){
		transform.position = new Vector3(transform.position.x , 0 , 0);
	}
	
	else if(transform.position.y < -4f ){
		transform.position = new Vector3(transform.position.x ,-4f , 0);
	}

	}