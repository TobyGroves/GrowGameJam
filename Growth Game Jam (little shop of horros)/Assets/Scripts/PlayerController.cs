using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float m_movementSpeed;

    [SerializeField]
    float m_horizontalSensitivity, m_verticalSensitivity;


    [SerializeField]
    Transform m_head;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*transform.position += transform.forward * Input.GetAxis("Vertical") * m_movementSpeed * Time.deltaTime;
        transform.position += transform.right * Input.GetAxis("Horizontal") * m_movementSpeed * Time.deltaTime;
        transform.eulerAngles += transform.up * Input.GetAxis("Mouse X") * m_horizontalSensitivity * Time.deltaTime;
        m_head.transform.eulerAngles -= Vector3.right * Input.GetAxis("Mouse Y") * m_verticalSensitivity * Time.deltaTime;*/
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Dentist"))
        {
            other.transform.parent = transform;
        }
    }

}