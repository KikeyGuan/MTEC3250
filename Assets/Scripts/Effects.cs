using UnityEngine;

public class Effects : MonoBehaviour
{

    public ParticleSystem ps;

    private void OnEnable()
    {
        Tile.CrateDestroyed += OnCrateDestory;

        
    }

    private void OnDisable()
    {
        Tile.CrateDestroyed -= OnCrateDestory;

    }

    void OnCrateDestory(Tile tile)
    {
        ps.transform.position = tile.transform.position;
        ps.Emit(Random.Range(20, 30));
    }

}
