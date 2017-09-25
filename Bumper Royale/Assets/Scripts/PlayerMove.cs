using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float forwardSpeed = 50f;
    public float sideSpeed = 100f;

    private void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");
        
        transform.Translate(0, 0, yMove * forwardSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, xMove*sideSpeed*Time.deltaTime, 0));
    }

}
