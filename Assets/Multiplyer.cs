using System.Collections.Generic;
using UnityEngine;

public class Multiplyer : MonoBehaviour
{
    [SerializeField] private ClickDetector _detector;
    [SerializeField] private GameObject _objectToSpawn;
    [SerializeField] private float _multiplyChance;
    private List<Rigidbody> explodableObjects = new List<Rigidbody>();

    private void Start()
    {
        _objectToSpawn.GetComponent<Multiplyer>()._multiplyChance /= 2;
    }

    public void Multiply()
    {
        int minChance = 0;
        int maxChance = 100;
        int chance = Random.Range(minChance, maxChance);

        if (chance <= _multiplyChance)
        {
            int minAmountObjects = 2;
            int maxAmountObjects = 6;
            int amountObjects = Random.Range(minAmountObjects, maxAmountObjects);
            _objectToSpawn.transform.localScale /= 2;
            Debug.Log(_objectToSpawn.GetComponent<Multiplyer>()._multiplyChance);

            for (int i = 0; i < amountObjects; i++)
            {
                GameObject clone = Instantiate(_objectToSpawn, transform.position, Quaternion.identity);
                explodableObjects.Add(clone.GetComponent<Rigidbody>());
            }
        }
    }

    public List<Rigidbody> GetExplodableObjects()
    {
        return explodableObjects;
    }
}
