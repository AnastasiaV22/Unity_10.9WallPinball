using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    [SerializeField] float force;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.layer == LayerMask.NameToLayer("Balls") && collision.rigidbody != null)
        {
            Vector3 direction = (collision.transform.position - transform.position).normalized;
            collision.rigidbody.AddForce(direction * force, ForceMode.Impulse);
        }
    }


}
