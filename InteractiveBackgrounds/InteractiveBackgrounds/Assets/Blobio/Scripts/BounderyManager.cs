using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blobio
{
    public class BounderyManager : MonoBehaviour
    {
        [SerializeField] private EdgeCollider2D m_Edge;

        [SerializeField] private GameObject m_ColliderLeft;
        [SerializeField] private GameObject m_ColliderRight;

        private Camera m_Cam;

        private float m_Width;
        private float m_Height;

        private void Awake()
        {
            m_Cam = Camera.main;
        }

        private void Start()
        {
            FindBounderies();
            SetBounds();
        }

        private void SetBounds()
        {
            Vector2 pointA = new Vector2(m_Width / 2, m_Height / 2);
            Vector2 pointB = new Vector2(m_Width / 2, -m_Height / 2);
            m_ColliderLeft.transform.position = new Vector3(pointB.x, m_ColliderLeft.transform.position.y, pointB.y);
            Vector2 pointC = new Vector2(-m_Width / 2, -m_Height / 2);
            m_ColliderRight.transform.position = new Vector3(pointC.x, m_ColliderRight.transform.position.y, pointC.y);
            Vector2 pointD = new Vector2(-m_Width / 2, m_Height / 2);

            Vector2[] tempPoints = new Vector2[] { pointA, pointB, pointC, pointD, pointA };
            m_Edge.points = tempPoints;
        }

        private void FindBounderies()
        {
            m_Width = 1 / (m_Cam.WorldToViewportPoint(new Vector3(1, 1, 0)).x - .5f);
            m_Height = 1 / (m_Cam.WorldToViewportPoint(new Vector3(1, 1, 0)).y - .5f);
        }
    }
}