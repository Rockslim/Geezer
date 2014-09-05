using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	float movementSpeed = 1.0f;
	float rotationSpeed = 100.0f;
	
	void Update()
	{
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
		float movement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
		
		transform.Translate(0.0f, movement, 0.0f);
		transform.Rotate(0.0f, 0.0f, -rotation);
	}
}