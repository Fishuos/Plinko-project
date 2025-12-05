using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
     private void OnCollisionEnter2D(Collision2D collision)
     {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("touchy");


        }
     }
     private void OnCollisionExit2D(Collision2D collision)
     {
        
     }
     private void OnCollisionStay2D(Collision2D collision)
     {
        
     }
}
