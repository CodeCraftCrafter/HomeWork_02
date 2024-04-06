using UnityEngine;

public class Person : MonoBehaviour
{
    [SerializeField]
    new private string name;
    public string Name
    {
        get { return name; }
    }

    [SerializeField]
    private int life = 100;
    public int Life
    {
        get { return life; }
        set
        {
            if (value < 0)
            {
                Debug.Log("RIP");
                life = 0;
            }
            else if (value < life)
            {
                Debug.Log($"Life decreased to {value}.");
                life = value;
            }
            else
            {
                life = value;
            }
        }
    }

    public void ChangeLife(int change)
    {
        Life += change;
    }
}