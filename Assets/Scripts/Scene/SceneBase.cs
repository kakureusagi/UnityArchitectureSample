using UniRx.Async;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MvpSample {

	public class SceneBase : MonoBehaviour {

		protected IDialogFactory dialogFactory;
		

		protected virtual async UniTask Start() {
			await SceneManager.LoadSceneAsync("System", LoadSceneMode.Additive);

			var rootGameObjects = SceneManager.GetSceneByName("System").GetRootGameObjects();
			foreach (GameObject rootGameObject in rootGameObjects) {
				dialogFactory = rootGameObject.GetComponentInChildren<IDialogFactory>();
				if (dialogFactory != null) {
					break;
				}
			}
		}
	}

}