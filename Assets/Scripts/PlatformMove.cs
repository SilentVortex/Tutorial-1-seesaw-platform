using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{

    [SerializeField] float moveDistance = 5.0f; 
    [SerializeField] float moveSpeed = 2.0f;
    private Vector3 targetPosition;
    private bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            targetPosition = new Vector3(transform.position.x, transform.position.y + moveDistance, transform.position.z);
            moving = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
                if (moving)
                {
                    transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
                    if (transform.position == targetPosition)
                    {
                        moving = false;
                    }
                }
    }
}
