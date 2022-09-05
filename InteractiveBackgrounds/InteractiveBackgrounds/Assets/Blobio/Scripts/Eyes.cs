using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    [SerializeField] private float m_RotationSpeed;

    private Camera m_Cam;

    private float m_EyeAngleX;
    private float m_EyeAngleY;

    private void Start()
    {
        m_Cam = Camera.main;
    }


    public void Update()
    {
        RotateEye();
    }

    private void RotateEye()
    {
        m_EyeAngleX += Input.GetAxis("Mouse X") * m_RotationSpeed * -Time.deltaTime;
        m_EyeAngleX = Mathf.Clamp(m_EyeAngleX, -47, 47);

        m_EyeAngleY += Input.GetAxis("Mouse Y") * m_RotationSpeed * -Time.deltaTime;
        m_EyeAngleY = Mathf.Clamp(m_EyeAngleY, -23, 23);

        transform.localRotation = Quaternion.Euler(m_EyeAngleY, 0, m_EyeAngleX);
    }
}
