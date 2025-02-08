using UnityEngine;

namespace HomeWork1
{
    public class SphereCharacter : MonoBehaviour
    {
        public int hp = 100;
        public bool isDeath = false;
        public bool isEnemy = false;

        private MeshRenderer meshRenderer;

        public void Start()
        {
            meshRenderer = GetComponent<MeshRenderer>();
            if (isEnemy)
            {
                meshRenderer.material.color = Color.red;
                Debug.Log("Enemy, Color Red");
            }
            else
            {
                meshRenderer.material.color = Color.blue;
                Debug.Log("Ally, Color Blue");
            }
        }

        public void TakeDamage(int damage)
        {
            if (isDeath)
            {
                return;
            }
            hp -= damage;

            if (hp <= 0)
            {
                hp = 0;
                isDeath = true;
                Debug.Log("Deth");
            }
            else
            {
                Debug.Log($"Damage {damage}. HP Left: {hp}");
            }
        }
    }
}
