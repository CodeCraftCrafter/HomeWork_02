using UnityEngine;

public class Players : Person
{
    [SerializeField]
    private float speed = 5.0f; // Скорость движения игрока
    [SerializeField]
    private int experience = 0; // Опыт игрока
    public int Experience
    {
        get { return experience; }
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
    }

    // Модифицированный метод TakeDamage с параметром gainExp
    public override void TakeDamage(int damageValue, bool gainExp = true)
    {
        Life -= damageValue;

        if (gainExp)
        {
            GainExperience(10); // Награда опытом за получение урона
        }

        Debug.Log($"Player took {damageValue} damage, remaining Life: {Life}, Experience: {experience}");
    }

    private void GainExperience(int xp)
    {
        experience += xp;
        Debug.Log($"Gained {xp} experience points. Total XP: {experience}");
    }

    public override void ShowStat()
    {
        Debug.Log($"Name: {Name}, Experience: {experience}, Life: {Life}");
    }
}