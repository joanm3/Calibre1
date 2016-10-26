using UnityEngine;
using System.Collections;

public class GravityAttractorTransform : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            return;

        float yPos = player.position.y;
        yPos = Mathf.Clamp(yPos, -6f, 8f);

        float xPos = player.position.x;
        xPos = Mathf.Clamp(xPos, -15f, 15f); 

        //if (player.position.y < 1f || player.position.y > 6f)
        //{
            transform.position = new Vector3(0f, yPos, transform.position.z);
        //}
        //else
        //{
        //    transform.position = new Vector3(xPos, 3f, transform.position.z);

        //}

    }
}
