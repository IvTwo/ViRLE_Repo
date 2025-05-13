using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotDogActivityManager : ActivityManager
{
    [SerializeField] private GameObject robotDog;
    [SerializeField] private GameObject dogController;

    public void SpawnRobotDog() { robotDog.SetActive(true); }

    public void SpawnDogController() { dogController.SetActive(true); }
}
