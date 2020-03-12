using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dentist : MonoBehaviour
{
    public bool m_alive = true;
    
    [SerializeField]
    GameObject m_AIParent;

    [SerializeField]
    GameObject m_ragdollToSpawn;
    

    public void killDentist()
    {
        if (m_alive)
        {
            m_AIParent = transform.parent.gameObject;
            // make it ragdoll
            transform.parent = null;
            Destroy(m_AIParent);

            // spawn a dead dentist 
            Instantiate(m_ragdollToSpawn, transform.position, transform.rotation);
            //Destroy self 
            Destroy(gameObject);
        }
    }
}
