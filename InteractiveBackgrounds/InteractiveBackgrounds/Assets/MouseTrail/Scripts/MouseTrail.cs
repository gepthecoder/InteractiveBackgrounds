using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using G3P.Utils;

public class MouseTrail : MonoBehaviour
{
    [SerializeField] private ParticleSystem m_ClickEffect;

    private Vector3 m_MousePos;
    private Vector3 m_MousePos2;
    private void FixedUpdate()
    {
        m_MousePos = Helper.GetMouseWorldPosition();
        m_MousePos2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("GetMouseWorldPosition" + m_MousePos);
        Debug.Log("m_MousePos2" + m_MousePos2);
        GameObject vfx = Instantiate(m_ClickEffect.gameObject, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        float duration = vfx.GetComponent<ParticleSystem>().main.duration;
        Destroy(vfx, duration + 0.3f);
    }
}
