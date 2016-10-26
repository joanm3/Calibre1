using UnityEngine;
using System.Collections;

public class Mecanism : MonoBehaviour
{

    public enum Axis { x, y, z };

    public Axis rotationAxis = Axis.y;

    public Color onTriggerEnterColor = Color.blue;
    public float rotationVelocity = 2f;
    private Color startColor;
    private Material material;
    private bool editingActivate = false;

    // Use this for initialization
    void Start()
    {
        material = GetComponentInChildren<MeshRenderer>().material;
        startColor = material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (editingActivate)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                switch (rotationAxis)
                {
                    case Axis.x:
                        transform.eulerAngles += new Vector3(rotationVelocity * Time.deltaTime, 0f, 0f);
                        break;
                    case Axis.y:
                        transform.eulerAngles += new Vector3(0f, rotationVelocity * Time.deltaTime, 0f);
                        break;
                    case Axis.z:
                        transform.eulerAngles += new Vector3(0f, 0f, rotationVelocity * Time.deltaTime);
                        break;
                }
            }
            if (Input.GetKey(KeyCode.E))
            {
                switch (rotationAxis)
                {
                    case Axis.x:
                        transform.eulerAngles -= new Vector3(rotationVelocity * Time.deltaTime, 0f, 0f);
                        break;
                    case Axis.y:
                        transform.eulerAngles -= new Vector3(0f, rotationVelocity * Time.deltaTime, 0f);
                        break;
                    case Axis.z:
                        transform.eulerAngles -= new Vector3(0f, 0f, rotationVelocity * Time.deltaTime);
                        break;
                }
            }
        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            material.color = onTriggerEnterColor;
            editingActivate = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            material.color = startColor;
            editingActivate = false;
        }
    }


}
