using UnityEngine;

public class Crate : MonoBehaviour
{
    public string type;   // which fruit this crate wants: apple, banana, pineapple, orange

    void OnCollisionEnter(Collision collision)
    {
        // check if the thing that hit us is a fruit
        Fruit fruit = collision.gameObject.GetComponent<Fruit>();
        if (fruit != null)
        {
            if (fruit.type == type)
            {
                GameManager.instance.AddScore(1);   // correct fruit
            }
            else
            {
                GameManager.instance.AddScore(-1);  // wrong fruit
            }

            Destroy(collision.gameObject);   // remove the fruit after it lands
        }
    }
}