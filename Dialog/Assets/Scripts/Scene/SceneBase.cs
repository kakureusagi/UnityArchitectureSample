using UniRx.Async;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MvpSample {

	public class SceneBase : MonoBehaviour {

		static readonly string SystemSceneName = "System";

		protected IDialogFactory dialogFactory;
		

		protected virtual async UniTask Start() {
			await SceneManager.LoadSceneAsync(SystemSceneName, LoadSceneMode.Additive);

			var rootGameObjects = SceneManager.GetSceneByName(SystemSceneName).GetRootGameObjects();
			foreach (GameObject rootGameObject in rootGameObjects) {
				dialogFactory = rootGameObject.GetComponentInChildren<IDialogFactory>();
				if (dialogFactory != null) {
					break;
				}
			}
		}
	}

}