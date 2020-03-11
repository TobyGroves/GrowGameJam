using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dentist : MonoBehaviour
{
    public bool m_alive = true;



    public void killDentist()
    {

        // make it ragdoll

        m_alive = false;


    }
}
