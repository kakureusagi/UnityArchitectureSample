using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace MvpSample {

	public class OneButtonDialogPresenter : DialogPresenterBase<OneButtonDialogModel> {
		
		[SerializeField]
		Text title;
		
		[SerializeField]
		Text body;
		
		[SerializeField]
		Button closeButton;

		
		protected override void RunCore() {
			title.text = model.Title;
			body.text = model.Body;
			
			closeButton.OnClickAsObservable()
				.Subscribe(_ => model.OnCloseButton())
				.AddTo(this);

			model.OnClose
				.Subscribe(_ => Destroy(gameObject))
				.AddTo(this);
		}

	}

}