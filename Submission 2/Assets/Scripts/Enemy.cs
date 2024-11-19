using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRb;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.AddForce(LookDirection() * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Hole"))
        {
            Destroy(other.gameObject);
        }
        
        if (SpawnManager.gameObjects.Count > 0)
        {
            SpawnManager.gameObjects.Remove(other.gameObject);
            LookDirection();
        }
        else
        {
            Debug.Log("Game over");
        }
    }

    //abstract the direction of motion
    private Vector3 LookDirection()
    {
        int index = Random.Range(0, SpawnManager.gameObjects.Count);
        Vector3 lookDirection = (SpawnManager.gameObjects[index].transform.position - transform.position).normalized;
        return lookDirection;
    }
}
