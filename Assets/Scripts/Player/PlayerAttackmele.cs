using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class PlayerAttackmele : MonoBehaviour
{



    public float TimeBetweenShots;
    public float timeSinceLastShot;
    public float _timePrefabSpawn;
    private float distance;
    public float _baseAtack;
    public float _playerRandomHit;
    public float _playerFullAttack;
    public Bat _batTarget;
    public Transform position;
    public PlayerIIMovment _player;
    public HealthSystem playerHealtShystem;
    public LevelSystem playerlevelSystem;
    public Transform MyTarget { get; set; }











    void FixedUpdate()
    {

   


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
        




    }

    IEnumerator Dmg_Spawn()
    {


        yield return new WaitForSeconds(0);
       // GameObject FloatHp = Instantiate(popUpprefab, _player.transform.position, _player.transform.rotation);
    }

    





}
