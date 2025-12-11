using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.EventSystems;


public class Player : MonoBehaviour
{
    public float speed = 1;
    public GameObject selectedDisc; 
    private GameObject activeDisc;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Move();
        DropDisc();
    }

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

    void Move()
    {
        //moves the triangle, indicating where the ball will spawn
        float movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 offset = new Vector3(movementX, 0, 0);
        transform.position += offset;
    }


}


