using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool right;

    // Start is called before the first frame update
    void Start()
    {
        if (!right)
        {
            transform.Rotate(Vector3.back * 180);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed);
    }

    //add the OnTriggerEnter2D
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        DirectionNode dn = other.GetComponent<DirectionNode>();
        Debug.Log(dn.current);

        //check direction
        float rot = 0;
        Vector3 dir = Vector3.zero;
        if (dn.current == "right")
        {
            dir = Vector3.back;
            rot = 90;
        }
        else if (dn.current == "left")
        {
            dir = Vector3.forward;
            rot = 90;
        }

        transform.Rotate(dir * rot);
        //back is right, forward is left
    }
}
