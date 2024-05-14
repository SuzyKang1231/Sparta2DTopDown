using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Rigidbody2D rigidbody;
    // private이지만 인스펙터 표출
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2D 캐싱
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 프레임마다 Input Manager에서 Vertical축과 Horizontal축의 입력 받아옴
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");  // 바로바로 멈추도록 Raw 붙임

        // 벡터의 normalized를 하면 벡터의 길이를 1로
        // vertical, horizontal 모두 1인 경우, direction의 크기는 1보다 크게 될 수 있는데, 이를 1로 맞춰줌
        Vector2 direction = new Vector2(horizontal, vertical);
        direction = direction.normalized;

        // rigidbody.velocity - 해당 물체가 1초당 움직이는 거리
        rigidbody.velocity = direction * speed;
    }
}
