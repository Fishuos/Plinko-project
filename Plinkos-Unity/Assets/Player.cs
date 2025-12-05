using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Player : MonoBehaviour
{
    public float speed = 1;
    public GameObject disc;
    public CameraFollow cameraFollow;
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

        if (Input.GetButtonDown("Fire1") && activeDisc == null)
        {
            Vector3 position = transform.position;
            Quaternion rotation = transform.rotation;
            activeDisc = Instantiate(disc, position, rotation);

                
        }
        
    }

    void Move()
    {
        float movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 offset = new Vector3(movementX, 0, 0);
        transform.position += offset;
    }


}


