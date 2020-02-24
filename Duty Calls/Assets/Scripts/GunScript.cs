using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunScript : MonoBehaviour
{
    public int damage = 10;
    public float range = 100f;

    public Camera playerCamera;
    public ParticleSystem mazleFlash;
    public GameObject hitParticle;

    public Text bolletText;
    public int boolet = 7;

    private void Awake()
    {
        SetBolletText(boolet);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    private void Fire()
    {
        if(boolet >0)
        {
            boolet--;

            SetBolletText(boolet);

            mazleFlash.Play();

            var ray = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, range))
            {
                if (hit.transform.TryGetComponent<TargetScript>(out TargetScript target))
                {
                    target.TakeDamage(damage);
                }
            }

            var particle = Instantiate(hitParticle, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(particle, 1f);
        }
    }
    private void SetBolletText(int takeBoolet)
    {
        bolletText.text = $"{takeBoolet}";
    }
}
