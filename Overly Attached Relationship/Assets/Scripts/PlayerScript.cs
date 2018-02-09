using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    [SerializeField]
    private float fSpeed = 5.0f; //Player's speed.

    private Rigidbody2D rb2d;



	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float m_fXAxis = Input.GetAxis("Horizontal");
        float m_fYAxis = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(m_fXAxis, m_fYAxis) * Time.deltaTime * fSpeed);
	}
}
