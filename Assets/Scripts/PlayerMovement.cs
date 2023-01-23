using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //��� �������� ����������, �� ����� �� ������� �������� � ������ Rigidbody� ����� �� ������� rb.
    public Rigidbody rb;

    //�������� ���������� �� �������� �� ��������, ����� ���� �� ����������� ����� � Unity
    public float forwardForce = 2000f;
    public float sidewaysMove = 500f;
    //������ Update ������� �� FixedUpdate �� �� ����� ��-������. Update �������� �� ������� �� ����� �� ��� ����� ����� �� ������.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  // �������� ���� ������.
        // ����� �� �� ������, ���� �������� ������� D �� ������������ - �������� �� ���� �
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // ����� �� �� ������, ���� �������� ������� A �� ������������ - �������� ������� �� ���� �, ������ ����� - 
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
