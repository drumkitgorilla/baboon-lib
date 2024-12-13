# BaboonLib 1.0
BaboonLib is a library made for Gorilla Tag to assist in basic development of client-side mods. It handles information like joining room codes,
getting and settings player color codes and names, and other small things that make a big difference.

## Installation
Drag BaboonLib.dll into your ``/BepInEx/plugins`` folder. If you are building it, it will be placed there for you.

## Usage
For mod developers, BaboonLib can be imported into most C# files.

```cs
using System;
using UnityEngine;
using GorillaLocomotion;

using BaboonLib;

namespace RoomJoiner {
  public class Core {
    public static bool IsModded() {
      return BaboonLib.Room.RoomIsModded;
    }

    public static bool JoinRoomCode(string code) {
      string result = BaboonLib.Room.JoinRoomCode(code)

      if (!result = "Success") {
        Debug.Log("error joining code: " + result);
        return false;
      } else {
        Debug.Log("room joined");
        return true;
      }

      // if something happened in the if

      return false;
    }

    public static bool IsForestMap() {
      return BaboonLib.Map == "forest";
    }
  }
}
```
