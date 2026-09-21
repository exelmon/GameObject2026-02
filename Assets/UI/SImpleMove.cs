using UnityEngine;

public class SImpleMove : MonoBehaviour
{
    public float speed = 5.0f;
 
    private void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        transform.Translate(vec * speed* Time.deltaTime);
    }
}
