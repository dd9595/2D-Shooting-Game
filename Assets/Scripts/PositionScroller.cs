using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PositionScroller : MonoBehaviour
{
    [SerializeField]
    private Transform target;                           // 타겟
    [SerializeField]
    private float scrollRange = 9.9f;                   // 스크롤 범위
    [SerializeField]
    private float moveSpeed = 3.0f;                     // 속도
    [SerializeField]
    private Vector3 moveDirection = Vector3.down;       // 방향값

    


    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        if ( transform.position.y <= -scrollRange )
        {
            transform.position = target.position + Vector3.up * scrollRange;
        }
    }
}
