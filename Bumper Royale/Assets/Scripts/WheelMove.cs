using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelMove : MonoBehaviour {

    public float speed = 500f;

	void Update () {
        float move = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(0, move * speed * Time.deltaTime, 0));
    }
}
