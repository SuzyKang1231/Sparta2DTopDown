using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Rigidbody2D rigidbody;
    // private������ �ν����� ǥ��
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2D ĳ��
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // �����Ӹ��� Input Manager���� Vertical��� Horizontal���� �Է� �޾ƿ�
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");  // �ٷιٷ� ���ߵ��� Raw ����

        // ������ normalized�� �ϸ� ������ ���̸� 1��
        // vertical, horizontal ��� 1�� ���, direction�� ũ��� 1���� ũ�� �� �� �ִµ�, �̸� 1�� ������
        Vector2 direction = new Vector2(horizontal, vertical);
        direction = direction.normalized;

        // rigidbody.velocity - �ش� ��ü�� 1�ʴ� �����̴� �Ÿ�
        rigidbody.velocity = direction * speed;
    }
}
