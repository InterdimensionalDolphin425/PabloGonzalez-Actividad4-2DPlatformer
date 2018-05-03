using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour {

    float speed = 0.1f;
    int coins = 0;
    int hearts = 0;
    int stars = 0;

    public Text contadorCoins;
    public Text contadorHearts;
    public Text contadorStars;

    // Use this for initialization
    void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {


        if (coll.gameObject.tag == "Coins")
        {

            coins = coins + 1;

            contadorCoins.text = coins.ToString();

            print("Coins");

            GameObject.Destroy(coll.gameObject);



        }

        if (coll.gameObject.tag == "Hearts")
        {

            hearts = hearts + 1;

            contadorHearts.text = hearts.ToString();

            print("Hearts");

            GameObject.Destroy(coll.gameObject);



        }

        if (coll.gameObject.tag == "Star")
        {

            stars = stars + 1;

            contadorStars.text = stars.ToString();

            print("Stars");

            GameObject.Destroy(coll.gameObject);



        }

    }


    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.RightArrow))
        {

            this.gameObject.transform.Translate(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            this.gameObject.transform.Translate(-speed, 0, 0);
        }

        //salto

        if (Input.GetKeyDown(KeyCode.Space))
        {

            this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 30, ForceMode2D.Impulse);

        }

    }
}
