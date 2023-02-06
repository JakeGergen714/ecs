using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.UI
{
    public class MainGameObjectCanvas : MonoBehaviour
    {
        
        public static Canvas Instance;
        void Awake()
        {
            Instance = GetComponent<UnityEngine.Canvas>();
            Debug.Log(Instance);
        }
    }
}