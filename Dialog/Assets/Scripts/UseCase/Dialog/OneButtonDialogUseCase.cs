namespace MvpSample {

	public class OneButtonDialogUseCase : DialogUseCsaeBase {

		public string Title { get; }
		public string Body { get; }


		public OneButtonDialogUseCase(string title, string body) {
			Title = title;
			Body = body;
		}

		public void OnCloseButton() {
			Close();
		}

	}

}