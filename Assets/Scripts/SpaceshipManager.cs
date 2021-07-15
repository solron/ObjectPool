using UnityEngine;

public class SpaceshipManager : MonoBehaviour
{
    //public GameObject bullet;

    float Speed = 5.0f;

    private void Start()
    {
        InvokeRepeating("FireBullet", 1f, 0.25f);
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * Speed, 0, 0));
    }

    void FireBullet()
    {
        // Instead of Instantiate, run this code
        GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            bullet.SetActive(true);
        }
    }
}
