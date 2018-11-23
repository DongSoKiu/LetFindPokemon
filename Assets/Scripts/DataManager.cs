using UnityEngine;

namespace Assets.Scripts
{
    public class DataManager : MonoBehaviour
    {
        private void Start()
        {
            //var asset = Resources.Load<TextAsset>("pokedex");
            //var info = PokemonModels.FromJson(asset.text);

            var card = Card.Find<Pokemon>("base5-20");
            var name = card.Card.Name;

            Debug.Log(name);
        }
    }
}