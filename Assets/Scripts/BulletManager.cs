using UnityEngine;

public class BulletManager : MonoBehaviour
{
    float timer = 3f;

    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * 5);

        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = 3f;
            gameObject.SetActive(false);    // Instead of destroying the object, we set it inactive so it returns to the pool
        }
    }
}
