using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{ public float dönüþhýzý=10;
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
            transform.Translate(Vector3.forward * dönüþhýzý * Time.deltaTime);
		}
        else if (Input.GetKey("s"))
		{
            transform.Translate(Vector3.back * dönüþhýzý * Time.deltaTime);
		}
        else if (Input.GetKey("d"))
		{
			transform.Translate(Vector3.right * dönüþhýzý * Time.deltaTime);

		}
        else if (Input.GetKey("a"))
		{
            transform.Translate(Vector3.left * dönüþhýzý * Time.deltaTime);
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
