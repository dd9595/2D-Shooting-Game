using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PositionScroller : MonoBehaviour
{
    [SerializeField]
    private Transform target;                           // Ÿ��
    [SerializeField]
    private float scrollRange = 9.9f;                   // ��ũ�� ����
    [SerializeField]
    private float moveSpeed = 3.0f;                     // �ӵ�
    [SerializeField]
    private Vector3 moveDirection = Vector3.down;       // ���Ⱚ

    


    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        if ( transform.position.y <= -scrollRange )
        {
            transform.position = target.position + Vector3.up * scrollRange;
        }
    }
}
