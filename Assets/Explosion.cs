using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private Multiplyer _multiplyer;
    [SerializeField] private float _explosionRadius;
    [SerializeField] private float _explosionForce;

    public void Explode()
    {
        foreach (Rigidbody explodableObject in _multiplyer.GetExplodableObjects())
        {
            explodableObject.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
        }
    }
}
