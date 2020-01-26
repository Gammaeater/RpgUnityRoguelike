using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class PlayerAttackmele : MonoBehaviour
{


    [SerializeField] private Text healtText;
    [SerializeField] private Text expirence;
    [SerializeField] private Text level;
    [SerializeField]
    public float TimeBetweenShots;
    public float timeSinceLastShot;
    public float _timePrefabSpawn;
    private float distance;
    public float _baseAtack;
    public float _playerRandomHit;
    public float _playerFullAttack;
    public Bat _batTarget;
    public Transform position;
    public GameObject popUpprefab;
    public PlayerIIMovment _player;
    public HealthSystem playerHealtShystem;
    public LevelSystem playerlevelSystem;
    public Transform MyTarget { get; set; }











    void FixedUpdate()
    {

        UpdateHealth();
        UpdateExpirience();


        distance = Vector3.Distance(_batTarget.transform.position, transform.position);

        if (distance < 1.5f && _batTarget.enemyHealtSystem.GetHealth() >= 1)
        {


            if (MyTarget != null && Time.time > timeSinceLastShot + TimeBetweenShots)
            {

               StartCoroutine(Dmg_Spawn());
                Attack(_playerFullAttack);



                













                timeSinceLastShot = Time.time;

            }

        }

    }

    public void Attack(float damage)
    {



        _playerRandomHit = (float)Random.Range(1, 5);
        _playerFullAttack = _baseAtack + _playerRandomHit;


        _batTarget.enemyHealtSystem.Damage(damage);
        Debug.Log("Ataaaaaaaaaaaaaaaakt");




    }

    IEnumerator Dmg_Spawn()
    {


        yield return new WaitForSeconds(0);
        GameObject FloatHp = Instantiate(popUpprefab, _player.transform.position, _player.transform.rotation);
    }

    public void UpdateHealth()
    {

        healtText.text = playerHealtShystem.GetHealth().ToString("0.0");







    }
    public void UpdateExpirience()
    {
        expirence.text = playerlevelSystem.GetExpirience().ToString("0");
        level.text = playerlevelSystem.GetLevelNumber().ToString("0");

    }






}
