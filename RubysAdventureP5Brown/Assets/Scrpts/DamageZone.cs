using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        RubyController Controller = other.GetComponent<RubyController>();

        if (Controller != null)
        {
            Controller.ChangeHealth(-1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
