using UnityEngine;

public class Move_Car : MonoBehaviour
{
    public float speed = 2.0f; // �̵� �ӵ�

    private void Update()
    {
        // ������Ʈ�� ������ �̵�
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
