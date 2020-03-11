using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    bool m_nearDentist = false;
    bool m_nearAudry = false;
    bool m_holdingDentist = false;
    Transform m_destist;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dentist"))
        {
            Debug.Log("Got Dentist");
            m_nearDentist = true;
            m_destist = other.transform;
        }
        if (other.CompareTag("Audry"))
        {
            Debug.Log("near Audry");
            m_nearAudry = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Dentist"))
        {
            Debug.Log("lost Dentist");
            m_nearDentist = false;
            m_destist = null;
        }
    }


    private void Update()
    {
        
            if (Input.GetButton("interact"))
            {
            if (m_nearDentist)
            {
                // if dentist is not dead
                if (!m_holdingDentist)
                {
                    Debug.Log("Dragging Dentist");
                    m_destist.parent = transform;
                    m_holdingDentist = true;
                }
                else
                {
                    if(m_nearAudry)
                    {
                        m_destist.parent = null;
                    }
                }

            }

            if(Input.GetButtonDown("Fire1"))
            {
                if(m_nearDentist)
                {

                }
            }
        }
    }
}
