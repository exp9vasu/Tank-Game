using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed, rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }

    public List<Tank> tankList;

    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

   private void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[0].movementSpeed, 
            tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
        
        TankController tankController = new TankController(tankModel, tankView);
    }
}
