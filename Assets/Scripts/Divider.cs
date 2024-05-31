using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Divider : MonoBehaviour
{
    [SerializeField] private float _divideChance;
    [SerializeField] private Explosion _explosion;

    private int _divideNumber = 2;

    private void Start()
    {
        _divideChance /= _divideNumber;
        _explosion.IncreaseRadiusAndForce();
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
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            

            for (int i = 0; i < amountObjects; i++)
            {
                Rigidbody clone = Instantiate(rigidbody, transform.position, Quaternion.identity);
                explodableObjects.Add(clone);
            }
        }

        return explodableObjects;
    }
}
