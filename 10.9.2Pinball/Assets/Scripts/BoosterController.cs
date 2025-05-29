using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterController : MonoBehaviour
{
    [SerializeField] float radius = 0.5f;
    [SerializeField] LayerMask mask;
    [SerializeField] float force = 1f;
    [SerializeField] GameObject targetDirection;


    private void FixedUpdate()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, radius, mask);
        
        foreach (Collider coll in colls)
        {
            Rigidbody rb = coll.GetComponent<Rigidbody>();
            if (rb != null) {

                Vector3 direction = (targetDirection.transform.position - coll.transform.position).normalized;
                rb.AddForce(direction*force*Time.deltaTime, ForceMode.Impulse);
            
            }


        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, radius);

    }


}
