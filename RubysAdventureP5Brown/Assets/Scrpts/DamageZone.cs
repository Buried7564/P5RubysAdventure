using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
   void OnTriggerStay2D(Collider2D other)
    {
        RubyController Controller = other.GetComponent<RubyController>();

        if (Controller != null)
        {
            Controller.ChangeHealth(-1);
        }
    }
}
