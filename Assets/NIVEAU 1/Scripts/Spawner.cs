using UnityEngine;
namespace Niveau1
{
    public class Spawner : MonoBehaviour
    {

        public GameObject prefab;
        public float spawnRate = 1f;

        public float minHeight = -1f;
        public float maxHeight = 1f;

        private void OnEnable()
        {
            InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
        }

        private void OnDisable()
        {
            CancelInvoke(nameof(Spawn));
        }

        private void Spawn()
        {
            GameObject alien = Instantiate(prefab, transform.position, Quaternion.identity);
            alien.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        }

    }
}
