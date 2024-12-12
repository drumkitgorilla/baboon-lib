using System;
using UnityEngine;
using GorillaLocomotion;
using System.Threading;
using BaboonLib;

namespace BaboonLib {
  public class Info {
    string name = "BaboonLib";
    string uuid = "com.drumkitgorilla.gorillatag.baboonlib";
    string description = "General-purpose Gorilla Tag library";
    string version = "1.0";

    string outputSign = "[BaboonLib]: ";
  };

  private class Baboon {
    public static void Log(string text) {
      UnityEngine.Debug.Log(Info.outputSign + text);
    }
  }

  public class Core {
    public static bool GameInitialized = false;
    public static Player LocalPlayer = null;
    
    public static bool Initialize() {
      Baboon.Log("Initializing BaboonLib");

      while (!GorillaLocomotion.Player.offlineVRRig) {
        Baboon.Log("Waiting for GorillaPlayer");
        Task.Wait(1000); // timeout
      }

      if (!GorillaLocomotion.Player.offlineVRRig) {
        GameInitialized = false;
      } else {
        LocalPlayer = GorillaLocomotion.Player.offlineVRRig;
        GameInitialized = true;
      }

      return GameInitialized;
    }
  }
}
