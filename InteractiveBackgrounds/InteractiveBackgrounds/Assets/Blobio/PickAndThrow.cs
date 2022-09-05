using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blobio
{
    [RequireComponent(typeof(Rigidbody))]
    public class PickAndThrow : MonoBehaviour
    {
        private Rigidbody m_Rigid;
        private Camera m_Cam;

        private void Start()
        {
            m_Rigid = GetComponent<Rigidbody>();
            m_Cam = Camera.main;
        }

        private void OnMouseDrag()
        {
            Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_Cam.WorldToScreenPoint(transform.position).z);
            Vector3 newWorldPosition = m_Cam.ScreenToWorldPoint(screenPosition);

            transform.position = newWorldPosition;
        }

        private void OnMouseDown()
        {
        }

        private void OnMouseUp()
        {
        }

        private void SetGravity(bool on)
        {
            m_Rigid.useGravity = on;
        }
    }
}
