using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Divider))]
[RequireComponent(typeof(Rigidbody))]
public class Divider : MonoBehaviour
{
    [SerializeField] private ClickDetector _detector;
    [SerializeField] private float _multiplyChance;
    private List<Rigidbody> explodableObjects = new List<Rigidbody>();

    private void Start()
    {
        gameObject.GetComponent<Divider>()._multiplyChance /= 2;
    }

    public void Divide()
    {
        int minChance = 0;
        int maxChance = 100;
        int chance = Random.Range(minChance, maxChance);

        if (chance <= _multiplyChance)
        {
            int minAmountObjects = 2;
            int maxAmountObjects = 6;
            int amountObjects = Random.Range(minAmountObjects, maxAmountObjects);
            gameObject.transform.localScale /= 2;
            Debug.Log(gameObject.GetComponent<Divider>()._multiplyChance);

            for (int i = 0; i < amountObjects; i++)
            {
                GameObject clone = Instantiate(gameObject, transform.position, Quaternion.identity);
                explodableObjects.Add(clone.GetComponent<Rigidbody>());
            }
        }
    }

    public List<Rigidbody> GetExplodableObjects()
    {
        return explodableObjects;
    }
}
