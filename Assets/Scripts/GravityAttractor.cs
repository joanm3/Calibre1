using UnityEngine;
using System.Collections;

public class GravityAttractor : MonoBehaviour {

    public float gravity = -10f;
    public Transform transformAttractor; 

    public void Attract(Transform body)
    {
        if (transformAttractor == null)
            transformAttractor = this.transform; 

        Vector3 targetDir = (body.position - transformAttractor.position).normalized;
        Vector3 bodyUp = body.up;

        body.rotation = Quaternion.FromToRotation(bodyUp, targetDir) * body.rotation;
        body.GetComponent<Rigidbody>().AddForce(targetDir * gravity);  
    }
}
