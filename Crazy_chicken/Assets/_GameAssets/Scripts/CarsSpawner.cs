using UnityEngine;

public class CarsSpawner : MonoBehaviour
{
    public GameObject[] cars;
    public float tiempoEntreCoches;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCar",tiempoEntreCoches,tiempoEntreCoches);
    }

    // Update is called once per frame
    void SpawnCar()
    {
        Instantiate(cars[Random.Range(0,cars.Length)], transform.position, transform.rotation);
    }
}
