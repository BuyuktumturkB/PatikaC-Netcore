using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{ public float d�n��h�z�=10;
    public GameObject player;
    // Start is called before   prthe first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
		{
            transform.Translate(Vector3.forward * d�n��h�z� * Time.deltaTime);
		}
        else if (Input.GetKey("s"))
		{
            transform.Translate(Vector3.back * d�n��h�z� * Time.deltaTime);
		}
        else if (Input.GetKey("d"))
		{
			transform.Translate(Vector3.right * d�n��h�z� * Time.deltaTime);

		}
        else if (Input.GetKey("a"))
		{
            transform.Translate(Vector3.left * d�n��h�z� * Time.deltaTime);
		}
    }
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Lav")
		{
            player.SetActive(false);
		}
	}
}
