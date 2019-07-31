using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
   public float speed = 20f;
   public Rigidbody2D rb;
   public bool isPinned = false;

   void Update ()
   {
       if(!isPinned)
       rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
       
   }

   void OnTriggerEnter2D (Collider2D col)
   {
       if (col.tag == "Rotator")
       {
           transform.SetParent(col.transform);
           Score.PinCount++;
           col.GetComponent<Rotator>().speed *= -1;
           isPinned = true;
       } else if (col.tag == "Pin")
       {
            FindObjectOfType<GameManager>().EndGame();
       }
   }
}
