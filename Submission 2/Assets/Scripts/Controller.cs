using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private float speed = 10.0f;
    private Rigidbody rb;
    [SerializeField] private GameObject cropPrefab;

    public float MoveSpeed
    {
        get { return speed; }
        set
        {
            if (value <= 0)
            {
                Debug.LogError("Not allowed a negative value");
            }
            else
            {
                speed = value;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    protected void Move()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float sideInput = Input.GetAxis("Horizontal");

        rb.AddForce(Vector3.forward * forwardInput * speed);
        rb.AddForce(Vector3.right * sideInput * speed);
    }

    protected void Move(Vector3 position,Rigidbody rb)
    {
        rb.AddForce(position * speed * Time.deltaTime);
    }
    
    protected void Move(Vector3 position,Rigidbody rb, float sp)
    {
        rb.AddForce(position * sp * Time.deltaTime);
    }

    protected void Plant()
    {
        Instantiate(cropPrefab, transform.position, cropPrefab.transform.rotation);
    }
}
