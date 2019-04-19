using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biker : MonoBehaviour {

    private Animator anim;

	void Start () {
        anim = GetComponent<Animator>();
	}
	
	void Update () {
        float v = Input.GetAxisRaw("Vertical");
        anim.SetFloat("Vertical", v);
        //transform.Translate(Vector3.forward * v * Time.deltaTime * 4);
	}
}
