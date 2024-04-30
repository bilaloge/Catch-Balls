using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        if(transform.position.x < -17)
        {
            transform.position = new Vector3(-17, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 17)
        {
            transform.position = new Vector3(17, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            
        }
    }
}
