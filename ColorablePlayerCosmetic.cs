using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace KitchenColorableCosmetics
{
    public abstract class ColorablePlayerCosmetic : CustomPlayerCosmetic
    {
        protected abstract class BaseMaterialInstruction
        {
            public string Path;

            // MaterialName, IsCustomMaterial
            public List<(string, bool)> Materials;

            protected Material[] _materialArray
            {
                get
                {
                    List<Material> tempList = new List<Material>();
                    foreach ((string materialName, bool isCustomMaterial) in Materials)
                    {
                        Material material;
                        switch (isCustomMaterial)
                        {
                            case true:
                                material = MaterialUtils.GetCustomMaterial(materialName);
                                break;
                            default:
                                material = MaterialUtils.GetExistingMaterial(materialName);
                                break;
                        }
                        tempList.Add(material);
                    }
                    return tempList.ToArray();
                }
            }
            public abstract void ApplyMaterials(GameObject gameObject);
        }

        protected class MaterialInstruction<T> : BaseMaterialInstruction where T : Renderer
        {
            public override void ApplyMaterials(GameObject gameObject)
            {
                gameObject.GetChild(Path).ApplyMaterial<T>(_materialArray);
            }
        }

        public abstract GameObject PrefabToCopy { get; }

        protected abstract List<BaseMaterialInstruction> MaterialsToApply { get; }

        public override void OnRegister(PlayerCosmetic gameDataObject)
        {
            GameObject prefabHider = GameObject.Find("PrefabHider");
            if (prefabHider == null)
            {
                prefabHider = new GameObject("PrefabHider");
                prefabHider.SetActive(false);
            }
            gameDataObject.Visual = GameObject.Instantiate(PrefabToCopy);
            gameDataObject.Visual.transform.SetParent(prefabHider.transform);

            foreach (BaseMaterialInstruction instruction in MaterialsToApply)
            {
                instruction.ApplyMaterials(gameDataObject.Visual);
            }
        }
    }
}
