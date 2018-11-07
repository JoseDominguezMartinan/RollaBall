using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	
	public float speed; //con esta variable almacenaremos la velocidad y sera editable desde unity
	public Text countText;
	public Text winText;

	private Rigidbody rbt; 
	private int count;
	
	void Start () { // start se ejecuta en el momento el que iniciamos la aplicacion 
	rbt = GetComponent<Rigidbody>();
	count=0;
	SetCountText();
	winText.text="";
	}	
	
	void FixedUpdate () { // fixed update se ejecuta en cada frame

		float moveHorizontal=Input.GetAxis("Horizontal"); 
		float moveVertical=Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);

		rbt.AddForce(movement*speed);
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("PickUp")){
			other.gameObject.SetActive(false);
			count=count+1;
			SetCountText();
		}
	}
	void SetCountText(){
		countText.text="Puntos: "+count.ToString();
		if(count>=11)
		{
			winText.text="HAS GANADO";
			//SceneManager.LoadScene("Menu");
		}
	}
	
}

