using UnityEngine;

public class CubeGrid : MonoBehaviour
{
    GameObject cubePrefab;
    public int x;
    public int y;
    public int z;
    public int cubeSize;
    public int space;

    // Start is called before the first frame update
    void Start()
    {
        cubePrefab = Resources.Load<GameObject>("Prefabs/Bob");
        CreateCubeGrid();
    }

    private void CreateCubeGrid()
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    GameObject newObj = Instantiate(cubePrefab);
                    newObj.transform.localScale = Vector3.one * cubeSize;
                    newObj.transform.position = new Vector3(i, j, k) * cubeSize + new Vector3(i, j, k) * space;
                }
            }
        }
    }
}
