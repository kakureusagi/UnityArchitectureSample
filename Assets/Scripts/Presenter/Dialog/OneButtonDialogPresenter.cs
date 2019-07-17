using UniRx;
using UnityEngine;
using UnityEngine.UI;

#pragma warning disable 0649

namespace MvpSample {

	public class OneButtonDialogPresenter : DialogPresenterBase<OneButtonDialogUseCsae> {
		
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