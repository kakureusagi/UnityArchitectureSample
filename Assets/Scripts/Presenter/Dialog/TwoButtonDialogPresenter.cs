using UniRx;
using UnityEngine;
using UnityEngine.UI;

#pragma warning disable 0649

namespace MvpSample {

	public class TwoButtonDialogPresenter : DialogPresenterBase<TwoButtonDialogUseCase> {

		[SerializeField]
		Text title;
		
		[SerializeField]
		Text body;
		
		[SerializeField]
		Button okButton;
		
		[SerializeField]
		Button cancelButton;

		
		protected override void RunCore() {
			title.text = model.Title;
			body.text = model.Body;
			
			okButton.OnClickAsObservable()
				.Subscribe(_ => model.OnOkButton())
				.AddTo(this);
			
			cancelButton.OnClickAsObservable()
				.Subscribe(_ => model.OnCancelButton())
				.AddTo(this);

			model.OnClose
				.Subscribe(_ => Destroy(gameObject))
				.AddTo(this);
		}

	}

}