using UnityEngine;

public class Camera : MonoBehaviour
{
    public float sensitivity = 2.0f; // ���콺 ����
    public float verticalRotationLimit = 80.0f; // ���� ȸ�� ����

    private float rotationY = 0.0f;

    private void Update()
    {
        // ���콺 ������ ��������
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // ���� ȸ�� ���
        rotationY -= mouseY;
        rotationY = Mathf.Clamp(rotationY, -verticalRotationLimit, verticalRotationLimit);

        // ī�޶� ȸ�� ����
        transform.localRotation = Quaternion.Euler(rotationY, transform.localEulerAngles.y + mouseX, 0);
    }
}
