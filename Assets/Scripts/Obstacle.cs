using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Platformer.Core.Simulation;
using Platformer.Gameplay;

namespace Platformer.Mechanics
{
    public class Obstacle : MonoBehaviour
    {
        [SerializeField] private float maxSpeed, minSpeed;
        private float speed;
        // Start is called before the first frame update
        void Start()
        {
            speed = Random.Range(minSpeed, maxSpeed);
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                var player = collision.gameObject.GetComponent<PlayerController>();
                if (player != null)
                {
                    var ev = Schedule<PlayerDeath>();
                    GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>().ResetScore();
                }
            }

            if (collision.gameObject.CompareTag("Border"))
            {
                Destroy(gameObject);
            }
        }
    }
}


