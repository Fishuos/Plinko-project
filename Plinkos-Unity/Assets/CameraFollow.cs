using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public Camera camera;
    public GameObject player;
    public GameObject disc;
    public float lerpRate = 0.5f;
    void Update()
    {
        Vector3 targetPosition;

        if (disc == null)
        {
            targetPosition = player.transform.position;

        }
        else
        {
            targetPosition = disc.transform.position;
        }
        targetPosition.x = 0;
        targetPosition.z = camera.transform.position.z;

        //assign cam pos part way from current position
        camera.transform.position = Vector3.Lerp(camera.transform.position,targetPosition,lerpRate);
    }
    public void FollowDisc(GameObject disc)
    {
        this.disc = disc;
    }
}
