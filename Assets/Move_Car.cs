using UnityEngine;

public class Move_Car : MonoBehaviour
{
    public float speed = 2.0f; // 이동 속도

    private void Update()
    {
        // 오브젝트를 앞으로 이동
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
