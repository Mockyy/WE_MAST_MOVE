using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PropSlot : MonoBehaviour
{
    [SerializeField]
    private string prop;

    public bool completed = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.name == prop)
        {
            completed = true;

            other.transform.parent = null;
            other.transform.position = transform.position;

            GetComponent<ParticleSystem>().Stop();

            other.gameObject.tag = "Done";
            other.GetComponent<Rigidbody>().isKinematic = true;

            GetComponent<MeshRenderer>().enabled = false;
            Destroy(transform.GetChild(0).gameObject);
            
        }
    }
}
