using UniRx;
using UnityEngine;

namespace MvpSample {

	public abstract class DialogPresenterBase : MonoBehaviour {

	}
	
	public abstract class DialogPresenterBase<TModel> : DialogPresenterBase where TModel : DialogUseCaseBase {

		protected TModel model;

		public void Run(TModel model) {
			this.model = model;

			model.OnClose.Subscribe(_ => Destroy(this));
			
			RunCore();
		}

		protected abstract void RunCore();

	}

}