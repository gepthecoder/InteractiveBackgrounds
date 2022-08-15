using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody m_Rigidbody;
    private float m_CoolDown = 5f;
    private float m_Time;
    
    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        m_Time += Time.deltaTime;

        if(m_Time <= m_CoolDown)
        {
            m_Rigidbody.AddForce(Random.insideUnitCircle.normalized * 55, ForceMode.Impulse);
            m_Time = 0;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        int r = Random.Range(3,25);
        transform.localScale = new Vector3(r, r, r);
    }
}
