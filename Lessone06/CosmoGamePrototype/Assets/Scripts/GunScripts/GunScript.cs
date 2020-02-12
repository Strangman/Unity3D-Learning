using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] private float _fireRate;
    [SerializeField] private float _maxFirerate;
    [SerializeField] private int _damage;
    [SerializeField] private GameObject _bullet;
    private const LoadKey _soundLoadKey = LoadKey.Sound;
    private const LoadKey _loadkey = LoadKey.Damage;
    private float _fireRateCounter;

    private void Awake()
    {
        _damage = PlayerPrefs.GetInt(_loadkey.ToString());
        bool soundState = PlayerPrefs.GetInt(_soundLoadKey.ToString()) == 0 ? true : false;
        gameObject.GetComponent<AudioSource>().mute = !soundState;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _fireRateCounter += Time.deltaTime;

        if(_fireRateCounter >= _fireRate)
        {
            Shot();
            _fireRateCounter = 0;
        }
    }
    public void Shot()
    {
        var gunpoSition = transform.position;
        _bullet.GetComponent<BulletScript>().BulletShot(_damage, gunpoSition);
        AudioManager.Instance.PlaySoundFx(SoundFxType.Shot);
    }
    public void ChageFiraRate(float boost)
    {
        if (_fireRate > _maxFirerate)
        {
            _fireRate -= boost;
            Mathf.Clamp(_fireRate, _maxFirerate, 2);
        }
    }
}
