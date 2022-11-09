using _Root.Scripts.Game.Car;
using _Root.Scripts.Tool.Reactive;
using _Root.Scripts.Tool.ResourceManagement;
using UnityEngine;

namespace _Root.Scripts.Game.InputLogic
{
    internal class InputGameController : BaseController
    {
        private readonly ResourcePath _resourcePath = new ResourcePath("Prefabs/Input/KeyboardMove");
        private readonly BaseInputView _view;


        public InputGameController(
            SubscriptionProperty<float> leftMove,
            SubscriptionProperty<float> rightMove,
            CarModel car)
        {
            _view = LoadView();
            _view.Init(leftMove, rightMove, car.Speed);
        }


        private BaseInputView LoadView()
        {
            GameObject prefab = ResourcesLoader.LoadPrefab(_resourcePath);
            GameObject objectView = Object.Instantiate(prefab);
            AddGameObject(objectView);

            return objectView.GetComponent<BaseInputView>();
        }
    }
}