using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerRigidbody;
    [SerializeField] float m_Speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float m_HorizontalMovement = Input.GetAxisRaw("Horizontal");
        float m_VerticalMovement = Input.GetAxisRaw("Vertical");

        playerRigidbody.velocity = new Vector2(m_HorizontalMovement * m_Speed, m_VerticalMovement * m_Speed);
    }
}
