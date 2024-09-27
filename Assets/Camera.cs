using UnityEngine;

public class Camera : MonoBehaviour
{
    public float sensitivity = 2.0f; // 마우스 감도
    public float verticalRotationLimit = 80.0f; // 수직 회전 제한

    private float rotationY = 0.0f;

    private void Update()
    {
        // 마우스 움직임 가져오기
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // 수직 회전 계산
        rotationY -= mouseY;
        rotationY = Mathf.Clamp(rotationY, -verticalRotationLimit, verticalRotationLimit);

        // 카메라 회전 적용
        transform.localRotation = Quaternion.Euler(rotationY, transform.localEulerAngles.y + mouseX, 0);
    }
}
