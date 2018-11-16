using UnityEngine;
using System.Collections;
using EZ_Pooling;

public class basic_object : MonoBehaviour
{
    public GameObject spawner;

    public GameObject recycler;

    public float rndLimit;

    void OnSpawned()
    {

        EZ_PoolManager.Spawn(spawner.transform, spawner.transform.position + transform.up * Mathf.RoundToInt(Random.Range(-rndLimit, rndLimit)), Quaternion.Euler (0, 0, 0));

        if (GetComponent<Rigidbody>())
            GetComponent<Rigidbody>().velocity = Vector3.zero;

        enabled = true;

    }

    void OnDespawned()
    {
        EZ_PoolManager.Despawn(recycler.transform);
        enabled = false;

    }
}
