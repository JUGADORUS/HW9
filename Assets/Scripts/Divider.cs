using System.Collections.Generic;
using UnityEngine;

public class Divider : MonoBehaviour
{
    [SerializeField] private float _divideChance;
    private int _divideNumber = 2;

    private void Start()
    {
        _divideChance /= _divideNumber;
    }

    public List<Rigidbody> Divide()
    {
        List<Rigidbody> explodableObjects = new List<Rigidbody>();
        int minChance = 0;
        int maxChance = 100;
        int chance = Random.Range(minChance, maxChance);

        if (chance <= _divideChance)
        {
            int minAmountObjects = 2;
            int maxAmountObjects = 6;
            int amountObjects = Random.Range(minAmountObjects, maxAmountObjects);
            gameObject.transform.localScale /= _divideNumber;

            for (int i = 0; i < amountObjects; i++)
            {
                GameObject clone = Instantiate(gameObject, transform.position, Quaternion.identity);

                if(clone.TryGetComponent<Rigidbody>(out Rigidbody rigidbody))
                {
                    explodableObjects.Add(rigidbody);
                }
            }
        }

        return explodableObjects;
    }
}
