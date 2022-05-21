using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField] float Speed = 4;

    List<GameObject> bullet_pool = new List<GameObject>();

    float angle;
    float timebullet = 0.75f;
    float timebulletnow;

    // Start is called before the first frame update
    void Start()
    {
        timebulletnow = timebullet;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {

        if (Input.GetAxisRaw("Vertical") == 1)
        {
            this.transform.position += Vector3.up * Speed * Time.deltaTime;
            angle = 0;
        }
        else if (Input.GetAxisRaw("Vertical") == -1)
        {
            this.transform.position += Vector3.down * Speed * Time.deltaTime;
            angle = 180;
        }
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            this.transform.position += Vector3.left * Speed * Time.deltaTime;
            angle = 90;
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            this.transform.position += Vector3.right * Speed * Time.deltaTime;
            angle = -90;
        }
        this.transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
