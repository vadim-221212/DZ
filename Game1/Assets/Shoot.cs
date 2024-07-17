using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject arrowPrefab;
    public Transform arrowLocation;
    public float shotPower;
    public AudioSource ShootSound;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Instantiate(arrowPrefab , arrowLocation.position,arrowLocation.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * shotPower);
            ShootSound.Play();
        }
    }
}
