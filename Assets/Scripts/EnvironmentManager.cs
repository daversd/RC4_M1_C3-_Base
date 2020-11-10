using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnvironmentManager : MonoBehaviour
{
    #region Private fields

    VoxelGrid _voxelGrid;

    #endregion

    #region Unity methods

    public void Start()
    {
        //01 Create a basic VoxelGrid
        _voxelGrid = new VoxelGrid(new Vector3Int(50, 5, 25), transform.position, 1f);

    }

    public void Update()
    {

    }

    #endregion

    #region Public methods

    

    #endregion

    #region Private methods


    #endregion
}
