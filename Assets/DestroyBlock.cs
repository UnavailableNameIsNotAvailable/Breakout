using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    [SerializeField]
    GameObject blocket;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (blocket.transform.position.y < -5)
        {
            BoxCollider bc = GetComponent<BoxCollider>();
            bc.enabled = true;

            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.enabled = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "boll")
        {
         BoxCollider bc =   GetComponent<BoxCollider>();
            bc.enabled = false;

            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.enabled = false;

        }
    }
}
