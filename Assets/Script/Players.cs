using UnityEngine;

public class Players : Person
{
    public float speed = 5.0f;

   
    void Start()
    {
        DisplayValues(); // начальные значения
    }

    
    void Update()
    {
        Vector3 moveDirection = Vector3.zero; 

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection += Vector3.right;
        }

        transform.position += moveDirection * speed * Time.deltaTime;

        // обновления состояния или вывода информации
    }

    // Name и Life в консоль
    void DisplayValues()
    {
        Debug.Log($"Name: {Name}, Life: {Life}");
    }
}