using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.EventSystems;


public class Player : MonoBehaviour
{
    public float speed = 5;
    public float leftBoundry = -8f;
    public float rightBoundry = 8f;

    private int direction = 1;



    public GameObject selectedDisc; 
    private GameObject activeDisc;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

    // Update is called once per frame
    void Update()
    {
      


        Move();
        DropDisc();
     }

    void DropDisc()
    {

       
        //drops ball if avaialble
        if (Input.GetKeyDown(KeyCode.Space) && activeDisc == null && selectedDisc != null)
        {
            activeDisc = Instantiate(selectedDisc, transform.position, transform.rotation);
        }

    }
    
    // indicates which ball is spawning
    public void SelectNormalDisc(GameObject normalPrefab)
    {
        selectedDisc = normalPrefab;
    }

    public void SelectHeavyDisc(GameObject heavyPrefab)
    {
        selectedDisc = heavyPrefab;
    }

    public void SelectBouncyDisc(GameObject bouncyPrefab)
    {
        selectedDisc = bouncyPrefab;
    }


    //makes player move back and forth
    void Move()
    {
        transform.position += Vector3.right * speed * direction * Time.deltaTime;

        if (transform.position.x >= rightBoundry)
            direction = -1;
        else if (transform.position.x <= leftBoundry)
            direction = 1;
    }


}


