import UnityEngine as ue

objects = ue.Object.FindObjectsOfType(ue.GameObject)
ue.Debug.Log("Hello World")
for item in objects:
    ue.Debug.Log(item.name)