using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Shoot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] float damage;
    [SerializeField] float count;

    private float totalDamage; 

    public void K()
    {

     
        Debug.Log("K!!");



    }

    public void Damage(float damage)
    {
        this.damage += damage;

        Debug.Log("Damage"+this.damage);

        if (this.damage>=100)
        {
            this.damage = 0.0f;
            Debug.Log("K");
        }
       

    }

    public void Shootcount(int count)
    {
        this.count += count;
        Debug.Log("count" + this.count);
        if (this.count>=10)
        {
            this.count = 0;
            Debug.Log("suppressive fire!!");
        }
    }


}
