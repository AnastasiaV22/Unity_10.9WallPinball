using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringTension : MonoBehaviour
{
    [SerializeField] float defaultStartTime = 5;
    [SerializeField] float targetY = 0;
    float nextStartTime;
    bool isShrinking;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isShrinking = false;   
        
    }

    void FixedUpdate()
    {
        if (isShrinking)
        {
            rb.isKinematic = true;
            transform.position += Vector3.down * Time.fixedDeltaTime;

            if (transform.position.y <= targetY)
            {
                rb.isKinematic = false;
                isShrinking = false;
            }
        }
        else
        {
            if (nextStartTime <= 0)
            {
                isShrinking = true;
                nextStartTime = defaultStartTime;

            }
            else
            {
                nextStartTime -= Time.fixedDeltaTime;
            }
        }
    }
}
