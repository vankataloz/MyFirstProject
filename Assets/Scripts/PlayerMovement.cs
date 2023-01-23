using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Тук избираме компонента, на който ще добавим движение в случая Rigidbodyр който ще наречем rb.
    public Rigidbody rb;

    //Добавяме променливи за скороста на движение, които може да редактираме после в Unity
    public float forwardForce = 2000f;
    public float sidewaysMove = 500f;
    //Вместо Update сменяме на FixedUpdate за да върви по-гладко. Update означава че действа на фрейм не при самия старт на играта.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  // Добавяме сила напред.
        // Какво да се случва, като натиснем буквата D на клавиатурата - движение по оста Х
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // Какво да се случва, като натиснем буквата A на клавиатурата - движение обратно по оста Х, понеже имаме - 
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
