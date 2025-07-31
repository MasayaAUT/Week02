using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int hp;

    public void TakeDamage()
    {
        hp -= 1;
        if(hp <= 0)
        {
            Debug.Log("Enemy Dead");
        }
    }

    public void Heal()
    {
        hp += 1;
    }
}
