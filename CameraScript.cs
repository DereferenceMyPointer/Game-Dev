using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 10f;
    public float snapSpeed = 0.7f;
    public BoxCollider2D activeBound;
    public BoxCollider2D cameraBox;

    private void Start()
    {
        cameraBox = GetComponentInChildren<BoxCollider2D>();
        SetBound();
    }

    private void SetBound()
    {
        switch ((int)Camera.main.aspect * 10)
        {
            case 17:
                cameraBox.size = new Vector2(25.47f, 14.3f);
                break;
        }
    }

    public void SetActiveBound(BoxCollider2D newBound)
    {
        activeBound = newBound;
        transform.position = Vector3.Lerp(transform.position, new Vector3(Mathf.Clamp(target.position.x, activeBound.bounds.min.x + cameraBox.size.x / 2, activeBound.bounds.max.x - cameraBox.size.x / 2),
                        Mathf.Clamp(target.position.y, activeBound.bounds.min.y + cameraBox.size.y / 2, activeBound.bounds.max.y - cameraBox.size.y / 2),
                        transform.position.z), snapSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target != null)
        {
            if (activeBound)
            {
                transform.position = Vector3.Lerp(transform.position, 
                    new Vector3(Mathf.Clamp(target.position.x, activeBound.bounds.min.x + cameraBox.size.x / 2, activeBound.bounds.max.x - cameraBox.size.x / 2), 
                        Mathf.Clamp(target.position.y, activeBound.bounds.min.y + cameraBox.size.y / 2, activeBound.bounds.max.y - cameraBox.size.y /2), 
                        transform.position.z), 
                    followSpeed);
            }
            else {
                transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, transform.position.y, transform.position.z), followSpeed);
            }
        }
    }
}
